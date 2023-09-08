namespace BillingSystem
{
    partial class frmDownloadAgents
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbZoneBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbDownloadAgentsHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAgentHistory = new BillingSystem.dsAgentHistory();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldlagent_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzonebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagent_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldownloadby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumrec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbDownloadAgentsHistoryTableAdapter = new BillingSystem.dsAgentHistoryTableAdapters.tbDownloadAgentsHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDownloadAgentsHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(269, 37);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(95, 42);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download to DBF";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(90, 10);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(129, 21);
            this.cmbBillMonth.TabIndex = 1;
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
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Billmonth :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbZoneBook
            // 
            this.cmbZoneBook.DataSource = this.tbZoneBindingSource;
            this.cmbZoneBook.DisplayMember = "zone_name";
            this.cmbZoneBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoneBook.FormattingEnabled = true;
            this.cmbZoneBook.Location = new System.Drawing.Point(90, 50);
            this.cmbZoneBook.Name = "cmbZoneBook";
            this.cmbZoneBook.Size = new System.Drawing.Size(129, 21);
            this.cmbZoneBook.TabIndex = 3;
            this.cmbZoneBook.ValueMember = "zone_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zone/Book :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAgentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbBillMonth);
            this.panel1.Controls.Add(this.cmbZoneBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 121);
            this.panel1.TabIndex = 5;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(90, 90);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(126, 20);
            this.txtAgentName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agent Name :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 345);
            this.panel2.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbDownloadAgentsHistoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(824, 345);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbDownloadAgentsHistoryBindingSource
            // 
            this.tbDownloadAgentsHistoryBindingSource.DataMember = "tbDownloadAgentsHistory";
            this.tbDownloadAgentsHistoryBindingSource.DataSource = this.dsAgentHistory;
            // 
            // dsAgentHistory
            // 
            this.dsAgentHistory.DataSetName = "dsAgentHistory";
            this.dsAgentHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldlagent_date,
            this.colzonebook,
            this.colbillmonth,
            this.colagent_name,
            this.coldownloadby,
            this.colnumrec});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // coldlagent_date
            // 
            this.coldlagent_date.FieldName = "dlagent_date";
            this.coldlagent_date.Name = "coldlagent_date";
            this.coldlagent_date.Visible = true;
            this.coldlagent_date.VisibleIndex = 0;
            // 
            // colzonebook
            // 
            this.colzonebook.FieldName = "zonebook";
            this.colzonebook.Name = "colzonebook";
            this.colzonebook.Visible = true;
            this.colzonebook.VisibleIndex = 1;
            // 
            // colbillmonth
            // 
            this.colbillmonth.FieldName = "billmonth";
            this.colbillmonth.Name = "colbillmonth";
            this.colbillmonth.Visible = true;
            this.colbillmonth.VisibleIndex = 2;
            // 
            // colagent_name
            // 
            this.colagent_name.FieldName = "agent_name";
            this.colagent_name.Name = "colagent_name";
            this.colagent_name.Visible = true;
            this.colagent_name.VisibleIndex = 3;
            // 
            // coldownloadby
            // 
            this.coldownloadby.FieldName = "downloadby";
            this.coldownloadby.Name = "coldownloadby";
            this.coldownloadby.Visible = true;
            this.coldownloadby.VisibleIndex = 4;
            // 
            // colnumrec
            // 
            this.colnumrec.FieldName = "numrec";
            this.colnumrec.Name = "colnumrec";
            this.colnumrec.Visible = true;
            this.colnumrec.VisibleIndex = 5;
            // 
            // tbDownloadAgentsHistoryTableAdapter
            // 
            this.tbDownloadAgentsHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmDownloadAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDownloadAgents";
            this.Text = "Download To Agents";
            this.Load += new System.EventHandler(this.frmDownloadAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDownloadAgentsHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.ComboBox cmbBillMonth;
        private System.Windows.Forms.BindingSource dsBillingBindingSource;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbZoneBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsAgentHistory dsAgentHistory;
        private System.Windows.Forms.BindingSource tbDownloadAgentsHistoryBindingSource;
        private dsAgentHistoryTableAdapters.tbDownloadAgentsHistoryTableAdapter tbDownloadAgentsHistoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldlagent_date;
        private DevExpress.XtraGrid.Columns.GridColumn colzonebook;
        private DevExpress.XtraGrid.Columns.GridColumn colbillmonth;
        private DevExpress.XtraGrid.Columns.GridColumn coldownloadby;
        private DevExpress.XtraGrid.Columns.GridColumn colnumrec;
        private DevExpress.XtraGrid.Columns.GridColumn colagent_name;
    }
}