// FormInvoice.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;


namespace miracle
{
    public partial class FormInvoice : Form
    {

        public string BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerGST { get; set; }

        public string mobile { get; set; }


        public DataTable BillingItems { get; set; }  // To hold the items
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public string AmountInWords { get; set; }

        private int? _billId = null;

        public FormInvoice(int billId)
        {
            InitializeComponent();
            _billId = billId;


        }


       

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            if (_billId.HasValue)
                LoadInvoiceById(_billId.Value);   // From See Bill
            else
                LoadLatestInvoice();              // From menu / reprint

            // Company Info (static)
            lblCompanyName.Text = "MIRACLE";
            lblCompanyAddress.Text = "Opp. Hotel Gokul, 3rd Floor, Station Road, Kolhapur-416003";
            lblCompanyContact.Text = "Contact: 9881843886 | GSTIN: 27ATNPP5836H1Z4";

            // Customer Info (dynamic)
            lblinno.Text = "Invoice No.: " + BillNo;
            lalindated.Text = (BillDate != DateTime.MinValue)
                ? "Dated: " + BillDate.ToString("dd-MMM-yyyy")
                : "Dated: -";

            lblinname.Text = CustomerName;
            lblinaddress.Text = CustomerAddress;
            lblingst.Text = CustomerGST;
            lblinmobile.Text = mobile;




            // Populate DataGridView
            dataGridViewItems.Rows.Clear();
            if (BillingItems != null)
            {
                int srNo = 1;
                foreach (DataRow row in BillingItems.Rows)
                {
                    dataGridViewItems.Rows.Add(
                           srNo++,                 // Sl No (constant, OK)
                           row["ProductName"],     // Description
                           row["HSNNO"],           // HSN
                           row["Quantity"],        // Quantity
                           row["Rate"],            // Rate
                           row["Per"],             // Per (NOW dynamic)
                           row["Discount"],        // Discount %
                           row["Amount"]           // Amount
                     );
                }
            }

            decimal totalCGST = 0;
            decimal totalSGST = 0;

            foreach (DataRow row in BillingItems.Rows)
            {
                totalCGST += Convert.ToDecimal(row["CGST"]);
                totalSGST += Convert.ToDecimal(row["SGST"]);
            }

            lblinTaxValue.Text =
                "CGST ₹ " + totalCGST.ToString("N2") +
                " | SGST ₹ " + totalSGST.ToString("N2");

            // Totals
            lblinTotalValue.Text = "₹ " + TotalAmount.ToString("N2");
            lblinGrandTotalValue.Text = "₹ " + GrandTotal.ToString("N2");
            lblinwordamt.Text = AmountInWords;
        }

        private void LoadInvoiceById(int billId)
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string billQuery = @"
        SELECT b.BillNo, b.BillDate,
               c.CustomerName, c.Address, c.GSTIN, c.Mobile,
               b.TotalAmount, b.TaxAmount,
               b.GrandTotal, b.AmountInWords
        FROM billing b
        JOIN customers c ON b.CustomerID = c.CustomerId
        WHERE b.BillId = @BillId";

                using (MySqlCommand cmd = new MySqlCommand(billQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BillId", billId);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            BillNo = dr["BillNo"].ToString();
                            if (dr["BillDate"] != DBNull.Value && DateTime.TryParse(dr["BillDate"].ToString(), out DateTime dt))
                                BillDate = dt;
                            else
                                BillDate = DateTime.Now;  // default to current date if NULL

                            CustomerName = dr["CustomerName"].ToString();
                            CustomerAddress = dr["Address"].ToString();
                            CustomerGST = dr["GSTIN"].ToString();
                            mobile = dr["Mobile"].ToString();
                            TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                            TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
                            GrandTotal = Convert.ToDecimal(dr["GrandTotal"]);
                            AmountInWords = dr["AmountInWords"].ToString();
                        }
                    }
                }

                string itemsQuery = @"
        SELECT ProductName, HSNNO, Quantity, Rate, Per,
               Discount, Amount, CGST, SGST
        FROM billing_items
        WHERE BillId = @BillId";

                using (MySqlCommand cmd = new MySqlCommand(itemsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BillId", billId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    BillingItems = new DataTable();
                    da.Fill(BillingItems);
                }
            }
        }


        private void lblinname_Click(object sender, EventArgs e)
        {

        }

        private void SaveInvoiceAsWord(string filePath)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Add company header
                body.AppendChild(new Paragraph(new Run(new Text("MIRACLE"))));
                body.AppendChild(new Paragraph(new Run(new Text("Opp. Hotel Gokul, 3rd Floor, Station Road, Kolhapur-416003"))));
                body.AppendChild(new Paragraph(new Run(new Text("Contact: 9881843886 | GSTIN: 27ATNPP5836H1Z4"))));

                // Add invoice info
                body.AppendChild(new Paragraph(new Run(new Text($"Invoice No.: {BillNo}   Date: {BillDate:dd-MMM-yyyy}"))));
                body.AppendChild(new Paragraph(new Run(new Text($"Customer: {CustomerName}"))));
                body.AppendChild(new Paragraph(new Run(new Text($"Address: {CustomerAddress}"))));

                // Add spacing
                body.AppendChild(new Paragraph(new Run(new Text(""))));

                // Add table for items
                Table table = new Table();

                // Table header row
                TableRow headerRow = new TableRow();
                string[] headers = { "Sr No", "Product", "HSN", "Qty", "Rate", "Discount", "Amount" };
                foreach (var h in headers)
                {
                    TableCell cell = new TableCell(new Paragraph(new Run(new Text(h))));
                    headerRow.Append(cell);
                }
                table.Append(headerRow);

                // Fill table rows from dataGridViewItems
                for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
                {
                    DataGridViewRow dgvRow = dataGridViewItems.Rows[i];
                    TableRow tRow = new TableRow();

                    tRow.Append(new TableCell(new Paragraph(new Run(new Text((i + 1).ToString())))));
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[1].Value.ToString()))))); // Product
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[2].Value.ToString()))))); // HSN
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[3].Value.ToString()))))); // Qty
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[4].Value.ToString()))))); // Rate
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[6].Value.ToString()))))); // Discount
                    tRow.Append(new TableCell(new Paragraph(new Run(new Text(dgvRow.Cells[7].Value.ToString()))))); // Amount

                    table.Append(tRow);
                }

                body.Append(table);

                // Add totals
                body.AppendChild(new Paragraph(new Run(new Text($"Total: {lblinTotalValue.Text}"))));
                body.AppendChild(new Paragraph(new Run(new Text($"GST: {lblinTaxValue.Text}"))));
                body.AppendChild(new Paragraph(new Run(new Text($"Grand Total: {lblinGrandTotalValue.Text}"))));
                body.AppendChild(new Paragraph(new Run(new Text($"Amount in Words: {lblAmountInWords.Text}"))));

                mainPart.Document.Save();
            }

            MessageBox.Show("Invoice saved as Word document successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Word Document|*.docx";
                sfd.FileName = $"Invoice_{BillNo}.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveInvoiceAsWord(sfd.FileName);
                }
                MessageBox.Show("Invoice saved as Word file.");
            }
        }

        //private void btnSavePdf_Click(object sender, EventArgs e)
        //{
        //    PrintDocument pd = new PrintDocument();
        //    pd.PrintPage += (s, ev) =>
        //    {
        //        Bitmap bm = new Bitmap(this.panelMain.Width, this.panelMain.Height);
        //        this.panelMain.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
        //        ev.Graphics.DrawImage(bm, 0, 0);
        //    };

        //    PrintDialog printDialog = new PrintDialog();
        //    printDialog.Document = pd;
        //    if (printDialog.ShowDialog() == DialogResult.OK)
        //        pd.Print();

        //}

        //private void btnSavePdf_Click(object sender, EventArgs e)
        //{
        //    PrintDocument pd = new PrintDocument();

        //    pd.PrintPage += (s, ev) =>
        //    {
        //        // Get FULL scrollable area
        //        Rectangle rect = panelMain.DisplayRectangle;

        //        Bitmap bmp = new Bitmap(rect.Width, rect.Height);
        //        panelMain.DrawToBitmap(bmp, new Rectangle(0, 0, rect.Width, rect.Height));

        //        Rectangle pageArea = ev.MarginBounds;

        //        float scaleX = (float)pageArea.Width / bmp.Width;
        //        float scaleY = (float)pageArea.Height / bmp.Height;
        //        float scale = Math.Min(scaleX, scaleY);

        //        int newWidth = (int)(bmp.Width * scale);
        //        int newHeight = (int)(bmp.Height * scale);

        //        ev.Graphics.DrawImage(bmp, pageArea.Left, pageArea.Top, newWidth, newHeight);
        //    };

        //    PrintDialog dialog = new PrintDialog();
        //    dialog.Document = pd;

        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        pd.Print();
        //    }
        //}


        Bitmap memoryImage;
        int currentY = 0;


        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            int pageHeight = e.MarginBounds.Height;

            int remainingHeight = memoryImage.Height - currentY;

            int drawHeight = Math.Min(pageHeight, remainingHeight);

            Rectangle srcRect = new Rectangle(0, currentY, memoryImage.Width, drawHeight);
            Rectangle destRect = new Rectangle(
                e.MarginBounds.Left,
                e.MarginBounds.Top,
                e.MarginBounds.Width,
                drawHeight
            );

            e.Graphics.DrawImage(memoryImage, destRect, srcRect, GraphicsUnit.Pixel);

            currentY += drawHeight;

            if (currentY < memoryImage.Height)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            Rectangle rect = panelMain.DisplayRectangle;

            memoryImage = new Bitmap(rect.Width, rect.Height);
            panelMain.DrawToBitmap(memoryImage, new Rectangle(0, 0, rect.Width, rect.Height));

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = false;
            pd.PrintPage += PrintPage;

            PrintDialog dialog = new PrintDialog();
            dialog.Document = pd;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentY = 0;
                pd.Print();
            }
        }

        private void LoadLatestInvoice()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                int billId = 0;

                // 🔹 Fetch latest billing record
                string billQuery = @"
                SELECT 
                b.BillId,
                b.BillNo,
                b.BillDate,
                b.TotalAmount,
                b.TaxAmount,
                b.GrandTotal,
                b.AmountInWords,
                c.CustomerName,
                c.Address,
                c.GSTIN,
                c.Mobile
                FROM billing b
                JOIN customers c ON b.CustomerID = c.CustomerId
                ORDER BY b.BillId DESC
                LIMIT 1";
                     

                using (MySqlCommand cmd = new MySqlCommand(billQuery, con))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        billId = Convert.ToInt32(dr["BillId"]);
                        BillNo = dr["BillNo"].ToString();
                        if (dr["BillDate"] != DBNull.Value && DateTime.TryParse(dr["BillDate"].ToString(), out DateTime dt))
                            BillDate = dt;
                        else
                            BillDate = DateTime.Now; // or MinValue if you prefer


                        CustomerName = dr["CustomerName"].ToString();
                        CustomerAddress = dr["Address"].ToString();
                        CustomerGST = dr["GSTIN"].ToString();
                        mobile = dr["Mobile"].ToString();
                        TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                        TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
                        GrandTotal = Convert.ToDecimal(dr["GrandTotal"]);
                        AmountInWords = dr["AmountInWords"].ToString();
                    }
                }

                // 🔹 Fetch billing items
                string itemsQuery = @"
            SELECT ProductName, HSNNO, Quantity, Rate, per, Discount, Amount, CGST, SGST
            FROM billing_items
            WHERE BillId = @BillId";

                using (MySqlCommand cmd = new MySqlCommand(itemsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BillId", billId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    BillingItems = new DataTable();
                    da.Fill(BillingItems);
                }
            }
        }



    }
}