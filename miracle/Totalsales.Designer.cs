namespace miracle
{
    partial class Totalsales
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
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel panelMain;

        // Cards
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelOffline;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Panel panelGrand;

        private System.Windows.Forms.Label lblOfflineText;
        private System.Windows.Forms.Label lblOfflineTotal;

        private System.Windows.Forms.Label lblOnlineText;
        private System.Windows.Forms.Label lblOnlineTotal;

        private System.Windows.Forms.Label lblGrandText;
        private System.Windows.Forms.Label lblGrandTotal;

        // Filter
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelOffline = new System.Windows.Forms.Panel();
            this.lblOfflineText = new System.Windows.Forms.Label();
            this.lblOfflineTotal = new System.Windows.Forms.Label();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.lblOnlineText = new System.Windows.Forms.Label();
            this.lblOnlineTotal = new System.Windows.Forms.Label();
            this.panelGrand = new System.Windows.Forms.Panel();
            this.lblGrandText = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelOffline.SuspendLayout();
            this.panelOnline.SuspendLayout();
            this.panelGrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1150, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Total Sales Dashboard";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1107, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelFilter);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1150, 520);
            this.panelMain.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFilter.Controls.Add(this.lblFrom);
            this.panelFilter.Controls.Add(this.dtpFrom);
            this.panelFilter.Controls.Add(this.lblTo);
            this.panelFilter.Controls.Add(this.dtpTo);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.btnReset);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 250);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1150, 80);
            this.panelFilter.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(127, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(85, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(215, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(466, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(66, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To Date";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(538, 23);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(790, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(939, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.panelOffline);
            this.panelCards.Controls.Add(this.panelOnline);
            this.panelCards.Controls.Add(this.panelGrand);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(0, 0);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1150, 250);
            this.panelCards.TabIndex = 1;
            // 
            // panelOffline
            // 
            this.panelOffline.BackColor = System.Drawing.Color.White;
            this.panelOffline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOffline.Controls.Add(this.lblOfflineText);
            this.panelOffline.Controls.Add(this.lblOfflineTotal);
            this.panelOffline.Location = new System.Drawing.Point(150, 50);
            this.panelOffline.Name = "panelOffline";
            this.panelOffline.Size = new System.Drawing.Size(280, 160);
            this.panelOffline.TabIndex = 0;
            // 
            // lblOfflineText
            // 
            this.lblOfflineText.AutoSize = true;
            this.lblOfflineText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOfflineText.ForeColor = System.Drawing.Color.Gray;
            this.lblOfflineText.Location = new System.Drawing.Point(25, 25);
            this.lblOfflineText.Name = "lblOfflineText";
            this.lblOfflineText.Size = new System.Drawing.Size(167, 30);
            this.lblOfflineText.TabIndex = 0;
            this.lblOfflineText.Text = "OFFLINE SALES";
            // 
            // lblOfflineTotal
            // 
            this.lblOfflineTotal.AutoSize = true;
            this.lblOfflineTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOfflineTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOfflineTotal.Location = new System.Drawing.Point(25, 70);
            this.lblOfflineTotal.Name = "lblOfflineTotal";
            this.lblOfflineTotal.Size = new System.Drawing.Size(149, 60);
            this.lblOfflineTotal.TabIndex = 1;
            this.lblOfflineTotal.Text = "₹ 0.00";
            // 
            // panelOnline
            // 
            this.panelOnline.BackColor = System.Drawing.Color.White;
            this.panelOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOnline.Controls.Add(this.lblOnlineText);
            this.panelOnline.Controls.Add(this.lblOnlineTotal);
            this.panelOnline.Location = new System.Drawing.Point(470, 50);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Size = new System.Drawing.Size(280, 160);
            this.panelOnline.TabIndex = 1;
            // 
            // lblOnlineText
            // 
            this.lblOnlineText.AutoSize = true;
            this.lblOnlineText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOnlineText.ForeColor = System.Drawing.Color.Gray;
            this.lblOnlineText.Location = new System.Drawing.Point(25, 25);
            this.lblOnlineText.Name = "lblOnlineText";
            this.lblOnlineText.Size = new System.Drawing.Size(162, 30);
            this.lblOnlineText.TabIndex = 0;
            this.lblOnlineText.Text = "ONLINE SALES";
            // 
            // lblOnlineTotal
            // 
            this.lblOnlineTotal.AutoSize = true;
            this.lblOnlineTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOnlineTotal.ForeColor = System.Drawing.Color.Green;
            this.lblOnlineTotal.Location = new System.Drawing.Point(25, 70);
            this.lblOnlineTotal.Name = "lblOnlineTotal";
            this.lblOnlineTotal.Size = new System.Drawing.Size(149, 60);
            this.lblOnlineTotal.TabIndex = 1;
            this.lblOnlineTotal.Text = "₹ 0.00";
            // 
            // panelGrand
            // 
            this.panelGrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelGrand.Controls.Add(this.lblGrandText);
            this.panelGrand.Controls.Add(this.lblGrandTotal);
            this.panelGrand.Location = new System.Drawing.Point(790, 40);
            this.panelGrand.Name = "panelGrand";
            this.panelGrand.Size = new System.Drawing.Size(300, 180);
            this.panelGrand.TabIndex = 2;
            // 
            // lblGrandText
            // 
            this.lblGrandText.AutoSize = true;
            this.lblGrandText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandText.ForeColor = System.Drawing.Color.White;
            this.lblGrandText.Location = new System.Drawing.Point(30, 35);
            this.lblGrandText.Name = "lblGrandText";
            this.lblGrandText.Size = new System.Drawing.Size(179, 32);
            this.lblGrandText.TabIndex = 0;
            this.lblGrandText.Text = "GRAND TOTAL";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblGrandTotal.Location = new System.Drawing.Point(30, 85);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(178, 70);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = "₹ 0.00";
            // 
            // Totalsales
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Totalsales";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelOffline.ResumeLayout(false);
            this.panelOffline.PerformLayout();
            this.panelOnline.ResumeLayout(false);
            this.panelOnline.PerformLayout();
            this.panelGrand.ResumeLayout(false);
            this.panelGrand.PerformLayout();
            this.ResumeLayout(false);

            #endregion

        }
    }
}