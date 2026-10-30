namespace miracle
{
    partial class Onlinesales
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.dgvOnlineSales = new System.Windows.Forms.DataGridView();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.panelfilter = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelhead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineSales)).BeginInit();
            this.panelfilter.SuspendLayout();
            this.panelhead.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.dgvOnlineSales);
            this.mainpanel.Controls.Add(this.lblTotalText);
            this.mainpanel.Controls.Add(this.lblTotalAmount);
            this.mainpanel.Controls.Add(this.panelfilter);
            this.mainpanel.Controls.Add(this.panelhead);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1080, 600);
            this.mainpanel.TabIndex = 0;
            // 
            // dgvOnlineSales
            // 
            this.dgvOnlineSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOnlineSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvOnlineSales.ColumnHeadersHeight = 34;
            this.dgvOnlineSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnlineSales.Location = new System.Drawing.Point(0, 160);
            this.dgvOnlineSales.Name = "dgvOnlineSales";
            this.dgvOnlineSales.RowHeadersVisible = false;
            this.dgvOnlineSales.RowHeadersWidth = 62;
            this.dgvOnlineSales.Size = new System.Drawing.Size(1080, 370);
            this.dgvOnlineSales.TabIndex = 0;
            // 
            // lblTotalText
            // 
            this.lblTotalText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalText.ForeColor = System.Drawing.Color.Black;
            this.lblTotalText.Location = new System.Drawing.Point(0, 530);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(1080, 30);
            this.lblTotalText.TabIndex = 1;
            this.lblTotalText.Text = "Total Sales:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalAmount.Location = new System.Drawing.Point(0, 560);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(1080, 40);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "₹ 0.00";
            // 
            // panelfilter
            // 
            this.panelfilter.BackColor = System.Drawing.Color.Gainsboro;
            this.panelfilter.Controls.Add(this.lblFrom);
            this.panelfilter.Controls.Add(this.dtpFrom);
            this.panelfilter.Controls.Add(this.lblTo);
            this.panelfilter.Controls.Add(this.dtpTo);
            this.panelfilter.Controls.Add(this.btnSearch);
            this.panelfilter.Controls.Add(this.btnReset);
            this.panelfilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfilter.Location = new System.Drawing.Point(0, 80);
            this.panelfilter.Name = "panelfilter";
            this.panelfilter.Size = new System.Drawing.Size(1080, 80);
            this.panelfilter.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(30, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(90, 23);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From Date:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(126, 27);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(370, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(81, 23);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To Date:";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(457, 30);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(673, 25);
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
            this.btnReset.Location = new System.Drawing.Point(820, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelhead
            // 
            this.panelhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelhead.Controls.Add(this.label1);
            this.panelhead.Controls.Add(this.btnclose);
            this.panelhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhead.Location = new System.Drawing.Point(0, 0);
            this.panelhead.Name = "panelhead";
            this.panelhead.Size = new System.Drawing.Size(1080, 80);
            this.panelhead.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Sales";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1037, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Onlinesales
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Onlinesales";
            this.Load += new System.EventHandler(this.Onlinesales_Load);
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineSales)).EndInit();
            this.panelfilter.ResumeLayout(false);
            this.panelhead.ResumeLayout(false);
            this.panelhead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panelhead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;

        private System.Windows.Forms.Panel panelfilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.DataGridView dgvOnlineSales;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalAmount;

    }
}