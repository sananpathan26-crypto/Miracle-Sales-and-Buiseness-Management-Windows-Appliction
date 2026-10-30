namespace miracle
{
    partial class PurchaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnViewPurchases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;




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
            this.panelmain = new System.Windows.Forms.Panel();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtsrno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbatchno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txthsnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsellingrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.btnViewPurchases = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.lblvendorName = new System.Windows.Forms.Label();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelmain.Controls.Add(this.lblvendorName);
            this.panelmain.Controls.Add(this.comboVendor);
            this.panelmain.Controls.Add(this.dataGridView);
            this.panelmain.Controls.Add(this.headerpanel);
            this.panelmain.Controls.Add(this.lblGrandTotal);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1100, 630);
            this.panelmain.TabIndex = 0;
            // 
            // comboVendor
            // 
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(778, 63);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(121, 28);
            this.comboVendor.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtsrno,
            this.txtproductname,
            this.txtbatchno,
            this.txthsnno,
            this.txtrate,
            this.txtmrp,
            this.txtsellingrate,
            this.txtquantity,
            this.txttotal});
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(25, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1059, 466);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_keydown);
            // 
            // txtsrno
            // 
            this.txtsrno.HeaderText = "SrNo";
            this.txtsrno.MinimumWidth = 8;
            this.txtsrno.Name = "txtsrno";
            // 
            // txtproductname
            // 
            this.txtproductname.HeaderText = "ProductName";
            this.txtproductname.MinimumWidth = 8;
            this.txtproductname.Name = "txtproductname";
            // 
            // txtbatchno
            // 
            this.txtbatchno.HeaderText = "BatchNo";
            this.txtbatchno.MinimumWidth = 8;
            this.txtbatchno.Name = "txtbatchno";
            // 
            // txthsnno
            // 
            this.txthsnno.HeaderText = "HSNNo.";
            this.txthsnno.MinimumWidth = 8;
            this.txthsnno.Name = "txthsnno";
            // 
            // txtrate
            // 
            this.txtrate.HeaderText = "PurchaseRate";
            this.txtrate.MinimumWidth = 8;
            this.txtrate.Name = "txtrate";
            // 
            // txtmrp
            // 
            this.txtmrp.HeaderText = "MRP";
            this.txtmrp.MinimumWidth = 8;
            this.txtmrp.Name = "txtmrp";
            // 
            // txtsellingrate
            // 
            this.txtsellingrate.HeaderText = "SellingRate";
            this.txtsellingrate.MinimumWidth = 8;
            this.txtsellingrate.Name = "txtsellingrate";
            // 
            // txtquantity
            // 
            this.txtquantity.HeaderText = "Quantity";
            this.txtquantity.MinimumWidth = 8;
            this.txtquantity.Name = "txtquantity";
            // 
            // txttotal
            // 
            this.txttotal.HeaderText = "Total";
            this.txttotal.MinimumWidth = 8;
            this.txttotal.Name = "txttotal";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.headerpanel.Controls.Add(this.btnViewPurchases);
            this.headerpanel.Controls.Add(this.btnSave);
            this.headerpanel.Controls.Add(this.btnclose);
            this.headerpanel.Controls.Add(this.flowLayoutPanel1);
            this.headerpanel.Controls.Add(this.label1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1100, 57);
            this.headerpanel.TabIndex = 7;
            // 
            // btnViewPurchases
            // 
            this.btnViewPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPurchases.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPurchases.ForeColor = System.Drawing.Color.White;
            this.btnViewPurchases.Location = new System.Drawing.Point(947, 16);
            this.btnViewPurchases.Name = "btnViewPurchases";
            this.btnViewPurchases.Size = new System.Drawing.Size(74, 33);
            this.btnViewPurchases.TabIndex = 5;
            this.btnViewPurchases.Text = "View ";
            this.btnViewPurchases.UseVisualStyleBackColor = false;
            this.btnViewPurchases.Click += new System.EventHandler(this.btnViewPurchases_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(840, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1066, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 28);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(545, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 93);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Entry";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGrandTotal.Location = new System.Drawing.Point(20, 580);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(400, 33);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "Grand Total: 0.00";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // lblvendorName
            // 
            this.lblvendorName.AutoSize = true;
            this.lblvendorName.Location = new System.Drawing.Point(644, 71);
            this.lblvendorName.Name = "lblvendorName";
            this.lblvendorName.Size = new System.Drawing.Size(115, 20);
            this.lblvendorName.TabIndex = 8;
            this.lblvendorName.Text = "Vendor Name :";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.panelmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn txtsrno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtproductname;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtbatchno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txthsnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsellingrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttotal;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboVendor;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblvendorName;
    }
}