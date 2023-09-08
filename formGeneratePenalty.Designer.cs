namespace BillingSystem
{
    partial class formGeneratePenalty
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbZoneLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZoneLookup = new BillingSystem.dsZoneLookup();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZone = new BillingSystem.dsZone();
            this.tbZoneTableAdapter = new BillingSystem.dsZoneTableAdapters.tbZoneTableAdapter();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbPenaltyHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPenaltyHistory = new BillingSystem.dsPenaltyHistory();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbillmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_generated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldone_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrecord_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgovernment_only = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbZoneLookupTableAdapter = new BillingSystem.dsZoneLookupTableAdapters.tbZoneLookupTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbPenaltyHistoryTableAdapter = new BillingSystem.dsPenaltyHistoryTableAdapters.tbPenaltyHistoryTableAdapter();
            this.btnRepair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZoneLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenaltyHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPenaltyHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Month:";
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(98, 30);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(154, 21);
            this.cmbBillMonth.TabIndex = 2;
            this.cmbBillMonth.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBillingBindingSource;
            // 
            // dsBillingBindingSource
            // 
            this.dsBillingBindingSource.DataSource = this.dsBilling;
            this.dsBillingBindingSource.Position = 0;
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbZone
            // 
            this.cmbZone.DataSource = this.tbZoneLookupBindingSource;
            this.cmbZone.DisplayMember = "zone_lookup_id";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(98, 60);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(154, 21);
            this.cmbZone.TabIndex = 3;
            this.cmbZone.ValueMember = "zone_uid";
            // 
            // tbZoneLookupBindingSource
            // 
            this.tbZoneLookupBindingSource.DataMember = "tbZoneLookup";
            this.tbZoneLookupBindingSource.DataSource = this.dsZoneLookup;
            // 
            // dsZoneLookup
            // 
            this.dsZoneLookup.DataSetName = "dsZoneLookup";
            this.dsZoneLookup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbZoneTableAdapter
            // 
            this.tbZoneTableAdapter.ClearBeforeFill = true;
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(98, 102);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 31);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Due Dates";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 349);
            this.panel1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbPenaltyHistoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(568, 349);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbPenaltyHistoryBindingSource
            // 
            this.tbPenaltyHistoryBindingSource.DataMember = "tbPenaltyHistory";
            this.tbPenaltyHistoryBindingSource.DataSource = this.dsPenaltyHistory;
            this.tbPenaltyHistoryBindingSource.Sort = "penalty_id DESC";
            // 
            // dsPenaltyHistory
            // 
            this.dsPenaltyHistory.DataSetName = "dsPenaltyHistory";
            this.dsPenaltyHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbillmonth,
            this.colzone,
            this.coldate_generated,
            this.coldue_date,
            this.coldone_by,
            this.coltotal_amount,
            this.colrecord_count,
            this.colgovernment_only});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colbillmonth
            // 
            this.colbillmonth.Caption = "Bill Month";
            this.colbillmonth.FieldName = "billmonth";
            this.colbillmonth.Name = "colbillmonth";
            this.colbillmonth.Visible = true;
            this.colbillmonth.VisibleIndex = 0;
            // 
            // colzone
            // 
            this.colzone.Caption = "Zone/Book";
            this.colzone.FieldName = "zone";
            this.colzone.Name = "colzone";
            this.colzone.Visible = true;
            this.colzone.VisibleIndex = 1;
            // 
            // coldate_generated
            // 
            this.coldate_generated.Caption = "Date Generated";
            this.coldate_generated.FieldName = "date_generated";
            this.coldate_generated.Name = "coldate_generated";
            this.coldate_generated.Visible = true;
            this.coldate_generated.VisibleIndex = 2;
            // 
            // coldue_date
            // 
            this.coldue_date.Caption = "Due Date";
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 3;
            // 
            // coldone_by
            // 
            this.coldone_by.Caption = "Done By";
            this.coldone_by.FieldName = "done_by";
            this.coldone_by.Name = "coldone_by";
            this.coldone_by.Visible = true;
            this.coldone_by.VisibleIndex = 4;
            // 
            // coltotal_amount
            // 
            this.coltotal_amount.Caption = "Total Amount";
            this.coltotal_amount.DisplayFormat.FormatString = "#,##0.00";
            this.coltotal_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_amount.FieldName = "total_amount";
            this.coltotal_amount.Name = "coltotal_amount";
            this.coltotal_amount.Visible = true;
            this.coltotal_amount.VisibleIndex = 5;
            // 
            // colrecord_count
            // 
            this.colrecord_count.Caption = "Record Count";
            this.colrecord_count.FieldName = "record_count";
            this.colrecord_count.Name = "colrecord_count";
            this.colrecord_count.Visible = true;
            this.colrecord_count.VisibleIndex = 6;
            // 
            // colgovernment_only
            // 
            this.colgovernment_only.Caption = "Gov. Only";
            this.colgovernment_only.FieldName = "government_only";
            this.colgovernment_only.Name = "colgovernment_only";
            this.colgovernment_only.Visible = true;
            this.colgovernment_only.VisibleIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Due Date ]";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(26, 32);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(203, 20);
            this.txtDueDate.TabIndex = 0;
            this.txtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(98, 293);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 31);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate Penalty";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbZoneLookupTableAdapter
            // 
            this.tbZoneLookupTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Only process Government Agencies";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbPenaltyHistoryTableAdapter
            // 
            this.tbPenaltyHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnRepair
            // 
            this.btnRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepair.Location = new System.Drawing.Point(12, 275);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(58, 64);
            this.btnRepair.TabIndex = 9;
            this.btnRepair.Text = "Repair Penalty";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Visible = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // formGeneratePenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 349);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.cmbBillMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formGeneratePenalty";
            this.Text = "Generate Penalty";
            this.Load += new System.EventHandler(this.formGeneratePenalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZoneLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenaltyHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPenaltyHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBillMonth;
        private System.Windows.Forms.ComboBox cmbZone;
        private dsZone dsZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private dsZoneTableAdapters.tbZoneTableAdapter tbZoneTableAdapter;
        private System.Windows.Forms.BindingSource dsBillingBindingSource;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Button btnGenerate;
        private dsZoneLookup dsZoneLookup;
        private System.Windows.Forms.BindingSource tbZoneLookupBindingSource;
        private dsZoneLookupTableAdapters.tbZoneLookupTableAdapter tbZoneLookupTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPenaltyHistory dsPenaltyHistory;
        private System.Windows.Forms.BindingSource tbPenaltyHistoryBindingSource;
        private dsPenaltyHistoryTableAdapters.tbPenaltyHistoryTableAdapter tbPenaltyHistoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colbillmonth;
        private DevExpress.XtraGrid.Columns.GridColumn colzone;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_generated;
        private DevExpress.XtraGrid.Columns.GridColumn coldue_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldone_by;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_amount;
        private DevExpress.XtraGrid.Columns.GridColumn colrecord_count;
        private DevExpress.XtraGrid.Columns.GridColumn colgovernment_only;
        private System.Windows.Forms.Button btnRepair;
    }
}