using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace miracle
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            SetRoundedRegion(panelshadow, 10);
            SetRoundedRegion(panel2, 10);
            SetRoundedRegion(btn, 18);

            SetPlaceholder(txtemail, "Enter Email");
            SetPlaceholder(txtuser, "Enter Username");
            SetPlaceholder(txtpass1, "Enter Password");
            SetPlaceholder(txtpass2, "Confirm Password");


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

        public void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
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

        //private void btn_Click(object sender, EventArgs e)
        //{

        //    string email = txtemail.Text;
        //    string username = txtuser.Text;
        //    string password = txtpass1.Text;
        //    string confirmpassword = txtpass2.Text;

        //    //check con pass
        //    if(password != confirmpassword)
        //    {
        //        MessageBox.Show("Password do not match");
        //        return;
        //    }

        //    //hashpass
        //    string hashedpassword = Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash
        //                                                     (System.Text.Encoding.UTF8.GetBytes (password)));

        //    // Connect to miracle database using DBConfig
        //    using (MySqlConnection conn = DBConfig.GetConnection())
        //    {
        //        try
        //        {
        //            conn.Open();

        //            // Check if username/email exists
        //            string checkQuery = "SELECT COUNT(*) FROM signup WHERE username=@username OR email=@email";
        //            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
        //            {
        //                checkCmd.Parameters.AddWithValue("@username", username);
        //                checkCmd.Parameters.AddWithValue("@email", email);

        //                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
        //                if (count > 0)
        //                {
        //                    MessageBox.Show("Username or email already exists!");
        //                    return;
        //                }
        //            }

        //            // Insert new user (role defaults to 'user')
        //            string insertQuery = "INSERT INTO signup (username, email, password, role) VALUES (@username, @email, @password, 'user')";
        //            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
        //            {
        //                insertCmd.Parameters.AddWithValue("@username", username);
        //                insertCmd.Parameters.AddWithValue("@email", email);
        //                insertCmd.Parameters.AddWithValue("@password", hashedpassword);
        //                insertCmd.ExecuteNonQuery();
        //            }

        //            MessageBox.Show("Signup successful!");
        //            Form1 form1 = new Form1();
        //            form1.Show();
        //            this.Hide(); // optionally close the signup form
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}


        private void btn_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string username = txtuser.Text.Trim();

            // Use REAL password variables (important)
            string password = realPassword1;
            string confirmPassword = realPassword2;

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check existing user
                    string checkQuery = "SELECT COUNT(*) FROM signup WHERE username=@username OR email=@email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@email", email);

                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Username or Email already exists");
                            return;
                        }
                    }

                    // INSERT WITHOUT HASHING
                    string insertQuery = @"INSERT INTO signup (username, email, password, role)
                                   VALUES (@username, @email, @password, 'user')";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password); // 👈 plain password
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Signup successful!");
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Signup Error: " + ex.Message);
                }
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private string realPassword1 = "";
        private string realPassword2 = "";
        private bool passwordVisible = false;
        private bool passwordVisible1 = false;
        private bool passwordVisible2 = false;

        private void txtpasss1KeyPress(object sender, KeyPressEventArgs e)
        {
            HandlePasswordInput(txtpass1, ref realPassword1, e);
        }

        private void txtpass2KeyPress(object sender, KeyPressEventArgs e)
        {
            HandlePasswordInput(txtpass2, ref realPassword2, e);

        }


        private void HandlePasswordInput(System.Windows.Forms.TextBox textBox, ref string realPassword, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if (realPassword.Length > 0)
                {
                    realPassword = realPassword.Substring(0, realPassword.Length - 1);
                    textBox.Text = passwordVisible ? realPassword : new string('*', realPassword.Length);
                    textBox.SelectionStart = textBox.Text.Length;
                }
                e.Handled = true;
                return;
            }

            if (char.IsControl(e.KeyChar))
                return;

            realPassword += e.KeyChar;
            textBox.Text = passwordVisible ? realPassword : textBox.Text + "*";
            textBox.SelectionStart = textBox.Text.Length;
            e.Handled = true;
        }

        private void SetButtonImage(System.Windows.Forms.Button btn, string imageFileName)
        { 
            if (btn.Image != null)
            {
                btn.Image.Dispose();
            }

            // Build the path to the image file
            string imagePath = Path.Combine(Application.StartupPath, "Images", imageFileName);

            // Load the image from file
            Image img = Image.FromFile(imagePath);

            // Scale it to the button’s size
            Image scaled = new Bitmap(img, new Size(btn.Width, btn.Height));

            // Assign it
            btn.Image = scaled;
        }


        private void eyebtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedBtn = sender as System.Windows.Forms.Button;
            if (clickedBtn == null) return;

            if (clickedBtn == eyebtn1)
            {
                passwordVisible1 = !passwordVisible1;
                txtpass1.Text = passwordVisible1 ? realPassword1 : new string('*', realPassword1.Length);
                txtpass1.SelectionStart = txtpass1.Text.Length;

                string imgName = passwordVisible1 ? @"C:\Users\ADMIN\Downloads\eyeopen.jpeg" : @"C:\Users\ADMIN\Downloads\eyeclose.jpeg";
                SetButtonImage(eyebtn1, imgName);
            }
            else if (clickedBtn == eyebtn2)
            {
                passwordVisible2 = !passwordVisible2;
                txtpass2.Text = passwordVisible2 ? realPassword2 : new string('*', realPassword2.Length);
                txtpass2.SelectionStart = txtpass2.Text.Length;

                string imgName = passwordVisible2 ? @"C:\Users\ADMIN\Downloads\eyeopen.jpeg" : @"C:\Users\ADMIN\Downloads\eyeclose.jpeg";
                SetButtonImage(eyebtn2, imgName);
            }
        }


    }
}

