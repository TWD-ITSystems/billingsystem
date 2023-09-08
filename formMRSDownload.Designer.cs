namespace BillingSystem
{
    partial class formMRSDownload
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldl_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldl_billmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldl_zonebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldl_doneby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldl_numrecords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMRSDownloadHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dtGovDueDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.labelRecNo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtDisco = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtCurrentTWD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDiscoArrears = new System.Windows.Forms.DateTimePicker();
            this.dtCurrentAgents = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dsMRSDownload = new BillingSystem.dsMRSDownload();
            this.dsMRSDownloadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMRSDownloadHistoryDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownloadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 449);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.gridControl1);
            this.tabPage2.Controls.Add(this.tbMRSDownloadHistoryDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Download History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(681, 417);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BillingSystem.tbMRSDownloadHistory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldl_date,
            this.coldl_billmonth,
            this.coldl_zonebook,
            this.coldl_doneby,
            this.coldl_numrecords});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // coldl_date
            // 
            this.coldl_date.Caption = "Date Downloaded";
            this.coldl_date.FieldName = "dl_date";
            this.coldl_date.Name = "coldl_date";
            this.coldl_date.Visible = true;
            this.coldl_date.VisibleIndex = 0;
            // 
            // coldl_billmonth
            // 
            this.coldl_billmonth.Caption = "Bill Month";
            this.coldl_billmonth.FieldName = "dl_billmonth";
            this.coldl_billmonth.Name = "coldl_billmonth";
            this.coldl_billmonth.Visible = true;
            this.coldl_billmonth.VisibleIndex = 1;
            // 
            // coldl_zonebook
            // 
            this.coldl_zonebook.Caption = "Zone/Book";
            this.coldl_zonebook.FieldName = "dl_zonebook";
            this.coldl_zonebook.Name = "coldl_zonebook";
            this.coldl_zonebook.Visible = true;
            this.coldl_zonebook.VisibleIndex = 2;
            // 
            // coldl_doneby
            // 
            this.coldl_doneby.Caption = "Done By";
            this.coldl_doneby.FieldName = "dl_doneby";
            this.coldl_doneby.Name = "coldl_doneby";
            this.coldl_doneby.Visible = true;
            this.coldl_doneby.VisibleIndex = 3;
            // 
            // coldl_numrecords
            // 
            this.coldl_numrecords.Caption = "Total Records";
            this.coldl_numrecords.FieldName = "dl_numrecords";
            this.coldl_numrecords.Name = "coldl_numrecords";
            this.coldl_numrecords.Visible = true;
            this.coldl_numrecords.VisibleIndex = 4;
            // 
            // tbMRSDownloadHistoryDataGridView
            // 
            this.tbMRSDownloadHistoryDataGridView.AllowUserToDeleteRows = false;
            this.tbMRSDownloadHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbMRSDownloadHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMRSDownloadHistoryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tbMRSDownloadHistoryDataGridView.Name = "tbMRSDownloadHistoryDataGridView";
            this.tbMRSDownloadHistoryDataGridView.RowHeadersVisible = false;
            this.tbMRSDownloadHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbMRSDownloadHistoryDataGridView.ShowCellErrors = false;
            this.tbMRSDownloadHistoryDataGridView.ShowEditingIcon = false;
            this.tbMRSDownloadHistoryDataGridView.ShowRowErrors = false;
            this.tbMRSDownloadHistoryDataGridView.Size = new System.Drawing.Size(681, 417);
            this.tbMRSDownloadHistoryDataGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dtGovDueDate);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtDisco);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtCurrentTWD);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtDiscoArrears);
            this.tabPage1.Controls.Add(this.dtCurrentAgents);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.cmbZone);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbBillMonth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Data to Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(271, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Check for undownloaded accounts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dtGovDueDate
            // 
            this.dtGovDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGovDueDate.Location = new System.Drawing.Point(328, 263);
            this.dtGovDueDate.Name = "dtGovDueDate";
            this.dtGovDueDate.Size = new System.Drawing.Size(141, 20);
            this.dtGovDueDate.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(147, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gov. Agencies Due Date :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCounter);
            this.groupBox1.Controls.Add(this.labelRecNo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(93, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Downloading ]";
            this.groupBox1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "No. of Records :";
            // 
            // labelCounter
            // 
            this.labelCounter.Location = new System.Drawing.Point(264, 16);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(137, 13);
            this.labelCounter.TabIndex = 8;
            this.labelCounter.Text = "Downloading Record 0";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRecNo
            // 
            this.labelRecNo.AutoSize = true;
            this.labelRecNo.Location = new System.Drawing.Point(93, 16);
            this.labelRecNo.Name = "labelRecNo";
            this.labelRecNo.Size = new System.Drawing.Size(13, 13);
            this.labelRecNo.TabIndex = 0;
            this.labelRecNo.Text = "0";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-72, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Load Average Vol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 32);
            this.progressBar1.TabIndex = 7;
            // 
            // dtDisco
            // 
            this.dtDisco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDisco.Location = new System.Drawing.Point(328, 186);
            this.dtDisco.Name = "dtDisco";
            this.dtDisco.Size = new System.Drawing.Size(141, 20);
            this.dtDisco.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Disco (without Arrears) :";
            // 
            // dtCurrentTWD
            // 
            this.dtCurrentTWD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCurrentTWD.Location = new System.Drawing.Point(328, 160);
            this.dtCurrentTWD.Name = "dtCurrentTWD";
            this.dtCurrentTWD.Size = new System.Drawing.Size(141, 20);
            this.dtCurrentTWD.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current (TWD) :";
            // 
            // dtDiscoArrears
            // 
            this.dtDiscoArrears.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscoArrears.Location = new System.Drawing.Point(328, 215);
            this.dtDiscoArrears.Name = "dtDiscoArrears";
            this.dtDiscoArrears.Size = new System.Drawing.Size(141, 20);
            this.dtDiscoArrears.TabIndex = 11;
            // 
            // dtCurrentAgents
            // 
            this.dtCurrentAgents.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCurrentAgents.Location = new System.Drawing.Point(328, 132);
            this.dtCurrentAgents.Name = "dtCurrentAgents";
            this.dtCurrentAgents.Size = new System.Drawing.Size(141, 20);
            this.dtCurrentAgents.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disco (w/ Arrears) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current (Agents) :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(205, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Due Dates";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(271, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download Data to MRS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(314, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 27);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbZone
            // 
            this.cmbZone.DataSource = this.tbZoneBindingSource;
            this.cmbZone.DisplayMember = "zone_name";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(163, 32);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(119, 21);
            this.cmbZone.TabIndex = 3;
            this.cmbZone.ValueMember = "zone_id";
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zone/Book:";
            // 
            // cmbBillMonth
            // 
            this.cmbBillMonth.DataSource = this.tbBillingBindingSource;
            this.cmbBillMonth.DisplayMember = "billing_desc";
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.Location = new System.Drawing.Point(21, 32);
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.Size = new System.Drawing.Size(119, 21);
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
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Month :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dsMRSDownload
            // 
            this.dsMRSDownload.DataSetName = "dsMRSDownload";
            this.dsMRSDownload.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMRSDownloadBindingSource
            // 
            this.dsMRSDownloadBindingSource.DataSource = this.dsMRSDownload;
            this.dsMRSDownloadBindingSource.Position = 0;
            // 
            // formMRSDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 449);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMRSDownload";
            this.Text = "MRS Download Module";
            this.Load += new System.EventHandler(this.formMRSUpload_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMRSDownloadHistoryDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMRSDownloadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBillMonth;
       // private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZone;
        //private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRecNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDiscoArrears;
        private System.Windows.Forms.DateTimePicker dtCurrentAgents;
        private System.Windows.Forms.DateTimePicker dtCurrentTWD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDisco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;        
        private System.Windows.Forms.BindingSource tbMRSDownloadHistoryBindingSource;
        private System.Windows.Forms.DataGridView tbMRSDownloadHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldl_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldl_billmonth;
        private DevExpress.XtraGrid.Columns.GridColumn coldl_zonebook;
        private DevExpress.XtraGrid.Columns.GridColumn coldl_doneby;
        private DevExpress.XtraGrid.Columns.GridColumn coldl_numrecords;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private dsMRSDownload dsMRSDownload;
        private System.Windows.Forms.BindingSource dsMRSDownloadBindingSource;
        private System.Windows.Forms.DateTimePicker dtGovDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}