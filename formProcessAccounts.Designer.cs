namespace BillingSystem
{
    partial class formProcessAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPrepareAcctHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepareAcct = new BillingSystem.dsPrepareAcct();
            this.tbPrepareAcctHistoryTableAdapter = new BillingSystem.dsPrepareAcctTableAdapters.tbPrepareAcctHistoryTableAdapter();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.preparebillingofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateprocessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donebyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numrecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disco_processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disco_marked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disco_reconnected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrepareAcctHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepareAcct)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(863, 385);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process Accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Bill Month :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbBillingBindingSource1;
            this.comboBox1.DisplayMember = "billing_desc";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource1
            // 
            this.tbBillingBindingSource1.DataMember = "tbBilling";
            this.tbBillingBindingSource1.DataSource = this.dsBilling;
            this.tbBillingBindingSource1.Sort = "billing_id DESC";
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preparebillingofDataGridViewTextBoxColumn,
            this.dateprocessDataGridViewTextBoxColumn,
            this.donebyDataGridViewTextBoxColumn,
            this.numrecords,
            this.disco_processed,
            this.disco_marked,
            this.disco_reconnected});
            this.dataGridView1.DataSource = this.tbPrepareAcctHistoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(689, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbPrepareAcctHistoryBindingSource
            // 
            this.tbPrepareAcctHistoryBindingSource.DataMember = "tbPrepareAcctHistory";
            this.tbPrepareAcctHistoryBindingSource.DataSource = this.dsPrepareAcct;
            this.tbPrepareAcctHistoryBindingSource.Sort = "process_id DESC";
            // 
            // dsPrepareAcct
            // 
            this.dsPrepareAcct.DataSetName = "dsPrepareAcct";
            this.dsPrepareAcct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPrepareAcctHistoryTableAdapter
            // 
            this.tbPrepareAcctHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // preparebillingofDataGridViewTextBoxColumn
            // 
            this.preparebillingofDataGridViewTextBoxColumn.DataPropertyName = "prepare_billing_of";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.preparebillingofDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.preparebillingofDataGridViewTextBoxColumn.HeaderText = "Preparation for Billing";
            this.preparebillingofDataGridViewTextBoxColumn.Name = "preparebillingofDataGridViewTextBoxColumn";
            this.preparebillingofDataGridViewTextBoxColumn.ReadOnly = true;
            this.preparebillingofDataGridViewTextBoxColumn.Width = 140;
            // 
            // dateprocessDataGridViewTextBoxColumn
            // 
            this.dateprocessDataGridViewTextBoxColumn.DataPropertyName = "date_process";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateprocessDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateprocessDataGridViewTextBoxColumn.HeaderText = "Date Processed";
            this.dateprocessDataGridViewTextBoxColumn.Name = "dateprocessDataGridViewTextBoxColumn";
            this.dateprocessDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateprocessDataGridViewTextBoxColumn.Width = 120;
            // 
            // donebyDataGridViewTextBoxColumn
            // 
            this.donebyDataGridViewTextBoxColumn.DataPropertyName = "done_by";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.donebyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.donebyDataGridViewTextBoxColumn.HeaderText = "Processed By";
            this.donebyDataGridViewTextBoxColumn.Name = "donebyDataGridViewTextBoxColumn";
            this.donebyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numrecords
            // 
            this.numrecords.DataPropertyName = "numrecords";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numrecords.DefaultCellStyle = dataGridViewCellStyle4;
            this.numrecords.HeaderText = "No. of Records";
            this.numrecords.Name = "numrecords";
            this.numrecords.ReadOnly = true;
            // 
            // disco_processed
            // 
            this.disco_processed.DataPropertyName = "disco_processed";
            this.disco_processed.HeaderText = "Processed Disco";
            this.disco_processed.Name = "disco_processed";
            this.disco_processed.ReadOnly = true;
            this.disco_processed.Width = 75;
            // 
            // disco_marked
            // 
            this.disco_marked.DataPropertyName = "disco_marked";
            this.disco_marked.HeaderText = "For X Marking";
            this.disco_marked.Name = "disco_marked";
            this.disco_marked.ReadOnly = true;
            this.disco_marked.Width = 75;
            // 
            // disco_reconnected
            // 
            this.disco_reconnected.DataPropertyName = "disco_reconnected";
            this.disco_reconnected.HeaderText = "Reconnected";
            this.disco_reconnected.Name = "disco_reconnected";
            this.disco_reconnected.ReadOnly = true;
            this.disco_reconnected.Width = 75;
            // 
            // formProcessAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 385);
            this.Controls.Add(this.splitContainer1);
            this.Name = "formProcessAccounts";
            this.Text = "Process Accounts for next billing";
            this.Load += new System.EventHandler(this.formProcessAccounts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrepareAcctHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepareAcct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsPrepareAcct dsPrepareAcct;
        private System.Windows.Forms.BindingSource tbPrepareAcctHistoryBindingSource;
        private dsPrepareAcctTableAdapters.tbPrepareAcctHistoryTableAdapter tbPrepareAcctHistoryTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private dsBilling dsBilling;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tbBillingBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparebillingofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateprocessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donebyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numrecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn disco_processed;
        private System.Windows.Forms.DataGridViewTextBoxColumn disco_marked;
        private System.Windows.Forms.DataGridViewTextBoxColumn disco_reconnected;
    }
}