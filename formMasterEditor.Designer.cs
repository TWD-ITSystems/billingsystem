namespace BillingSystem
{
    partial class formMasterEditor
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label cardnoLabel;
            System.Windows.Forms.Label zone_nameLabel;
            System.Windows.Forms.Label meternoLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label last_disco_dateLabel;
            System.Windows.Forms.Label last_reco_dateLabel;
            System.Windows.Forms.Label date_installedLabel;
            System.Windows.Forms.Label senior_expiryLabel;
            System.Windows.Forms.Label iFBalanceLabel;
            System.Windows.Forms.Label iFArrearsLabel;
            System.Windows.Forms.Label rdg_presLabel;
            System.Windows.Forms.Label last_read_dateLabel;
            System.Windows.Forms.Label prev_read_dateLabel;
            System.Windows.Forms.Label last_edit_dateLabel;
            System.Windows.Forms.Label last_edit_byLabel;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsMaster = new BillingSystem.dsMaster();
            this.tbMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMasterTableAdapter = new BillingSystem.dsMasterTableAdapters.tbMasterTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsMasterTableAdapters.TableAdapterManager();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categorySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cardnoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dsZone = new BillingSystem.dsZone();
            this.tbZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbZoneTableAdapter = new BillingSystem.dsZoneTableAdapters.tbZoneTableAdapter();
            this.tableAdapterManager1 = new BillingSystem.dsZoneTableAdapters.TableAdapterManager();
            this.zone_nameComboBox = new System.Windows.Forms.ComboBox();
            this.dsMeters = new BillingSystem.dsMeters();
            this.tbMetersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMetersTableAdapter = new BillingSystem.dsMetersTableAdapters.tbMetersTableAdapter();
            this.tableAdapterManager2 = new BillingSystem.dsMetersTableAdapters.TableAdapterManager();
            this.meternoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.master_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.meter_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.statusTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.last_disco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.last_reco_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.date_installedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dsMasterAccts = new BillingSystem.dsMasterAccts();
            this.tbMasterAcctsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMasterAcctsTableAdapter = new BillingSystem.dsMasterAcctsTableAdapters.tbMasterAcctsTableAdapter();
            this.tableAdapterManager3 = new BillingSystem.dsMasterAcctsTableAdapters.TableAdapterManager();
            this.isSeniorCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.senior_expiryDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.isIFCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iFArrearsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.iFBalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rdg_presSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.last_read_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.prev_read_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.button4 = new System.Windows.Forms.Button();
            this.last_edit_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.last_edit_byTextEdit = new DevExpress.XtraEditors.TextEdit();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            cardnoLabel = new System.Windows.Forms.Label();
            zone_nameLabel = new System.Windows.Forms.Label();
            meternoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            last_disco_dateLabel = new System.Windows.Forms.Label();
            last_reco_dateLabel = new System.Windows.Forms.Label();
            date_installedLabel = new System.Windows.Forms.Label();
            senior_expiryLabel = new System.Windows.Forms.Label();
            iFBalanceLabel = new System.Windows.Forms.Label();
            iFArrearsLabel = new System.Windows.Forms.Label();
            rdg_presLabel = new System.Windows.Forms.Label();
            last_read_dateLabel = new System.Windows.Forms.Label();
            prev_read_dateLabel = new System.Windows.Forms.Label();
            last_edit_dateLabel = new System.Windows.Forms.Label();
            last_edit_byLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMetersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meternoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAccts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAcctsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSeniorCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_expiryDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_expiryDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isIFCheckEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_presSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_read_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_read_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_byTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(14, 106);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(302, 145);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // cardnoLabel
            // 
            cardnoLabel.AutoSize = true;
            cardnoLabel.Location = new System.Drawing.Point(20, 147);
            cardnoLabel.Name = "cardnoLabel";
            cardnoLabel.Size = new System.Drawing.Size(58, 17);
            cardnoLabel.TabIndex = 9;
            cardnoLabel.Text = "Cardno:";
            // 
            // zone_nameLabel
            // 
            zone_nameLabel.AutoSize = true;
            zone_nameLabel.Location = new System.Drawing.Point(33, 188);
            zone_nameLabel.Name = "zone_nameLabel";
            zone_nameLabel.Size = new System.Drawing.Size(45, 17);
            zone_nameLabel.TabIndex = 11;
            zone_nameLabel.Text = "Zone:";
            // 
            // meternoLabel
            // 
            meternoLabel.AutoSize = true;
            meternoLabel.Location = new System.Drawing.Point(246, 188);
            meternoLabel.Name = "meternoLabel";
            meternoLabel.Size = new System.Drawing.Size(70, 17);
            meternoLabel.TabIndex = 13;
            meternoLabel.Text = "Meter No:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(24, 272);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 19;
            statusLabel.Text = "Status:";
            // 
            // last_disco_dateLabel
            // 
            last_disco_dateLabel.AutoSize = true;
            last_disco_dateLabel.Location = new System.Drawing.Point(186, 272);
            last_disco_dateLabel.Name = "last_disco_dateLabel";
            last_disco_dateLabel.Size = new System.Drawing.Size(81, 17);
            last_disco_dateLabel.TabIndex = 23;
            last_disco_dateLabel.Text = "Disco Date:";
            // 
            // last_reco_dateLabel
            // 
            last_reco_dateLabel.AutoSize = true;
            last_reco_dateLabel.Location = new System.Drawing.Point(186, 315);
            last_reco_dateLabel.Name = "last_reco_dateLabel";
            last_reco_dateLabel.Size = new System.Drawing.Size(87, 17);
            last_reco_dateLabel.TabIndex = 25;
            last_reco_dateLabel.Text = "Recon Date:";
            // 
            // date_installedLabel
            // 
            date_installedLabel.AutoSize = true;
            date_installedLabel.Location = new System.Drawing.Point(12, 230);
            date_installedLabel.Name = "date_installedLabel";
            date_installedLabel.Size = new System.Drawing.Size(98, 17);
            date_installedLabel.TabIndex = 27;
            date_installedLabel.Text = "Date Installed:";
            // 
            // senior_expiryLabel
            // 
            senior_expiryLabel.AutoSize = true;
            senior_expiryLabel.Location = new System.Drawing.Point(610, 190);
            senior_expiryLabel.Name = "senior_expiryLabel";
            senior_expiryLabel.Size = new System.Drawing.Size(50, 17);
            senior_expiryLabel.TabIndex = 29;
            senior_expiryLabel.Text = "Expiry:";
            // 
            // iFBalanceLabel
            // 
            iFBalanceLabel.AutoSize = true;
            iFBalanceLabel.Location = new System.Drawing.Point(25, 62);
            iFBalanceLabel.Name = "iFBalanceLabel";
            iFBalanceLabel.Size = new System.Drawing.Size(74, 17);
            iFBalanceLabel.TabIndex = 31;
            iFBalanceLabel.Text = "IFBalance:";
            // 
            // iFArrearsLabel
            // 
            iFArrearsLabel.AutoSize = true;
            iFArrearsLabel.Location = new System.Drawing.Point(25, 99);
            iFArrearsLabel.Name = "iFArrearsLabel";
            iFArrearsLabel.Size = new System.Drawing.Size(70, 17);
            iFArrearsLabel.TabIndex = 32;
            iFArrearsLabel.Text = "IFArrears:";
            // 
            // rdg_presLabel
            // 
            rdg_presLabel.AutoSize = true;
            rdg_presLabel.Location = new System.Drawing.Point(508, 72);
            rdg_presLabel.Name = "rdg_presLabel";
            rdg_presLabel.Size = new System.Drawing.Size(118, 17);
            rdg_presLabel.TabIndex = 32;
            rdg_presLabel.Text = "Present Reading:";
            // 
            // last_read_dateLabel
            // 
            last_read_dateLabel.AutoSize = true;
            last_read_dateLabel.Location = new System.Drawing.Point(508, 106);
            last_read_dateLabel.Name = "last_read_dateLabel";
            last_read_dateLabel.Size = new System.Drawing.Size(152, 17);
            last_read_dateLabel.TabIndex = 33;
            last_read_dateLabel.Text = "Present Reading Date:";
            // 
            // prev_read_dateLabel
            // 
            prev_read_dateLabel.AutoSize = true;
            prev_read_dateLabel.Location = new System.Drawing.Point(508, 140);
            prev_read_dateLabel.Name = "prev_read_dateLabel";
            prev_read_dateLabel.Size = new System.Drawing.Size(158, 17);
            prev_read_dateLabel.TabIndex = 35;
            prev_read_dateLabel.Text = "Previous Reading Date:";
            // 
            // last_edit_dateLabel
            // 
            last_edit_dateLabel.AutoSize = true;
            last_edit_dateLabel.Location = new System.Drawing.Point(4, 367);
            last_edit_dateLabel.Name = "last_edit_dateLabel";
            last_edit_dateLabel.Size = new System.Drawing.Size(101, 17);
            last_edit_dateLabel.TabIndex = 38;
            last_edit_dateLabel.Text = "Last Edit Date:";
            // 
            // last_edit_byLabel
            // 
            last_edit_byLabel.AutoSize = true;
            last_edit_byLabel.Location = new System.Drawing.Point(246, 367);
            last_edit_byLabel.Name = "last_edit_byLabel";
            last_edit_byLabel.Size = new System.Drawing.Size(71, 17);
            last_edit_byLabel.TabIndex = 40;
            last_edit_byLabel.Text = "Edited by:";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(111, 25);
            this.txtAcctNo.MaxLength = 6;
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(180, 23);
            this.txtAcctNo.TabIndex = 0;
            this.txtAcctNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcctNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account No. :";
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "dsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMasterBindingSource
            // 
            this.tbMasterBindingSource.DataMember = "tbMaster";
            this.tbMasterBindingSource.DataSource = this.dsMaster;
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
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(82, 69);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.MaxLength = 30;
            this.nameTextEdit.Size = new System.Drawing.Size(378, 20);
            this.nameTextEdit.TabIndex = 4;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(82, 105);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Properties.MaxLength = 50;
            this.addressTextEdit.Size = new System.Drawing.Size(378, 20);
            this.addressTextEdit.TabIndex = 6;
            // 
            // categorySpinEdit
            // 
            this.categorySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "category", true));
            this.categorySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.categorySpinEdit.Location = new System.Drawing.Point(375, 142);
            this.categorySpinEdit.Name = "categorySpinEdit";
            this.categorySpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.categorySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.categorySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.categorySpinEdit.Size = new System.Drawing.Size(85, 20);
            this.categorySpinEdit.TabIndex = 8;
            // 
            // cardnoSpinEdit
            // 
            this.cardnoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "cardno", true));
            this.cardnoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cardnoSpinEdit.Location = new System.Drawing.Point(82, 144);
            this.cardnoSpinEdit.Name = "cardnoSpinEdit";
            this.cardnoSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.cardnoSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cardnoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.cardnoSpinEdit.Properties.EditFormat.FormatString = "######";
            this.cardnoSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cardnoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cardnoSpinEdit.TabIndex = 10;
            // 
            // dsZone
            // 
            this.dsZone.DataSetName = "dsZone";
            this.dsZone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbZoneBindingSource
            // 
            this.tbZoneBindingSource.DataMember = "tbZone";
            this.tbZoneBindingSource.DataSource = this.dsZone;
            // 
            // tbZoneTableAdapter
            // 
            this.tbZoneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbZoneTableAdapter = this.tbZoneTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BillingSystem.dsZoneTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // zone_nameComboBox
            // 
            this.zone_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbZoneBindingSource, "zone_name", true));
            this.zone_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbMasterBindingSource, "zone_id", true));
            this.zone_nameComboBox.DataSource = this.tbZoneBindingSource;
            this.zone_nameComboBox.DisplayMember = "zone_name";
            this.zone_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zone_nameComboBox.FormattingEnabled = true;
            this.zone_nameComboBox.Location = new System.Drawing.Point(82, 185);
            this.zone_nameComboBox.Name = "zone_nameComboBox";
            this.zone_nameComboBox.Size = new System.Drawing.Size(121, 24);
            this.zone_nameComboBox.TabIndex = 12;
            this.zone_nameComboBox.ValueMember = "zone_id";
            // 
            // dsMeters
            // 
            this.dsMeters.DataSetName = "dsMeters";
            this.dsMeters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMetersBindingSource
            // 
            this.tbMetersBindingSource.DataMember = "tbMeters";
            this.tbMetersBindingSource.DataSource = this.dsMeters;
            // 
            // tbMetersTableAdapter
            // 
            this.tbMetersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.tbMetersTableAdapter = this.tbMetersTableAdapter;
            this.tableAdapterManager2.UpdateOrder = BillingSystem.dsMetersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meternoTextEdit
            // 
            this.meternoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMetersBindingSource, "meterno", true));
            this.meternoTextEdit.Location = new System.Drawing.Point(322, 187);
            this.meternoTextEdit.Name = "meternoTextEdit";
            this.meternoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.meternoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.meternoTextEdit.Size = new System.Drawing.Size(138, 20);
            this.meternoTextEdit.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(80, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // master_idSpinEdit
            // 
            this.master_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "master_id", true));
            this.master_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.master_idSpinEdit.Location = new System.Drawing.Point(178, 28);
            this.master_idSpinEdit.Name = "master_idSpinEdit";
            this.master_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.master_idSpinEdit.Size = new System.Drawing.Size(40, 20);
            this.master_idSpinEdit.TabIndex = 17;
            this.master_idSpinEdit.TabStop = false;
            // 
            // meter_idSpinEdit
            // 
            this.meter_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "meter_id", true));
            this.meter_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.meter_idSpinEdit.Location = new System.Drawing.Point(111, 27);
            this.meter_idSpinEdit.Name = "meter_idSpinEdit";
            this.meter_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.meter_idSpinEdit.Size = new System.Drawing.Size(47, 20);
            this.meter_idSpinEdit.TabIndex = 19;
            this.meter_idSpinEdit.TabStop = false;
            // 
            // statusTextEdit
            // 
            this.statusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "status", true));
            this.statusTextEdit.Location = new System.Drawing.Point(80, 269);
            this.statusTextEdit.Name = "statusTextEdit";
            this.statusTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.statusTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.statusTextEdit.Size = new System.Drawing.Size(60, 20);
            this.statusTextEdit.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(146, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "x";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(146, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "R";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // last_disco_dateDateEdit
            // 
            this.last_disco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_disco_date", true));
            this.last_disco_dateDateEdit.EditValue = null;
            this.last_disco_dateDateEdit.Location = new System.Drawing.Point(279, 271);
            this.last_disco_dateDateEdit.Name = "last_disco_dateDateEdit";
            this.last_disco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_disco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_disco_dateDateEdit.Size = new System.Drawing.Size(131, 20);
            this.last_disco_dateDateEdit.TabIndex = 24;
            // 
            // last_reco_dateDateEdit
            // 
            this.last_reco_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_reco_date", true));
            this.last_reco_dateDateEdit.EditValue = null;
            this.last_reco_dateDateEdit.Location = new System.Drawing.Point(279, 314);
            this.last_reco_dateDateEdit.Name = "last_reco_dateDateEdit";
            this.last_reco_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_reco_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_reco_dateDateEdit.Size = new System.Drawing.Size(131, 20);
            this.last_reco_dateDateEdit.TabIndex = 26;
            // 
            // date_installedDateEdit
            // 
            this.date_installedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "date_installed", true));
            this.date_installedDateEdit.EditValue = null;
            this.date_installedDateEdit.Location = new System.Drawing.Point(111, 227);
            this.date_installedDateEdit.Name = "date_installedDateEdit";
            this.date_installedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_installedDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_installedDateEdit.Size = new System.Drawing.Size(134, 20);
            this.date_installedDateEdit.TabIndex = 28;
            // 
            // dsMasterAccts
            // 
            this.dsMasterAccts.DataSetName = "dsMasterAccts";
            this.dsMasterAccts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMasterAcctsBindingSource
            // 
            this.tbMasterAcctsBindingSource.DataMember = "tbMasterAccts";
            this.tbMasterAcctsBindingSource.DataSource = this.dsMasterAccts;
            // 
            // tbMasterAcctsTableAdapter
            // 
            this.tbMasterAcctsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.tbMasterAcctsTableAdapter = this.tbMasterAcctsTableAdapter;
            this.tableAdapterManager3.UpdateOrder = BillingSystem.dsMasterAcctsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // isSeniorCheckEdit
            // 
            this.isSeniorCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "isSenior", true));
            this.isSeniorCheckEdit.Location = new System.Drawing.Point(506, 188);
            this.isSeniorCheckEdit.Name = "isSeniorCheckEdit";
            this.isSeniorCheckEdit.Properties.Caption = "Senior Citizen";
            this.isSeniorCheckEdit.Size = new System.Drawing.Size(98, 19);
            this.isSeniorCheckEdit.TabIndex = 29;
            // 
            // senior_expiryDateEdit
            // 
            this.senior_expiryDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "senior_expiry", true));
            this.senior_expiryDateEdit.EditValue = null;
            this.senior_expiryDateEdit.Location = new System.Drawing.Point(666, 189);
            this.senior_expiryDateEdit.Name = "senior_expiryDateEdit";
            this.senior_expiryDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.senior_expiryDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.senior_expiryDateEdit.Size = new System.Drawing.Size(125, 20);
            this.senior_expiryDateEdit.TabIndex = 30;
            // 
            // isIFCheckEdit
            // 
            this.isIFCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "isIF", true));
            this.isIFCheckEdit.Location = new System.Drawing.Point(26, 24);
            this.isIFCheckEdit.Name = "isIFCheckEdit";
            this.isIFCheckEdit.Properties.Caption = "IF2";
            this.isIFCheckEdit.Size = new System.Drawing.Size(58, 19);
            this.isIFCheckEdit.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iFArrearsLabel);
            this.groupBox1.Controls.Add(this.iFArrearsSpinEdit);
            this.groupBox1.Controls.Add(iFBalanceLabel);
            this.groupBox1.Controls.Add(this.iFBalanceSpinEdit);
            this.groupBox1.Controls.Add(this.isIFCheckEdit);
            this.groupBox1.Location = new System.Drawing.Point(511, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 142);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation Fee";
            // 
            // iFArrearsSpinEdit
            // 
            this.iFArrearsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "IFArrears", true));
            this.iFArrearsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFArrearsSpinEdit.Location = new System.Drawing.Point(105, 96);
            this.iFArrearsSpinEdit.Name = "iFArrearsSpinEdit";
            this.iFArrearsSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.iFArrearsSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.iFArrearsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.iFArrearsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFArrearsSpinEdit.TabIndex = 33;
            // 
            // iFBalanceSpinEdit
            // 
            this.iFBalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "IFBalance", true));
            this.iFBalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFBalanceSpinEdit.Location = new System.Drawing.Point(105, 60);
            this.iFBalanceSpinEdit.Name = "iFBalanceSpinEdit";
            this.iFBalanceSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.iFBalanceSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.iFBalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.iFBalanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFBalanceSpinEdit.TabIndex = 32;
            // 
            // rdg_presSpinEdit
            // 
            this.rdg_presSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "rdg_pres", true));
            this.rdg_presSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rdg_presSpinEdit.Location = new System.Drawing.Point(632, 69);
            this.rdg_presSpinEdit.Name = "rdg_presSpinEdit";
            this.rdg_presSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.rdg_presSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rdg_presSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.rdg_presSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.rdg_presSpinEdit.TabIndex = 33;
            // 
            // last_read_dateDateEdit
            // 
            this.last_read_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_read_date", true));
            this.last_read_dateDateEdit.EditValue = null;
            this.last_read_dateDateEdit.Location = new System.Drawing.Point(666, 105);
            this.last_read_dateDateEdit.Name = "last_read_dateDateEdit";
            this.last_read_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_read_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_read_dateDateEdit.Size = new System.Drawing.Size(125, 20);
            this.last_read_dateDateEdit.TabIndex = 34;
            // 
            // prev_read_dateDateEdit
            // 
            this.prev_read_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "prev_read_date", true));
            this.prev_read_dateDateEdit.EditValue = null;
            this.prev_read_dateDateEdit.Location = new System.Drawing.Point(666, 137);
            this.prev_read_dateDateEdit.Name = "prev_read_dateDateEdit";
            this.prev_read_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.prev_read_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prev_read_dateDateEdit.Size = new System.Drawing.Size(125, 20);
            this.prev_read_dateDateEdit.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(249, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 29);
            this.button4.TabIndex = 37;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // last_edit_dateDateEdit
            // 
            this.last_edit_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_edit_date", true));
            this.last_edit_dateDateEdit.EditValue = null;
            this.last_edit_dateDateEdit.Location = new System.Drawing.Point(118, 364);
            this.last_edit_dateDateEdit.Name = "last_edit_dateDateEdit";
            this.last_edit_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_edit_dateDateEdit.Properties.ReadOnly = true;
            this.last_edit_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.last_edit_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.last_edit_dateDateEdit.TabIndex = 39;
            // 
            // last_edit_byTextEdit
            // 
            this.last_edit_byTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterBindingSource, "last_edit_by", true));
            this.last_edit_byTextEdit.Location = new System.Drawing.Point(322, 366);
            this.last_edit_byTextEdit.Name = "last_edit_byTextEdit";
            this.last_edit_byTextEdit.Properties.ReadOnly = true;
            this.last_edit_byTextEdit.Size = new System.Drawing.Size(88, 20);
            this.last_edit_byTextEdit.TabIndex = 41;
            // 
            // formMasterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 464);
            this.Controls.Add(last_edit_byLabel);
            this.Controls.Add(this.last_edit_byTextEdit);
            this.Controls.Add(last_edit_dateLabel);
            this.Controls.Add(this.last_edit_dateDateEdit);
            this.Controls.Add(this.button4);
            this.Controls.Add(prev_read_dateLabel);
            this.Controls.Add(this.prev_read_dateDateEdit);
            this.Controls.Add(last_read_dateLabel);
            this.Controls.Add(this.last_read_dateDateEdit);
            this.Controls.Add(rdg_presLabel);
            this.Controls.Add(this.rdg_presSpinEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(senior_expiryLabel);
            this.Controls.Add(this.senior_expiryDateEdit);
            this.Controls.Add(this.isSeniorCheckEdit);
            this.Controls.Add(date_installedLabel);
            this.Controls.Add(this.date_installedDateEdit);
            this.Controls.Add(last_reco_dateLabel);
            this.Controls.Add(this.last_reco_dateDateEdit);
            this.Controls.Add(last_disco_dateLabel);
            this.Controls.Add(this.last_disco_dateDateEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(meternoLabel);
            this.Controls.Add(this.meternoTextEdit);
            this.Controls.Add(zone_nameLabel);
            this.Controls.Add(this.zone_nameComboBox);
            this.Controls.Add(cardnoLabel);
            this.Controls.Add(this.cardnoSpinEdit);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categorySpinEdit);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.meter_idSpinEdit);
            this.Controls.Add(this.master_idSpinEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMasterEditor";
            this.Text = "Master Editor";
            this.Load += new System.EventHandler(this.formMasterEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMetersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meternoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_disco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_reco_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_installedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAccts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAcctsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSeniorCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_expiryDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_expiryDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isIFCheckEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_presSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_read_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_read_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_read_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_edit_byTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.Label label1;
        private dsMaster dsMaster;
        private System.Windows.Forms.BindingSource tbMasterBindingSource;
        private dsMasterTableAdapters.tbMasterTableAdapter tbMasterTableAdapter;
        private dsMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.SpinEdit categorySpinEdit;
        private DevExpress.XtraEditors.SpinEdit cardnoSpinEdit;
        private dsZone dsZone;
        private System.Windows.Forms.BindingSource tbZoneBindingSource;
        private dsZoneTableAdapters.tbZoneTableAdapter tbZoneTableAdapter;
        private dsZoneTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox zone_nameComboBox;
        private dsMeters dsMeters;
        private System.Windows.Forms.BindingSource tbMetersBindingSource;
        private dsMetersTableAdapters.tbMetersTableAdapter tbMetersTableAdapter;
        private dsMetersTableAdapters.TableAdapterManager tableAdapterManager2;
        private DevExpress.XtraEditors.TextEdit meternoTextEdit;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SpinEdit master_idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit meter_idSpinEdit;
        private DevExpress.XtraEditors.TextEdit statusTextEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.DateEdit last_disco_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit last_reco_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit date_installedDateEdit;
        private dsMasterAccts dsMasterAccts;
        private System.Windows.Forms.BindingSource tbMasterAcctsBindingSource;
        private dsMasterAcctsTableAdapters.tbMasterAcctsTableAdapter tbMasterAcctsTableAdapter;
        private dsMasterAcctsTableAdapters.TableAdapterManager tableAdapterManager3;
        private DevExpress.XtraEditors.CheckEdit isSeniorCheckEdit;
        private DevExpress.XtraEditors.DateEdit senior_expiryDateEdit;
        private DevExpress.XtraEditors.CheckEdit isIFCheckEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit iFArrearsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit iFBalanceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit rdg_presSpinEdit;
        private DevExpress.XtraEditors.DateEdit last_read_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit prev_read_dateDateEdit;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraEditors.DateEdit last_edit_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit last_edit_byTextEdit;
    }
}