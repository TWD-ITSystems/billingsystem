namespace BillingSystem
{
    partial class formGenerateWizard
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
            System.Windows.Forms.Label billing_idLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label billing_idLabel2;
            System.Windows.Forms.Label label9;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingScheduleGridControl = new DevExpress.XtraGrid.GridControl();
            this.tbBillingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_rdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_bill_serve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.billing_idTextBox = new System.Windows.Forms.TextBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billing_endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.billing_startDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cmbBilling = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSave = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAcctno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrevRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMeterReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            billing_idLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            billing_idLabel2 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMeterReaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billing_idLabel
            // 
            billing_idLabel.AutoSize = true;
            billing_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            billing_idLabel.Location = new System.Drawing.Point(16, 46);
            billing_idLabel.Name = "billing_idLabel";
            billing_idLabel.Size = new System.Drawing.Size(80, 15);
            billing_idLabel.TabIndex = 2;
            billing_idLabel.Text = "Bill Month :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(15, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 6;
            label2.Text = "From :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(191, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 17);
            label3.TabIndex = 8;
            label3.Text = "To :";
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Navy;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(3, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(532, 26);
            label4.TabIndex = 9;
            label4.Text = "Schedules";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billing_idLabel2
            // 
            billing_idLabel2.AutoSize = true;
            billing_idLabel2.Location = new System.Drawing.Point(375, 123);
            billing_idLabel2.Name = "billing_idLabel2";
            billing_idLabel2.Size = new System.Drawing.Size(47, 13);
            billing_idLabel2.TabIndex = 15;
            billing_idLabel2.Text = "billing id:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(34, 445);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(108, 15);
            label9.TabIndex = 3;
            label9.Text = "Total Accounts :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 527);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(644, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(527, 494);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 33);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Generate";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(215, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(544, 488);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.progressPanel1);
            this.xtraTabPage1.Controls.Add(this.labelStatus);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.cmbZone);
            this.xtraTabPage1.Controls.Add(this.tbBillingScheduleGridControl);
            this.xtraTabPage1.Controls.Add(billing_idLabel2);
            this.xtraTabPage1.Controls.Add(this.billing_idTextBox);
            this.xtraTabPage1.Controls.Add(label4);
            this.xtraTabPage1.Controls.Add(label3);
            this.xtraTabPage1.Controls.Add(this.billing_endDateEdit);
            this.xtraTabPage1.Controls.Add(label2);
            this.xtraTabPage1.Controls.Add(this.billing_startDateEdit);
            this.xtraTabPage1.Controls.Add(this.cmbBilling);
            this.xtraTabPage1.Controls.Add(billing_idLabel);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(538, 482);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.progressPanel1.Location = new System.Drawing.Point(188, 198);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(135, 55);
            this.progressPanel1.TabIndex = 19;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(308, 67);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 15);
            this.labelStatus.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zone/Book :";
            // 
            // cmbZone
            // 
            this.cmbZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbZone.DataSource = this.tbZoneBindingSource;
            this.cmbZone.DisplayMember = "zone_name";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(164, 67);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(117, 21);
            this.cmbZone.TabIndex = 6;
            this.cmbZone.ValueMember = "zone_id";
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            this.tbZoneBindingSource.PositionChanged += new System.EventHandler(this.tbZoneBindingSource_PositionChanged);
            // 
            // tbBillingScheduleGridControl
            // 
            this.tbBillingScheduleGridControl.DataSource = this.tbBillingScheduleBindingSource;
            this.tbBillingScheduleGridControl.Location = new System.Drawing.Point(3, 178);
            this.tbBillingScheduleGridControl.MainView = this.gridView1;
            this.tbBillingScheduleGridControl.Name = "tbBillingScheduleGridControl";
            this.tbBillingScheduleGridControl.Size = new System.Drawing.Size(532, 301);
            this.tbBillingScheduleGridControl.TabIndex = 16;
            this.tbBillingScheduleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbBillingScheduleBindingSource
            // 
            this.tbBillingScheduleBindingSource.DataSource = typeof(BillingSystem.tbBillingSchedule);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colzone,
            this.coldate_rdg,
            this.coldate_bill_serve});
            this.gridView1.GridControl = this.tbBillingScheduleGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colzone
            // 
            this.colzone.Caption = "Zone";
            this.colzone.FieldName = "zone";
            this.colzone.Name = "colzone";
            this.colzone.Visible = true;
            this.colzone.VisibleIndex = 0;
            this.colzone.Width = 34;
            // 
            // coldate_rdg
            // 
            this.coldate_rdg.Caption = "Reading";
            this.coldate_rdg.FieldName = "date_rdg";
            this.coldate_rdg.Name = "coldate_rdg";
            this.coldate_rdg.Visible = true;
            this.coldate_rdg.VisibleIndex = 1;
            this.coldate_rdg.Width = 100;
            // 
            // coldate_bill_serve
            // 
            this.coldate_bill_serve.Caption = "Distribution";
            this.coldate_bill_serve.FieldName = "date_bill_serve";
            this.coldate_bill_serve.Name = "coldate_bill_serve";
            this.coldate_bill_serve.Visible = true;
            this.coldate_bill_serve.VisibleIndex = 2;
            this.coldate_bill_serve.Width = 100;
            // 
            // billing_idTextBox
            // 
            this.billing_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "billing_id", true));
            this.billing_idTextBox.Location = new System.Drawing.Point(428, 120);
            this.billing_idTextBox.Name = "billing_idTextBox";
            this.billing_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.billing_idTextBox.TabIndex = 16;
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataSource = typeof(BillingSystem.tbBilling);
            this.tbBillingBindingSource.Sort = "billing_desc";
            this.tbBillingBindingSource.PositionChanged += new System.EventHandler(this.tbBillingBindingSource_PositionChanged);
            // 
            // billing_endDateEdit
            // 
            this.billing_endDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_end", true));
            this.billing_endDateEdit.EditValue = null;
            this.billing_endDateEdit.Location = new System.Drawing.Point(188, 120);
            this.billing_endDateEdit.Name = "billing_endDateEdit";
            this.billing_endDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.billing_endDateEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billing_endDateEdit.Properties.Appearance.Options.UseFont = true;
            this.billing_endDateEdit.Properties.Appearance.Options.UseForeColor = true;
            this.billing_endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_endDateEdit.Properties.ReadOnly = true;
            this.billing_endDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_endDateEdit.Size = new System.Drawing.Size(115, 20);
            this.billing_endDateEdit.TabIndex = 7;
            // 
            // billing_startDateEdit
            // 
            this.billing_startDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_start", true));
            this.billing_startDateEdit.EditValue = null;
            this.billing_startDateEdit.Location = new System.Drawing.Point(17, 120);
            this.billing_startDateEdit.Name = "billing_startDateEdit";
            this.billing_startDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.billing_startDateEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billing_startDateEdit.Properties.Appearance.Options.UseFont = true;
            this.billing_startDateEdit.Properties.Appearance.Options.UseForeColor = true;
            this.billing_startDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_startDateEdit.Properties.ReadOnly = true;
            this.billing_startDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_startDateEdit.Size = new System.Drawing.Size(124, 20);
            this.billing_startDateEdit.TabIndex = 5;
            this.billing_startDateEdit.TabStop = false;
            // 
            // cmbBilling
            // 
            this.cmbBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbBilling.DataSource = this.tbBillingBindingSource;
            this.cmbBilling.DisplayMember = "billing_desc";
            this.cmbBilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBilling.FormattingEnabled = true;
            this.cmbBilling.Location = new System.Drawing.Point(18, 67);
            this.cmbBilling.Name = "cmbBilling";
            this.cmbBilling.Size = new System.Drawing.Size(123, 21);
            this.cmbBilling.TabIndex = 4;
            this.cmbBilling.ValueMember = "billing_id";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Billing Date to Generate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel1);
            this.xtraTabPage2.Controls.Add(this.labelTotal);
            this.xtraTabPage2.Controls.Add(label9);
            this.xtraTabPage2.Controls.Add(this.dataGridView1);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(538, 482);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelSave);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(88, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 84);
            this.panel1.TabIndex = 6;
            this.panel1.UseWaitCursor = true;
            this.panel1.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.Location = new System.Drawing.Point(154, 18);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(170, 13);
            this.labelSave.TabIndex = 2;
            this.labelSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSave.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Saving ...";
            this.label8.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(22, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(148, 447);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "label8";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAcctno,
            this.colCardNo,
            this.colPrevRdg,
            this.colCurrRdg,
            this.colVolume});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(514, 377);
            this.dataGridView1.TabIndex = 2;
            // 
            // colAcctno
            // 
            this.colAcctno.HeaderText = "Acct No";
            this.colAcctno.Name = "colAcctno";
            this.colAcctno.ReadOnly = true;
            // 
            // colCardNo
            // 
            this.colCardNo.HeaderText = "Card No";
            this.colCardNo.Name = "colCardNo";
            this.colCardNo.ReadOnly = true;
            // 
            // colPrevRdg
            // 
            this.colPrevRdg.HeaderText = "Prev. Rdg";
            this.colPrevRdg.Name = "colPrevRdg";
            this.colPrevRdg.ReadOnly = true;
            // 
            // colCurrRdg
            // 
            this.colCurrRdg.HeaderText = "Curr. Rdg";
            this.colCurrRdg.Name = "colCurrRdg";
            this.colCurrRdg.ReadOnly = true;
            // 
            // colVolume
            // 
            this.colVolume.HeaderText = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Purple;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Accounts / Readings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMeterReaderBindingSource
            // 
            this.tbMeterReaderBindingSource.DataSource = typeof(BillingSystem.tbMeterReader);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // formGenerateWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 531);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formGenerateWizard";
            this.Text = "Generate Billing";
            this.Load += new System.EventHandler(this.formGenerateWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMeterReaderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private System.Windows.Forms.ComboBox cmbBilling;
        private DevExpress.XtraEditors.DateEdit billing_endDateEdit;
        private DevExpress.XtraEditors.DateEdit billing_startDateEdit;
        private System.Windows.Forms.BindingSource tbBillingScheduleBindingSource;
        private System.Windows.Forms.TextBox billing_idTextBox;
        private DevExpress.XtraGrid.GridControl tbBillingScheduleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.BindingSource tbMeterReaderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colzone;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_rdg;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_bill_serve;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcctno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrevRdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrRdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolume;
        private System.Windows.Forms.Label labelTotal;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}