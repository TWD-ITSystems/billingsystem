namespace BillingSystem
{
    partial class formBackupLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsBackupLog = new BillingSystem.dsBackupLog();
            this.tbBackupLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBackupLogTableAdapter = new BillingSystem.dsBackupLogTableAdapters.tbBackupLogTableAdapter();
            this.backuplogidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donebyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBackupLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackupLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.backuplogidDataGridViewTextBoxColumn,
            this.transdateDataGridViewTextBoxColumn,
            this.donebyDataGridViewTextBoxColumn,
            this.machineaddressDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbBackupLogBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsBackupLog
            // 
            this.dsBackupLog.DataSetName = "dsBackupLog";
            this.dsBackupLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBackupLogBindingSource
            // 
            this.tbBackupLogBindingSource.DataMember = "tbBackupLog";
            this.tbBackupLogBindingSource.DataSource = this.dsBackupLog;
            // 
            // tbBackupLogTableAdapter
            // 
            this.tbBackupLogTableAdapter.ClearBeforeFill = true;
            // 
            // backuplogidDataGridViewTextBoxColumn
            // 
            this.backuplogidDataGridViewTextBoxColumn.DataPropertyName = "backuplog_id";
            this.backuplogidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.backuplogidDataGridViewTextBoxColumn.Name = "backuplogidDataGridViewTextBoxColumn";
            this.backuplogidDataGridViewTextBoxColumn.ReadOnly = true;
            this.backuplogidDataGridViewTextBoxColumn.Width = 50;
            // 
            // transdateDataGridViewTextBoxColumn
            // 
            this.transdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date";
            this.transdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transdateDataGridViewTextBoxColumn.Name = "transdateDataGridViewTextBoxColumn";
            this.transdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // donebyDataGridViewTextBoxColumn
            // 
            this.donebyDataGridViewTextBoxColumn.DataPropertyName = "done_by";
            this.donebyDataGridViewTextBoxColumn.HeaderText = "Done by";
            this.donebyDataGridViewTextBoxColumn.Name = "donebyDataGridViewTextBoxColumn";
            this.donebyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineaddressDataGridViewTextBoxColumn
            // 
            this.machineaddressDataGridViewTextBoxColumn.DataPropertyName = "machine_address";
            this.machineaddressDataGridViewTextBoxColumn.HeaderText = "Computer Used";
            this.machineaddressDataGridViewTextBoxColumn.Name = "machineaddressDataGridViewTextBoxColumn";
            this.machineaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            this.filenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.filenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // formBackupLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 264);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBackupLog";
            this.Text = "Backup Log";
            this.Load += new System.EventHandler(this.formBackupLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBackupLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackupLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBackupLog dsBackupLog;
        private System.Windows.Forms.BindingSource tbBackupLogBindingSource;
        private dsBackupLogTableAdapters.tbBackupLogTableAdapter tbBackupLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn backuplogidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donebyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
    }
}