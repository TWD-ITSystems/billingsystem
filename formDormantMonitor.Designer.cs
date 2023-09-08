namespace BillingSystem
{
    partial class formDormantMonitor
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbDormantMonitoringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDormantMonitor = new BillingSystem.dsDormantMonitor();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldormant_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_disconnected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount_paid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_paid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaid_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_generated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbaseline_data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbDormantMonitoringTableAdapter = new BillingSystem.dsDormantMonitorTableAdapters.tbDormantMonitoringTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDormantMonitoringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDormantMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 52);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export to xls";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(572, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Update Payment Transactions ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select cutoff date:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Payments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(426, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy To Live Server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12-2020"});
            this.comboBox1.Location = new System.Drawing.Point(169, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Baseline Data to Load :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 453);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbDormantMonitoringBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(953, 453);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbDormantMonitoringBindingSource
            // 
            this.tbDormantMonitoringBindingSource.DataMember = "tbDormantMonitoring";
            this.tbDormantMonitoringBindingSource.DataSource = this.dsDormantMonitor;
            // 
            // dsDormantMonitor
            // 
            this.dsDormantMonitor.DataSetName = "dsDormantMonitor";
            this.dsDormantMonitor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldormant_id,
            this.colname,
            this.coladdress,
            this.colcardno,
            this.colzone,
            this.colcategory,
            this.coldate_disconnected,
            this.colarrears,
            this.colamount_paid,
            this.coldate_paid,
            this.colpaid_count,
            this.colcurrent_status,
            this.coldate_generated,
            this.colbaseline_data,
            this.colmasterID,
            this.colacctno,
            this.colbalance});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // coldormant_id
            // 
            this.coldormant_id.FieldName = "dormant_id";
            this.coldormant_id.Name = "coldormant_id";
            this.coldormant_id.OptionsColumn.ReadOnly = true;
            this.coldormant_id.Visible = true;
            this.coldormant_id.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 2;
            // 
            // colcardno
            // 
            this.colcardno.FieldName = "cardno";
            this.colcardno.Name = "colcardno";
            this.colcardno.Visible = true;
            this.colcardno.VisibleIndex = 3;
            // 
            // colzone
            // 
            this.colzone.FieldName = "zone";
            this.colzone.Name = "colzone";
            this.colzone.Visible = true;
            this.colzone.VisibleIndex = 4;
            // 
            // colcategory
            // 
            this.colcategory.FieldName = "category";
            this.colcategory.Name = "colcategory";
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 5;
            // 
            // coldate_disconnected
            // 
            this.coldate_disconnected.FieldName = "date_disconnected";
            this.coldate_disconnected.Name = "coldate_disconnected";
            this.coldate_disconnected.Visible = true;
            this.coldate_disconnected.VisibleIndex = 6;
            // 
            // colarrears
            // 
            this.colarrears.FieldName = "arrears";
            this.colarrears.Name = "colarrears";
            this.colarrears.Visible = true;
            this.colarrears.VisibleIndex = 7;
            // 
            // colamount_paid
            // 
            this.colamount_paid.FieldName = "amount_paid";
            this.colamount_paid.Name = "colamount_paid";
            this.colamount_paid.Visible = true;
            this.colamount_paid.VisibleIndex = 8;
            // 
            // coldate_paid
            // 
            this.coldate_paid.FieldName = "date_paid";
            this.coldate_paid.Name = "coldate_paid";
            this.coldate_paid.Visible = true;
            this.coldate_paid.VisibleIndex = 9;
            // 
            // colpaid_count
            // 
            this.colpaid_count.FieldName = "paid_count";
            this.colpaid_count.Name = "colpaid_count";
            this.colpaid_count.Visible = true;
            this.colpaid_count.VisibleIndex = 10;
            // 
            // colcurrent_status
            // 
            this.colcurrent_status.FieldName = "current_status";
            this.colcurrent_status.Name = "colcurrent_status";
            this.colcurrent_status.Visible = true;
            this.colcurrent_status.VisibleIndex = 11;
            // 
            // coldate_generated
            // 
            this.coldate_generated.FieldName = "date_generated";
            this.coldate_generated.Name = "coldate_generated";
            this.coldate_generated.Visible = true;
            this.coldate_generated.VisibleIndex = 12;
            // 
            // colbaseline_data
            // 
            this.colbaseline_data.FieldName = "baseline_data";
            this.colbaseline_data.Name = "colbaseline_data";
            this.colbaseline_data.Visible = true;
            this.colbaseline_data.VisibleIndex = 13;
            // 
            // colmasterID
            // 
            this.colmasterID.FieldName = "masterID";
            this.colmasterID.Name = "colmasterID";
            this.colmasterID.Visible = true;
            this.colmasterID.VisibleIndex = 14;
            // 
            // colacctno
            // 
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 15;
            // 
            // colbalance
            // 
            this.colbalance.FieldName = "balance";
            this.colbalance.Name = "colbalance";
            this.colbalance.Visible = true;
            this.colbalance.VisibleIndex = 16;
            // 
            // tbDormantMonitoringTableAdapter
            // 
            this.tbDormantMonitoringTableAdapter.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files|*.xlsx";
            // 
            // formDormantMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formDormantMonitor";
            this.Text = "Dormant Accounts Monitoring Tool";
            this.Load += new System.EventHandler(this.formDormantMonitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDormantMonitoringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDormantMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsDormantMonitor dsDormantMonitor;
        private System.Windows.Forms.BindingSource tbDormantMonitoringBindingSource;
        private dsDormantMonitorTableAdapters.tbDormantMonitoringTableAdapter tbDormantMonitoringTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldormant_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colcardno;
        private DevExpress.XtraGrid.Columns.GridColumn colzone;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_disconnected;
        private DevExpress.XtraGrid.Columns.GridColumn colarrears;
        private DevExpress.XtraGrid.Columns.GridColumn colamount_paid;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_paid;
        private DevExpress.XtraGrid.Columns.GridColumn colpaid_count;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_status;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_generated;
        private DevExpress.XtraGrid.Columns.GridColumn colbaseline_data;
        private DevExpress.XtraGrid.Columns.GridColumn colmasterID;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colbalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}