namespace BillingSystem
{
    partial class formViewUploadHistory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbMRSUploadHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUploadHistory = new BillingSystem.dsUploadHistory();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colup_historyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colup_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colup_billmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colup_zonebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colup_doneby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colup_numrecords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.pMRSDownloadUploadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMRSDownUpload = new BillingSystem.dsMRSDownUpload();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmd_acctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_cardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_billno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_zone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_ctgry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_prevrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_presrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_volume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_ave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_billamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_ffcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd_dateuploaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMRSUploadHistoryTableAdapter = new BillingSystem.dsUploadHistoryTableAdapters.tbMRSUploadHistoryTableAdapter();
            this.pMRSDownloadUploadTableAdapter = new BillingSystem.dsMRSDownUploadTableAdapters.pMRSDownloadUploadTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMRSUploadHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUploadHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMRSDownloadUploadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 488);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Readings";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbMRSUploadHistoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(806, 453);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbMRSUploadHistoryBindingSource
            // 
            this.tbMRSUploadHistoryBindingSource.DataMember = "tbMRSUploadHistory";
            this.tbMRSUploadHistoryBindingSource.DataSource = this.dsUploadHistory;
            // 
            // dsUploadHistory
            // 
            this.dsUploadHistory.DataSetName = "dsUploadHistory";
            this.dsUploadHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colup_historyID,
            this.colup_date,
            this.colup_billmonth,
            this.colup_zonebook,
            this.colup_doneby,
            this.colup_numrecords});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colup_historyID
            // 
            this.colup_historyID.Caption = "Update ID";
            this.colup_historyID.FieldName = "up_historyID";
            this.colup_historyID.Name = "colup_historyID";
            this.colup_historyID.OptionsColumn.ReadOnly = true;
            this.colup_historyID.Visible = true;
            this.colup_historyID.VisibleIndex = 0;
            // 
            // colup_date
            // 
            this.colup_date.Caption = "Update Date";
            this.colup_date.FieldName = "up_date";
            this.colup_date.Name = "colup_date";
            this.colup_date.Visible = true;
            this.colup_date.VisibleIndex = 1;
            // 
            // colup_billmonth
            // 
            this.colup_billmonth.Caption = "Bill Month";
            this.colup_billmonth.FieldName = "up_billmonth";
            this.colup_billmonth.Name = "colup_billmonth";
            this.colup_billmonth.Visible = true;
            this.colup_billmonth.VisibleIndex = 2;
            // 
            // colup_zonebook
            // 
            this.colup_zonebook.Caption = "Zone";
            this.colup_zonebook.FieldName = "up_zonebook";
            this.colup_zonebook.Name = "colup_zonebook";
            this.colup_zonebook.Visible = true;
            this.colup_zonebook.VisibleIndex = 3;
            // 
            // colup_doneby
            // 
            this.colup_doneby.Caption = "Updated By";
            this.colup_doneby.FieldName = "up_doneby";
            this.colup_doneby.Name = "colup_doneby";
            this.colup_doneby.Visible = true;
            this.colup_doneby.VisibleIndex = 4;
            // 
            // colup_numrecords
            // 
            this.colup_numrecords.Caption = "No. of Records";
            this.colup_numrecords.FieldName = "up_numrecords";
            this.colup_numrecords.Name = "colup_numrecords";
            this.colup_numrecords.Visible = true;
            this.colup_numrecords.VisibleIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.pMRSDownloadUploadBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(806, 453);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pMRSDownloadUploadBindingSource
            // 
            this.pMRSDownloadUploadBindingSource.DataMember = "pMRSDownloadUpload";
            this.pMRSDownloadUploadBindingSource.DataSource = this.dsMRSDownUpload;
            // 
            // dsMRSDownUpload
            // 
            this.dsMRSDownUpload.DataSetName = "dsMRSDownUpload";
            this.dsMRSDownUpload.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmd_acctno,
            this.colmd_cardno,
            this.colmd_billno,
            this.colmd_name,
            this.colmd_zone,
            this.colmd_ctgry,
            this.colmd_prevrdg,
            this.colmd_presrdg,
            this.colmd_volume,
            this.colmd_ave,
            this.colmd_billamount,
            this.colmd_ffcode,
            this.colmd_dateuploaded});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "md_acctno", null, "Count : {0}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colmd_acctno
            // 
            this.colmd_acctno.Caption = "AcctNo";
            this.colmd_acctno.FieldName = "md_acctno";
            this.colmd_acctno.Name = "colmd_acctno";
            this.colmd_acctno.Visible = true;
            this.colmd_acctno.VisibleIndex = 0;
            this.colmd_acctno.Width = 60;
            // 
            // colmd_cardno
            // 
            this.colmd_cardno.Caption = "CardNo";
            this.colmd_cardno.FieldName = "md_cardno";
            this.colmd_cardno.Name = "colmd_cardno";
            this.colmd_cardno.Visible = true;
            this.colmd_cardno.VisibleIndex = 1;
            this.colmd_cardno.Width = 50;
            // 
            // colmd_billno
            // 
            this.colmd_billno.Caption = "BillNo";
            this.colmd_billno.FieldName = "md_billno";
            this.colmd_billno.Name = "colmd_billno";
            this.colmd_billno.Visible = true;
            this.colmd_billno.VisibleIndex = 2;
            // 
            // colmd_name
            // 
            this.colmd_name.Caption = "Name";
            this.colmd_name.FieldName = "md_name";
            this.colmd_name.Name = "colmd_name";
            this.colmd_name.Visible = true;
            this.colmd_name.VisibleIndex = 3;
            this.colmd_name.Width = 197;
            // 
            // colmd_zone
            // 
            this.colmd_zone.Caption = "Zone";
            this.colmd_zone.FieldName = "md_zone";
            this.colmd_zone.Name = "colmd_zone";
            this.colmd_zone.Visible = true;
            this.colmd_zone.VisibleIndex = 4;
            this.colmd_zone.Width = 42;
            // 
            // colmd_ctgry
            // 
            this.colmd_ctgry.Caption = "Ctgry";
            this.colmd_ctgry.FieldName = "md_ctgry";
            this.colmd_ctgry.Name = "colmd_ctgry";
            this.colmd_ctgry.Visible = true;
            this.colmd_ctgry.VisibleIndex = 5;
            this.colmd_ctgry.Width = 42;
            // 
            // colmd_prevrdg
            // 
            this.colmd_prevrdg.Caption = "PrevRdg";
            this.colmd_prevrdg.FieldName = "md_prevrdg";
            this.colmd_prevrdg.Name = "colmd_prevrdg";
            this.colmd_prevrdg.Visible = true;
            this.colmd_prevrdg.VisibleIndex = 6;
            this.colmd_prevrdg.Width = 42;
            // 
            // colmd_presrdg
            // 
            this.colmd_presrdg.Caption = "PresRdg";
            this.colmd_presrdg.FieldName = "md_presrdg";
            this.colmd_presrdg.Name = "colmd_presrdg";
            this.colmd_presrdg.Visible = true;
            this.colmd_presrdg.VisibleIndex = 7;
            this.colmd_presrdg.Width = 42;
            // 
            // colmd_volume
            // 
            this.colmd_volume.Caption = "Volume";
            this.colmd_volume.FieldName = "md_volume";
            this.colmd_volume.Name = "colmd_volume";
            this.colmd_volume.Visible = true;
            this.colmd_volume.VisibleIndex = 8;
            this.colmd_volume.Width = 42;
            // 
            // colmd_ave
            // 
            this.colmd_ave.Caption = "Ave Vol";
            this.colmd_ave.FieldName = "md_ave";
            this.colmd_ave.Name = "colmd_ave";
            this.colmd_ave.Visible = true;
            this.colmd_ave.VisibleIndex = 9;
            this.colmd_ave.Width = 42;
            // 
            // colmd_billamount
            // 
            this.colmd_billamount.Caption = "Current";
            this.colmd_billamount.FieldName = "md_billamount";
            this.colmd_billamount.Name = "colmd_billamount";
            this.colmd_billamount.Visible = true;
            this.colmd_billamount.VisibleIndex = 10;
            this.colmd_billamount.Width = 42;
            // 
            // colmd_ffcode
            // 
            this.colmd_ffcode.Caption = "Findings";
            this.colmd_ffcode.FieldName = "md_ffcode";
            this.colmd_ffcode.Name = "colmd_ffcode";
            this.colmd_ffcode.Visible = true;
            this.colmd_ffcode.VisibleIndex = 11;
            this.colmd_ffcode.Width = 42;
            // 
            // colmd_dateuploaded
            // 
            this.colmd_dateuploaded.Caption = "Upload Date";
            this.colmd_dateuploaded.FieldName = "md_dateuploaded";
            this.colmd_dateuploaded.Name = "colmd_dateuploaded";
            this.colmd_dateuploaded.Visible = true;
            this.colmd_dateuploaded.VisibleIndex = 12;
            this.colmd_dateuploaded.Width = 70;
            // 
            // tbMRSUploadHistoryTableAdapter
            // 
            this.tbMRSUploadHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // pMRSDownloadUploadTableAdapter
            // 
            this.pMRSDownloadUploadTableAdapter.ClearBeforeFill = true;
            // 
            // formViewUploadHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "formViewUploadHistory";
            this.Text = "View Uploads History";
            this.Load += new System.EventHandler(this.formViewUploadHistory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMRSUploadHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUploadHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMRSDownloadUploadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsUploadHistory dsUploadHistory;
        private System.Windows.Forms.BindingSource tbMRSUploadHistoryBindingSource;
        private dsUploadHistoryTableAdapters.tbMRSUploadHistoryTableAdapter tbMRSUploadHistoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colup_historyID;
        private DevExpress.XtraGrid.Columns.GridColumn colup_date;
        private DevExpress.XtraGrid.Columns.GridColumn colup_billmonth;
        private DevExpress.XtraGrid.Columns.GridColumn colup_zonebook;
        private DevExpress.XtraGrid.Columns.GridColumn colup_doneby;
        private DevExpress.XtraGrid.Columns.GridColumn colup_numrecords;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource pMRSDownloadUploadBindingSource;
        private dsMRSDownUpload dsMRSDownUpload;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_acctno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_cardno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_billno;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_zone;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_ctgry;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_prevrdg;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_presrdg;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_volume;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_ave;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_billamount;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_ffcode;
        private DevExpress.XtraGrid.Columns.GridColumn colmd_dateuploaded;
        private dsMRSDownUploadTableAdapters.pMRSDownloadUploadTableAdapter pMRSDownloadUploadTableAdapter;
    }
}