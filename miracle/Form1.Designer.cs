namespace miracle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.signup = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginPanel.Controls.Add(this.checkBox1);
            this.loginPanel.Controls.Add(this.signup);
            this.loginPanel.Controls.Add(this.lable1);
            this.loginPanel.Controls.Add(this.exitbtn);
            this.loginPanel.Controls.Add(this.btn);
            this.loginPanel.Controls.Add(this.txtpass);
            this.loginPanel.Controls.Add(this.txtuser);
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Location = new System.Drawing.Point(514, 86);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(395, 516);
            this.loginPanel.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(70, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 26);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signup.Location = new System.Drawing.Point(232, 455);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(76, 22);
            this.signup.TabIndex = 6;
            this.signup.Text = "Signup?";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(109, 455);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(135, 22);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Do you want to ";
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(363, 0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(32, 27);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "X";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Black;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(99, 373);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(209, 62);
            this.btn.TabIndex = 3;
            this.btn.Text = "login";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(70, 266);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(256, 35);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Window;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(70, 164);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(256, 40);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(126, 29);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(135, 53);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(77, 36);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 87);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 699);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox logo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button exitbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

