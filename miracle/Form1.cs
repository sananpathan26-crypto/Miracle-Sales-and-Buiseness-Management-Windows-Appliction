using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Threading;


namespace miracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterLoginPanel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
            SetRoundedRegion(btn, 14);
            SetRoundedRegion(loginPanel, 10);

            SetPlaceholder(txtuser, "Username / Email");
            SetPlaceholder(txtpass, "Password");

        }

        private void CenterLoginPanel()
        {
            // Center the login panel on the form
            loginPanel.Left = (this.ClientSize.Width - loginPanel.Width) / 2;
            loginPanel.Top = (this.ClientSize.Height - loginPanel.Height) / 2;

        }

        private void SetRoundedRegion(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top-left
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top-right
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Set initial placeholder
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // Attach GotFocus and LostFocus only once
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignupForm form2 = new SignupForm();
            form2.ShowDialog();
            this.Hide();
        }





        //private async void btn_Click(object sender, EventArgs e)
        //{
        //    string username = txtuser.Text.Trim();
        //    string password = txtpass.Text.Trim(); // plain text

        //    using (MySqlConnection conn = DBConfig.GetConnection())
        //    {
        //        try
        //        {
        //            conn.Open();

        //            string query = "SELECT role FROM signup WHERE username=@username AND password=@password";
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@username", username);
        //                cmd.Parameters.AddWithValue("@password", password);

        //                object result = cmd.ExecuteScalar();

        //                if (result == null)
        //                {
        //                    MessageBox.Show("Invalid username or password");
        //                    return;
        //                }

        //                string role = result.ToString();

        //                if (role == "admin")
        //                {
        //                    admindashboard ad = new admindashboard();
        //                    ad.Show();
        //                    this.Hide();
        //                }
        //                else if (role == "user")
        //                {
        //                    await StartBackendIfNotRunningAsync();

        //                    // open web UI
        //                    Process.Start(new ProcessStartInfo
        //                    {
        //                        FileName = "http://localhost:5271/index.html",
        //                        UseShellExecute = true
        //                    });

        //                    this.Hide();
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Login Error: " + ex.Message);
        //        }
        //    }
        //}

        private async void btn_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpass.Text.Trim(); // plain text

            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT user_id, role FROM signup WHERE username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password");
                                return;
                            }

                            int userId = reader.GetInt32("user_id");
                            string role = reader.GetString("role");

                            if (role == "admin")
                            {
                                admindashboard ad = new admindashboard();
                                ad.Show();
                                this.Hide();
                            }
                            else if (role == "user")
                            {
                                await StartBackendIfNotRunningAsync();

                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = $"http://localhost:5271/api/auth/set-user?userId={userId}",
                                    UseShellExecute = true
                                });


                                this.Hide();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Error: " + ex.Message);
                }
            }
        }


        private async Task StartBackendIfNotRunningAsync()
        {
            if (await IsBackendRunningAsync())
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = "run",
                WorkingDirectory = @"C:\Users\ADMIN\OneDrive\Desktop\csharp\miracle\backend",
                UseShellExecute = true,
                CreateNoWindow = false
            });

            // wait a little so backend starts
            await Task.Delay(4000);
        }


        private async Task<bool> IsBackendRunningAsync()
        {
            try
            {
                 var client = new System.Net.Http.HttpClient();
                client.Timeout = TimeSpan.FromSeconds(2);
                var res = await client.GetAsync("http://localhost:5271/api/orders/dbcheck");
                return res.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

    }
}

            
        
