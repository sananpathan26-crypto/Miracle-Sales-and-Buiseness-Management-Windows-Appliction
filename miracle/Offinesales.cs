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

namespace miracle
{
    public partial class Offinesales : Form
    {
        public Offinesales()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = @"SELECT BillNo,
                                        BillDate,
                                        CustomerID,
                                        TotalAmount,
                                        CGST,
                                        SGST,
                                        GrandTotal,
                                        PaymentMode
                                 FROM billing
                                 WHERE BillDate BETWEEN @from AND @to
                                 ORDER BY BillDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSales.DataSource = dt;

                CalculateTotal(dt);
            }

        }

        private void Offinesales_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadAllOfflineSales();
        }


        private void LoadAllOfflineSales()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = @"SELECT BillNo,
                                        BillDate,
                                        CustomerID,
                                        TotalAmount,
                                        CGST,
                                        SGST,
                                        GrandTotal,
                                        PaymentMode
                                 FROM billing
                                 ORDER BY BillDate DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSales.DataSource = dt;

                CalculateTotal(dt);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadAllOfflineSales();
        }

        private void CalculateTotal(DataTable dt)
        {
            decimal total = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["GrandTotal"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["GrandTotal"]);
                }
            }

            lblTotalAmount.Text = "₹ " + total.ToString("N2");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
