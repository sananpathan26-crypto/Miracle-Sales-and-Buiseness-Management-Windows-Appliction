namespace miracle
{
    partial class customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnview = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvcustomerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcustomername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcustomeradd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcustomergst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.lblgst = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelhead = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblmob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtgst);
            this.panel1.Controls.Add(this.txtadd);
            this.panel1.Controls.Add(this.txtmob);
            this.panel1.Controls.Add(this.lblgst);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbladd);
            this.panel1.Controls.Add(this.lblmob);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 683);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Blue;
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(678, 232);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(84, 36);
            this.btnview.TabIndex = 14;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcustomerid,
            this.dgvcustomername,
            this.dgvmobile,
            this.dgvcustomeradd,
            this.dgvcustomergst,
            this.dgvtotal});
            this.dgv.Location = new System.Drawing.Point(29, 297);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1050, 347);
            this.dgv.TabIndex = 13;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // dgvcustomerid
            // 
            this.dgvcustomerid.DataPropertyName = "CustomerID";
            this.dgvcustomerid.HeaderText = "CustomerID";
            this.dgvcustomerid.MinimumWidth = 8;
            this.dgvcustomerid.Name = "dgvcustomerid";
            // 
            // dgvcustomername
            // 
            this.dgvcustomername.DataPropertyName = "CustomerName";
            this.dgvcustomername.HeaderText = "CustomerName";
            this.dgvcustomername.MinimumWidth = 8;
            this.dgvcustomername.Name = "dgvcustomername";
            // 
            // dgvmobile
            // 
            this.dgvmobile.DataPropertyName = "Mobile";
            this.dgvmobile.HeaderText = "Mobile No.";
            this.dgvmobile.MinimumWidth = 8;
            this.dgvmobile.Name = "dgvmobile";
            // 
            // dgvcustomeradd
            // 
            this.dgvcustomeradd.DataPropertyName = "Address";
            this.dgvcustomeradd.HeaderText = "Addres";
            this.dgvcustomeradd.MinimumWidth = 8;
            this.dgvcustomeradd.Name = "dgvcustomeradd";
            // 
            // dgvcustomergst
            // 
            this.dgvcustomergst.DataPropertyName = "GSTIN";
            this.dgvcustomergst.HeaderText = "GSTIN";
            this.dgvcustomergst.MinimumWidth = 8;
            this.dgvcustomergst.Name = "dgvcustomergst";
            // 
            // dgvtotal
            // 
            this.dgvtotal.DataPropertyName = "TotalPurchase";
            this.dgvtotal.HeaderText = "Total Purchase";
            this.dgvtotal.MinimumWidth = 8;
            this.dgvtotal.Name = "dgvtotal";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Green;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(517, 232);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(84, 36);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(360, 232);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(84, 36);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(172, 232);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 36);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(187, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 26);
            this.txtname.TabIndex = 9;
            // 
            // txtgst
            // 
            this.txtgst.Location = new System.Drawing.Point(187, 166);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(200, 26);
            this.txtgst.TabIndex = 8;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(879, 120);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(200, 26);
            this.txtadd.TabIndex = 7;
            // 
            // txtmob
            // 
            this.txtmob.Location = new System.Drawing.Point(517, 120);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(200, 26);
            this.txtmob.TabIndex = 6;
            // 
            // lblgst
            // 
            this.lblgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgst.Location = new System.Drawing.Point(101, 166);
            this.lblgst.Name = "lblgst";
            this.lblgst.Size = new System.Drawing.Size(80, 26);
            this.lblgst.TabIndex = 5;
            this.lblgst.Text = "GSTIN :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnmaximize);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelhead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 74);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaximize.ForeColor = System.Drawing.Color.White;
            this.btnmaximize.Location = new System.Drawing.Point(1040, 4);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(39, 32);
            this.btnmaximize.TabIndex = 16;
            this.btnmaximize.Text = "🗖";
            this.btnmaximize.UseVisualStyleBackColor = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1085, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelhead
            // 
            this.labelhead.AutoSize = true;
            this.labelhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhead.ForeColor = System.Drawing.Color.White;
            this.labelhead.Location = new System.Drawing.Point(22, 20);
            this.labelhead.Name = "labelhead";
            this.labelhead.Size = new System.Drawing.Size(200, 40);
            this.labelhead.TabIndex = 0;
            this.labelhead.Text = "Customers";
            this.labelhead.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbladd
            // 
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(773, 123);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(100, 23);
            this.lbladd.TabIndex = 3;
            this.lbladd.Text = " Address :";
            // 
            // lblmob
            // 
            this.lblmob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmob.Location = new System.Drawing.Point(437, 121);
            this.lblmob.Name = "lblmob";
            this.lblmob.Size = new System.Drawing.Size(74, 26);
            this.lblmob.TabIndex = 2;
            this.lblmob.Text = "Mobile :";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(25, 122);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(156, 25);
            this.lblname.TabIndex = 1;
            this.lblname.Text = " Customer Name :";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 683);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.Text = "customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblmob;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label labelhead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblgst;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomeradd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcustomergst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmaximize;
    }
}