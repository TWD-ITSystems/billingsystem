namespace BillingSystem
{
    partial class formManualBillPrint
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
            this.btnPrinting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefnum = new System.Windows.Forms.TextBox();
            this.btnRefnum = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadStarting = new System.Windows.Forms.Button();
            this.txtStartRefNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chkReprint = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBillmonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZone = new BillingSystem.dsZone();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.tbZoneTableAdapter = new BillingSystem.dsZoneTableAdapters.tbZoneTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbManualBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsManualBill = new BillingSystem.dsManualBill();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanual_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpres_rdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprev_rdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrefnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoded_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colctgy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbManualBillsTableAdapter = new BillingSystem.dsManualBillTableAdapters.tbManualBillsTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManualBillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManualBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrinting
            // 
            this.btnPrinting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrinting.Location = new System.Drawing.Point(866, 62);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(131, 33);
            this.btnPrinting.TabIndex = 0;
            this.btnPrinting.Text = "Start Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            this.btnPrinting.Visible = false;
            this.btnPrinting.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPrinting);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnProcessed);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbZone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBillmonth);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 133);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(569, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 121);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtRefnum);
            this.tabPage1.Controls.Add(this.btnRefnum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 95);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal Printing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Starting Reference Number:";
            // 
            // txtRefnum
            // 
            this.txtRefnum.Location = new System.Drawing.Point(14, 40);
            this.txtRefnum.Name = "txtRefnum";
            this.txtRefnum.Size = new System.Drawing.Size(169, 20);
            this.txtRefnum.TabIndex = 10;
            // 
            // btnRefnum
            // 
            this.btnRefnum.Location = new System.Drawing.Point(14, 66);
            this.btnRefnum.Name = "btnRefnum";
            this.btnRefnum.Size = new System.Drawing.Size(165, 23);
            this.btnRefnum.TabIndex = 11;
            this.btnRefnum.Text = "Set Reference Number";
            this.btnRefnum.UseVisualStyleBackColor = true;
            this.btnRefnum.Visible = false;
            this.btnRefnum.Click += new System.EventHandler(this.btnRefnum_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadStarting);
            this.tabPage2.Controls.Add(this.txtStartRefNum);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(243, 95);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reprint Bills";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadStarting
            // 
            this.btnLoadStarting.Location = new System.Drawing.Point(55, 60);
            this.btnLoadStarting.Name = "btnLoadStarting";
            this.btnLoadStarting.Size = new System.Drawing.Size(118, 23);
            this.btnLoadStarting.TabIndex = 9;
            this.btnLoadStarting.Text = "Load Starting";
            this.btnLoadStarting.UseVisualStyleBackColor = true;
            this.btnLoadStarting.Click += new System.EventHandler(this.btnLoadStarting_Click);
            // 
            // txtStartRefNum
            // 
            this.txtStartRefNum.Location = new System.Drawing.Point(101, 17);
            this.txtStartRefNum.Name = "txtStartRefNum";
            this.txtStartRefNum.Size = new System.Drawing.Size(121, 20);
            this.txtStartRefNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Ref. Num:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.chkReprint);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(237, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Processing Mode ]";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "with Arrears";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // chkReprint
            // 
            this.chkReprint.AutoSize = true;
            this.chkReprint.Location = new System.Drawing.Point(144, 63);
            this.chkReprint.Name = "chkReprint";
            this.chkReprint.Size = new System.Drawing.Size(84, 17);
            this.chkReprint.TabIndex = 14;
            this.chkReprint.Text = "Reprint Only";
            this.chkReprint.UseVisualStyleBackColor = true;
            this.chkReprint.CheckedChanged += new System.EventHandler(this.chkReprint_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Current Only";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(144, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnProcessed
            // 
            this.btnProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessed.Location = new System.Drawing.Point(866, 17);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(131, 33);
            this.btnProcessed.TabIndex = 1;
            this.btnProcessed.Text = "Process Records";
            this.btnProcessed.UseVisualStyleBackColor = true;
            this.btnProcessed.Visible = false;
            this.btnProcessed.Click += new System.EventHandler(this.btnProcessed_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(26, 94);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(147, 17);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total Number of Bills :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zone :";
            // 
            // cmbZone
            // 
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cmbZone.Location = new System.Drawing.Point(70, 59);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(148, 21);
            this.cmbZone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Billmonth :";
            // 
            // cmbBillmonth
            // 
            this.cmbBillmonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillmonth.DisplayMember = "billing_desc";
            this.cmbBillmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillmonth.FormattingEnabled = true;
            this.cmbBillmonth.Location = new System.Drawing.Point(70, 22);
            this.cmbBillmonth.Name = "cmbBillmonth";
            this.cmbBillmonth.Size = new System.Drawing.Size(148, 21);
            this.cmbBillmonth.TabIndex = 4;
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
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataMember = "tbZone";
            this.tbZoneBindingSource.DataSource = this.dsZone;
            // 
            // dsZone
            // 
            this.dsZone.DataSetName = "dsZone";
            this.dsZone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // tbZoneTableAdapter
            // 
            this.tbZoneTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbManualBillsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 139);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1050, 596);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbManualBillsBindingSource
            // 
            this.tbManualBillsBindingSource.DataMember = "tbManualBills";
            this.tbManualBillsBindingSource.DataSource = this.dsManualBill;
            // 
            // dsManualBill
            // 
            this.dsManualBill.DataSetName = "dsManualBill";
            this.dsManualBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmanual_id,
            this.colmaster_id,
            this.colpres_rdg,
            this.colprev_rdg,
            this.colcurrent_amt,
            this.gridColumn1,
            this.colvolume,
            this.colrefnum,
            this.colencoded_by,
            this.colacctno,
            this.colname,
            this.colzone,
            this.colcardno,
            this.colctgy,
            this.colbillmonth,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            // 
            // colmanual_id
            // 
            this.colmanual_id.FieldName = "manual_id";
            this.colmanual_id.Name = "colmanual_id";
            this.colmanual_id.OptionsColumn.ReadOnly = true;
            // 
            // colmaster_id
            // 
            this.colmaster_id.FieldName = "master_id";
            this.colmaster_id.Name = "colmaster_id";
            // 
            // colpres_rdg
            // 
            this.colpres_rdg.FieldName = "pres_rdg";
            this.colpres_rdg.Name = "colpres_rdg";
            this.colpres_rdg.Visible = true;
            this.colpres_rdg.VisibleIndex = 5;
            this.colpres_rdg.Width = 84;
            // 
            // colprev_rdg
            // 
            this.colprev_rdg.FieldName = "prev_rdg";
            this.colprev_rdg.Name = "colprev_rdg";
            this.colprev_rdg.Visible = true;
            this.colprev_rdg.VisibleIndex = 6;
            this.colprev_rdg.Width = 87;
            // 
            // colcurrent_amt
            // 
            this.colcurrent_amt.FieldName = "current_amt";
            this.colcurrent_amt.Name = "colcurrent_amt";
            this.colcurrent_amt.Visible = true;
            this.colcurrent_amt.VisibleIndex = 8;
            this.colcurrent_amt.Width = 120;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Arrears";
            this.gridColumn1.FieldName = "arrears";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // colvolume
            // 
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 7;
            this.colvolume.Width = 64;
            // 
            // colrefnum
            // 
            this.colrefnum.FieldName = "refnum";
            this.colrefnum.Name = "colrefnum";
            this.colrefnum.Visible = true;
            this.colrefnum.VisibleIndex = 10;
            this.colrefnum.Width = 150;
            // 
            // colencoded_by
            // 
            this.colencoded_by.FieldName = "encoded_by";
            this.colencoded_by.Name = "colencoded_by";
            this.colencoded_by.Visible = true;
            this.colencoded_by.VisibleIndex = 11;
            this.colencoded_by.Width = 80;
            // 
            // colacctno
            // 
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 0;
            this.colacctno.Width = 77;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 207;
            // 
            // colzone
            // 
            this.colzone.FieldName = "zone";
            this.colzone.Name = "colzone";
            this.colzone.Visible = true;
            this.colzone.VisibleIndex = 4;
            this.colzone.Width = 68;
            // 
            // colcardno
            // 
            this.colcardno.FieldName = "cardno";
            this.colcardno.Name = "colcardno";
            this.colcardno.Visible = true;
            this.colcardno.VisibleIndex = 2;
            this.colcardno.Width = 64;
            // 
            // colctgy
            // 
            this.colctgy.FieldName = "ctgy";
            this.colctgy.Name = "colctgy";
            this.colctgy.Visible = true;
            this.colctgy.VisibleIndex = 3;
            this.colctgy.Width = 51;
            // 
            // colbillmonth
            // 
            this.colbillmonth.FieldName = "billmonth";
            this.colbillmonth.Name = "colbillmonth";
            this.colbillmonth.Visible = true;
            this.colbillmonth.VisibleIndex = 12;
            this.colbillmonth.Width = 189;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "manual_id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 13;
            // 
            // tbManualBillsTableAdapter
            // 
            this.tbManualBillsTableAdapter.ClearBeforeFill = true;
            // 
            // formManualBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 735);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "formManualBillPrint";
            this.Text = "Manual Bill Printing";
            this.Load += new System.EventHandler(this.formManualBillPrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManualBillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManualBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBillmonth;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZone;
        private dsZone dsZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private dsZoneTableAdapters.tbZoneTableAdapter tbZoneTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsManualBill dsManualBill;
        private System.Windows.Forms.BindingSource tbManualBillsBindingSource;
        private dsManualBillTableAdapters.tbManualBillsTableAdapter tbManualBillsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmanual_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpres_rdg;
        private DevExpress.XtraGrid.Columns.GridColumn colprev_rdg;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_amt;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colrefnum;
        private DevExpress.XtraGrid.Columns.GridColumn colencoded_by;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colzone;
        private DevExpress.XtraGrid.Columns.GridColumn colcardno;
        private DevExpress.XtraGrid.Columns.GridColumn colctgy;
        private DevExpress.XtraGrid.Columns.GridColumn colbillmonth;
        private System.Windows.Forms.TextBox txtRefnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefnum;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkReprint;
        private System.Windows.Forms.TextBox txtStartRefNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadStarting;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}