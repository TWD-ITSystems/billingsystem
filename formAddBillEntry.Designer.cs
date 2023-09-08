namespace BillingSystem
{
    partial class formAddBillEntry
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRdgPres = new System.Windows.Forms.TextBox();
            this.txtRdgPrev = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePres = new Telerik.WinControls.UI.RadDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.last_reco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tbMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster = new BillingSystem.dsMaster();
            this.last_disco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.last_read_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.date_installedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMasterTableAdapter = new BillingSystem.dsMasterTableAdapters.tbMasterTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsMasterTableAdapters.TableAdapterManager();
            this.datePrev = new Telerik.WinControls.UI.RadDateTimePicker();
            this.labelCardNo = new System.Windows.Forms.Label();
            this.btnLedger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePres)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePrev)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(647, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNo.Location = new System.Drawing.Point(89, 39);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(102, 21);
            this.txtAcctNo.TabIndex = 0;
            this.txtAcctNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcctNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctNo_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add / Edit Billing Entries";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account No. :";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(23, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(387, 21);
            this.labelName.TabIndex = 4;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Previous Reading :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Present Reading :";
            // 
            // txtRdgPres
            // 
            this.txtRdgPres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRdgPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRdgPres.Location = new System.Drawing.Point(105, 117);
            this.txtRdgPres.Name = "txtRdgPres";
            this.txtRdgPres.Size = new System.Drawing.Size(85, 21);
            this.txtRdgPres.TabIndex = 2;
            this.txtRdgPres.TabStop = false;
            this.txtRdgPres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRdgPres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRdgPres_KeyPress);
            // 
            // txtRdgPrev
            // 
            this.txtRdgPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRdgPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRdgPrev.Location = new System.Drawing.Point(308, 117);
            this.txtRdgPrev.Name = "txtRdgPrev";
            this.txtRdgPrev.Size = new System.Drawing.Size(103, 21);
            this.txtRdgPrev.TabIndex = 1;
            this.txtRdgPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRdgPrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRdgPrev_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(528, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(6, 144);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewCheckBoxColumn1.AllowFiltering = false;
            gridViewCheckBoxColumn1.AllowGroup = false;
            gridViewCheckBoxColumn1.AllowHide = false;
            gridViewCheckBoxColumn1.AllowReorder = false;
            gridViewCheckBoxColumn1.AllowResize = false;
            gridViewCheckBoxColumn1.AllowSort = false;
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "";
            gridViewCheckBoxColumn1.Name = "colSelect";
            gridViewCheckBoxColumn1.Width = 30;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Account No.";
            gridViewTextBoxColumn1.Name = "colAcctNo";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "colName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 150;
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Current";
            gridViewDecimalColumn1.Name = "colCurrent";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 80;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Pres Rdg";
            gridViewTextBoxColumn3.Name = "colPresRdg";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 80;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Prev Rdg";
            gridViewTextBoxColumn4.Name = "colPrevRdg";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 80;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Vol";
            gridViewTextBoxColumn5.Name = "colVolume";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn2.HeaderText = "column1";
            gridViewCheckBoxColumn2.IsVisible = false;
            gridViewCheckBoxColumn2.Name = "column1";
            gridViewTextBoxColumn6.HeaderText = "column2";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "column2";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.HeaderText = "Pres";
            gridViewDateTimeColumn1.Name = "colDatePres";
            gridViewDateTimeColumn1.Width = 85;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.HeaderText = "Prev";
            gridViewDateTimeColumn2.Name = "colDatePrev";
            gridViewDateTimeColumn2.Width = 85;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(751, 353);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 24);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pres Read Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Previous Read Date :";
            // 
            // datePres
            // 
            this.datePres.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePres.Location = new System.Drawing.Point(105, 90);
            this.datePres.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePres.MinDate = new System.DateTime(((long)(0)));
            this.datePres.Name = "datePres";
            this.datePres.NullableValue = null;
            this.datePres.NullDate = new System.DateTime(((long)(0)));
            // 
            // 
            // 
            this.datePres.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePres.Size = new System.Drawing.Size(86, 20);
            this.datePres.TabIndex = 14;
            this.datePres.TabStop = false;
            this.datePres.Value = new System.DateTime(((long)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.last_reco_dateDateEdit);
            this.groupBox1.Controls.Add(this.last_disco_dateDateEdit);
            this.groupBox1.Controls.Add(this.last_read_dateDateEdit);
            this.groupBox1.Controls.Add(this.date_installedDateEdit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(416, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Date Details ]";
            // 
            // last_reco_dateDateEdit
            // 
            this.last_reco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_reco_date", true));
            this.last_reco_dateDateEdit.EditValue = null;
            this.last_reco_dateDateEdit.Location = new System.Drawing.Point(131, 87);
            this.last_reco_dateDateEdit.Name = "last_reco_dateDateEdit";
            this.last_reco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.last_reco_dateDateEdit.Properties.ReadOnly = true;
            this.last_reco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_reco_dateDateEdit.Size = new System.Drawing.Size(141, 20);
            this.last_reco_dateDateEdit.TabIndex = 19;
            this.last_reco_dateDateEdit.TabStop = false;
            // 
            // tbMasterBindingSource
            // 
            this.tbMasterBindingSource.DataMember = "tbMaster";
            this.tbMasterBindingSource.DataSource = this.dsMaster;
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "dsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // last_disco_dateDateEdit
            // 
            this.last_disco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_disco_date", true));
            this.last_disco_dateDateEdit.EditValue = null;
            this.last_disco_dateDateEdit.Location = new System.Drawing.Point(131, 62);
            this.last_disco_dateDateEdit.Name = "last_disco_dateDateEdit";
            this.last_disco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.last_disco_dateDateEdit.Properties.ReadOnly = true;
            this.last_disco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_disco_dateDateEdit.Size = new System.Drawing.Size(141, 20);
            this.last_disco_dateDateEdit.TabIndex = 18;
            this.last_disco_dateDateEdit.TabStop = false;
            // 
            // last_read_dateDateEdit
            // 
            this.last_read_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_read_date", true));
            this.last_read_dateDateEdit.EditValue = null;
            this.last_read_dateDateEdit.Location = new System.Drawing.Point(131, 37);
            this.last_read_dateDateEdit.Name = "last_read_dateDateEdit";
            this.last_read_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.last_read_dateDateEdit.Properties.ReadOnly = true;
            this.last_read_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_read_dateDateEdit.Size = new System.Drawing.Size(141, 20);
            this.last_read_dateDateEdit.TabIndex = 17;
            this.last_read_dateDateEdit.TabStop = false;
            // 
            // date_installedDateEdit
            // 
            this.date_installedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "date_installed", true));
            this.date_installedDateEdit.EditValue = null;
            this.date_installedDateEdit.Location = new System.Drawing.Point(131, 12);
            this.date_installedDateEdit.Name = "date_installedDateEdit";
            this.date_installedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.date_installedDateEdit.Properties.ReadOnly = true;
            this.date_installedDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_installedDateEdit.Size = new System.Drawing.Size(141, 20);
            this.date_installedDateEdit.TabIndex = 16;
            this.date_installedDateEdit.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Reconnection :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Disconnection :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last Reading :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Installation :";
            // 
            // tbMasterTableAdapter
            // 
            this.tbMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbMasterTableAdapter = this.tbMasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datePrev
            // 
            this.datePrev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePrev.Location = new System.Drawing.Point(308, 90);
            this.datePrev.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePrev.MinDate = new System.DateTime(((long)(0)));
            this.datePrev.Name = "datePrev";
            this.datePrev.NullableValue = null;
            this.datePrev.NullDate = new System.DateTime(((long)(0)));
            // 
            // 
            // 
            this.datePrev.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePrev.Size = new System.Drawing.Size(102, 20);
            this.datePrev.TabIndex = 17;
            this.datePrev.TabStop = false;
            this.datePrev.Value = new System.DateTime(((long)(0)));
            // 
            // labelCardNo
            // 
            this.labelCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNo.Location = new System.Drawing.Point(197, 39);
            this.labelCardNo.Name = "labelCardNo";
            this.labelCardNo.Size = new System.Drawing.Size(213, 21);
            this.labelCardNo.TabIndex = 18;
            this.labelCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLedger
            // 
            this.btnLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedger.Location = new System.Drawing.Point(126, 513);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(104, 24);
            this.btnLedger.TabIndex = 19;
            this.btnLedger.Text = "Show Ledger";
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.Visible = false;
            this.btnLedger.Click += new System.EventHandler(this.btnLedger_Click);
            // 
            // formAddBillEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 549);
            this.Controls.Add(this.btnLedger);
            this.Controls.Add(this.labelCardNo);
            this.Controls.Add(this.datePrev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRdgPrev);
            this.Controls.Add(this.txtRdgPres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddBillEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formAddBillEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRdgPres;
        private System.Windows.Forms.TextBox txtRdgPrev;
        private System.Windows.Forms.Button btnSave;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDateTimePicker datePres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private dsMaster dsMaster;
        private System.Windows.Forms.BindingSource tbMasterBindingSource;
        private dsMasterTableAdapters.tbMasterTableAdapter tbMasterTableAdapter;
        private dsMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit last_read_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit date_installedDateEdit;
        private DevExpress.XtraEditors.DateEdit last_disco_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit last_reco_dateDateEdit;
        private Telerik.WinControls.UI.RadDateTimePicker datePrev;
        private System.Windows.Forms.Label labelCardNo;
        private System.Windows.Forms.Button btnLedger;
    }
}