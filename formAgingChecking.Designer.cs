namespace BillingSystem
{
    partial class formAgingChecking
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbMasterAgingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMasterAging = new BillingSystem.dsMasterAging();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colaging_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colday1to60 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colday61to180 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colday181to365 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colover365 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colday0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_generated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colctgy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbilling_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMasterAgingTableAdapter = new BillingSystem.dsMasterAgingTableAdapters.tbMasterAgingTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAgingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbMasterAgingBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(919, 411);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbMasterAgingBindingSource
            // 
            this.tbMasterAgingBindingSource.DataMember = "tbMasterAging";
            this.tbMasterAgingBindingSource.DataSource = this.dsMasterAging;
            // 
            // dsMasterAging
            // 
            this.dsMasterAging.DataSetName = "dsMasterAging";
            this.dsMasterAging.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colaging_id,
            this.colmaster_id,
            this.gridColumn1,
            this.colbalance,
            this.colday1to60,
            this.colday61to180,
            this.colday181to365,
            this.colover365,
            this.colday0,
            this.colzone_id,
            this.colstatus,
            this.coldate_generated,
            this.colctgy,
            this.colbilling_id,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "aging_id", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colaging_id
            // 
            this.colaging_id.FieldName = "aging_id";
            this.colaging_id.Name = "colaging_id";
            this.colaging_id.OptionsColumn.ReadOnly = true;
            this.colaging_id.Visible = true;
            this.colaging_id.VisibleIndex = 0;
            // 
            // colmaster_id
            // 
            this.colmaster_id.FieldName = "master_id";
            this.colmaster_id.Name = "colmaster_id";
            this.colmaster_id.Visible = true;
            this.colmaster_id.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "From Master Balance";
            this.gridColumn1.FieldName = "bill_balance";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // colbalance
            // 
            this.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbalance.FieldName = "balance";
            this.colbalance.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbalance.Name = "colbalance";
            this.colbalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", "{0}")});
            this.colbalance.Visible = true;
            this.colbalance.VisibleIndex = 3;
            // 
            // colday1to60
            // 
            this.colday1to60.FieldName = "day1to60";
            this.colday1to60.Name = "colday1to60";
            this.colday1to60.Visible = true;
            this.colday1to60.VisibleIndex = 4;
            // 
            // colday61to180
            // 
            this.colday61to180.FieldName = "day61to180";
            this.colday61to180.Name = "colday61to180";
            this.colday61to180.Visible = true;
            this.colday61to180.VisibleIndex = 5;
            // 
            // colday181to365
            // 
            this.colday181to365.FieldName = "day181to365";
            this.colday181to365.Name = "colday181to365";
            this.colday181to365.Visible = true;
            this.colday181to365.VisibleIndex = 6;
            // 
            // colover365
            // 
            this.colover365.FieldName = "over365";
            this.colover365.Name = "colover365";
            this.colover365.Visible = true;
            this.colover365.VisibleIndex = 7;
            // 
            // colday0
            // 
            this.colday0.FieldName = "day0";
            this.colday0.Name = "colday0";
            this.colday0.Visible = true;
            this.colday0.VisibleIndex = 8;
            // 
            // colzone_id
            // 
            this.colzone_id.FieldName = "zone_id";
            this.colzone_id.Name = "colzone_id";
            this.colzone_id.Visible = true;
            this.colzone_id.VisibleIndex = 9;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 10;
            // 
            // coldate_generated
            // 
            this.coldate_generated.FieldName = "date_generated";
            this.coldate_generated.Name = "coldate_generated";
            this.coldate_generated.Visible = true;
            this.coldate_generated.VisibleIndex = 12;
            // 
            // colctgy
            // 
            this.colctgy.FieldName = "ctgy";
            this.colctgy.Name = "colctgy";
            this.colctgy.Visible = true;
            this.colctgy.VisibleIndex = 11;
            // 
            // colbilling_id
            // 
            this.colbilling_id.FieldName = "billing_id";
            this.colbilling_id.Name = "colbilling_id";
            this.colbilling_id.Visible = true;
            this.colbilling_id.VisibleIndex = 13;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Acct for Checking";
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundExpression = "[balance] != [bill_balance]";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 14;
            // 
            // tbMasterAgingTableAdapter
            // 
            this.tbMasterAgingTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 39);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.Filter = "Excel File (*.xls)|*.xls";
            this.saveFileDialog1.Title = "Export to Excel";
            // 
            // formAgingChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.panel1);
            this.Name = "formAgingChecking";
            this.Text = "Aging Check";
            this.Load += new System.EventHandler(this.formAgingChecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAgingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsMasterAging dsMasterAging;
        private System.Windows.Forms.BindingSource tbMasterAgingBindingSource;
        private dsMasterAgingTableAdapters.tbMasterAgingTableAdapter tbMasterAgingTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colaging_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbalance;
        private DevExpress.XtraGrid.Columns.GridColumn colday1to60;
        private DevExpress.XtraGrid.Columns.GridColumn colday61to180;
        private DevExpress.XtraGrid.Columns.GridColumn colday181to365;
        private DevExpress.XtraGrid.Columns.GridColumn colover365;
        private DevExpress.XtraGrid.Columns.GridColumn colday0;
        private DevExpress.XtraGrid.Columns.GridColumn colzone_id;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_generated;
        private DevExpress.XtraGrid.Columns.GridColumn colctgy;
        private DevExpress.XtraGrid.Columns.GridColumn colbilling_id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}