namespace BillingSystem
{
    partial class formBlacklistMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBlacklistMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbBlacklistAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBlacklist = new BillingSystem.dsBlacklist();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldate_encoded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladded_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunblocked_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunblocked_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblacklist_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbBlacklistAccountsTableAdapter = new BillingSystem.dsBlacklistTableAdapters.tbBlacklistAccountsTableAdapter();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklistAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlacklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 49);
            this.toolStripButton1.Text = "     Block    ";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 49);
            this.toolStripButton3.Text = "  Unblock  ";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 49);
            this.toolStripButton2.Text = "     Print    ";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbBlacklistAccountsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(836, 401);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbBlacklistAccountsBindingSource
            // 
            this.tbBlacklistAccountsBindingSource.DataMember = "tbBlacklistAccounts";
            this.tbBlacklistAccountsBindingSource.DataSource = this.dsBlacklist;
            this.tbBlacklistAccountsBindingSource.Sort = "blacklist_id desc";
            // 
            // dsBlacklist
            // 
            this.dsBlacklist.DataSetName = "dsBlacklist";
            this.dsBlacklist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldate_encoded,
            this.colacctno,
            this.colname,
            this.colblock_reason,
            this.colstatus,
            this.coladded_by,
            this.colunblocked_by,
            this.colunblocked_date,
            this.colblacklist_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "status", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // coldate_encoded
            // 
            this.coldate_encoded.Caption = "Blocked Date";
            this.coldate_encoded.FieldName = "date_encoded";
            this.coldate_encoded.Name = "coldate_encoded";
            this.coldate_encoded.Visible = true;
            this.coldate_encoded.VisibleIndex = 0;
            this.coldate_encoded.Width = 70;
            // 
            // colacctno
            // 
            this.colacctno.Caption = "Account No";
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 1;
            this.colacctno.Width = 65;
            // 
            // colname
            // 
            this.colname.Caption = "Concessionaire";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 200;
            // 
            // colblock_reason
            // 
            this.colblock_reason.Caption = "Reason";
            this.colblock_reason.FieldName = "block_reason";
            this.colblock_reason.Name = "colblock_reason";
            this.colblock_reason.Visible = true;
            this.colblock_reason.VisibleIndex = 3;
            this.colblock_reason.Width = 205;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 4;
            this.colstatus.Width = 48;
            // 
            // coladded_by
            // 
            this.coladded_by.Caption = "Blocked by";
            this.coladded_by.FieldName = "added_by";
            this.coladded_by.Name = "coladded_by";
            this.coladded_by.Visible = true;
            this.coladded_by.VisibleIndex = 5;
            this.coladded_by.Width = 58;
            // 
            // colunblocked_by
            // 
            this.colunblocked_by.Caption = "Unblocked by";
            this.colunblocked_by.FieldName = "unblocked_by";
            this.colunblocked_by.Name = "colunblocked_by";
            this.colunblocked_by.Visible = true;
            this.colunblocked_by.VisibleIndex = 6;
            this.colunblocked_by.Width = 71;
            // 
            // colunblocked_date
            // 
            this.colunblocked_date.Caption = "Unblocked Date";
            this.colunblocked_date.FieldName = "unblocked_date";
            this.colunblocked_date.Name = "colunblocked_date";
            this.colunblocked_date.Visible = true;
            this.colunblocked_date.VisibleIndex = 7;
            this.colunblocked_date.Width = 101;
            // 
            // colblacklist_id
            // 
            this.colblacklist_id.FieldName = "blacklist_id";
            this.colblacklist_id.Name = "colblacklist_id";
            // 
            // tbBlacklistAccountsTableAdapter
            // 
            this.tbBlacklistAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl1;
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Landscape = true;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(20, 20, 120, 68);
            this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "",
                "Tagum Water District\r\nTagum City\r\n\r\n\r\nList of Blacklisted Accounts\r\nas of [Date P" +
                    "rinted]",
                ""}, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "[Page # of Pages #]",
                ""}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // formBlacklistMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 453);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBlacklistMenu";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.formBlacklistMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlacklistAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlacklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsBlacklist dsBlacklist;
        private System.Windows.Forms.BindingSource tbBlacklistAccountsBindingSource;
        private dsBlacklistTableAdapters.tbBlacklistAccountsTableAdapter tbBlacklistAccountsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_encoded;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_reason;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn coladded_by;
        private DevExpress.XtraGrid.Columns.GridColumn colunblocked_by;
        private DevExpress.XtraGrid.Columns.GridColumn colunblocked_date;
        private DevExpress.XtraGrid.Columns.GridColumn colblacklist_id;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
    }
}