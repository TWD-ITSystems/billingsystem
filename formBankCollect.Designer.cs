namespace BillingSystem
{
    partial class formBankCollect
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn13 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn14 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCollectDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtArrears = new System.Windows.Forms.TextBox();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.txtSenior = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelNumRec = new System.Windows.Forms.Label();
            this.labelTotalAmt = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMtrMtn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBankCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankCodes = new BillingSystem.dsBankCodes();
            this.tbBankCodesTableAdapter = new BillingSystem.dsBankCodesTableAdapters.tbBankCodesTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDM = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.labelpenalty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBankCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(105, 23);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(111, 21);
            this.cmbBillMonth.TabIndex = 0;
            this.cmbBillMonth.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBilling;
            this.tbBillingBindingSource.Sort = "billing_id desc";
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bank Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Acctno :";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(105, 124);
            this.txtAcctNo.MaxLength = 6;
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(111, 20);
            this.txtAcctNo.TabIndex = 5;
            this.txtAcctNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcctNo.Click += new System.EventHandler(this.txtAcctNo_Click);
            this.txtAcctNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ref. No. :";
            // 
            // txtRefNo
            // 
            this.txtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefNo.Location = new System.Drawing.Point(105, 170);
            this.txtRefNo.MaxLength = 10;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(111, 20);
            this.txtRefNo.TabIndex = 7;
            this.txtRefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRefNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefNo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Collection Date :";
            // 
            // dtCollectDate
            // 
            this.dtCollectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCollectDate.Location = new System.Drawing.Point(105, 76);
            this.dtCollectDate.Name = "dtCollectDate";
            this.dtCollectDate.Size = new System.Drawing.Size(111, 20);
            this.dtCollectDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zone :";
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(68, 248);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(91, 20);
            this.txtZone.TabIndex = 13;
            this.txtZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Current :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Arrears :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Others :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Senior :";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(68, 283);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(91, 20);
            this.txtCurrent.TabIndex = 18;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // txtArrears
            // 
            this.txtArrears.Location = new System.Drawing.Point(68, 309);
            this.txtArrears.Name = "txtArrears";
            this.txtArrears.Size = new System.Drawing.Size(91, 20);
            this.txtArrears.TabIndex = 19;
            this.txtArrears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArrears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(68, 334);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(91, 20);
            this.txtOthers.TabIndex = 20;
            this.txtOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOthers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // txtSenior
            // 
            this.txtSenior.Location = new System.Drawing.Point(68, 359);
            this.txtSenior.Name = "txtSenior";
            this.txtSenior.Size = new System.Drawing.Size(91, 20);
            this.txtSenior.TabIndex = 21;
            this.txtSenior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSenior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(68, 453);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 23);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // btnAddToList
            // 
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToList.Location = new System.Drawing.Point(46, 502);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(114, 26);
            this.btnAddToList.TabIndex = 24;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(245, 50);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewCheckBoxColumn3.HeaderText = "";
            gridViewCheckBoxColumn3.Name = "column8";
            gridViewCheckBoxColumn3.Width = 30;
            gridViewTextBoxColumn15.FormatString = "";
            gridViewTextBoxColumn15.HeaderText = "Ref No.";
            gridViewTextBoxColumn15.Name = "column1";
            gridViewTextBoxColumn15.Width = 80;
            gridViewTextBoxColumn16.FormatString = "";
            gridViewTextBoxColumn16.HeaderText = "AcctNo";
            gridViewTextBoxColumn16.Name = "column2";
            gridViewTextBoxColumn16.Width = 60;
            gridViewTextBoxColumn17.FormatString = "";
            gridViewTextBoxColumn17.HeaderText = "Name";
            gridViewTextBoxColumn17.Name = "column3";
            gridViewTextBoxColumn17.Width = 200;
            gridViewTextBoxColumn18.HeaderText = "Zone";
            gridViewTextBoxColumn18.Name = "column10";
            gridViewDecimalColumn11.FormatString = "";
            gridViewDecimalColumn11.HeaderText = "Current";
            gridViewDecimalColumn11.Name = "column4";
            gridViewDecimalColumn11.Width = 70;
            gridViewDecimalColumn12.FormatString = "";
            gridViewDecimalColumn12.HeaderText = "Arrears";
            gridViewDecimalColumn12.Name = "column5";
            gridViewDecimalColumn12.Width = 70;
            gridViewTextBoxColumn19.HeaderText = "Penalty";
            gridViewTextBoxColumn19.Name = "column13";
            gridViewTextBoxColumn19.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn13.FormatString = "";
            gridViewDecimalColumn13.HeaderText = "Others";
            gridViewDecimalColumn13.Name = "column6";
            gridViewDecimalColumn13.Width = 70;
            gridViewTextBoxColumn20.HeaderText = "DMTR";
            gridViewTextBoxColumn20.Name = "column12";
            gridViewTextBoxColumn20.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn14.HeaderText = "Senior";
            gridViewDecimalColumn14.Name = "column7";
            gridViewDecimalColumn14.Width = 70;
            gridViewDecimalColumn15.HeaderText = "Total";
            gridViewDecimalColumn15.Name = "column9";
            gridViewDecimalColumn15.Width = 80;
            gridViewTextBoxColumn21.HeaderText = "column11";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "column11";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn3,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewTextBoxColumn19,
            gridViewDecimalColumn13,
            gridViewTextBoxColumn20,
            gridViewDecimalColumn14,
            gridViewDecimalColumn15,
            gridViewTextBoxColumn21});
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(864, 433);
            this.radGridView1.TabIndex = 25;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(766, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 26);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(906, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 26);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelNumRec
            // 
            this.labelNumRec.AutoSize = true;
            this.labelNumRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRec.Location = new System.Drawing.Point(243, 7);
            this.labelNumRec.Name = "labelNumRec";
            this.labelNumRec.Size = new System.Drawing.Size(139, 17);
            this.labelNumRec.TabIndex = 28;
            this.labelNumRec.Text = "Number of Records :";
            this.labelNumRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalAmt
            // 
            this.labelTotalAmt.AutoSize = true;
            this.labelTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmt.Location = new System.Drawing.Point(244, 28);
            this.labelTotalAmt.Name = "labelTotalAmt";
            this.labelTotalAmt.Size = new System.Drawing.Size(139, 17);
            this.labelTotalAmt.TabIndex = 29;
            this.labelTotalAmt.Text = "Number of Records :";
            this.labelTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(257, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 26);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mtr Mtn :";
            // 
            // txtMtrMtn
            // 
            this.txtMtrMtn.Location = new System.Drawing.Point(69, 430);
            this.txtMtrMtn.Name = "txtMtrMtn";
            this.txtMtrMtn.Size = new System.Drawing.Size(91, 20);
            this.txtMtrMtn.TabIndex = 32;
            this.txtMtrMtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMtrMtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbBankCodesBindingSource;
            this.comboBox1.DisplayMember = "bank_code";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "bank_code";
            // 
            // tbBankCodesBindingSource
            // 
            this.tbBankCodesBindingSource.DataMember = "tbBankCodes";
            this.tbBankCodesBindingSource.DataSource = this.dsBankCodes;
            // 
            // dsBankCodes
            // 
            this.dsBankCodes.DataSetName = "dsBankCodes";
            this.dsBankCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBankCodesTableAdapter
            // 
            this.tbBankCodesTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Mtr. Dmg :";
            // 
            // txtDM
            // 
            this.txtDM.Location = new System.Drawing.Point(68, 406);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(91, 20);
            this.txtDM.TabIndex = 35;
            this.txtDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(68, 382);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(91, 20);
            this.txtPenalty.TabIndex = 36;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelpenalty
            // 
            this.labelpenalty.AutoSize = true;
            this.labelpenalty.Location = new System.Drawing.Point(15, 385);
            this.labelpenalty.Name = "labelpenalty";
            this.labelpenalty.Size = new System.Drawing.Size(48, 13);
            this.labelpenalty.TabIndex = 37;
            this.labelpenalty.Text = "Penalty :";
            // 
            // formBankCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 537);
            this.Controls.Add(this.labelpenalty);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtDM);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtMtrMtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelTotalAmt);
            this.Controls.Add(this.labelNumRec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSenior);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.txtArrears);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCollectDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBillMonth);
            this.Name = "formBankCollect";
            this.Text = "Bank Payments Posting";
            this.Load += new System.EventHandler(this.formBankCollect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBankCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBillMonth;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCollectDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtArrears;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.TextBox txtSenior;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddToList;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelNumRec;
        private System.Windows.Forms.Label labelTotalAmt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMtrMtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private dsBankCodes dsBankCodes;
        private System.Windows.Forms.BindingSource tbBankCodesBindingSource;
        private dsBankCodesTableAdapters.tbBankCodesTableAdapter tbBankCodesTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDM;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label labelpenalty;
    }
}