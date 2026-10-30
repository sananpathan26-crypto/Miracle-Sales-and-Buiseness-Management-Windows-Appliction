// FormInvoice.Designer.cs
namespace miracle
{
    partial class FormInvoice
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

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyContact = new System.Windows.Forms.Label();
            this.panelMeta = new System.Windows.Forms.Panel();
            this.lblinno = new System.Windows.Forms.Label();
            this.lalindated = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelParty = new System.Windows.Forms.Panel();
            this.lblinmobile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinname = new System.Windows.Forms.Label();
            this.lblinaddress = new System.Windows.Forms.Label();
            this.lblingst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartyTitle = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.lblPartyAddress = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.Panel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTotals = new System.Windows.Forms.Panel();
            this.lblinwordamt = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblinTotalValue = new System.Windows.Forms.Label();
            this.lblTaxLabel = new System.Windows.Forms.Label();
            this.lblinTaxValue = new System.Windows.Forms.Label();
            this.lblGrandTotalLabel = new System.Windows.Forms.Label();
            this.lblinGrandTotalValue = new System.Windows.Forms.Label();
            this.pictureBoxQr = new System.Windows.Forms.PictureBox();
            this.lblAmountInWords = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDeclaration = new System.Windows.Forms.Label();
            this.btnSaveWorld = new System.Windows.Forms.Button();
            this.lblAuthorizedSign = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMeta.SuspendLayout();
            this.panelParty.SuspendLayout();
            this.panelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panelTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.panelMeta);
            this.panelMain.Controls.Add(this.panelParty);
            this.panelMain.Controls.Add(this.panelItems);
            this.panelMain.Controls.Add(this.panelTotals);
            this.panelMain.Controls.Add(this.panelFooter);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(16);
            this.panelMain.Size = new System.Drawing.Size(965, 840);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.lblCompanyName);
            this.panelHeader.Controls.Add(this.lblCompanyAddress);
            this.panelHeader.Controls.Add(this.lblCompanyContact);
            this.panelHeader.Location = new System.Drawing.Point(21, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 120);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Image = global::miracle.Properties.Resources._1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Location = new System.Drawing.Point(150, 8);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(181, 40);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "MIRACLE";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyAddress.Location = new System.Drawing.Point(150, 48);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(590, 30);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "Opp. Hotel Gokul, 3rd Floor, RS No. 438/439, 1/2 Gala No.2, Shahupuri Thorli Masj" +
    "id, Station Road, Kolhapur-416003";
            // 
            // lblCompanyContact
            // 
            this.lblCompanyContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyContact.Location = new System.Drawing.Point(150, 84);
            this.lblCompanyContact.Name = "lblCompanyContact";
            this.lblCompanyContact.Size = new System.Drawing.Size(590, 36);
            this.lblCompanyContact.TabIndex = 3;
            this.lblCompanyContact.Text = "Contact: 9881843886 | GSTIN/UIN: 27ATNPP5836H1Z4";
            // 
            // panelMeta
            // 
            this.panelMeta.Controls.Add(this.lblinno);
            this.panelMeta.Controls.Add(this.lalindated);
            this.panelMeta.Controls.Add(this.lblDate);
            this.panelMeta.Location = new System.Drawing.Point(20, 148);
            this.panelMeta.Name = "panelMeta";
            this.panelMeta.Size = new System.Drawing.Size(860, 48);
            this.panelMeta.TabIndex = 1;
            // 
            // lblinno
            // 
            this.lblinno.Location = new System.Drawing.Point(112, 9);
            this.lblinno.Name = "lblinno";
            this.lblinno.Size = new System.Drawing.Size(162, 20);
            this.lblinno.TabIndex = 5;
            this.lblinno.Text = "label2";
            // 
            // lalindated
            // 
            this.lalindated.Location = new System.Drawing.Point(712, 8);
            this.lalindated.Name = "lalindated";
            this.lalindated.Size = new System.Drawing.Size(145, 25);
            this.lalindated.TabIndex = 4;
            this.lalindated.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(640, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Dated:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelParty
            // 
            this.panelParty.Controls.Add(this.lblinmobile);
            this.panelParty.Controls.Add(this.label2);
            this.panelParty.Controls.Add(this.lblinname);
            this.panelParty.Controls.Add(this.lblinaddress);
            this.panelParty.Controls.Add(this.lblingst);
            this.panelParty.Controls.Add(this.label1);
            this.panelParty.Controls.Add(this.lblPartyTitle);
            this.panelParty.Controls.Add(this.lblPartyName);
            this.panelParty.Controls.Add(this.lblPartyAddress);
            this.panelParty.Location = new System.Drawing.Point(20, 208);
            this.panelParty.Name = "panelParty";
            this.panelParty.Size = new System.Drawing.Size(860, 88);
            this.panelParty.TabIndex = 2;
            // 
            // lblinmobile
            // 
            this.lblinmobile.Location = new System.Drawing.Point(600, 60);
            this.lblinmobile.Name = "lblinmobile";
            this.lblinmobile.Size = new System.Drawing.Size(191, 20);
            this.lblinmobile.TabIndex = 7;
            this.lblinmobile.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact:";
            // 
            // lblinname
            // 
            this.lblinname.Location = new System.Drawing.Point(189, 12);
            this.lblinname.Name = "lblinname";
            this.lblinname.Size = new System.Drawing.Size(441, 20);
            this.lblinname.TabIndex = 5;
            this.lblinname.Text = "label2";
            this.lblinname.Click += new System.EventHandler(this.lblinname_Click);
            // 
            // lblinaddress
            // 
            this.lblinaddress.Location = new System.Drawing.Point(180, 35);
            this.lblinaddress.Name = "lblinaddress";
            this.lblinaddress.Size = new System.Drawing.Size(321, 20);
            this.lblinaddress.TabIndex = 4;
            this.lblinaddress.Text = "label2";
            // 
            // lblingst
            // 
            this.lblingst.Location = new System.Drawing.Point(180, 61);
            this.lblingst.Name = "lblingst";
            this.lblingst.Size = new System.Drawing.Size(321, 20);
            this.lblingst.TabIndex = 3;
            this.lblingst.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "GSTIN :";
            // 
            // lblPartyTitle
            // 
            this.lblPartyTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPartyTitle.Location = new System.Drawing.Point(8, 8);
            this.lblPartyTitle.Name = "lblPartyTitle";
            this.lblPartyTitle.Size = new System.Drawing.Size(120, 30);
            this.lblPartyTitle.TabIndex = 0;
            this.lblPartyTitle.Text = "Party :";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyName.Location = new System.Drawing.Point(127, 11);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(59, 21);
            this.lblPartyName.TabIndex = 1;
            this.lblPartyName.Text = "Name :";
            // 
            // lblPartyAddress
            // 
            this.lblPartyAddress.AutoSize = true;
            this.lblPartyAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPartyAddress.Location = new System.Drawing.Point(127, 38);
            this.lblPartyAddress.Name = "lblPartyAddress";
            this.lblPartyAddress.Size = new System.Drawing.Size(45, 21);
            this.lblPartyAddress.TabIndex = 2;
            this.lblPartyAddress.Text = "Add :";
            // 
            // panelItems
            // 
            this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItems.Controls.Add(this.dataGridViewItems);
            this.panelItems.Location = new System.Drawing.Point(20, 308);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(860, 260);
            this.panelItems.TabIndex = 3;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSL,
            this.colDescription,
            this.colHSN,
            this.colQty,
            this.colRate,
            this.colPer,
            this.colDisc,
            this.colAmount});
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(858, 258);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // colSL
            // 
            this.colSL.FillWeight = 8F;
            this.colSL.HeaderText = "Sl. No.";
            this.colSL.MinimumWidth = 8;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.FillWeight = 36F;
            this.colDescription.HeaderText = "Description of Goods";
            this.colDescription.MinimumWidth = 8;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colHSN
            // 
            this.colHSN.FillWeight = 12F;
            this.colHSN.HeaderText = "HSN/SAC";
            this.colHSN.MinimumWidth = 8;
            this.colHSN.Name = "colHSN";
            this.colHSN.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.FillWeight = 10F;
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.FillWeight = 12F;
            this.colRate.HeaderText = "Rate";
            this.colRate.MinimumWidth = 8;
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colPer
            // 
            this.colPer.FillWeight = 8F;
            this.colPer.HeaderText = "Per";
            this.colPer.MinimumWidth = 8;
            this.colPer.Name = "colPer";
            this.colPer.ReadOnly = true;
            // 
            // colDisc
            // 
            this.colDisc.FillWeight = 8F;
            this.colDisc.HeaderText = "Disc. %";
            this.colDisc.MinimumWidth = 8;
            this.colDisc.Name = "colDisc";
            this.colDisc.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.FillWeight = 18F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 8;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // panelTotals
            // 
            this.panelTotals.Controls.Add(this.lblinwordamt);
            this.panelTotals.Controls.Add(this.lblTotalLabel);
            this.panelTotals.Controls.Add(this.lblinTotalValue);
            this.panelTotals.Controls.Add(this.lblTaxLabel);
            this.panelTotals.Controls.Add(this.lblinTaxValue);
            this.panelTotals.Controls.Add(this.lblGrandTotalLabel);
            this.panelTotals.Controls.Add(this.lblinGrandTotalValue);
            this.panelTotals.Controls.Add(this.pictureBoxQr);
            this.panelTotals.Controls.Add(this.lblAmountInWords);
            this.panelTotals.Location = new System.Drawing.Point(20, 580);
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Size = new System.Drawing.Size(860, 200);
            this.panelTotals.TabIndex = 4;
            // 
            // lblinwordamt
            // 
            this.lblinwordamt.Location = new System.Drawing.Point(156, 53);
            this.lblinwordamt.Name = "lblinwordamt";
            this.lblinwordamt.Size = new System.Drawing.Size(280, 39);
            this.lblinwordamt.TabIndex = 10;
            this.lblinwordamt.Text = "label2";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.Location = new System.Drawing.Point(520, 8);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(120, 20);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblinTotalValue
            // 
            this.lblinTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblinTotalValue.Location = new System.Drawing.Point(680, 8);
            this.lblinTotalValue.Name = "lblinTotalValue";
            this.lblinTotalValue.Size = new System.Drawing.Size(160, 20);
            this.lblinTotalValue.TabIndex = 1;
            this.lblinTotalValue.Text = ".";
            this.lblinTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTaxLabel.Location = new System.Drawing.Point(520, 36);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(120, 20);
            this.lblTaxLabel.TabIndex = 2;
            this.lblTaxLabel.Text = "Tax";
            this.lblTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblinTaxValue
            // 
            this.lblinTaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinTaxValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblinTaxValue.Location = new System.Drawing.Point(680, 36);
            this.lblinTaxValue.Name = "lblinTaxValue";
            this.lblinTaxValue.Size = new System.Drawing.Size(160, 20);
            this.lblinTaxValue.TabIndex = 3;
            this.lblinTaxValue.Text = ".";
            this.lblinTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotalLabel
            // 
            this.lblGrandTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotalLabel.Location = new System.Drawing.Point(520, 68);
            this.lblGrandTotalLabel.Name = "lblGrandTotalLabel";
            this.lblGrandTotalLabel.Size = new System.Drawing.Size(120, 24);
            this.lblGrandTotalLabel.TabIndex = 4;
            this.lblGrandTotalLabel.Text = "Grand Total";
            this.lblGrandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblinGrandTotalValue
            // 
            this.lblinGrandTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinGrandTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblinGrandTotalValue.Location = new System.Drawing.Point(680, 68);
            this.lblinGrandTotalValue.Name = "lblinGrandTotalValue";
            this.lblinGrandTotalValue.Size = new System.Drawing.Size(160, 24);
            this.lblinGrandTotalValue.TabIndex = 5;
            this.lblinGrandTotalValue.Text = ".";
            this.lblinGrandTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxQr
            // 
            this.pictureBoxQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQr.Image = global::miracle.Properties.Resources.WhatsApp_Image_2025_12_12_at_8_41_35_PM;
            this.pictureBoxQr.Location = new System.Drawing.Point(16, 8);
            this.pictureBoxQr.Name = "pictureBoxQr";
            this.pictureBoxQr.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQr.TabIndex = 6;
            this.pictureBoxQr.TabStop = false;
            // 
            // lblAmountInWords
            // 
            this.lblAmountInWords.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmountInWords.Location = new System.Drawing.Point(150, 16);
            this.lblAmountInWords.Name = "lblAmountInWords";
            this.lblAmountInWords.Size = new System.Drawing.Size(340, 96);
            this.lblAmountInWords.TabIndex = 7;
            this.lblAmountInWords.Text = "Amount Chargeable (in words): INR ";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblDeclaration);
            this.panelFooter.Controls.Add(this.btnSaveWorld);
            this.panelFooter.Controls.Add(this.lblAuthorizedSign);
            this.panelFooter.Location = new System.Drawing.Point(20, 800);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(860, 160);
            this.panelFooter.TabIndex = 5;
            // 
            // lblDeclaration
            // 
            this.lblDeclaration.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDeclaration.Location = new System.Drawing.Point(8, 8);
            this.lblDeclaration.Name = "lblDeclaration";
            this.lblDeclaration.Size = new System.Drawing.Size(560, 64);
            this.lblDeclaration.TabIndex = 0;
            this.lblDeclaration.Text = "Declaration: We declare that this invoice shows the actual price of the goods des" +
    "cribed and that all particulars are true and correct.";
            // 
            // btnSaveWorld
            // 
            this.btnSaveWorld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveWorld.ForeColor = System.Drawing.Color.White;
            this.btnSaveWorld.Location = new System.Drawing.Point(443, 91);
            this.btnSaveWorld.Name = "btnSaveWorld";
            this.btnSaveWorld.Size = new System.Drawing.Size(140, 36);
            this.btnSaveWorld.TabIndex = 9;
            this.btnSaveWorld.Text = "Save as World ";
            this.btnSaveWorld.UseVisualStyleBackColor = false;
            this.btnSaveWorld.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAuthorizedSign
            // 
            this.lblAuthorizedSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthorizedSign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthorizedSign.Location = new System.Drawing.Point(640, 8);
            this.lblAuthorizedSign.Name = "lblAuthorizedSign";
            this.lblAuthorizedSign.Size = new System.Drawing.Size(200, 88);
            this.lblAuthorizedSign.TabIndex = 1;
            this.lblAuthorizedSign.Text = "For MIRACLE\r\n\nAuthorised Signatory";
            this.lblAuthorizedSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(965, 840);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormInvoice";
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMeta.ResumeLayout(false);
            this.panelParty.ResumeLayout(false);
            this.panelParty.PerformLayout();
            this.panelItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panelTotals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyContact;
        private System.Windows.Forms.Panel panelMeta;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelParty;
        private System.Windows.Forms.Label lblPartyTitle;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label lblPartyAddress;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panelTotals;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblinTotalValue;
        private System.Windows.Forms.Label lblTaxLabel;
        private System.Windows.Forms.Label lblinTaxValue;
        private System.Windows.Forms.Label lblGrandTotalLabel;
        private System.Windows.Forms.Label lblinGrandTotalValue;
        private System.Windows.Forms.PictureBox pictureBoxQr;
        private System.Windows.Forms.Label lblAmountInWords;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblDeclaration;
        private System.Windows.Forms.Label lblAuthorizedSign;

        // DataGridView columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Label lalindated;
        private System.Windows.Forms.Button btnSaveWorld;
        private System.Windows.Forms.Label lblingst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinname;
        private System.Windows.Forms.Label lblinaddress;
        private System.Windows.Forms.Label lblinno;
        private System.Windows.Forms.Label lblinwordamt;
        private System.Windows.Forms.Label lblinmobile;
        private System.Windows.Forms.Label label2;
    }
}
