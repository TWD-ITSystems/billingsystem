namespace BillingSystem
{
    partial class formMRSUpload
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnSaveManualBill = new System.Windows.Forms.Button();
            this.labelDownload = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveDBF = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReadings = new System.Windows.Forms.Button();
            this.cmbZoneBook = new System.Windows.Forms.ComboBox();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRefNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vwMRSUploadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMRSDownUpload = new BillingSystem.dsMRSDownUpload();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmd_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_billno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_acctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_cardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_presrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_prevrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_volume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_ave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_billamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_ffcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_readtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_encoder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_dateuploaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_metno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmrsUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dsMRSUploadView = new BillingSystem.dsMRSUploadView();
            this.vwMRSUploadTableAdapter = new BillingSystem.dsMRSUploadViewTableAdapters.vwMRSUploadTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pMRSDownloadUploadTableAdapter = new BillingSystem.dsMRSDownUploadTableAdapters.pMRSDownloadUploadTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwMRSUploadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSUploadView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.Controls.Add(this.btnSaveManualBill);
            this.Panel1.Controls.Add(this.labelDownload);
            this.Panel1.Controls.Add(this.btnPrint);
            this.Panel1.Controls.Add(this.btnSaveDBF);
            this.Panel1.Controls.Add(this.btnUpdate);
            this.Panel1.Controls.Add(this.btnReadings);
            this.Panel1.Controls.Add(this.cmbZoneBook);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.cmbBillMonth);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1085, 104);
            this.Panel1.TabIndex = 0;
            // 
            // btnSaveManualBill
            // 
            this.btnSaveManualBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveManualBill.Location = new System.Drawing.Point(712, 47);
            this.btnSaveManualBill.Name = "btnSaveManualBill";
            this.btnSaveManualBill.Size = new System.Drawing.Size(149, 32);
            this.btnSaveManualBill.TabIndex = 10;
            this.btnSaveManualBill.Text = "Save to Manual Billing";
            this.btnSaveManualBill.UseVisualStyleBackColor = true;
            this.btnSaveManualBill.Visible = false;
            this.btnSaveManualBill.Click += new System.EventHandler(this.btnSaveManualBill_Click);
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Location = new System.Drawing.Point(159, 84);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(137, 13);
            this.labelDownload.TabIndex = 9;
            this.labelDownload.Text = "Records Downloaded : 544";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(437, 48);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 31);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Readings";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSaveDBF
            // 
            this.btnSaveDBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDBF.Location = new System.Drawing.Point(557, 47);
            this.btnSaveDBF.Name = "btnSaveDBF";
            this.btnSaveDBF.Size = new System.Drawing.Size(149, 32);
            this.btnSaveDBF.TabIndex = 7;
            this.btnSaveDBF.Text = "Save No Readings  to DBF";
            this.btnSaveDBF.UseVisualStyleBackColor = true;
            this.btnSaveDBF.Visible = false;
            this.btnSaveDBF.Click += new System.EventHandler(this.btnSaveDBF_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(928, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 53);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Master Table";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReadings
            // 
            this.btnReadings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadings.Location = new System.Drawing.Point(317, 48);
            this.btnReadings.Name = "btnReadings";
            this.btnReadings.Size = new System.Drawing.Size(114, 31);
            this.btnReadings.TabIndex = 5;
            this.btnReadings.Text = "Upload Readings";
            this.btnReadings.UseVisualStyleBackColor = true;
            this.btnReadings.Click += new System.EventHandler(this.btnReadings_Click);
            // 
            // cmbZoneBook
            // 
            this.cmbZoneBook.DataSource = this.tbZoneBindingSource;
            this.cmbZoneBook.DisplayMember = "zone_name";
            this.cmbZoneBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoneBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZoneBook.FormattingEnabled = true;
            this.cmbZoneBook.Location = new System.Drawing.Point(159, 57);
            this.cmbZoneBook.Name = "cmbZoneBook";
            this.cmbZoneBook.Size = new System.Drawing.Size(127, 21);
            this.cmbZoneBook.TabIndex = 4;
            this.cmbZoneBook.ValueMember = "zone_id";
            this.cmbZoneBook.TextChanged += new System.EventHandler(this.cmbZoneBook_TextChanged);
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zone / Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Month";
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(15, 57);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(118, 21);
            this.cmbBillMonth.TabIndex = 1;
            this.cmbBillMonth.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataSource = typeof(BillingSystem.tbBilling);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Data to Upload from MRS";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.vwMRSUploadBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1085, 430);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRefNoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            this.contextMenuStrip1.Text = "Edit Ref. No.";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editRefNoToolStripMenuItem
            // 
            this.editRefNoToolStripMenuItem.Name = "editRefNoToolStripMenuItem";
            this.editRefNoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editRefNoToolStripMenuItem.Text = "Edit Ref No.";
            this.editRefNoToolStripMenuItem.Click += new System.EventHandler(this.editRefNoToolStripMenuItem_Click);
            // 
            // vwMRSUploadBindingSource
            // 
            this.vwMRSUploadBindingSource.DataMember = "pMRSDownloadUpload";
            this.vwMRSUploadBindingSource.DataSource = this.dsMRSDownUpload;
            // 
            // dsMRSDownUpload
            // 
            this.dsMRSDownUpload.DataSetName = "dsMRSDownUpload";
            this.dsMRSDownUpload.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmd_status,
            this.colmd_billno,
            this.colmd_acctno,
            this.colmd_name,
            this.colmd_cardno,
            this.colmd_presrdg,
            this.colmd_prevrdg,
            this.colmd_volume,
            this.colmd_ave,
            this.gridColumn1,
            this.colmd_billamount,
            this.colmd_ffcode,
            this.colmd_readtime,
            this.colmd_encoder,
            this.colmd_remark,
            this.colmd_dateuploaded,
            this.colmd_address,
            this.colmd_metno,
            this.colmrsUP_ID});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "md_acctno", null, "Count : {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colmd_status
            // 
            this.colmd_status.AppearanceCell.Options.UseTextOptions = true;
            this.colmd_status.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.colmd_status.Caption = "Status";
            this.colmd_status.FieldName = "md_status";
            this.colmd_status.Name = "colmd_status";
            this.colmd_status.OptionsColumn.AllowEdit = false;
            this.colmd_status.Width = 63;
            // 
            // colmd_billno
            // 
            this.colmd_billno.Caption = "RefNo";
            this.colmd_billno.FieldName = "md_billno";
            this.colmd_billno.Name = "colmd_billno";
            this.colmd_billno.Visible = true;
            this.colmd_billno.VisibleIndex = 0;
            this.colmd_billno.Width = 119;
            // 
            // colmd_acctno
            // 
            this.colmd_acctno.Caption = "AcctNo";
            this.colmd_acctno.FieldName = "md_acctno";
            this.colmd_acctno.Name = "colmd_acctno";
            this.colmd_acctno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colmd_acctno.OptionsColumn.FixedWidth = true;
            this.colmd_acctno.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "md_acctno", "{0}")});
            this.colmd_acctno.Visible = true;
            this.colmd_acctno.VisibleIndex = 1;
            this.colmd_acctno.Width = 50;
            // 
            // colmd_name
            // 
            this.colmd_name.Caption = "Name";
            this.colmd_name.FieldName = "md_name";
            this.colmd_name.Name = "colmd_name";
            this.colmd_name.Visible = true;
            this.colmd_name.VisibleIndex = 2;
            this.colmd_name.Width = 205;
            // 
            // colmd_cardno
            // 
            this.colmd_cardno.Caption = "CardNo";
            this.colmd_cardno.FieldName = "md_cardno";
            this.colmd_cardno.Name = "colmd_cardno";
            this.colmd_cardno.Visible = true;
            this.colmd_cardno.VisibleIndex = 3;
            this.colmd_cardno.Width = 56;
            // 
            // colmd_presrdg
            // 
            this.colmd_presrdg.AppearanceCell.Options.UseTextOptions = true;
            this.colmd_presrdg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmd_presrdg.Caption = "Pres Rdg";
            this.colmd_presrdg.FieldName = "md_presrdg";
            this.colmd_presrdg.Name = "colmd_presrdg";
            this.colmd_presrdg.Visible = true;
            this.colmd_presrdg.VisibleIndex = 4;
            this.colmd_presrdg.Width = 67;
            // 
            // colmd_prevrdg
            // 
            this.colmd_prevrdg.AppearanceCell.Options.UseTextOptions = true;
            this.colmd_prevrdg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmd_prevrdg.Caption = "Prev Rdg";
            this.colmd_prevrdg.FieldName = "md_prevrdg";
            this.colmd_prevrdg.Name = "colmd_prevrdg";
            this.colmd_prevrdg.Visible = true;
            this.colmd_prevrdg.VisibleIndex = 5;
            this.colmd_prevrdg.Width = 67;
            // 
            // colmd_volume
            // 
            this.colmd_volume.AppearanceCell.Options.UseTextOptions = true;
            this.colmd_volume.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmd_volume.Caption = "Volume";
            this.colmd_volume.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmd_volume.FieldName = "md_volume";
            this.colmd_volume.Name = "colmd_volume";
            this.colmd_volume.Visible = true;
            this.colmd_volume.VisibleIndex = 6;
            this.colmd_volume.Width = 67;
            // 
            // colmd_ave
            // 
            this.colmd_ave.Caption = "Ave.";
            this.colmd_ave.FieldName = "md_ave";
            this.colmd_ave.Name = "colmd_ave";
            this.colmd_ave.Visible = true;
            this.colmd_ave.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Variance";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "[md_volume]-[md_ave]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // colmd_billamount
            // 
            this.colmd_billamount.AppearanceCell.Options.UseTextOptions = true;
            this.colmd_billamount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colmd_billamount.Caption = "Amount";
            this.colmd_billamount.FieldName = "md_billamount";
            this.colmd_billamount.Name = "colmd_billamount";
            this.colmd_billamount.Visible = true;
            this.colmd_billamount.VisibleIndex = 9;
            this.colmd_billamount.Width = 76;
            // 
            // colmd_ffcode
            // 
            this.colmd_ffcode.Caption = "Field Findings";
            this.colmd_ffcode.FieldName = "md_ffcode";
            this.colmd_ffcode.Name = "colmd_ffcode";
            this.colmd_ffcode.Visible = true;
            this.colmd_ffcode.VisibleIndex = 10;
            this.colmd_ffcode.Width = 100;
            // 
            // colmd_readtime
            // 
            this.colmd_readtime.Caption = "Readtime";
            this.colmd_readtime.FieldName = "md_readtime";
            this.colmd_readtime.Name = "colmd_readtime";
            this.colmd_readtime.Visible = true;
            this.colmd_readtime.VisibleIndex = 11;
            this.colmd_readtime.Width = 57;
            // 
            // colmd_encoder
            // 
            this.colmd_encoder.Caption = "Encoder/MReader";
            this.colmd_encoder.FieldName = "md_encoder";
            this.colmd_encoder.Name = "colmd_encoder";
            this.colmd_encoder.Visible = true;
            this.colmd_encoder.VisibleIndex = 12;
            this.colmd_encoder.Width = 45;
            // 
            // colmd_remark
            // 
            this.colmd_remark.FieldName = "md_remark";
            this.colmd_remark.Name = "colmd_remark";
            this.colmd_remark.Visible = true;
            this.colmd_remark.VisibleIndex = 14;
            // 
            // colmd_dateuploaded
            // 
            this.colmd_dateuploaded.Caption = "Date Uploaded";
            this.colmd_dateuploaded.FieldName = "md_dateuploaded";
            this.colmd_dateuploaded.Name = "colmd_dateuploaded";
            this.colmd_dateuploaded.Visible = true;
            this.colmd_dateuploaded.VisibleIndex = 13;
            this.colmd_dateuploaded.Width = 95;
            // 
            // colmd_address
            // 
            this.colmd_address.FieldName = "md_address";
            this.colmd_address.Name = "colmd_address";
            this.colmd_address.Visible = true;
            this.colmd_address.VisibleIndex = 15;
            // 
            // colmd_metno
            // 
            this.colmd_metno.FieldName = "md_metno";
            this.colmd_metno.Name = "colmd_metno";
            this.colmd_metno.Visible = true;
            this.colmd_metno.VisibleIndex = 16;
            // 
            // colmrsUP_ID
            // 
            this.colmrsUP_ID.FieldName = "mrsUP_ID";
            this.colmrsUP_ID.Name = "colmrsUP_ID";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // dsMRSUploadView
            // 
            this.dsMRSUploadView.DataSetName = "dsMRSUploadView";
            this.dsMRSUploadView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwMRSUploadTableAdapter
            // 
            this.vwMRSUploadTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pMRSDownloadUploadTableAdapter
            // 
            this.pMRSDownloadUploadTableAdapter.ClearBeforeFill = true;
            // 
            // formMRSUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 534);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.Panel1);
            this.MinimizeBox = false;
            this.Name = "formMRSUpload";
            this.Text = "Upload Data from MRS";
            this.Load += new System.EventHandler(this.formMRSUpload_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwMRSUploadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSUploadView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBillMonth;
        private System.Windows.Forms.ComboBox cmbZoneBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadings;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsMRSUploadView dsMRSUploadView;
        private System.Windows.Forms.BindingSource vwMRSUploadBindingSource;
        private dsMRSUploadViewTableAdapters.vwMRSUploadTableAdapter vwMRSUploadTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_status;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_acctno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_cardno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_billno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_presrdg;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_prevrdg;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_volume;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_billamount;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_readtime;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_encoder;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_dateuploaded;
        private System.Windows.Forms.Button btnSaveDBF;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_ffcode;
        private dsMRSDownUpload dsMRSDownUpload;
        private dsMRSDownUploadTableAdapters.pMRSDownloadUploadTableAdapter pMRSDownloadUploadTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_ave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label labelDownload;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_address;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_metno;
        private DevExpress.XtraGrid.Columns.GridColumn colmrsUP_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editRefNoToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_remark;
        private System.Windows.Forms.Button btnSaveManualBill;
    }
}