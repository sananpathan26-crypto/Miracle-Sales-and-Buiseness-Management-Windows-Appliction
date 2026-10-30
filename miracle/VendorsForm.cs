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
    public partial class VendorsForm : Form
    {
        public VendorsForm()
        {
            InitializeComponent();
        }

        private void lblgst_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO vendors (VendorName, Phone, Email, Address) VALUES (@name, @phone, @email, @address)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone", txtmob.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@address", txtadd.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Vendor Saved Successfully!");
        }

        

        private void btndelete_Click(object sender, EventArgs e)
        {


           
            if (dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["VendorID"].Value);

                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM vendors WHERE VendorID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Vendor Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        

        

        private void btnview_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM vendors";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
           
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
    
    
}
