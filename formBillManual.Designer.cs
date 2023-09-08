namespace BillingSystem
{
    partial class formBillManual
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBilling = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMtrReader = new System.Windows.Forms.TextBox();
            this.txtEncoder = new System.Windows.Forms.TextBox();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRemarks = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAcctNo = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCombo = new System.Windows.Forms.Panel();
            this.datePres = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spinPrev = new DevExpress.XtraEditors.SpinEdit();
            this.spinPres = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridBilling = new Telerik.WinControls.UI.RadGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRecNum = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLedger = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcctNo.Properties)).BeginInit();
            this.panelCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinPrev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPres.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Billing Period :";
            // 
            // cmbBilling
            // 
            this.cmbBilling.DataSource = this.tbBillingBindingSource;
            this.cmbBilling.DisplayMember = "billing_desc";
            this.cmbBilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilling.FormattingEnabled = true;
            this.cmbBilling.Location = new System.Drawing.Point(87, 38);
            this.cmbBilling.Name = "cmbBilling";
            this.cmbBilling.Size = new System.Drawing.Size(146, 21);
            this.cmbBilling.TabIndex = 2;
            this.cmbBilling.TabStop = false;
            this.cmbBilling.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBilling;
            this.tbBillingBindingSource.Sort = "billing_id desc";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zone / Book :";
            // 
            // cmbZone
            // 
            this.cmbZone.DataSource = this.tbZoneBindingSource;
            this.cmbZone.DisplayMember = "zone_name";
            this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(87, 67);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(146, 21);
            this.cmbZone.TabIndex = 4;
            this.cmbZone.TabStop = false;
            this.cmbZone.ValueMember = "zone_id";
            this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataSource = typeof(BillingSystem.tbZone);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encoder :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Meter Reader :";
            // 
            // txtMtrReader
            // 
            this.txtMtrReader.BackColor = System.Drawing.Color.White;
            this.txtMtrReader.Location = new System.Drawing.Point(351, 11);
            this.txtMtrReader.Name = "txtMtrReader";
            this.txtMtrReader.ReadOnly = true;
            this.txtMtrReader.Size = new System.Drawing.Size(140, 20);
            this.txtMtrReader.TabIndex = 8;
            this.txtMtrReader.TabStop = false;
            // 
            // txtEncoder
            // 
            this.txtEncoder.BackColor = System.Drawing.Color.White;
            this.txtEncoder.Location = new System.Drawing.Point(351, 39);
            this.txtEncoder.Name = "txtEncoder";
            this.txtEncoder.ReadOnly = true;
            this.txtEncoder.Size = new System.Drawing.Size(140, 20);
            this.txtEncoder.TabIndex = 9;
            this.txtEncoder.TabStop = false;
            // 
            // dateToday
            // 
            this.dateToday.CustomFormat = "";
            this.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToday.Location = new System.Drawing.Point(87, 10);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(146, 20);
            this.dateToday.TabIndex = 10;
            this.dateToday.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRemarks);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAcctNo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.panelCombo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.spinPrev);
            this.panel1.Controls.Add(this.spinPres);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 152);
            this.panel1.TabIndex = 11;
            // 
            // cmbRemarks
            // 
            this.cmbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemarks.FormattingEnabled = true;
            this.cmbRemarks.Location = new System.Drawing.Point(634, 124);
            this.cmbRemarks.Name = "cmbRemarks";
            this.cmbRemarks.Size = new System.Drawing.Size(189, 21);
            this.cmbRemarks.TabIndex = 3;
            this.cmbRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinPres_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Remarks";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(6, 124);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAcctNo.Properties.Appearance.Options.UseFont = true;
            this.txtAcctNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAcctNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAcctNo.Properties.MaxLength = 6;
            this.txtAcctNo.Size = new System.Drawing.Size(91, 22);
            this.txtAcctNo.TabIndex = 0;
            this.txtAcctNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctNo_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(701, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 29);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCombo
            // 
            this.panelCombo.Controls.Add(this.cmbZone);
            this.panelCombo.Controls.Add(this.label3);
            this.panelCombo.Controls.Add(this.datePres);
            this.panelCombo.Controls.Add(this.dateToday);
            this.panelCombo.Controls.Add(this.label11);
            this.panelCombo.Controls.Add(this.label1);
            this.panelCombo.Controls.Add(this.label2);
            this.panelCombo.Controls.Add(this.cmbBilling);
            this.panelCombo.Controls.Add(this.txtMtrReader);
            this.panelCombo.Controls.Add(this.label4);
            this.panelCombo.Controls.Add(this.label5);
            this.panelCombo.Controls.Add(this.txtEncoder);
            this.panelCombo.Location = new System.Drawing.Point(12, 4);
            this.panelCombo.Name = "panelCombo";
            this.panelCombo.Size = new System.Drawing.Size(516, 101);
            this.panelCombo.TabIndex = 24;
            // 
            // datePres
            // 
            this.datePres.CustomFormat = "";
            this.datePres.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePres.Location = new System.Drawing.Point(351, 65);
            this.datePres.Name = "datePres";
            this.datePres.Size = new System.Drawing.Size(140, 20);
            this.datePres.TabIndex = 22;
            this.datePres.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date Pres :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 23;
            this.button1.TabStop = false;
            this.button1.Text = "Create Bill File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(106, 126);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(367, 17);
            this.labelName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Prev :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name :";
            // 
            // spinPrev
            // 
            this.spinPrev.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPrev.Location = new System.Drawing.Point(557, 124);
            this.spinPrev.Name = "spinPrev";
            this.spinPrev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spinPrev.Properties.Appearance.Options.UseFont = true;
            this.spinPrev.Properties.Appearance.Options.UseTextOptions = true;
            this.spinPrev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.spinPrev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.spinPrev.Properties.Mask.EditMask = "d";
            this.spinPrev.Size = new System.Drawing.Size(71, 22);
            this.spinPrev.TabIndex = 2;
            this.spinPrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinPres_KeyPress);
            // 
            // spinPres
            // 
            this.spinPres.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPres.Location = new System.Drawing.Point(479, 124);
            this.spinPres.Name = "spinPres";
            this.spinPres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spinPres.Properties.Appearance.Options.UseFont = true;
            this.spinPres.Properties.Appearance.Options.UseTextOptions = true;
            this.spinPres.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.spinPres.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spinPres.Properties.Mask.EditMask = "d";
            this.spinPres.Size = new System.Drawing.Size(72, 22);
            this.spinPres.TabIndex = 1;
            this.spinPres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinPres_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Acct No.:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridBilling);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 331);
            this.panel2.TabIndex = 12;
            // 
            // gridBilling
            // 
            this.gridBilling.AutoScroll = true;
            this.gridBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBilling.Location = new System.Drawing.Point(0, 0);
            // 
            // gridBilling
            // 
            this.gridBilling.MasterTemplate.AllowAddNewRow = false;
            this.gridBilling.MasterTemplate.AllowColumnChooser = false;
            this.gridBilling.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridBilling.MasterTemplate.AllowColumnReorder = false;
            this.gridBilling.MasterTemplate.AllowDeleteRow = false;
            this.gridBilling.MasterTemplate.AllowRowResize = false;
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Select";
            gridViewCheckBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "masterID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "masterID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Card#";
            gridViewTextBoxColumn2.Name = "colCardno";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Acct#";
            gridViewTextBoxColumn3.Name = "colAcctNo";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 80;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Name";
            gridViewTextBoxColumn4.Name = "colName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 250;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Pres";
            gridViewDecimalColumn1.Name = "colPres";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn2.DecimalPlaces = 0;
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "Prev";
            gridViewDecimalColumn2.Name = "colPrev";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Volume";
            gridViewTextBoxColumn5.Name = "colVol";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.HeaderText = "Remarks";
            gridViewTextBoxColumn6.Name = "colRemarks";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 120;
            gridViewDecimalColumn3.HeaderText = "Current";
            gridViewDecimalColumn3.Name = "colCurrent";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn4.HeaderText = "Penalty";
            gridViewDecimalColumn4.Name = "colPenalty";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewDateTimeColumn1.HeaderText = "DatePrev";
            gridViewDateTimeColumn1.Name = "colDatePrev";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn2.HeaderText = "ReadTime";
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "colReadTime";
            gridViewDateTimeColumn2.ReadOnly = true;
            gridViewTextBoxColumn7.HeaderText = "AveVol";
            gridViewTextBoxColumn7.Name = "colAveVol";
            gridViewTextBoxColumn7.ReadOnly = true;
            this.gridBilling.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn7});
            this.gridBilling.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gridBilling.Name = "gridBilling";
            this.gridBilling.Size = new System.Drawing.Size(866, 331);
            this.gridBilling.TabIndex = 0;
            this.gridBilling.Text = "radGridView1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnLedger);
            this.panel3.Controls.Add(this.labelRecNum);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 46);
            this.panel3.TabIndex = 13;
            // 
            // labelRecNum
            // 
            this.labelRecNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecNum.Location = new System.Drawing.Point(418, 17);
            this.labelRecNum.Name = "labelRecNum";
            this.labelRecNum.Size = new System.Drawing.Size(272, 17);
            this.labelRecNum.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(736, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 29);
            this.btnSave.TabIndex = 27;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save Bill File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 26;
            this.button2.TabStop = false;
            this.button2.Text = "Delete Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressPanel1.Description = "Processing...";
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(144, 71);
            this.progressPanel1.TabIndex = 28;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnLedger
            // 
            this.btnLedger.Location = new System.Drawing.Point(111, 7);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(110, 29);
            this.btnLedger.TabIndex = 29;
            this.btnLedger.TabStop = false;
            this.btnLedger.Text = "[F1]  View Ledger";
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 29);
            this.button3.TabIndex = 30;
            this.button3.TabStop = false;
            this.button3.Text = "Unprocess MRS Records";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formBillManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 529);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "formBillManual";
            this.Text = "Billfile Manual Entry";
            this.Load += new System.EventHandler(this.formBillManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcctNo.Properties)).EndInit();
            this.panelCombo.ResumeLayout(false);
            this.panelCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinPrev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPres.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBilling;
        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMtrReader;
        private System.Windows.Forms.TextBox txtEncoder;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView gridBilling;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spinPrev;
        private DevExpress.XtraEditors.SpinEdit spinPres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCombo;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtAcctNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRemarks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelRecNum;
        private System.Windows.Forms.Button btnLedger;
        private System.Windows.Forms.Button button3;
    }
}