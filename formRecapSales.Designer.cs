namespace BillingSystem
{
    partial class formRecapSales
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.dsRecapSales = new BillingSystem.dsRecapSales();
            this.tbRecapSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRecapSalesTableAdapter = new BillingSystem.dsRecapSalesTableAdapters.tbRecapSalesTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsRecapSalesTableAdapters.TableAdapterManager();
            this.tbRecapSalesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrecap_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzonebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvol_ctgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_con = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_vol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZone = new BillingSystem.dsZone();
            this.label1 = new System.Windows.Forms.Label();
            this.tbZoneTableAdapter = new BillingSystem.dsZoneTableAdapters.tbZoneTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecapSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRecapSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRecapSalesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(71, 12);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbBillMonth.TabIndex = 3;
            this.cmbBillMonth.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBilling;
            this.tbBillingBindingSource.Sort = "billing_id DESC";
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bill Month:";
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // dsRecapSales
            // 
            this.dsRecapSales.DataSetName = "dsRecapSales";
            this.dsRecapSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRecapSalesBindingSource
            // 
            this.tbRecapSalesBindingSource.DataMember = "tbRecapSales";
            this.tbRecapSalesBindingSource.DataSource = this.dsRecapSales;
            // 
            // tbRecapSalesTableAdapter
            // 
            this.tbRecapSalesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbRecapSalesTableAdapter = this.tbRecapSalesTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsRecapSalesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbRecapSalesGridControl
            // 
            this.tbRecapSalesGridControl.DataSource = this.tbRecapSalesBindingSource;
            this.tbRecapSalesGridControl.Location = new System.Drawing.Point(8, 54);
            this.tbRecapSalesGridControl.MainView = this.gridView1;
            this.tbRecapSalesGridControl.Name = "tbRecapSalesGridControl";
            this.tbRecapSalesGridControl.Size = new System.Drawing.Size(806, 359);
            this.tbRecapSalesGridControl.TabIndex = 4;
            this.tbRecapSalesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrecap_id,
            this.colbillmonth,
            this.colzonebook,
            this.colcategory,
            this.colvol_ctgr,
            this.colnum_con,
            this.coltotal_vol,
            this.coltotal_amt,
            this.colcode});
            this.gridView1.GridControl = this.tbRecapSalesGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "num_con", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_vol", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_amt", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colrecap_id
            // 
            this.colrecap_id.FieldName = "recap_id";
            this.colrecap_id.Name = "colrecap_id";
            this.colrecap_id.OptionsColumn.ReadOnly = true;
            this.colrecap_id.Visible = true;
            this.colrecap_id.VisibleIndex = 0;
            // 
            // colbillmonth
            // 
            this.colbillmonth.FieldName = "billmonth";
            this.colbillmonth.Name = "colbillmonth";
            this.colbillmonth.Visible = true;
            this.colbillmonth.VisibleIndex = 1;
            // 
            // colzonebook
            // 
            this.colzonebook.FieldName = "zonebook";
            this.colzonebook.Name = "colzonebook";
            this.colzonebook.Visible = true;
            this.colzonebook.VisibleIndex = 2;
            // 
            // colcategory
            // 
            this.colcategory.FieldName = "category";
            this.colcategory.Name = "colcategory";
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 3;
            // 
            // colvol_ctgr
            // 
            this.colvol_ctgr.FieldName = "vol_ctgr";
            this.colvol_ctgr.Name = "colvol_ctgr";
            this.colvol_ctgr.Visible = true;
            this.colvol_ctgr.VisibleIndex = 4;
            // 
            // colnum_con
            // 
            this.colnum_con.FieldName = "num_con";
            this.colnum_con.Name = "colnum_con";
            this.colnum_con.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colnum_con.Visible = true;
            this.colnum_con.VisibleIndex = 5;
            // 
            // coltotal_vol
            // 
            this.coltotal_vol.FieldName = "total_vol";
            this.coltotal_vol.Name = "coltotal_vol";
            this.coltotal_vol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.coltotal_vol.Visible = true;
            this.coltotal_vol.VisibleIndex = 6;
            // 
            // coltotal_amt
            // 
            this.coltotal_amt.DisplayFormat.FormatString = "#,##0.00";
            this.coltotal_amt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_amt.FieldName = "total_amt";
            this.coltotal_amt.Name = "coltotal_amt";
            this.coltotal_amt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.coltotal_amt.Visible = true;
            this.coltotal_amt.VisibleIndex = 7;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 8;
            // 
            // cmbZone
            // 
            this.cmbZone.DataSource = this.tbZoneBindingSource;
            this.cmbZone.DisplayMember = "zone_name";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(278, 12);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(121, 21);
            this.cmbZone.TabIndex = 5;
            this.cmbZone.ValueMember = "zone_id";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ZoneBook :";
            // 
            // tbZoneTableAdapter
            // 
            this.tbZoneTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Bill Summary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formRecapSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 425);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.tbRecapSalesGridControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBillMonth);
            this.Controls.Add(this.button1);
            this.Name = "formRecapSales";
            this.Text = "Generate Recap of Sales";
            this.Load += new System.EventHandler(this.formRecapSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecapSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRecapSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRecapSalesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBillMonth;
        private System.Windows.Forms.Label label2;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private dsRecapSales dsRecapSales;
        private System.Windows.Forms.BindingSource tbRecapSalesBindingSource;
        private dsRecapSalesTableAdapters.tbRecapSalesTableAdapter tbRecapSalesTableAdapter;
        private dsRecapSalesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tbRecapSalesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colrecap_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbillmonth;
        private DevExpress.XtraGrid.Columns.GridColumn colzonebook;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private DevExpress.XtraGrid.Columns.GridColumn colvol_ctgr;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_con;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_vol;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_amt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label label1;
        private dsZone dsZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private dsZoneTableAdapters.tbZoneTableAdapter tbZoneTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}