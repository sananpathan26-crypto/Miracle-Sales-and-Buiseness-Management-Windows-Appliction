using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.Core;
using miracle;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace miracle
{
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
            ApplyModernStyle();


        }

        private async void admindashboard_Load(object sender, EventArgs e)
        {
            LoadCategories();
            panelcomp.Visible = false;

            LoadLowStock();

            LoadTopCustomersInPanel();

            await StartSignalRSafeAsync();

            UpdateBadge();

            StyleChart();
            LoadFinancialYearChart();
            //LoadYearlyChart();
            //LoadMonths();
            //LoadMonthlyChart(DateTime.Today.Month);

            //cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;



        }



        private void labDash_Click(object sender, EventArgs e)
        {

        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            StockIn stock = new StockIn();
            stock.Show();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            categpanel.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the form
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newadminlogin newad = new newadminlogin();
            newad.ShowDialog();
            this.Hide();

        }

        private void labA_Click(object sender, EventArgs e)
        {

        }

        private void labMIR_Click_1(object sender, EventArgs e)
        {

        }

        private void labAdmin_Click(object sender, EventArgs e)
        {

        }

        private void labCCable_Click(object sender, EventArgs e)
        {

        }

        private void btnEDIT1_Click(object sender, EventArgs e)
        {

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void labActios_Click(object sender, EventArgs e)
        {

        }

        private void btnaddcatg_Click(object sender, EventArgs e)
        {
            txtcateg.Visible = true;
            btnsavecateg.Visible = true;
        }

        private void btncategclose_Click(object sender, EventArgs e)
        {
            categpanel.Visible = false;
        }

        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT CategoryID, CategoryName FROM Categories";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable categoriesTable = new DataTable();
                    adapter.Fill(categoriesTable);

                    // ✅ Correct binding setup
                    categlist.DisplayMember = "CategoryName"; // What user sees
                    categlist.ValueMember = "CategoryID";     // What you use (e.g., SelectedValue)
                    categlist.DataSource = categoriesTable;   // Must be set last
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message);
            }
        }

        private void btnsavecateg_Click(object sender, EventArgs e)
        {
            string categoryName = txtcateg.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO categories (CategoryName) VALUES (@CategoryName)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category saved successfully!");
                txtcateg.Clear();
                txtcateg.Visible = false;
                btnsavecateg.Visible = false;

                // Reload categories into your combo box
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void categlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categlist.SelectedItem == null)
                return;
            int categoryId = Convert.ToInt32(categlist.SelectedValue);
            LoadCompanies(categoryId);
            panelcomp.Visible = true;

        }

        //company
        private void LoadCompanies(int categoryId)
        {
            listcomp.Items.Clear();

            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT CompanyID, CompanyName FROM Companies WHERE CategoryID = @CategoryID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add Company objects to listcomp (ListBox or ListView)
                                listcomp.Items.Add(new Company
                                {
                                    CompanyID = Convert.ToInt32(reader["CompanyID"]),
                                    CompanyName = reader["CompanyName"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading companies: " + ex.Message);
            }
        }




        private void listcomp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company selectedCompany = listcomp.SelectedItem as Company;
            if (selectedCompany == null)
                return;

            int companyId = selectedCompany.CompanyID;
            string companyName = selectedCompany.CompanyName;

            LoadTodayStockIn(companyId);

            PurchaseForm purchaseForm = new PurchaseForm(companyId, companyName);
            purchaseForm.ShowDialog();

            LoadTodayStockIn(companyId);
            LoadLowStock();
        }

        private void btnaddcomp_Click(object sender, EventArgs e)
        {
            txtcomp.Visible = true;
            btnsavecomp.Visible = true;
        }

        private void btnsavecomp_Click(object sender, EventArgs e)
        {
            string companyName = txtcomp.Text.Trim();

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please enter a company name.");
                return;
            }

            if (categlist.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            int categoryId = Convert.ToInt32(categlist.SelectedValue);

            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO companies (CompanyName, CategoryID) VALUES (@CompanyName, @CategoryID)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Company saved successfully!");
                txtcomp.Clear();
                txtcomp.Visible = false;
                btnsavecomp.Visible = false;

                // Reload companies list if needed
                LoadCompanies(categoryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnclosecomp_Click(object sender, EventArgs e)
        {
            panelcomp.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            categpanel.Visible = true;
        }


        private void LoadTodayStockIn(int companyId)
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                con.Open();

                string query = @"
            SELECT IFNULL(SUM(pi.Total), 0)
            FROM purchases p
            JOIN purchase_items pi ON p.PurchaseID = pi.PurchaseID
            WHERE DATE(p.PurchaseDate) = CURDATE()
            AND p.CompanyID = @CompanyId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CompanyId", companyId);

                decimal todayStockIn = Convert.ToDecimal(cmd.ExecuteScalar());
                lblstockin.Text = "₹ " + todayStockIn.ToString("0.00");
            }
        }

        private void LoadLowStock()
        {
            lostockpnl.Controls.Clear(); // Clear previous alerts

            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT ProductName, Quantity, ReorderLevel
                FROM stock 
                WHERE Quantity <= ReorderLevel
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int y = 10; // For dynamically creating labels inside panel

                        while (reader.Read())
                        {
                            string product = reader["ProductName"].ToString();
                            int qty = Convert.ToInt32(reader["Quantity"]);
                            int reorder = Convert.ToInt32(reader["ReorderLevel"]);

                            Label alert = new Label();
                            alert.AutoSize = true;
                            alert.ForeColor = Color.DarkRed;
                            alert.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                            alert.Location = new Point(10, y);

                            alert.Text = $"{product} — Qty: {qty}, Reorder Level: {reorder} stock is very low";

                            lostockpnl.Controls.Add(alert);

                            y += 30;
                        }

                        if (y == 10) // No items added
                        {
                            Label noAlert = new Label();
                            noAlert.AutoSize = true;
                            noAlert.ForeColor = Color.Green;
                            noAlert.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            noAlert.Location = new Point(10, 10);
                            noAlert.Text = "All items are sufficiently stocked.";

                            lostockpnl.Controls.Add(noAlert);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stock alerts: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillingForm bill = new BillingForm();
            bill.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPurchases viewpur = new ViewPurchases();
            viewpur.Show();
        }

        private void LoadTopCustomersInPanel()
        {
            // clear old data

            // Header (keep your existing label text style)
            Label header = new Label();
            header.Text = "Top Customers";
            header.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            header.ForeColor = Color.Black;
            header.Location = new Point(15, 15);
            header.AutoSize = true;
            panelcustomer.Controls.Add(header);

            int y = 55;

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();

                    string query = @"
                SELECT 
                    c.CustomerName,
                    IFNULL(SUM(b.GrandTotal), 0) AS TotalPurchase
                FROM customers c
                INNER JOIN billing b ON c.CustomerID = b.CustomerID
                GROUP BY c.CustomerID, c.CustomerName
                ORDER BY TotalPurchase DESC
                LIMIT 5";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        int rank = 1;

                        while (dr.Read())
                        {
                            string name = dr["CustomerName"].ToString();
                            decimal total = Convert.ToDecimal(dr["TotalPurchase"]);

                            Label lbl = new Label();
                            lbl.AutoSize = true;
                            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            lbl.ForeColor = Color.Black;
                            lbl.Location = new Point(15, y);
                            lbl.Text = $"{rank}. {name}  -  ₹ {total:0.00}";

                            panelcustomer.Controls.Add(lbl);

                            y += 30;
                            rank++;
                        }

                        if (rank == 1)
                        {
                            Label noData = new Label();
                            noData.Text = "No customer data available";
                            noData.ForeColor = Color.Black;
                            noData.Location = new Point(15, y);
                            noData.AutoSize = true;
                            panelcustomer.Controls.Add(noData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
        }


        // from user for orders
        private void btnSeeOrders_Click(object sender, EventArgs e)
        {

            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Owner = this;

            // Stop timer temporarily
            TimerBadgeRefresh.Stop();

            ordersForm.FormClosed += (s, args) =>
            {
                TimerBadgeRefresh.Start(); // restart timer when OrdersForm closes
                UpdateBadge(); // refresh badge immediately
            };

            ordersForm.Show();


        }

        private void UpdateBadge()
        {
            int unseenCount = 0;

            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM orders WHERE IsNew = 0";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        unseenCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                if (unseenCount > 0)
                {
                    lblOrderBadge.Text = unseenCount.ToString();
                    lblOrderBadge.Visible = true;
                }
                else
                {
                    lblOrderBadge.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating badge: " + ex.Message);
            }
        }



        private void TimerBadgeRefresh_Tick_1(object sender, EventArgs e)
        {
            UpdateBadge();
        }




        private Microsoft.AspNetCore.SignalR.Client.HubConnection connection;

        private async Task<bool> IsBackendRunningAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(2);
                    var res = await client.GetAsync("http://localhost:5271/api/orders/dbcheck");
                    return res.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task StartSignalRSafeAsync()
        {
            if (!await IsBackendRunningAsync())
                return;

            if (connection != null &&
                connection.State == HubConnectionState.Connected)
                return;

            try
            {
                connection = new HubConnectionBuilder()
                    .WithUrl("http://localhost:5271/orderHub") // ✔ correct
                    .WithAutomaticReconnect()
                    .Build();

                connection.On("NewOrder", () =>
                {
                    Invoke(new Action(() =>
                    {
                        UpdateBadge();
                        MessageBox.Show("New order received!");

                    }));


                });

                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SignalR error: " + ex.Message);
            }
        }

     

            // 🔘 BUTTON: View Online Orders / Open Backend Admin Page
            private async void btnexp_Click(object sender, EventArgs e)
            {
                try
                {
                    await StartBackendIfNotRunningAsync();

                    // open backend admin page
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "http://localhost:5271/admin/admin.html",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // ✅ Start backend only if not running
            private async Task StartBackendIfNotRunningAsync()
            {
                bool running = await IsBackendRunningAsync();
                if (running)
                    return;

                Process.Start(new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "run",
                    WorkingDirectory = @"C:\Users\ADMIN\OneDrive\Desktop\csharp\miracle\backend",
                    UseShellExecute = true,
                    CreateNoWindow = false
                });

                // wait for backend to boot
                await Task.Delay(5000);
            }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Offinesales sale = new Offinesales();
            sale.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Onlinesales on = new Onlinesales();
            on.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Totalsales total = new Totalsales();
            total.Show();
     
        }


        //private void ApplyModernStyle()
        //{
        //    // 1. Set the background to a soft, modern light gray
        //    this.BackColor = Color.FromArgb(244, 247, 246);

        //    // 2. Sidebar (panel7) - Deep Professional Navy
        //    panel7.BackColor = Color.FromArgb(31, 30, 68);
        //    panel7.Width = 240;

        //    // 3. Style Sidebar Buttons
        //    var sideButtons = new Button[] { button1, button3, button4, btncustomer, btnexp, button5, button6, button7 };
        //    foreach (var btn in sideButtons)
        //    {
        //        btn.FlatStyle = FlatStyle.Flat;
        //        btn.FlatAppearance.BorderSize = 0;
        //        btn.ForeColor = Color.White;
        //        btn.TextAlign = ContentAlignment.MiddleLeft;
        //        btn.Padding = new Padding(20, 0, 0, 0);

        //        // FIX for CS0117: Using FontStyle.Bold instead of SemiBold
        //        btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        //        btn.Cursor = Cursors.Hand;

        //        // Hover effect for responsiveness
        //        btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 100);
        //        btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(31, 30, 68);
        //    }

        //    // 4. Header Styling (panel2)
        //    panel2.BackColor = Color.White;
        //    panel2.Height = 65;

        //    // 5. Dashboard Cards (Sales, Purchase, Stock)
        //    // FIX for CS1503: Correct Font constructor usage
        //    StyleCard(btnsales, Color.FromArgb(0, 177, 243));   // Sky Blue
        //    StyleCard(btnpurchase, Color.FromArgb(46, 204, 113)); // Emerald Green
        //    StyleCard(btnstack, Color.FromArgb(255, 203, 41));    // Golden Yellow
        //}

        //private void StyleCard(Button btn, Color accentColor)
        //{
        //    btn.FlatStyle = FlatStyle.Flat;
        //    btn.FlatAppearance.BorderSize = 0; // Removing the thin border for a flatter look
        //    btn.BackColor = Color.White;
        //    btn.ForeColor = accentColor;
        //    btn.Font = new Font("Segoe UI Semibold", 12F); // Using font name directly to get the weight
        //}


        private void ApplyModernStyle()
        {
            // 1. Overall Theme
            this.BackColor = Color.FromArgb(242, 245, 250); // Soft cool gray background
            panel1.BackColor = Color.FromArgb(242, 245, 250);

            // 2. Sidebar (panel7)
            panel7.BackColor = Color.FromArgb(34, 45, 50); // Professional Dark Charcoal
            panel7.Width = 240;

            // 3. Header (panel2)
            panel2.BackColor = Color.White;
            panel2.Height = 60;

            // 4. Style Sidebar Buttons (Use Bold instead of SemiBold)
            var sideButtons = new Button[] { button1, button3, button4, btncustomer, btnexp, button5, button6, button7 };
            foreach (var btn in sideButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.FromArgb(191, 203, 217);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);
                btn.Cursor = Cursors.Hand;

                // Dynamic Hover effect
                btn.MouseEnter += (s, e) => { btn.BackColor = Color.FromArgb(44, 59, 65); btn.ForeColor = Color.White; };
                btn.MouseLeave += (s, e) => { btn.BackColor = Color.Transparent; btn.ForeColor = Color.FromArgb(191, 203, 217); };
            }

            // 5. Dashboard Cards (Sales, Purchase, Stock)
            // This creates a clean "White Card" look
            //StyleModernCard(btnsales, Color.FromArgb(0, 120, 212));   // Blue
            //StyleModernCard(btnpurchase, Color.FromArgb(16, 124, 16)); // Green
            //StyleModernCard(btnstack, Color.FromArgb(255, 185, 0));    // Gold

            // 6. Data Panels (Low Stock & Customers)
            StyleDataPanel(lostockpnl);
            StyleDataPanel(panelcustomer);
            panelcustomer.BackColor = Color.White; // Removed pink background
        }

        private void StyleModernCard(Button btn, Color accentColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.White;
            btn.ForeColor = accentColor;
            btn.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void StyleDataPanel(Panel pnl)
        {
            pnl.BackColor = Color.White;
            pnl.BorderStyle = BorderStyle.None;
            // Note: To see a thin border, set BorderStyle to FixedSingle and color to LightGray
        }


        //chart
        //private void LoadMonths()
        //{
        //    cmbMonth.Items.Clear();

        //    for (int i = 1; i <= 12; i++)
        //    {
        //        cmbMonth.Items.Add(new DateTime(1, i, 1).ToString("MMMM"));
        //    }

        //    cmbMonth.SelectedIndex = DateTime.Today.Month - 1;
        //}

        //private void LoadMonthlyChart(int month)
        //{
        //    chartSales.Series.Clear();
        //    chartSales.ChartAreas.Clear();

        //    chartSales.ChartAreas.Add(new ChartArea("MainArea"));

        //    Series series = new Series("Total Sales");
        //    series.ChartType = SeriesChartType.Column;
        //    series.IsValueShownAsLabel = true;

        //    decimal total = 0;

        //    using (MySqlConnection con = DBConfig.GetConnection())
        //    {
        //        con.Open();

        //        string query = @"
        //    SELECT IFNULL(SUM(total),0) FROM
        //    (
        //        SELECT GrandTotal as total FROM billing
        //        WHERE MONTH(BillDate)=@month
        //        UNION ALL
        //        SELECT (Price * Quantity) as total FROM orders
        //        WHERE OrderStatus='Delivered' AND MONTH(OrderDate)=@month
        //    ) as combined";

        //        MySqlCommand cmd = new MySqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@month", month);

        //        total = Convert.ToDecimal(cmd.ExecuteScalar());
        //    }

        //    series.Points.AddXY(
        //        new DateTime(1, month, 1).ToString("MMMM"),
        //        total
        //    );

        //    chartSales.Series.Add(series);
        //}

        //        private void LoadYearlyChart()
        //{
        //    chartSales.Series.Clear();
        //    chartSales.ChartAreas.Clear();

        //    ChartArea area = new ChartArea("MainArea");

        //    area.AxisX.MajorGrid.Enabled = false;
        //    area.AxisY.MajorGrid.LineColor = Color.LightGray;

        //    area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
        //    area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

        //    chartSales.ChartAreas.Add(area);

        //    Series series = new Series("Total Sales");
        //    series.ChartType = SeriesChartType.Column;
        //    series.IsValueShownAsLabel = true;
        //    series.Font = new Font("Segoe UI", 8, FontStyle.Bold);
        //    series.Color = Color.FromArgb(88, 101, 242); // modern blue

        //    using (MySqlConnection con = DBConfig.GetConnection())
        //    {
        //        con.Open();

        //        for (int month = 1; month <= 12; month++)
        //        {
        //            string query = @"
        //                SELECT IFNULL(SUM(total),0) FROM
        //                (
        //                    SELECT GrandTotal as total FROM billing
        //                    WHERE MONTH(BillDate)=@month
        //                    UNION ALL
        //                    SELECT (Price * Quantity) as total FROM orders
        //                    WHERE OrderStatus='Delivered' AND MONTH(OrderDate)=@month
        //                ) as combined";

        //            MySqlCommand cmd = new MySqlCommand(query, con);
        //            cmd.Parameters.AddWithValue("@month", month);

        //            decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

        //            string monthName = new DateTime(1, month, 1).ToString("MMM");

        //            series.Points.AddXY(monthName, total);
        //        }
        //    }

        //    chartSales.Series.Add(series);
        //}

        //private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedMonth = cmbMonth.SelectedIndex + 1;
        //    LoadMonthlyChart(selectedMonth);
        //}
        private void LoadFinancialYearChart()
        {
            chartSales.Series["Total Sales"].Points.Clear();

            DateTime startDate = new DateTime(2025, 3, 1);
            DateTime endDate = new DateTime(2026, 3, 31);

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT 
            MONTH(BillDate) as MonthNumber,
            SUM(GrandTotal) as TotalSales
        FROM billing
        WHERE BillDate BETWEEN @startDate AND @endDate
       GROUP BY YEAR(BillDate), MONTH(BillDate)
ORDER BY YEAR(BillDate), MONTH(BillDate)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, decimal> salesData = new Dictionary<int, decimal>();

                while (reader.Read())
                {
                    int month = reader.GetInt32("MonthNumber");
                    decimal total = reader.GetDecimal("TotalSales");
                    salesData[month] = total;
                }

                reader.Close();

                // Add months from March 2025 to March 2026
                DateTime temp = startDate;

                while (temp <= endDate)
                {
                    int monthNumber = temp.Month;
                    string monthName = temp.ToString("MMM");

                    decimal total = salesData.ContainsKey(monthNumber)
                        ? salesData[monthNumber]
                        : 0;

                    chartSales.Series["Total Sales"]
                              .Points.AddXY(monthName, total);

                    temp = temp.AddMonths(1);
                }
            }
        }
        private void StyleChart()
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();
            chartSales.Legends.Clear();

            chartSales.BackColor = Color.White;

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);

            area.AxisX.LineWidth = 0;
            area.AxisY.LineWidth = 0;

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            chartSales.ChartAreas.Add(area);

            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            legend.Alignment = StringAlignment.Far;
            legend.BackColor = Color.Transparent;

            chartSales.Legends.Add(legend);

            Series series = new Series("Total Sales");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 4;
            series.Color = Color.FromArgb(67, 97, 238);

            chartSales.Series.Add(series);
        }

        private void mainpic_Click(object sender, EventArgs e)
        {

        }

        private void btnvendor_Click(object sender, EventArgs e)
        {
            VendorsForm v = new VendorsForm();
            v.Show();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            Totalsales t = new Totalsales();
            t.Show();
        }
    }
    }









