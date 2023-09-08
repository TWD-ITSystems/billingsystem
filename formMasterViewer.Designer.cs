namespace BillingSystem
{
    partial class formMasterViewer
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
            System.Windows.Forms.Label acctnoLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label zone_nameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label master_idLabel;
            System.Windows.Forms.Label bill_currentLabel;
            System.Windows.Forms.Label bill_balanceLabel;
            System.Windows.Forms.Label bill_arrearsLabel;
            System.Windows.Forms.Label arrears_curr_yrLabel;
            System.Windows.Forms.Label arrears_prev_yrsLabel;
            System.Windows.Forms.Label cardnoLabel;
            System.Windows.Forms.Label iFBalanceLabel;
            System.Windows.Forms.Label iFArrearsLabel;
            System.Windows.Forms.Label date_installedLabel;
            System.Windows.Forms.Label last_disco_dateLabel;
            System.Windows.Forms.Label last_reco_dateLabel;
            System.Windows.Forms.Label last_read_dateLabel;
            System.Windows.Forms.Label remarksLabel;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.Label mtrDmg_BalanceLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwMasterDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMasterDetails = new BillingSystem.dsMasterDetails();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmeterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colisSenior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisMtrDmg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.last_reco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.last_disco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.last_read_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.date_installedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.iFArrearsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.iFBalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cardnoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.arrears_prev_yrsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.arrears_curr_yrSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bill_arrearsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bill_balanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bill_currentSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.master_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLedger = new System.Windows.Forms.Button();
            this.categorySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.zone_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acctnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster = new BillingSystem.dsMaster();
            this.vwMasterDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMasterDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwMasterDetailsTableAdapter = new BillingSystem.dsMasterDetailsTableAdapters.vwMasterDetailsTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsMasterDetailsTableAdapters.TableAdapterManager();
            this.tbMasterTableAdapter = new BillingSystem.dsMasterTableAdapters.tbMasterTableAdapter();
            this.tableAdapterManager1 = new BillingSystem.dsMasterTableAdapters.TableAdapterManager();
            this.mtrDmg_BalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            acctnoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            zone_nameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            master_idLabel = new System.Windows.Forms.Label();
            bill_currentLabel = new System.Windows.Forms.Label();
            bill_balanceLabel = new System.Windows.Forms.Label();
            bill_arrearsLabel = new System.Windows.Forms.Label();
            arrears_curr_yrLabel = new System.Windows.Forms.Label();
            arrears_prev_yrsLabel = new System.Windows.Forms.Label();
            cardnoLabel = new System.Windows.Forms.Label();
            iFBalanceLabel = new System.Windows.Forms.Label();
            iFArrearsLabel = new System.Windows.Forms.Label();
            date_installedLabel = new System.Windows.Forms.Label();
            last_disco_dateLabel = new System.Windows.Forms.Label();
            last_reco_dateLabel = new System.Windows.Forms.Label();
            last_read_dateLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            mtrDmg_BalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMasterDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_prev_yrsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_curr_yrSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrearsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_balanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_currentSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_idSpinEdit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMasterDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrDmg_BalanceSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acctnoLabel
            // 
            acctnoLabel.AutoSize = true;
            acctnoLabel.Location = new System.Drawing.Point(39, 25);
            acctnoLabel.Name = "acctnoLabel";
            acctnoLabel.Size = new System.Drawing.Size(55, 17);
            acctnoLabel.TabIndex = 0;
            acctnoLabel.Text = "Acctno:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(45, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(30, 86);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // zone_nameLabel
            // 
            zone_nameLabel.AutoSize = true;
            zone_nameLabel.Location = new System.Drawing.Point(13, 121);
            zone_nameLabel.Name = "zone_nameLabel";
            zone_nameLabel.Size = new System.Drawing.Size(81, 17);
            zone_nameLabel.TabIndex = 6;
            zone_nameLabel.Text = "Zone/Book:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(221, 121);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 8;
            categoryLabel.Text = "Category:";
            // 
            // master_idLabel
            // 
            master_idLabel.AutoSize = true;
            master_idLabel.Location = new System.Drawing.Point(259, 25);
            master_idLabel.Name = "master_idLabel";
            master_idLabel.Size = new System.Drawing.Size(72, 17);
            master_idLabel.TabIndex = 11;
            master_idLabel.Text = "Master ID:";
            // 
            // bill_currentLabel
            // 
            bill_currentLabel.AutoSize = true;
            bill_currentLabel.Location = new System.Drawing.Point(37, 277);
            bill_currentLabel.Name = "bill_currentLabel";
            bill_currentLabel.Size = new System.Drawing.Size(78, 17);
            bill_currentLabel.TabIndex = 13;
            bill_currentLabel.Text = "bill current:";
            // 
            // bill_balanceLabel
            // 
            bill_balanceLabel.AutoSize = true;
            bill_balanceLabel.Location = new System.Drawing.Point(233, 277);
            bill_balanceLabel.Name = "bill_balanceLabel";
            bill_balanceLabel.Size = new System.Drawing.Size(83, 17);
            bill_balanceLabel.TabIndex = 15;
            bill_balanceLabel.Text = "bill balance:";
            // 
            // bill_arrearsLabel
            // 
            bill_arrearsLabel.AutoSize = true;
            bill_arrearsLabel.Location = new System.Drawing.Point(36, 319);
            bill_arrearsLabel.Name = "bill_arrearsLabel";
            bill_arrearsLabel.Size = new System.Drawing.Size(79, 17);
            bill_arrearsLabel.TabIndex = 17;
            bill_arrearsLabel.Text = "bill arrears:";
            // 
            // arrears_curr_yrLabel
            // 
            arrears_curr_yrLabel.AutoSize = true;
            arrears_curr_yrLabel.Location = new System.Drawing.Point(12, 357);
            arrears_curr_yrLabel.Name = "arrears_curr_yrLabel";
            arrears_curr_yrLabel.Size = new System.Drawing.Size(103, 17);
            arrears_curr_yrLabel.TabIndex = 19;
            arrears_curr_yrLabel.Text = "arrears curr yr:";
            // 
            // arrears_prev_yrsLabel
            // 
            arrears_prev_yrsLabel.AutoSize = true;
            arrears_prev_yrsLabel.Location = new System.Drawing.Point(2, 395);
            arrears_prev_yrsLabel.Name = "arrears_prev_yrsLabel";
            arrears_prev_yrsLabel.Size = new System.Drawing.Size(113, 17);
            arrears_prev_yrsLabel.TabIndex = 21;
            arrears_prev_yrsLabel.Text = "arrears prev yrs:";
            // 
            // cardnoLabel
            // 
            cardnoLabel.AutoSize = true;
            cardnoLabel.Location = new System.Drawing.Point(40, 153);
            cardnoLabel.Name = "cardnoLabel";
            cardnoLabel.Size = new System.Drawing.Size(56, 17);
            cardnoLabel.TabIndex = 23;
            cardnoLabel.Text = "cardno:";
            // 
            // iFBalanceLabel
            // 
            iFBalanceLabel.AutoSize = true;
            iFBalanceLabel.Location = new System.Drawing.Point(233, 319);
            iFBalanceLabel.Name = "iFBalanceLabel";
            iFBalanceLabel.Size = new System.Drawing.Size(74, 17);
            iFBalanceLabel.TabIndex = 25;
            iFBalanceLabel.Text = "IFBalance:";
            // 
            // iFArrearsLabel
            // 
            iFArrearsLabel.AutoSize = true;
            iFArrearsLabel.Location = new System.Drawing.Point(233, 355);
            iFArrearsLabel.Name = "iFArrearsLabel";
            iFArrearsLabel.Size = new System.Drawing.Size(105, 17);
            iFArrearsLabel.TabIndex = 27;
            iFArrearsLabel.Text = "IF Amount Due:";
            // 
            // date_installedLabel
            // 
            date_installedLabel.AutoSize = true;
            date_installedLabel.Location = new System.Drawing.Point(0, 193);
            date_installedLabel.Name = "date_installedLabel";
            date_installedLabel.Size = new System.Drawing.Size(96, 17);
            date_installedLabel.TabIndex = 29;
            date_installedLabel.Text = "date installed:";
            // 
            // last_disco_dateLabel
            // 
            last_disco_dateLabel.AutoSize = true;
            last_disco_dateLabel.Location = new System.Drawing.Point(213, 193);
            last_disco_dateLabel.Name = "last_disco_dateLabel";
            last_disco_dateLabel.Size = new System.Drawing.Size(103, 17);
            last_disco_dateLabel.TabIndex = 31;
            last_disco_dateLabel.Text = "last disco date:";
            // 
            // last_reco_dateLabel
            // 
            last_reco_dateLabel.AutoSize = true;
            last_reco_dateLabel.Location = new System.Drawing.Point(218, 234);
            last_reco_dateLabel.Name = "last_reco_dateLabel";
            last_reco_dateLabel.Size = new System.Drawing.Size(98, 17);
            last_reco_dateLabel.TabIndex = 33;
            last_reco_dateLabel.Text = "last reco date:";
            // 
            // last_read_dateLabel
            // 
            last_read_dateLabel.AutoSize = true;
            last_read_dateLabel.Location = new System.Drawing.Point(-2, 232);
            last_read_dateLabel.Name = "last_read_dateLabel";
            last_read_dateLabel.Size = new System.Drawing.Size(99, 17);
            last_read_dateLabel.TabIndex = 35;
            last_read_dateLabel.Text = "last read date:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(13, 425);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(63, 17);
            remarksLabel.TabIndex = 39;
            remarksLabel.Text = "remarks:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(mtrDmg_BalanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.mtrDmg_BalanceSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(remarksLabel);
            this.splitContainer1.Panel2.Controls.Add(this.remarksTextEdit);
            this.splitContainer1.Panel2.Controls.Add(this.last_reco_dateDateEdit);
            this.splitContainer1.Panel2.Controls.Add(this.last_disco_dateDateEdit);
            this.splitContainer1.Panel2.Controls.Add(this.last_read_dateDateEdit);
            this.splitContainer1.Panel2.Controls.Add(this.date_installedDateEdit);
            this.splitContainer1.Panel2.Controls.Add(last_read_dateLabel);
            this.splitContainer1.Panel2.Controls.Add(last_reco_dateLabel);
            this.splitContainer1.Panel2.Controls.Add(last_disco_dateLabel);
            this.splitContainer1.Panel2.Controls.Add(date_installedLabel);
            this.splitContainer1.Panel2.Controls.Add(iFArrearsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.iFArrearsSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(iFBalanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.iFBalanceSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(cardnoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cardnoSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(arrears_prev_yrsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.arrears_prev_yrsSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(arrears_curr_yrLabel);
            this.splitContainer1.Panel2.Controls.Add(this.arrears_curr_yrSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(bill_arrearsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.bill_arrearsSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(bill_balanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.bill_balanceSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(bill_currentLabel);
            this.splitContainer1.Panel2.Controls.Add(this.bill_currentSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(master_idLabel);
            this.splitContainer1.Panel2.Controls.Add(this.master_idSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(categoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categorySpinEdit);
            this.splitContainer1.Panel2.Controls.Add(zone_nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.zone_nameTextEdit);
            this.splitContainer1.Panel2.Controls.Add(addressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addressTextEdit);
            this.splitContainer1.Panel2.Controls.Add(nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextEdit);
            this.splitContainer1.Panel2.Controls.Add(acctnoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.acctnoTextEdit);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(984, 557);
            this.splitContainer1.SplitterDistance = 521;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(153, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading Database...";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwMasterDetailsBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(521, 557);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwMasterDetailsBindingSource1
            // 
            this.vwMasterDetailsBindingSource1.DataMember = "vwMasterDetails";
            this.vwMasterDetailsBindingSource1.DataSource = this.dsMasterDetails;
            // 
            // dsMasterDetails
            // 
            this.dsMasterDetails.DataSetName = "dsMasterDetails";
            this.dsMasterDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colacctno,
            this.colname,
            this.colcardno,
            this.colzone_name,
            this.colstatus,
            this.colcategory,
            this.colmaster_id,
            this.colmeterno,
            this.colisIF,
            this.colisSenior,
            this.colisMtrDmg});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "acctno", null, "Count: {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colacctno
            // 
            this.colacctno.Caption = "Account No.";
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 0;
            this.colacctno.Width = 80;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 279;
            // 
            // colcardno
            // 
            this.colcardno.Caption = "CardNo";
            this.colcardno.FieldName = "cardno";
            this.colcardno.Name = "colcardno";
            this.colcardno.Visible = true;
            this.colcardno.VisibleIndex = 2;
            // 
            // colzone_name
            // 
            this.colzone_name.Caption = "Zone/Book";
            this.colzone_name.FieldName = "zone_name";
            this.colzone_name.Name = "colzone_name";
            this.colzone_name.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "zone_name", "Count: {0}")});
            this.colzone_name.Visible = true;
            this.colzone_name.VisibleIndex = 3;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 4;
            // 
            // colcategory
            // 
            this.colcategory.FieldName = "category";
            this.colcategory.Name = "colcategory";
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 5;
            // 
            // colmaster_id
            // 
            this.colmaster_id.FieldName = "master_id";
            this.colmaster_id.Name = "colmaster_id";
            this.colmaster_id.Visible = true;
            this.colmaster_id.VisibleIndex = 6;
            // 
            // colmeterno
            // 
            this.colmeterno.FieldName = "meterno";
            this.colmeterno.Name = "colmeterno";
            this.colmeterno.Visible = true;
            this.colmeterno.VisibleIndex = 7;
            // 
            // colisIF
            // 
            this.colisIF.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colisIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colisIF.FieldName = "isIF";
            this.colisIF.Name = "colisIF";
            this.colisIF.Visible = true;
            this.colisIF.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.ImageIndexChecked = 1;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueUnchecked = null;
            // 
            // colisSenior
            // 
            this.colisSenior.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colisSenior.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisSenior.FieldName = "isSenior";
            this.colisSenior.Name = "colisSenior";
            this.colisSenior.Visible = true;
            this.colisSenior.VisibleIndex = 9;
            // 
            // colisMtrDmg
            // 
            this.colisMtrDmg.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colisMtrDmg.FieldName = "isMtrDmg";
            this.colisMtrDmg.Name = "colisMtrDmg";
            this.colisMtrDmg.Visible = true;
            this.colisMtrDmg.VisibleIndex = 10;
            // 
            // remarksTextEdit
            // 
            this.remarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "remarks", true));
            this.remarksTextEdit.Location = new System.Drawing.Point(16, 445);
            this.remarksTextEdit.Name = "remarksTextEdit";
            this.remarksTextEdit.Properties.AutoHeight = false;
            this.remarksTextEdit.Size = new System.Drawing.Size(431, 50);
            this.remarksTextEdit.TabIndex = 40;
            // 
            // last_reco_dateDateEdit
            // 
            this.last_reco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "last_reco_date", true));
            this.last_reco_dateDateEdit.EditValue = null;
            this.last_reco_dateDateEdit.Location = new System.Drawing.Point(313, 233);
            this.last_reco_dateDateEdit.Name = "last_reco_dateDateEdit";
            this.last_reco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_reco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_reco_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.last_reco_dateDateEdit.TabIndex = 39;
            // 
            // last_disco_dateDateEdit
            // 
            this.last_disco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "last_disco_date", true));
            this.last_disco_dateDateEdit.EditValue = null;
            this.last_disco_dateDateEdit.Location = new System.Drawing.Point(313, 192);
            this.last_disco_dateDateEdit.Name = "last_disco_dateDateEdit";
            this.last_disco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_disco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_disco_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.last_disco_dateDateEdit.TabIndex = 38;
            // 
            // last_read_dateDateEdit
            // 
            this.last_read_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "last_read_date", true));
            this.last_read_dateDateEdit.EditValue = null;
            this.last_read_dateDateEdit.Location = new System.Drawing.Point(102, 233);
            this.last_read_dateDateEdit.Name = "last_read_dateDateEdit";
            this.last_read_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_read_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_read_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.last_read_dateDateEdit.TabIndex = 37;
            // 
            // date_installedDateEdit
            // 
            this.date_installedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "date_installed", true));
            this.date_installedDateEdit.EditValue = null;
            this.date_installedDateEdit.Location = new System.Drawing.Point(102, 192);
            this.date_installedDateEdit.Name = "date_installedDateEdit";
            this.date_installedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_installedDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_installedDateEdit.Size = new System.Drawing.Size(100, 20);
            this.date_installedDateEdit.TabIndex = 36;
            // 
            // iFArrearsSpinEdit
            // 
            this.iFArrearsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "IFArrears", true));
            this.iFArrearsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFArrearsSpinEdit.Location = new System.Drawing.Point(347, 354);
            this.iFArrearsSpinEdit.Name = "iFArrearsSpinEdit";
            this.iFArrearsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.iFArrearsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFArrearsSpinEdit.TabIndex = 28;
            // 
            // iFBalanceSpinEdit
            // 
            this.iFBalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "IFBalance", true));
            this.iFBalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFBalanceSpinEdit.Location = new System.Drawing.Point(347, 318);
            this.iFBalanceSpinEdit.Name = "iFBalanceSpinEdit";
            this.iFBalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.iFBalanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFBalanceSpinEdit.TabIndex = 26;
            // 
            // cardnoSpinEdit
            // 
            this.cardnoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "cardno", true));
            this.cardnoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cardnoSpinEdit.Location = new System.Drawing.Point(102, 150);
            this.cardnoSpinEdit.Name = "cardnoSpinEdit";
            this.cardnoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cardnoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cardnoSpinEdit.TabIndex = 24;
            // 
            // arrears_prev_yrsSpinEdit
            // 
            this.arrears_prev_yrsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "arrears_prev_yrs", true));
            this.arrears_prev_yrsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.arrears_prev_yrsSpinEdit.Location = new System.Drawing.Point(121, 392);
            this.arrears_prev_yrsSpinEdit.Name = "arrears_prev_yrsSpinEdit";
            this.arrears_prev_yrsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.arrears_prev_yrsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.arrears_prev_yrsSpinEdit.TabIndex = 22;
            // 
            // arrears_curr_yrSpinEdit
            // 
            this.arrears_curr_yrSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "arrears_curr_yr", true));
            this.arrears_curr_yrSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.arrears_curr_yrSpinEdit.Location = new System.Drawing.Point(121, 354);
            this.arrears_curr_yrSpinEdit.Name = "arrears_curr_yrSpinEdit";
            this.arrears_curr_yrSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.arrears_curr_yrSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.arrears_curr_yrSpinEdit.TabIndex = 20;
            // 
            // bill_arrearsSpinEdit
            // 
            this.bill_arrearsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "bill_arrears", true));
            this.bill_arrearsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_arrearsSpinEdit.Location = new System.Drawing.Point(121, 316);
            this.bill_arrearsSpinEdit.Name = "bill_arrearsSpinEdit";
            this.bill_arrearsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_arrearsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_arrearsSpinEdit.TabIndex = 18;
            // 
            // bill_balanceSpinEdit
            // 
            this.bill_balanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "bill_balance", true));
            this.bill_balanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_balanceSpinEdit.Location = new System.Drawing.Point(347, 274);
            this.bill_balanceSpinEdit.Name = "bill_balanceSpinEdit";
            this.bill_balanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_balanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_balanceSpinEdit.TabIndex = 16;
            // 
            // bill_currentSpinEdit
            // 
            this.bill_currentSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "bill_current", true));
            this.bill_currentSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_currentSpinEdit.Location = new System.Drawing.Point(121, 274);
            this.bill_currentSpinEdit.Name = "bill_currentSpinEdit";
            this.bill_currentSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_currentSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_currentSpinEdit.TabIndex = 14;
            // 
            // master_idSpinEdit
            // 
            this.master_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "master_id", true));
            this.master_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.master_idSpinEdit.Location = new System.Drawing.Point(335, 22);
            this.master_idSpinEdit.Name = "master_idSpinEdit";
            this.master_idSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.master_idSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.master_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.master_idSpinEdit.Size = new System.Drawing.Size(78, 20);
            this.master_idSpinEdit.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLedger);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 45);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLedger
            // 
            this.btnLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedger.Location = new System.Drawing.Point(16, 8);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(99, 34);
            this.btnLedger.TabIndex = 0;
            this.btnLedger.Text = "F10 -Ledger";
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.Click += new System.EventHandler(this.btnLedger_Click);
            // 
            // categorySpinEdit
            // 
            this.categorySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "category", true));
            this.categorySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.categorySpinEdit.Location = new System.Drawing.Point(296, 120);
            this.categorySpinEdit.Name = "categorySpinEdit";
            this.categorySpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.categorySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.categorySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.categorySpinEdit.Properties.ReadOnly = true;
            this.categorySpinEdit.Size = new System.Drawing.Size(100, 20);
            this.categorySpinEdit.TabIndex = 9;
            // 
            // zone_nameTextEdit
            // 
            this.zone_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "zone_name", true));
            this.zone_nameTextEdit.Location = new System.Drawing.Point(102, 118);
            this.zone_nameTextEdit.Name = "zone_nameTextEdit";
            this.zone_nameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.zone_nameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.zone_nameTextEdit.Properties.ReadOnly = true;
            this.zone_nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.zone_nameTextEdit.TabIndex = 7;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(102, 85);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Properties.ReadOnly = true;
            this.addressTextEdit.Size = new System.Drawing.Size(311, 20);
            this.addressTextEdit.TabIndex = 5;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(102, 52);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.ReadOnly = true;
            this.nameTextEdit.Size = new System.Drawing.Size(311, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // acctnoTextEdit
            // 
            this.acctnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "acctno", true));
            this.acctnoTextEdit.Location = new System.Drawing.Point(102, 22);
            this.acctnoTextEdit.Name = "acctnoTextEdit";
            this.acctnoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.acctnoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.acctnoTextEdit.Properties.ReadOnly = true;
            this.acctnoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.acctnoTextEdit.TabIndex = 1;
            // 
            // tbMasterBindingSource
            // 
            this.tbMasterBindingSource.DataMember = "tbMaster";
            this.tbMasterBindingSource.DataSource = this.dsMaster;
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "dsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwMasterDetailsBindingSource
            // 
            this.vwMasterDetailsBindingSource.DataMember = "vwMasterDetails";
            this.vwMasterDetailsBindingSource.DataSource = this.dsMasterDetailsBindingSource;
            // 
            // dsMasterDetailsBindingSource
            // 
            this.dsMasterDetailsBindingSource.DataSource = this.dsMasterDetails;
            this.dsMasterDetailsBindingSource.Position = 0;
            // 
            // vwMasterDetailsTableAdapter
            // 
            this.vwMasterDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsMasterDetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbMasterTableAdapter
            // 
            this.tbMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbMasterTableAdapter = this.tbMasterTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BillingSystem.dsMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mtrDmg_BalanceLabel
            // 
            mtrDmg_BalanceLabel.AutoSize = true;
            mtrDmg_BalanceLabel.Location = new System.Drawing.Point(227, 395);
            mtrDmg_BalanceLabel.Name = "mtrDmg_BalanceLabel";
            mtrDmg_BalanceLabel.Size = new System.Drawing.Size(120, 17);
            mtrDmg_BalanceLabel.TabIndex = 40;
            mtrDmg_BalanceLabel.Text = "Mtr Dmg Balance:";
            // 
            // mtrDmg_BalanceSpinEdit
            // 
            this.mtrDmg_BalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwMasterDetailsBindingSource1, "MtrDmg_Balance", true));
            this.mtrDmg_BalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mtrDmg_BalanceSpinEdit.Location = new System.Drawing.Point(347, 392);
            this.mtrDmg_BalanceSpinEdit.Name = "mtrDmg_BalanceSpinEdit";
            this.mtrDmg_BalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.mtrDmg_BalanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.mtrDmg_BalanceSpinEdit.TabIndex = 41;
            // 
            // formMasterViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.splitContainer1);
            this.Name = "formMasterViewer";
            this.Text = "Master Viewer";
            this.Load += new System.EventHandler(this.formMasterViewer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMasterDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_prev_yrsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_curr_yrSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrearsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_balanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_currentSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_idSpinEdit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categorySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMasterDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrDmg_BalanceSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dsMasterDetailsBindingSource;
        private dsMasterDetails dsMasterDetails;
        private System.Windows.Forms.BindingSource vwMasterDetailsBindingSource;
        private dsMasterDetailsTableAdapters.vwMasterDetailsTableAdapter vwMasterDetailsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.TextEdit acctnoTextEdit;
        private System.Windows.Forms.BindingSource vwMasterDetailsBindingSource1;
        private dsMasterDetailsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit zone_nameTextEdit;
        private DevExpress.XtraEditors.SpinEdit categorySpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colzone_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLedger;
        private DevExpress.XtraEditors.SpinEdit master_idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit arrears_curr_yrSpinEdit;
        private DevExpress.XtraEditors.SpinEdit bill_arrearsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit bill_balanceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit bill_currentSpinEdit;
        private DevExpress.XtraEditors.SpinEdit arrears_prev_yrsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit cardnoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit iFArrearsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit iFBalanceSpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcardno;
        private DevExpress.XtraGrid.Columns.GridColumn colmeterno;
        private DevExpress.XtraGrid.Columns.GridColumn colisIF;
        private DevExpress.XtraGrid.Columns.GridColumn colisSenior;
        private DevExpress.XtraGrid.Columns.GridColumn colisMtrDmg;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private dsMaster dsMaster;
        private System.Windows.Forms.BindingSource tbMasterBindingSource;
        private dsMasterTableAdapters.tbMasterTableAdapter tbMasterTableAdapter;
        private dsMasterTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.DateEdit last_read_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit date_installedDateEdit;
        private DevExpress.XtraEditors.DateEdit last_reco_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit last_disco_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit remarksTextEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit mtrDmg_BalanceSpinEdit;
    }
}