using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace miracle
{
    public partial class PurchaseForm : Form
    {
        private int companyId;
        private string companyName;
        public PurchaseForm(int companyId, string companyName)
        {
            InitializeComponent();

            this.companyId = companyId;
            this.companyName = companyName;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPurchases_Click(object sender, EventArgs e)
        {
            ViewPurchases viewpur = new ViewPurchases();
            viewpur.ShowDialog();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                conn.Open();
                MySqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Calculate grand total from DataGridView
                    decimal grandTotal = 0m;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        decimal rowTotal = 0m;
                        decimal.TryParse(Convert.ToString(row.Cells["txttotal"].Value ?? "0"),
                                         System.Globalization.NumberStyles.Any,
                                         System.Globalization.CultureInfo.InvariantCulture,
                                         out rowTotal);
                        grandTotal += rowTotal;
                    }

                    int vendorId = GetOrCreateVendor(conn, tran);
                    // 2️⃣ Insert into purchases table including GrandTotal
                    string purchaseQuery =
                        "INSERT INTO purchases (CompanyID, VendorID, GrandTotal) VALUES (@CompanyID,@VendorID, @GrandTotal); " +
                        "SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdPurchase = new MySqlCommand(purchaseQuery, conn, tran);
                    cmdPurchase.Parameters.AddWithValue("@CompanyID", companyId);
                    cmdPurchase.Parameters.AddWithValue("@VendorID", vendorId);
                    cmdPurchase.Parameters.AddWithValue("@GrandTotal", grandTotal);

                    int purchaseId = Convert.ToInt32(cmdPurchase.ExecuteScalar());

                    // 3️⃣ Insert purchase items & update stock
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["txtproductname"].Value == null) continue;

                        string productName = Convert.ToString(row.Cells["txtproductname"].Value);
                        int quantity = Convert.ToInt32(row.Cells["txtquantity"].Value ?? 0);

                        // --- Insert into purchase_items ---
                        string itemQuery =
                        @"INSERT INTO purchase_items
                  (PurchaseID, SrNo, ProductName, BatchNo, HSNNo,
                   PurchaseRate, MRP, SellingRate, Quantity, Total)
                  VALUES
                  (@PurchaseID, @SrNo, @ProductName, @BatchNo, @HSNNo,
                   @PurchaseRate, @MRP, @SellingRate, @Quantity, @Total)";

                        MySqlCommand cmdItem = new MySqlCommand(itemQuery, conn, tran);
                        cmdItem.Parameters.AddWithValue("@PurchaseID", purchaseId);
                        cmdItem.Parameters.AddWithValue("@SrNo", row.Cells["txtsrno"].Value ?? 0);
                        cmdItem.Parameters.AddWithValue("@ProductName", productName);
                        cmdItem.Parameters.AddWithValue("@BatchNo", row.Cells["txtbatchno"].Value ?? "");
                        cmdItem.Parameters.AddWithValue("@HSNNo", row.Cells["txthsnno"].Value ?? "");
                        cmdItem.Parameters.AddWithValue("@PurchaseRate", row.Cells["txtrate"].Value ?? 0);
                        cmdItem.Parameters.AddWithValue("@MRP", row.Cells["txtmrp"].Value ?? 0);
                        cmdItem.Parameters.AddWithValue("@SellingRate", row.Cells["txtsellingrate"].Value ?? 0);
                        cmdItem.Parameters.AddWithValue("@Quantity", quantity);
                        cmdItem.Parameters.AddWithValue("@Total", row.Cells["txttotal"].Value ?? 0);
                        cmdItem.ExecuteNonQuery();

                        // --- Update stock table ---
                        string stockCheckQuery = @"SELECT Quantity FROM stock 
                                           WHERE ProductName=@ProductName AND CompanyID=@CompanyID";
                        MySqlCommand cmdStockCheck = new MySqlCommand(stockCheckQuery, conn, tran);
                        cmdStockCheck.Parameters.AddWithValue("@ProductName", productName);
                        cmdStockCheck.Parameters.AddWithValue("@CompanyID", companyId);

                        object existingQtyObj = cmdStockCheck.ExecuteScalar();
                        if (existingQtyObj != null)
                        {
                            // Product exists → update quantity
                            int existingQty = Convert.ToInt32(existingQtyObj);
                            string updateStock = @"UPDATE stock 
                                           SET Quantity=@NewQty, UpdatedAt=NOW()
                                           WHERE ProductName=@ProductName AND CompanyID=@CompanyID";
                            MySqlCommand cmdUpdateStock = new MySqlCommand(updateStock, conn, tran);
                            cmdUpdateStock.Parameters.AddWithValue("@NewQty", existingQty + quantity);
                            cmdUpdateStock.Parameters.AddWithValue("@ProductName", productName);
                            cmdUpdateStock.Parameters.AddWithValue("@CompanyID", companyId);
                            cmdUpdateStock.ExecuteNonQuery();
                        }
                        else
                        {
                            // New product → insert new row
                            string insertStock = @"INSERT INTO stock
                                           (ProductName, Quantity, CompanyID, UpdatedAt)
                                           VALUES
                                           (@ProductName, @Quantity, @CompanyID, NOW())";
                            MySqlCommand cmdInsertStock = new MySqlCommand(insertStock, conn, tran);
                            cmdInsertStock.Parameters.AddWithValue("@ProductName", productName);
                            cmdInsertStock.Parameters.AddWithValue("@Quantity", quantity);
                            cmdInsertStock.Parameters.AddWithValue("@CompanyID", companyId);
                            cmdInsertStock.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    MessageBox.Show("Purchase saved and stock updated successfully ✅");

                    // Reset DataGridView
                    dataGridView.Rows.Clear();
                    dataGridView.Rows.Add();
                    UpdateSrNo();
                    lblGrandTotal.Text = "Grand Total: 0.00";
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error saving purchase:\n" + ex.Message);
                }
            }
        }



        // Helper to update SrNo for all rows
        private void UpdateSrNo()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (!dataGridView.Rows[i].IsNewRow)
                {
                    dataGridView.Rows[i].Cells["txtsrno"].Value = i + 1;
                }
            }
        }

        private void dataGridView_keydown(object sender, KeyEventArgs e)
        {
            // Handle key press
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;  // stop default behavior

            int row = dataGridView.CurrentCell.RowIndex;
            int col = dataGridView.CurrentCell.ColumnIndex;

            // If not last column → move to next cell
            if (col < dataGridView.Columns.Count - 1)
            {
                dataGridView.CurrentCell = dataGridView.Rows[row].Cells[col + 1];
                return;
            }

            // If last column → create new row
            int newRow = row + 1;

            if (newRow >= dataGridView.Rows.Count)
            {
                dataGridView.Rows.Add();
            }

            // Update SrNo for all rows
            UpdateSrNo();

            // Move cursor to ProductName (1st editable column)
            dataGridView.CurrentCell = dataGridView.Rows[newRow].Cells["txtproductname"];
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            LoadVendors();
            //lblgrandtotal
            this.dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            this.dataGridView.EditingControlShowing += dataGridView_EditingControlShowing;

            // Load initialization code
            txtsrno.ReadOnly = true;
            txtsrno.DefaultCellStyle.BackColor = Color.LightGray;

            // Create first row if empty
            if (dataGridView.Rows.Count == 0)
                dataGridView.Rows.Add();

            // Update SrNo for all rows
            UpdateSrNo();

            // Move cursor to first editable column
            dataGridView.CurrentCell = dataGridView.Rows[0].Cells["txtproductname"];
            //new
            this.dataGridView.CellEndEdit += dataGridView_CellEndEdit;
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView.Rows[e.RowIndex];

            // Only recalc when PurchaseRate or Quantity edited (optional: also when PurchaseRate text changed)
            string colName = dataGridView.Columns[e.ColumnIndex].Name;
            if (colName != "txtrate" && colName != "txtquantity")
            {
                // still update if you want totals to be recalculated after any edit:
                // RecalculateRowTotal(row);
                return;
            }

            RecalculateRowTotal(row);
            UpdateSrNo(); // keeps srno consistent if you add/remove rows
            UpdateGrandTotal(); // optional: updates aggregated total label
        }

        private void RecalculateRowTotal(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow) return;

            // Read values safely as strings
            string rateText = Convert.ToString(row.Cells["txtrate"].Value) ?? "0";
            string qtyText = Convert.ToString(row.Cells["txtquantity"].Value) ?? "0";

            // Parse carefully (use decimal for money)
            decimal rate;
            int quantity;

            // Try parsing rate
            if (!decimal.TryParse(rateText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out rate))
            {
                // If parsing fails, set to zero and optionally notify user
                rate = 0m;
            }

            // Try parsing quantity (allow decimals only if you really need them; here I assume integer quantity)
            if (!int.TryParse(qtyText, out quantity))
            {
                // if user types "2.5" and you allow decimal quantities, use decimal.TryParse instead and change type
                quantity = 0;
            }

            // Calculate total (digit-by-digit safe because we used decimal)
            decimal total = rate * quantity;

            // Put result back into cell formatted to 2 decimals
            row.Cells["txttotal"].Value = total.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void UpdateGrandTotal()
        {
            decimal grand = 0m;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string totalText = Convert.ToString(row.Cells["txttotal"].Value) ?? "0";
                decimal t;
                if (decimal.TryParse(totalText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out t))
                {
                    grand += t;
                }
            }

            // Show it in label
            lblGrandTotal.Text = "Grand Total: " + grand.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var tb = e.Control as TextBox;
            if (tb == null) return;

            int colIndex = dataGridView.CurrentCell.ColumnIndex;
            string colName = dataGridView.Columns[colIndex].Name;
            if (colName == "txtrate" || colName == "txtquantity" || colName == "txtmrp" || colName == "txtsellingrate")
            {
                tb.KeyPress -= NumericTextBox_KeyPress;
                tb.KeyPress += NumericTextBox_KeyPress;
            }
            else
            {
                tb.KeyPress -= NumericTextBox_KeyPress;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digits, one dot, backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            var tb = sender as TextBox;
            if (e.KeyChar == '.' && tb != null && tb.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private int GetOrCreateVendor(MySqlConnection conn, MySqlTransaction tran)
        {
            if (comboVendor.SelectedValue != null)
            {
                return Convert.ToInt32(comboVendor.SelectedValue);
            }

            // fallback if user types new vendor
            string vendorName = comboVendor.Text.Trim();

            string checkQuery = "SELECT VendorID FROM vendors WHERE VendorName=@VendorName";
            MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn, tran);
            cmdCheck.Parameters.AddWithValue("@VendorName", vendorName);

            object result = cmdCheck.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            string insertQuery = "INSERT INTO vendors (VendorName) VALUES (@VendorName); SELECT LAST_INSERT_ID();";
            MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn, tran);
            cmdInsert.Parameters.AddWithValue("@VendorName", vendorName);

            return Convert.ToInt32(cmdInsert.ExecuteScalar());
        }


        private void LoadVendors()
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                conn.Open();

                string query = "SELECT VendorID, VendorName FROM vendors";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboVendor.DataSource = dt;
                comboVendor.DisplayMember = "VendorName"; // what user sees
                comboVendor.ValueMember = "VendorID";     // actual value
            }
        }
    }
}
