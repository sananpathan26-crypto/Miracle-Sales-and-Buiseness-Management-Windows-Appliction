using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace miracle
{
    public partial class newadminlogin : Form
    {
        public newadminlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpass1_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtpass2_TextChanged(object sender, EventArgs e)
        {



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show password
                txtadpass1.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                txtadpass1.UseSystemPasswordChar = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // Show password
                txtadpass2.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                txtadpass2.UseSystemPasswordChar = true;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string username = txtaduse.Text.Trim();
            string email = txtademail.Text.Trim();
            string password = txtadpass1.Text.Trim();
            string confirmPassword = txtadpass2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create().ComputeHash(
                    System.Text.Encoding.UTF8.GetBytes(password)));

            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM signup WHERE username=@username OR email=@email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@email", email);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("An account with this username or email already exists.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO signup (username, email, password, role) VALUES (@username, @email, @password, 'admin')";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@password", hashedPassword);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("New admin added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding admin: " + ex.Message);
                }
            }
        }

        private void picuse_Click(object sender, EventArgs e)
        {

        }

        private void newadminlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        { 

            admindashboard ad = new admindashboard();
            ad.Show();
            this.Hide();


        }
       

        // Minimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }



}
