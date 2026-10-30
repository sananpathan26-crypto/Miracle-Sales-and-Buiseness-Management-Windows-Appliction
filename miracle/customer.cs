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
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace miracle
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtname.Text = dgv.Rows[e.RowIndex].Cells["dgvcustomername"].Value.ToString();
            txtmob.Text = dgv.Rows[e.RowIndex].Cells["dgvmobile"].Value.ToString();
            txtadd.Text = dgv.Rows[e.RowIndex].Cells["dgvcustomeradd"].Value.ToString();
            txtgst.Text = dgv.Rows[e.RowIndex].Cells["dgvcustomergst"].Value.ToString();
        }




        private void btnview_Click(object sender, EventArgs e)
        {
           
            string query = @"
        SELECT 
            c.CustomerID,
            c.CustomerName,
            c.Mobile,
            c.Address,
            c.GSTIN,
            IFNULL(SUM(i.GrandTotal), 0) AS TotalPurchase
        FROM Customers c
        LEFT JOIN billing i ON c.CustomerID = i.CustomerID
        GROUP BY 
            c.CustomerID, c.CustomerName, c.Mobile, c.Address, c.GSTIN
        ORDER BY TotalPurchase DESC";

            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
            {
                da.Fill(dt);
            }

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
          
            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("Customer name is required");
                return;
            }

            string query = @"INSERT INTO Customers
                     (CustomerName, Mobile, Address, GSTIN)
                     VALUES (@Name, @Mobile, @Address, @GSTIN)";

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@Mobile", txtmob.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim());
                cmd.Parameters.AddWithValue("@GSTIN", txtgst.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer saved successfully");
            ClearFields();
            btnview_Click(null, null); // refresh grid
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            int customerId = Convert.ToInt32(
                dgv.CurrentRow.Cells["dgvcustomerid"].Value
            );

            string query = @"UPDATE Customers SET
                        CustomerName = @Name,
                        Mobile = @Mobile,
                        Address = @Address,
                        GSTIN = @GSTIN
                     WHERE CustomerID = @CustomerID";

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@Mobile", txtmob.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim());
                cmd.Parameters.AddWithValue("@GSTIN", txtgst.Text.Trim());
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer updated successfully");
            ClearFields();
            btnview_Click(null, null);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr != DialogResult.Yes) return;

            int customerId = Convert.ToInt32(
                dgv.CurrentRow.Cells["dgvcustomerid"].Value
            );

            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer deleted successfully");
            ClearFields();
            btnview_Click(null, null);
        }

        private void ClearFields()
        {
            txtname.Clear();
            txtmob.Clear();
            txtadd.Clear();
            txtgst.Clear();

            dgv.ClearSelection();   // optional
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
           
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





