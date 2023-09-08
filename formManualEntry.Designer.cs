namespace BillingSystem
{
    partial class formManualEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbBillProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBilling = new System.Windows.Forms.ComboBox();
            this.tbbillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSR = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditCard = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tbBillingDetailGridControl = new DevExpress.XtraGrid.GridControl();
            this.tbBillingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltbMaster1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbMaster2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrdg_pres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrdg_prev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colave_vol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsenior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinst_fee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmtr_dmg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupEditCardNo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewCardNo = new System.Windows.Forms.TextBox();
            this.labelCurrentCardno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardAcctNo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressPanel2 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSRName = new System.Windows.Forms.Label();
            this.labelSRAccntNo = new System.Windows.Forms.Label();
            this.btnSRCancel = new System.Windows.Forms.Button();
            this.btnSROk = new System.Windows.Forms.Button();
            this.cmbSRCodes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbillingBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupEditCardNo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.cmbZone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBilling);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Select Bill Month to Edit ]";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(594, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 11;
            this.button4.TabStop = false;
            this.button4.Text = "Process Other Fees";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(460, 41);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 23);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.TabStop = false;
            this.btnProcess.Text = "Process Other Fees";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Visible = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(320, 41);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Load Readings";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbZone
            // 
            this.cmbZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbZone.DataSource = this.tbBillProcBindingSource;
            this.cmbZone.DisplayMember = "zone_book";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(172, 43);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(120, 21);
            this.cmbZone.TabIndex = 8;
            this.cmbZone.TabStop = false;
            this.cmbZone.ValueMember = "bill_process_id";
            this.cmbZone.TextChanged += new System.EventHandler(this.cmbZone_TextChanged);
            this.cmbZone.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBilling_Validating);
            // 
            // tbBillProcBindingSource
            // 
            this.tbBillProcBindingSource.DataSource = typeof(BillingSystem.tbBillProcessing);
            this.tbBillProcBindingSource.Filter = "date_checked is Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zone / Book :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bill Month :";
            // 
            // cmbBilling
            // 
            this.cmbBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbBilling.DataSource = this.tbbillingBindingSource;
            this.cmbBilling.DisplayMember = "billing_desc";
            this.cmbBilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBilling.FormattingEnabled = true;
            this.cmbBilling.Location = new System.Drawing.Point(9, 43);
            this.cmbBilling.Name = "cmbBilling";
            this.cmbBilling.Size = new System.Drawing.Size(151, 21);
            this.cmbBilling.TabIndex = 5;
            this.cmbBilling.TabStop = false;
            this.cmbBilling.ValueMember = "billing_id";
            this.cmbBilling.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBilling_Validating);
            this.cmbBilling.Validated += new System.EventHandler(this.cmbBilling_Validated);
            // 
            // tbbillingBindingSource
            // 
            this.tbbillingBindingSource.DataSource = typeof(BillingSystem.tbBilling);
            this.tbbillingBindingSource.Sort = "billing_id ASC";
            this.tbbillingBindingSource.PositionChanged += new System.EventHandler(this.tbbillingBindingSource_PositionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSR);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnFinalize);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnEditCard);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnSR
            // 
            this.btnSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSR.Location = new System.Drawing.Point(229, 6);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(104, 23);
            this.btnSR.TabIndex = 16;
            this.btnSR.Text = "Create SR";
            this.btnSR.UseVisualStyleBackColor = true;
            this.btnSR.Visible = false;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(119, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(681, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(119, 23);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View Bill";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(806, 6);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(118, 23);
            this.btnFinalize.TabIndex = 13;
            this.btnFinalize.Text = "Finalize Billfile";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Visible = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(449, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Print Bill File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditCard
            // 
            this.btnEditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCard.Location = new System.Drawing.Point(9, 6);
            this.btnEditCard.Name = "btnEditCard";
            this.btnEditCard.Size = new System.Drawing.Size(104, 23);
            this.btnEditCard.TabIndex = 11;
            this.btnEditCard.Text = "Edit Card No.";
            this.btnEditCard.UseVisualStyleBackColor = true;
            this.btnEditCard.Visible = false;
            this.btnEditCard.Click += new System.EventHandler(this.btnEditCard_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(339, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Add / Edit Entries";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.tbBillingDetailGridControl);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 432);
            this.panel2.TabIndex = 2;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressPanel1.Description = "Processing ...";
            this.progressPanel1.Location = new System.Drawing.Point(383, 154);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(131, 50);
            this.progressPanel1.TabIndex = 11;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // tbBillingDetailGridControl
            // 
            this.tbBillingDetailGridControl.DataSource = this.tbBillingDetailBindingSource;
            this.tbBillingDetailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBillingDetailGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillingDetailGridControl.Location = new System.Drawing.Point(0, 0);
            this.tbBillingDetailGridControl.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tbBillingDetailGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbBillingDetailGridControl.MainView = this.gridView1;
            this.tbBillingDetailGridControl.Name = "tbBillingDetailGridControl";
            this.tbBillingDetailGridControl.Size = new System.Drawing.Size(927, 432);
            this.tbBillingDetailGridControl.TabIndex = 0;
            this.tbBillingDetailGridControl.TabStop = false;
            this.tbBillingDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbBillingDetailBindingSource
            // 
            this.tbBillingDetailBindingSource.DataSource = typeof(BillingSystem.tbBillingDetail);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltbMaster1,
            this.coltbMaster,
            this.coltbMaster2,
            this.colcurrent,
            this.colarrears,
            this.colrdg_pres,
            this.colrdg_prev,
            this.colvolume,
            this.colave_vol,
            this.colremarks,
            this.colsenior,
            this.colinst_fee,
            this.colmtr_dmg});
            this.gridView1.GridControl = this.tbBillingDetailGridControl;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // coltbMaster1
            // 
            this.coltbMaster1.Caption = "Card #";
            this.coltbMaster1.FieldName = "tbMaster.cardno";
            this.coltbMaster1.Name = "coltbMaster1";
            this.coltbMaster1.Visible = true;
            this.coltbMaster1.VisibleIndex = 0;
            this.coltbMaster1.Width = 70;
            // 
            // coltbMaster
            // 
            this.coltbMaster.Caption = "Acct No.";
            this.coltbMaster.FieldName = "tbMaster.acctno";
            this.coltbMaster.Name = "coltbMaster";
            this.coltbMaster.Visible = true;
            this.coltbMaster.VisibleIndex = 1;
            // 
            // coltbMaster2
            // 
            this.coltbMaster2.Caption = "Name";
            this.coltbMaster2.FieldName = "tbMaster.name";
            this.coltbMaster2.Name = "coltbMaster2";
            this.coltbMaster2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "billingdetails_id", "Total Records : {0}")});
            this.coltbMaster2.Visible = true;
            this.coltbMaster2.VisibleIndex = 2;
            this.coltbMaster2.Width = 200;
            // 
            // colcurrent
            // 
            this.colcurrent.Caption = "Current";
            this.colcurrent.FieldName = "current";
            this.colcurrent.Name = "colcurrent";
            this.colcurrent.Visible = true;
            this.colcurrent.VisibleIndex = 3;
            // 
            // colarrears
            // 
            this.colarrears.Caption = "Arrears";
            this.colarrears.FieldName = "arrears";
            this.colarrears.Name = "colarrears";
            this.colarrears.Visible = true;
            this.colarrears.VisibleIndex = 4;
            // 
            // colrdg_pres
            // 
            this.colrdg_pres.Caption = "Pres Rdg";
            this.colrdg_pres.FieldName = "rdg_pres";
            this.colrdg_pres.Name = "colrdg_pres";
            this.colrdg_pres.Visible = true;
            this.colrdg_pres.VisibleIndex = 5;
            this.colrdg_pres.Width = 70;
            // 
            // colrdg_prev
            // 
            this.colrdg_prev.Caption = "Prev Rdg";
            this.colrdg_prev.FieldName = "rdg_prev";
            this.colrdg_prev.Name = "colrdg_prev";
            this.colrdg_prev.Visible = true;
            this.colrdg_prev.VisibleIndex = 6;
            this.colrdg_prev.Width = 70;
            // 
            // colvolume
            // 
            this.colvolume.Caption = "Volume";
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 7;
            this.colvolume.Width = 70;
            // 
            // colave_vol
            // 
            this.colave_vol.Caption = "Average";
            this.colave_vol.FieldName = "ave_vol";
            this.colave_vol.Name = "colave_vol";
            this.colave_vol.Visible = true;
            this.colave_vol.VisibleIndex = 8;
            this.colave_vol.Width = 70;
            // 
            // colremarks
            // 
            this.colremarks.Caption = "Remarks";
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 9;
            this.colremarks.Width = 120;
            // 
            // colsenior
            // 
            this.colsenior.Caption = "Senior";
            this.colsenior.FieldName = "senior";
            this.colsenior.Name = "colsenior";
            this.colsenior.Visible = true;
            this.colsenior.VisibleIndex = 10;
            // 
            // colinst_fee
            // 
            this.colinst_fee.Caption = "IF2";
            this.colinst_fee.FieldName = "inst_fee";
            this.colinst_fee.Name = "colinst_fee";
            this.colinst_fee.Visible = true;
            this.colinst_fee.VisibleIndex = 11;
            // 
            // colmtr_dmg
            // 
            this.colmtr_dmg.Caption = "Dmg Mtr";
            this.colmtr_dmg.FieldName = "mtr_dmg";
            this.colmtr_dmg.Name = "colmtr_dmg";
            this.colmtr_dmg.Visible = true;
            this.colmtr_dmg.VisibleIndex = 12;
            // 
            // groupEditCardNo
            // 
            this.groupEditCardNo.Controls.Add(this.button2);
            this.groupEditCardNo.Controls.Add(this.button1);
            this.groupEditCardNo.Controls.Add(this.txtNewCardNo);
            this.groupEditCardNo.Controls.Add(this.labelCurrentCardno);
            this.groupEditCardNo.Controls.Add(this.label7);
            this.groupEditCardNo.Controls.Add(this.label6);
            this.groupEditCardNo.Controls.Add(this.label5);
            this.groupEditCardNo.Controls.Add(this.lblCardName);
            this.groupEditCardNo.Controls.Add(this.lblCardAcctNo);
            this.groupEditCardNo.Location = new System.Drawing.Point(320, 154);
            this.groupEditCardNo.Name = "groupEditCardNo";
            this.groupEditCardNo.Size = new System.Drawing.Size(422, 219);
            this.groupEditCardNo.TabIndex = 10;
            this.groupEditCardNo.TabStop = false;
            this.groupEditCardNo.Text = "[ EDIT CARD NO. ]";
            this.groupEditCardNo.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(246, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(98, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNewCardNo
            // 
            this.txtNewCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewCardNo.Location = new System.Drawing.Point(158, 116);
            this.txtNewCardNo.Name = "txtNewCardNo";
            this.txtNewCardNo.Size = new System.Drawing.Size(126, 20);
            this.txtNewCardNo.TabIndex = 0;
            this.txtNewCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentCardno
            // 
            this.labelCurrentCardno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentCardno.ForeColor = System.Drawing.Color.Red;
            this.labelCurrentCardno.Location = new System.Drawing.Point(161, 93);
            this.labelCurrentCardno.Name = "labelCurrentCardno";
            this.labelCurrentCardno.Size = new System.Drawing.Size(123, 17);
            this.labelCurrentCardno.TabIndex = 5;
            this.labelCurrentCardno.Text = "Current Card No. :";
            this.labelCurrentCardno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Note :   This will also update the master list.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "New Card No. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Card No. :";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(22, 45);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(56, 18);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "Name :";
            // 
            // lblCardAcctNo
            // 
            this.lblCardAcctNo.AutoSize = true;
            this.lblCardAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardAcctNo.Location = new System.Drawing.Point(22, 25);
            this.lblCardAcctNo.Name = "lblCardAcctNo";
            this.lblCardAcctNo.Size = new System.Drawing.Size(93, 17);
            this.lblCardAcctNo.TabIndex = 0;
            this.lblCardAcctNo.Text = "Account No. :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // progressPanel2
            // 
            this.progressPanel2.Appearance.BackColor = System.Drawing.Color.White;
            this.progressPanel2.Appearance.Options.UseBackColor = true;
            this.progressPanel2.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel2.AppearanceCaption.Options.UseFont = true;
            this.progressPanel2.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel2.AppearanceDescription.Options.UseFont = true;
            this.progressPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressPanel2.Description = "Processing ...";
            this.progressPanel2.Location = new System.Drawing.Point(41, 45);
            this.progressPanel2.Name = "progressPanel2";
            this.progressPanel2.Size = new System.Drawing.Size(153, 67);
            this.progressPanel2.TabIndex = 11;
            this.progressPanel2.Text = "progressPanel2";
            this.progressPanel2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelSRName);
            this.groupBox2.Controls.Add(this.labelSRAccntNo);
            this.groupBox2.Controls.Add(this.btnSRCancel);
            this.groupBox2.Controls.Add(this.btnSROk);
            this.groupBox2.Controls.Add(this.cmbSRCodes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 159);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Create Service Request ]";
            this.groupBox2.Visible = false;
            // 
            // labelSRName
            // 
            this.labelSRName.Location = new System.Drawing.Point(94, 51);
            this.labelSRName.Name = "labelSRName";
            this.labelSRName.Size = new System.Drawing.Size(168, 13);
            this.labelSRName.TabIndex = 7;
            this.labelSRName.Text = "Account No. :";
            // 
            // labelSRAccntNo
            // 
            this.labelSRAccntNo.Location = new System.Drawing.Point(94, 27);
            this.labelSRAccntNo.Name = "labelSRAccntNo";
            this.labelSRAccntNo.Size = new System.Drawing.Size(168, 13);
            this.labelSRAccntNo.TabIndex = 6;
            this.labelSRAccntNo.Text = "Account No. :";
            // 
            // btnSRCancel
            // 
            this.btnSRCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRCancel.Location = new System.Drawing.Point(186, 119);
            this.btnSRCancel.Name = "btnSRCancel";
            this.btnSRCancel.Size = new System.Drawing.Size(88, 23);
            this.btnSRCancel.TabIndex = 5;
            this.btnSRCancel.Text = "Cancel";
            this.btnSRCancel.UseVisualStyleBackColor = true;
            this.btnSRCancel.Click += new System.EventHandler(this.btnSRCancel_Click);
            // 
            // btnSROk
            // 
            this.btnSROk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSROk.Location = new System.Drawing.Point(67, 119);
            this.btnSROk.Name = "btnSROk";
            this.btnSROk.Size = new System.Drawing.Size(88, 23);
            this.btnSROk.TabIndex = 4;
            this.btnSROk.Text = "Ok";
            this.btnSROk.UseVisualStyleBackColor = true;
            this.btnSROk.Click += new System.EventHandler(this.btnSROk_Click);
            // 
            // cmbSRCodes
            // 
            this.cmbSRCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRCodes.FormattingEnabled = true;
            this.cmbSRCodes.Location = new System.Drawing.Point(91, 78);
            this.cmbSRCodes.Name = "cmbSRCodes";
            this.cmbSRCodes.Size = new System.Drawing.Size(171, 21);
            this.cmbSRCodes.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Field Findings :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account No. :";
            // 
            // formManualEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 550);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressPanel2);
            this.Controls.Add(this.groupEditCardNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "formManualEntry";
            this.Text = "Check Billing";
            this.Load += new System.EventHandler(this.formManualEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbillingBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupEditCardNo.ResumeLayout(false);
            this.groupEditCardNo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBilling;
        private System.Windows.Forms.BindingSource tbbillingBindingSource;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbBillProcBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl tbBillingDetailGridControl;
        private System.Windows.Forms.BindingSource tbBillingDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colave_vol;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colrdg_pres;
        private DevExpress.XtraGrid.Columns.GridColumn colrdg_prev;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn coltbMaster1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditCard;
        private System.Windows.Forms.GroupBox groupEditCardNo;
        private System.Windows.Forms.TextBox txtNewCardNo;
        private System.Windows.Forms.Label labelCurrentCardno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardAcctNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnProcess;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.Columns.GridColumn coltbMaster;
        private DevExpress.XtraGrid.Columns.GridColumn coltbMaster2;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent;
        private DevExpress.XtraGrid.Columns.GridColumn colarrears;
        private DevExpress.XtraGrid.Columns.GridColumn colsenior;
        private DevExpress.XtraGrid.Columns.GridColumn colinst_fee;
        private DevExpress.XtraGrid.Columns.GridColumn colmtr_dmg;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel2;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSRCancel;
        private System.Windows.Forms.Button btnSROk;
        private System.Windows.Forms.ComboBox cmbSRCodes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSRName;
        private System.Windows.Forms.Label labelSRAccntNo;
    }
}