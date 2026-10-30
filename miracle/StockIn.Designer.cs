namespace miracle
{
    partial class StockIn
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.Label lblGrandTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMain.Controls.Add(this.lblGrandTotal);
            this.panelMain.Controls.Add(this.dgvStockIn);
            this.panelMain.Controls.Add(this.btnFilter);
            this.panelMain.Controls.Add(this.dtTo);
            this.panelMain.Controls.Add(this.labelTo);
            this.panelMain.Controls.Add(this.dtFrom);
            this.panelMain.Controls.Add(this.labelDateRange);
            this.panelMain.Controls.Add(this.labelCompany);
            this.panelMain.Controls.Add(this.cmbCompany);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 600);
            this.panelMain.TabIndex = 0;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(20, 530);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(324, 38);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Text = "Grand Total Quantity: 0";
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockIn.ColumnHeadersHeight = 34;
            this.dgvStockIn.EnableHeadersVisualStyles = false;
            this.dgvStockIn.Location = new System.Drawing.Point(20, 110);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.RowHeadersWidth = 62;
            this.dgvStockIn.Size = new System.Drawing.Size(960, 400);
            this.dgvStockIn.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(830, 68);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 30);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(335, 70);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(150, 26);
            this.dtTo.TabIndex = 3;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTo.Location = new System.Drawing.Point(297, 70);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 28);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(141, 72);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(150, 26);
            this.dtFrom.TabIndex = 5;
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDateRange.Location = new System.Drawing.Point(25, 70);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(117, 28);
            this.labelDateRange.TabIndex = 6;
            this.labelDateRange.Text = "Date Range:";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCompany.Location = new System.Drawing.Point(500, 70);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(100, 28);
            this.labelCompany.TabIndex = 7;
            this.labelCompany.Text = "Company:";
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(600, 68);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(200, 28);
            this.cmbCompany.TabIndex = 8;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock In";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(960, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StockIn
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockIn";
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
