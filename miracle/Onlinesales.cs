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
    public partial class Onlinesales : Form
    {
        public Onlinesales()
        {
            InitializeComponent();
        }

        private void Onlinesales_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadAllOnlineSales();
        }

        private void LoadAllOnlineSales()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = @"SELECT OrderID,
                                        CustomerID,
                                        ProductName,
                                        Price,
                                        Quantity,
                                        (Price * Quantity) AS TotalAmount,
                                        OrderDate,
                                        PaymentMode,
                                        OrderStatus
                                 FROM orders
                                 WHERE OrderStatus = 'Delivered'
                                 ORDER BY OrderDate DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOnlineSales.DataSource = dt;

                CalculateTotal(dt);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = @"SELECT OrderID,
                                        CustomerID,
                                        ProductName,
                                        Price,
                                        Quantity,
                                        (Price * Quantity) AS TotalAmount,
                                        OrderDate,
                                        PaymentMode,
                                        OrderStatus
                                 FROM orders
                                 WHERE OrderStatus = 'Delivered'
                                 AND OrderDate BETWEEN @from AND @to
                                 ORDER BY OrderDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOnlineSales.DataSource = dt;

                CalculateTotal(dt);
            }

        }

        private void CalculateTotal(DataTable dt)
        {
            decimal total = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["TotalAmount"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["TotalAmount"]);
                }
            }

            lblTotalAmount.Text = "₹ " + total.ToString("N2");
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadAllOnlineSales();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
