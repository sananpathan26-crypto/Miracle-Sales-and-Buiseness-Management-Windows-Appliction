namespace miracle
{
    partial class BillingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBillNo = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblHSN = new System.Windows.Forms.Label();
            this.txtHSN = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.valGST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.valGrandTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.valTotalAmount = new System.Windows.Forms.Label();
            this.panelmain = new System.Windows.Forms.Panel();
            this.comboBoxpay = new System.Windows.Forms.ComboBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.lblgstin = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsee = new System.Windows.Forms.Button();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblper = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panelmain.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(42, 84);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(57, 20);
            this.lblBillNo.TabIndex = 0;
            this.lblBillNo.Text = "Bill No:";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(123, 82);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(150, 26);
            this.txtBillNo.TabIndex = 1;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(302, 85);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(72, 20);
            this.lblBillDate.TabIndex = 2;
            this.lblBillDate.Text = "Bill Date:";
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(380, 79);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(200, 26);
            this.dtBillDate.TabIndex = 3;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(35, 121);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 20);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer:";
            // 
            // comboCustomer
            // 
            this.comboCustomer.BackColor = System.Drawing.Color.White;
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.Location = new System.Drawing.Point(123, 118);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(150, 28);
            this.comboCustomer.TabIndex = 5;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(302, 121);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(103, 20);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(31, 169);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(68, 20);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product:";
            // 
            // lblHSN
            // 
            this.lblHSN.AutoSize = true;
            this.lblHSN.Location = new System.Drawing.Point(231, 169);
            this.lblHSN.Name = "lblHSN";
            this.lblHSN.Size = new System.Drawing.Size(47, 20);
            this.lblHSN.TabIndex = 9;
            this.lblHSN.Text = "HSN:";
            // 
            // txtHSN
            // 
            this.txtHSN.Location = new System.Drawing.Point(284, 166);
            this.txtHSN.Name = "txtHSN";
            this.txtHSN.Size = new System.Drawing.Size(80, 26);
            this.txtHSN.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(384, 169);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(37, 20);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Qty:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(427, 166);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 26);
            this.txtQuantity.TabIndex = 12;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(502, 166);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 20);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(556, 166);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(80, 26);
            this.txtRate.TabIndex = 14;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(770, 166);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(44, 20);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Disc:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(820, 166);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(60, 26);
            this.txtDiscount.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(907, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeight = 34;
            this.dgvItems.Location = new System.Drawing.Point(35, 216);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.Size = new System.Drawing.Size(1121, 300);
            this.dgvItems.TabIndex = 0;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 540);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(128, 20);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Taxable Amount:";
            // 
            // valGST
            // 
            this.valGST.AutoSize = true;
            this.valGST.Location = new System.Drawing.Point(150, 569);
            this.valGST.Name = "valGST";
            this.valGST.Size = new System.Drawing.Size(40, 20);
            this.valGST.TabIndex = 2;
            this.valGST.Text = "0.00";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(20, 569);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(85, 20);
            this.lblGST.TabIndex = 3;
            this.lblGST.Text = "GST Total:";
            // 
            // valGrandTotal
            // 
            this.valGrandTotal.AutoSize = true;
            this.valGrandTotal.Location = new System.Drawing.Point(150, 598);
            this.valGrandTotal.Name = "valGrandTotal";
            this.valGrandTotal.Size = new System.Drawing.Size(40, 20);
            this.valGrandTotal.TabIndex = 4;
            this.valGrandTotal.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(20, 598);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(97, 20);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // valTotalAmount
            // 
            this.valTotalAmount.AutoSize = true;
            this.valTotalAmount.Location = new System.Drawing.Point(150, 540);
            this.valTotalAmount.Name = "valTotalAmount";
            this.valTotalAmount.Size = new System.Drawing.Size(40, 20);
            this.valTotalAmount.TabIndex = 6;
            this.valTotalAmount.Text = "0.00";
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.panelmain.Controls.Add(this.comboBoxpay);
            this.panelmain.Controls.Add(this.lblpay);
            this.panelmain.Controls.Add(this.txtmobile);
            this.panelmain.Controls.Add(this.label3);
            this.panelmain.Controls.Add(this.txtGSTIN);
            this.panelmain.Controls.Add(this.lblgstin);
            this.panelmain.Controls.Add(this.txtCustomerAddress);
            this.panelmain.Controls.Add(this.label2);
            this.panelmain.Controls.Add(this.btnsee);
            this.panelmain.Controls.Add(this.headerpanel);
            this.panelmain.Controls.Add(this.dtBillDate);
            this.panelmain.Controls.Add(this.lblBillDate);
            this.panelmain.Controls.Add(this.txtBillNo);
            this.panelmain.Controls.Add(this.textBox1);
            this.panelmain.Controls.Add(this.lblper);
            this.panelmain.Controls.Add(this.lblProduct);
            this.panelmain.Controls.Add(this.lblCustomerID);
            this.panelmain.Controls.Add(this.comboCustomer);
            this.panelmain.Controls.Add(this.lblCustomer);
            this.panelmain.Controls.Add(this.comboProduct);
            this.panelmain.Controls.Add(this.lblBillNo);
            this.panelmain.Controls.Add(this.txtCustomerID);
            this.panelmain.Controls.Add(this.dgvItems);
            this.panelmain.Controls.Add(this.btnAdd);
            this.panelmain.Controls.Add(this.txtDiscount);
            this.panelmain.Controls.Add(this.lblDiscount);
            this.panelmain.Controls.Add(this.txtRate);
            this.panelmain.Controls.Add(this.lblRate);
            this.panelmain.Controls.Add(this.txtQuantity);
            this.panelmain.Controls.Add(this.lblQuantity);
            this.panelmain.Controls.Add(this.txtHSN);
            this.panelmain.Controls.Add(this.lblHSN);
            this.panelmain.Controls.Add(this.lblTotalAmount);
            this.panelmain.Controls.Add(this.valGST);
            this.panelmain.Controls.Add(this.lblGST);
            this.panelmain.Controls.Add(this.valGrandTotal);
            this.panelmain.Controls.Add(this.lblGrandTotal);
            this.panelmain.Controls.Add(this.valTotalAmount);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1200, 692);
            this.panelmain.TabIndex = 18;
            // 
            // comboBoxpay
            // 
            this.comboBoxpay.FormattingEnabled = true;
            this.comboBoxpay.Items.AddRange(new object[] {
            "Cash",
            "UPI",
            "Card",
            "Net Banking",
            "Cheque",
            "Wallet",
            "Credit",
            "Split Payment"});
            this.comboBoxpay.Location = new System.Drawing.Point(1010, 127);
            this.comboBoxpay.Name = "comboBoxpay";
            this.comboBoxpay.Size = new System.Drawing.Size(146, 28);
            this.comboBoxpay.TabIndex = 29;
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Location = new System.Drawing.Point(928, 127);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(75, 20);
            this.lblpay.TabIndex = 28;
            this.lblpay.Text = "Payment:";
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(1006, 82);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(150, 26);
            this.txtmobile.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(930, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contact:";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(759, 121);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(150, 26);
            this.txtGSTIN.TabIndex = 25;
            // 
            // lblgstin
            // 
            this.lblgstin.AutoSize = true;
            this.lblgstin.Location = new System.Drawing.Point(616, 120);
            this.lblgstin.Name = "lblgstin";
            this.lblgstin.Size = new System.Drawing.Size(66, 20);
            this.lblgstin.TabIndex = 24;
            this.lblgstin.Text = "GSTIN :";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(759, 81);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(150, 26);
            this.txtCustomerAddress.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer Address:";
            // 
            // btnsee
            // 
            this.btnsee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsee.ForeColor = System.Drawing.Color.White;
            this.btnsee.Location = new System.Drawing.Point(533, 580);
            this.btnsee.Name = "btnsee";
            this.btnsee.Size = new System.Drawing.Size(122, 38);
            this.btnsee.TabIndex = 21;
            this.btnsee.Text = "See Bill";
            this.btnsee.UseVisualStyleBackColor = false;
            this.btnsee.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.headerpanel.Controls.Add(this.btnclose);
            this.headerpanel.Controls.Add(this.label1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.ForeColor = System.Drawing.Color.White;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1200, 60);
            this.headerpanel.TabIndex = 20;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1161, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 32);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Section";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 26);
            this.textBox1.TabIndex = 19;
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Location = new System.Drawing.Point(650, 169);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(37, 20);
            this.lblper.TabIndex = 18;
            this.lblper.Text = "Per:";
            // 
            // comboProduct
            // 
            this.comboProduct.BackColor = System.Drawing.Color.White;
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.Location = new System.Drawing.Point(105, 166);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(120, 28);
            this.comboProduct.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(379, 118);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 26);
            this.txtCustomerID.TabIndex = 7;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(0, 0);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 0;
            // 
            // BillingForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.Text = "Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label lblCustomerID;

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label lblHSN;
        private System.Windows.Forms.TextBox txtHSN;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvItems;

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label valGST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label valGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label valTotalAmount;

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblper;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsee;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgstin;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.ComboBox comboBoxpay;
    }
}
