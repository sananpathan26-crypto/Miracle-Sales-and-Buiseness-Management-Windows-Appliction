using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace miracle
{
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            dtTo.Value = DateTime.Today;
            dtFrom.Value = DateTime.Today.AddMonths(-1);

            LoadCompanies(); // load company list in ComboBox
            LoadStockInReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadStockInReport();
        }

        private void LoadCompanies()
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CompanyID, CompanyName FROM companies ORDER BY CompanyName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCompany.DataSource = dt;
                    cmbCompany.DisplayMember = "CompanyName";
                    cmbCompany.ValueMember = "CompanyID";
                    cmbCompany.SelectedIndex = -1; // no default selection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading companies:\n" + ex.Message);
            }
        }

        private void LoadStockInReport()
        {
            try
            {
                DateTime dateFrom = dtFrom.Value.Date;
                DateTime dateTo = dtTo.Value.Date.AddDays(1).AddTicks(-1);

                if (dateFrom > dateTo)
                {
                    MessageBox.Show("Start date cannot be later than the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = new DataTable();
                int companyId = cmbCompany.SelectedIndex >= 0 ? Convert.ToInt32(cmbCompany.SelectedValue) : 0;

                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT s.StockID, s.ProductName, s.Quantity, s.CompanyID, c.CompanyName, s.UpdatedAt
                                     FROM stock s
                                     INNER JOIN companies c ON s.CompanyID = c.CompanyID
                                     WHERE s.UpdatedAt BETWEEN @FromDate AND @ToDate";

                    if (companyId > 0)
                        query += " AND s.CompanyID = @CompanyID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FromDate", dateFrom);
                    cmd.Parameters.AddWithValue("@ToDate", dateTo);
                    if (companyId > 0)
                        cmd.Parameters.AddWithValue("@CompanyID", companyId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                dgvStockIn.DataSource = dt;
                ConfigureDataGridView();
                CalculateGrandTotal(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            if (dgvStockIn.Columns.Contains("StockID"))
                dgvStockIn.Columns["StockID"].Visible = false;

            if (dgvStockIn.Columns.Contains("CompanyID"))
                dgvStockIn.Columns["CompanyID"].Visible = false;

            if (dgvStockIn.Columns.Contains("UpadatedAt"))
            {
                dgvStockIn.Columns["UpadatedAt"].HeaderText = "Updated At";
                dgvStockIn.Columns["UpadatedAt"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
            }

            if (dgvStockIn.Columns.Contains("Quantity"))
            {
                dgvStockIn.Columns["Quantity"].HeaderText = "Quantity";
                dgvStockIn.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvStockIn.Columns.Contains("CompanyName"))
            {
                dgvStockIn.Columns["CompanyName"].HeaderText = "Company";
            }
        }

        private void CalculateGrandTotal(DataTable dt)
        {
            int totalQty = 0;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                    totalQty += row.Field<int>("Quantity");
            }
            lblGrandTotal.Text = $"Grand Total Quantity: {totalQty}";
        }
    }
}
