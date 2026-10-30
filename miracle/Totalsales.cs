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
    public partial class Totalsales : Form
    {
        public Totalsales()
        {
            InitializeComponent();
        }

        private void Totalsales_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // First day of current month
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);

            dtpFrom.Value = firstDay;
            dtpTo.Value = today;

            // Load THIS MONTH data by default
            LoadSalesSummary(firstDay, today);
        }

        private void LoadSalesSummary(DateTime? fromDate = null, DateTime? toDate = null)
        {
            decimal offlineTotal = 0;
            decimal onlineTotal = 0;

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                // ================= OFFLINE =================
                string offlineQuery = "SELECT IFNULL(SUM(GrandTotal),0) FROM billing";

                if (fromDate.HasValue && toDate.HasValue)
                {
                    offlineQuery += " WHERE BillDate BETWEEN @from AND @to";
                }

                MySqlCommand cmd1 = new MySqlCommand(offlineQuery, con);

                if (fromDate.HasValue && toDate.HasValue)
                {
                    cmd1.Parameters.AddWithValue("@from", fromDate.Value.Date);
                    cmd1.Parameters.AddWithValue("@to", toDate.Value.Date.AddDays(1).AddSeconds(-1));
                }

                offlineTotal = Convert.ToDecimal(cmd1.ExecuteScalar());

                // ================= ONLINE =================
                string onlineQuery = "SELECT IFNULL(SUM(Price * Quantity),0) FROM orders WHERE OrderStatus='Delivered'";

                if (fromDate.HasValue && toDate.HasValue)
                {
                    onlineQuery += " AND OrderDate BETWEEN @from2 AND @to2";
                }

                MySqlCommand cmd2 = new MySqlCommand(onlineQuery, con);

                if (fromDate.HasValue && toDate.HasValue)
                {
                    cmd2.Parameters.AddWithValue("@from2", fromDate.Value.Date);
                    cmd2.Parameters.AddWithValue("@to2", toDate.Value.Date.AddDays(1).AddSeconds(-1));
                }

                onlineTotal = Convert.ToDecimal(cmd2.ExecuteScalar());
            }

            decimal grandTotal = offlineTotal + onlineTotal;

            lblOfflineTotal.Text = "₹ " + offlineTotal.ToString("N2");
            lblOnlineTotal.Text = "₹ " + onlineTotal.ToString("N2");
            lblGrandTotal.Text = "₹ " + grandTotal.ToString("N2");
        }

      

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesSummary(dtpFrom.Value, dtpTo.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadSalesSummary();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
