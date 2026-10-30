using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace miracle
{
    public partial class BillingForm : Form
    {
        private DataTable dtBillingItems;

        public BillingForm()
        {
            InitializeComponent();
            InitializeDataGrid();
            LoadCustomers();
            LoadProducts();
            GenerateBillNo();

            dgvItems.AutoGenerateColumns = false;

            comboCustomer.DropDownStyle = ComboBoxStyle.DropDown;
            comboCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCustomer.Leave += comboCustomer_Leave;

            //txtProduct.Leave += txtProduct_Leave;
           
            btnAdd.Click += btnAdd_Click;
            txtQuantity.TextChanged += CalculateItemAmount;
            txtRate.TextChanged += CalculateItemAmount;
            txtDiscount.TextChanged += CalculateItemAmount;
            comboCustomer.SelectedValueChanged += comboCustomer_SelectedValueChanged;
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;

        }

        private int GetAvailableStock(string productName)
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                string query = @"
        SELECT IFNULL(SUM(Quantity),0)
        FROM stock
        WHERE ProductName = @ProductName";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private void comboCustomer_Leave(object sender, EventArgs e)
        {
            string typedName = comboCustomer.Text.Trim();
            if (string.IsNullOrEmpty(typedName))
                return;

            DataTable dt = comboCustomer.DataSource as DataTable;
            if (dt == null) return;

            DataRow[] found = dt.Select(
                $"CustomerName = '{typedName.Replace("'", "''")}'");

            if (found.Length > 0)
            {
                // Existing customer → auto select
                comboCustomer.SelectedValueChanged -= comboCustomer_SelectedValueChanged;
                comboCustomer.SelectedValue = found[0]["CustomerID"];
                comboCustomer.SelectedValueChanged += comboCustomer_SelectedValueChanged;
            }

            // ❗ DO NOTHING for new customer here
        }


        private int InsertCustomer(string customerName, string customerAddress, string GSTIN, string mobile)
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO customers (CustomerName, Address, GSTIN, Mobile) VALUES (@name, @address, @GSTIN, @mobile); SELECT LAST_INSERT_ID();",
                    con);

                cmd.Parameters.AddWithValue("@name", customerName);
                cmd.Parameters.AddWithValue("@address", customerAddress);
                cmd.Parameters.AddWithValue("@GSTIN", GSTIN);
                cmd.Parameters.AddWithValue("@mobile", mobile);


                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        private void comboCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedValue != null &&
                int.TryParse(comboCustomer.SelectedValue.ToString(), out int cid))
            {
                txtCustomerID.Text = cid == 0 ? "" : cid.ToString();

                DataTable dt = comboCustomer.DataSource as DataTable;
                if (dt != null && cid != 0)
                {
                    DataRow[] found = dt.Select($"CustomerID = {cid}");
                    if (found.Length > 0)
                    {
                        txtCustomerAddress.Text = found[0]["Address"].ToString();
                        txtGSTIN.Text = found[0]["GSTIN"].ToString();
                        txtmobile.Text = found[0]["Mobile"].ToString();
                    }
                }

            }
        }




        // ===================== GRID INITIALIZATION =====================
        private void InitializeDataGrid()
        {
            dtBillingItems = new DataTable();

            dtBillingItems.Columns.Add("ProductName", typeof(string));
            dtBillingItems.Columns.Add("HSN", typeof(string));
            dtBillingItems.Columns.Add("Qty", typeof(int));
            dtBillingItems.Columns.Add("Rate", typeof(decimal));
            dtBillingItems.Columns.Add("Discount", typeof(decimal));
            dtBillingItems.Columns.Add("TaxableAmount", typeof(decimal));
            dtBillingItems.Columns.Add("CGSTValue", typeof(decimal));
            dtBillingItems.Columns.Add("SGSTValue", typeof(decimal));
            dtBillingItems.Columns.Add("TotalAmount", typeof(decimal));

            dgvItems.DataSource = dtBillingItems;
        }

        // ===================== ITEM CALCULATION =====================
        private void CalculateItemAmount(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0) return;
            if (!decimal.TryParse(txtRate.Text, out decimal rate) || rate <= 0) return;

            decimal discount = 0;
            decimal.TryParse(txtDiscount.Text, out discount);

            decimal gross = qty * rate;
            decimal discountValue = gross * (discount / 100);
            decimal taxable = gross - discountValue;
        }

        // ===================== ADD ITEM =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboProduct.Text))
            {
                MessageBox.Show("Enter product name");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Invalid quantity");
                return;
            }

            if (!decimal.TryParse(txtRate.Text, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Invalid rate");
                return;
            }

            // 🔹 CHECK STOCK
            int availableStock = GetAvailableStock(comboProduct.Text.Trim());

            if (availableStock <= 0)
            {
                MessageBox.Show("Stock not available");
                return;
            }

            if (qty > availableStock)
            {
                MessageBox.Show(
                    $"Insufficient stock!\nAvailable: {availableStock}",
                    "Stock Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            decimal discount = 0;
            decimal.TryParse(txtDiscount.Text, out discount);

            const decimal CGST_RATE = 9;
            const decimal SGST_RATE = 9;

            decimal gross = qty * rate;
            decimal discountValue = gross * (discount / 100);
            decimal taxable = gross - discountValue;

            decimal cgstValue = taxable * (CGST_RATE / 100);
            decimal sgstValue = taxable * (SGST_RATE / 100);

            decimal total = taxable + cgstValue + sgstValue;

            dtBillingItems.Rows.Add(
                comboProduct.Text,
                txtHSN.Text,
                qty,
                rate,
                discount,
                taxable,
                cgstValue,
                sgstValue,
                total
            );

            UpdateTotals();
            ClearItemInputs();
        }

        private void ClearItemInputs()
        {
           
            txtHSN.Clear();
            txtQuantity.Clear();
            txtRate.Clear();
            txtDiscount.Text = "0";
            comboProduct.SelectedIndex = -1;
            comboProduct.Focus();
        }

        // ===================== TOTALS =====================
        private void UpdateTotals()
        {
            decimal taxable = 0, gst = 0, grand = 0;

            foreach (DataRow row in dtBillingItems.Rows)
            {
                taxable += row.Field<decimal>("TaxableAmount");
                gst += row.Field<decimal>("CGSTValue") + row.Field<decimal>("SGSTValue");
                grand += row.Field<decimal>("TotalAmount");
            }

            valGST.Text = gst.ToString("N2");
            valGrandTotal.Text = grand.ToString("N2");
            valTotalAmount.Text = taxable.ToString("N2");
        }
       

        // ===================== SAVE BILL =====================
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBoxpay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select payment mode");
                return;
            }

            string paymentMode = comboBoxpay.SelectedItem.ToString();



            if (dtBillingItems.Rows.Count == 0)
            {
                MessageBox.Show("Add items first");
                return;
            }

           
            int customerId = 0;

            // 🔹 Check if customer already selected
            if (comboCustomer.SelectedValue != null)
            {
                int.TryParse(comboCustomer.SelectedValue.ToString(), out customerId);
            }

            // 🔹 If new customer → insert now
            if (customerId == 0)
            {
                if (string.IsNullOrWhiteSpace(comboCustomer.Text))
                {
                    MessageBox.Show("Enter customer name");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerAddress.Text))
                {
                    MessageBox.Show("Enter customer address");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGSTIN.Text))
                {
                    MessageBox.Show("Enter GSTIN");
                    return;
                }

                customerId = InsertCustomer(
                    comboCustomer.Text.Trim(),
                    txtCustomerAddress.Text.Trim(),
                    txtGSTIN.Text.Trim(),
                    txtmobile.Text.Trim());

                LoadCustomers();

                comboCustomer.SelectedValueChanged -= comboCustomer_SelectedValueChanged;
                comboCustomer.SelectedValue = customerId;
                comboCustomer.SelectedValueChanged += comboCustomer_SelectedValueChanged;

            }


            decimal taxable = 0, cgst = 0, sgst = 0;

            foreach (DataRow row in dtBillingItems.Rows)
            {
                taxable += row.Field<decimal>("TaxableAmount");
                cgst += row.Field<decimal>("CGSTValue");
                sgst += row.Field<decimal>("SGSTValue");
            }

            decimal taxAmount = cgst + sgst;
            decimal grandTotal = taxable + taxAmount;
            string amountWords = ConvertNumberToWords((long)grandTotal);

            int billId = 0;
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                string billQuery =
                "INSERT INTO billing (BillNo, BillDate, CustomerID, TotalAmount, CGST, SGST, GrandTotal, TaxAmount, AmountInWords, PaymentMode) " +
                "VALUES (@BillNo, @BillDate, @CustomerID, @TotalAmount, @CGST, @SGST, @GrandTotal, @TaxAmount, @AmountInWords, @PaymentMode); " +
                "SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(billQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BillNo", txtBillNo.Text);
                    cmd.Parameters.AddWithValue("@BillDate", dtBillDate.Value);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@TotalAmount", taxable);
                    cmd.Parameters.AddWithValue("@CGST", cgst);
                    cmd.Parameters.AddWithValue("@SGST", sgst);
                    cmd.Parameters.AddWithValue("@GrandTotal", grandTotal);
                    cmd.Parameters.AddWithValue("@TaxAmount", taxAmount);
                    cmd.Parameters.AddWithValue("@AmountInWords", amountWords);
                    cmd.Parameters.AddWithValue("@PaymentMode", paymentMode);

                    billId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string itemQuery = @"
                INSERT INTO billing_items
                (BillID, ProductName, HSNNO, Quantity, Rate, Per, Discount, Amount, CGST, SGST)
                VALUES
                (@BillID, @ProductName, @HSNNO, @Quantity, @Rate, 'NOS', @Discount, @Amount, @CGST, @SGST);";

                foreach (DataRow row in dtBillingItems.Rows)
                {
                    using (MySqlCommand cmd = new MySqlCommand(itemQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@BillID", billId);
                        cmd.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                        cmd.Parameters.AddWithValue("@HSNNO", row["HSN"]);
                        cmd.Parameters.AddWithValue("@Quantity", row["Qty"]);
                        cmd.Parameters.AddWithValue("@Rate", row["Rate"]);
                        cmd.Parameters.AddWithValue("@Discount", row["Discount"]);
                        cmd.Parameters.AddWithValue("@Amount", row["TaxableAmount"]);
                        cmd.Parameters.AddWithValue("@CGST", row["CGSTValue"]);
                        cmd.Parameters.AddWithValue("@SGST", row["SGSTValue"]);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 🔹 Update stock after successful billing
                UpdateStockAfterBilling(con, billId);
            }

           


            FormInvoice frm = new FormInvoice(billId);
            frm.ShowDialog();

            MessageBox.Show("Bill saved successfully");

            dtBillingItems.Clear();
            GenerateBillNo();
        }

       


        // ===================== CUSTOMERS ===================== //
        private void LoadCustomers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT CustomerID, CustomerName, Address, GSTIN, Mobile FROM customers", con);
                da.Fill(dt);
            }

            DataRow dr = dt.NewRow();
            dr["CustomerID"] = 0;
            dr["CustomerName"] = "-- Select Customer --";
            dt.Rows.InsertAt(dr, 0);

            comboCustomer.DataSource = dt;
            comboCustomer.DisplayMember = "CustomerName";
            comboCustomer.ValueMember = "CustomerID";
            comboCustomer.SelectedIndex = 0;
        }




        public static string ConvertNumberToWords(long number)
        {
            if (number == 0) return "Zero Only";
            return ConvertToWords(number).Trim() + " Only";
        }

        private static string ConvertToWords(long number)
        {
            if (number == 0) return "";

            if (number < 0)
                return "Minus " + ConvertToWords(Math.Abs(number));

            string words = "";

            if ((number / 10000000) > 0)
            {
                words += ConvertToWords(number / 10000000) + " Crore ";
                number %= 10000000;
            }

            if ((number / 100000) > 0)
            {
                words += ConvertToWords(number / 100000) + " Lakh ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += ConvertToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ConvertToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            string[] units = { "", "One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                       "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number > 0)
            {
                if (number < 20)
                    words += units[number] + " ";
                else
                    words += tens[number / 10] + " " + units[number % 10] + " ";
            }

            return words;
        }



        private void UpdateStockAfterBilling(MySqlConnection con, int billId)
        {
            string updateStockQuery = @"
            UPDATE stock
            SET Quantity = Quantity - @Qty,
            UpdatedAt = NOW()
            WHERE ProductName = @ProductName";

            foreach (DataRow row in dtBillingItems.Rows)
            {
                using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Qty", row["Qty"]);
                    cmd.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadProductDetails(string productName)
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                string query = @"
        SELECT HSNNO, SellingRate
        FROM purchase_items
        WHERE ProductName = @ProductName
        ORDER BY ItemID DESC
        LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtHSN.Text = dr["HSNNO"].ToString();
                            txtRate.Text = dr["SellingRate"].ToString();
                        }
                        else
                        {
                            txtHSN.Clear();
                            txtRate.Clear();
                        }
                    }
                }
            }
        }

        private void LoadProducts()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT DISTINCT ProductName FROM purchase_items ORDER BY ProductName",
                    con);

                da.Fill(dt);
            }

            comboProduct.DataSource = dt;
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductName";
            comboProduct.SelectedIndex = -1;
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduct.SelectedValue != null)
            {
                string productName = comboProduct.SelectedValue.ToString();
                LoadProductDetails(productName);
            }
        }


        //private void txtProduct_Leave(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(txtProduct.Text))
        //    {
        //        LoadProductDetails(txtProduct.Text.Trim());
        //    }
        //}


        private void GenerateBillNo()
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                string query = "SELECT IFNULL(MAX(BillID),0) + 1 FROM billing";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int nextId = Convert.ToInt32(cmd.ExecuteScalar());

                    txtBillNo.Text = "BILL-" + nextId.ToString("D4");
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
