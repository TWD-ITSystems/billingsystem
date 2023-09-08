namespace BillingSystem
{
    partial class formManualBillEncode
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBillMonth;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel2;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtBilledDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboZone = new System.Windows.Forms.ComboBox();
            this.tbZoneLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZoneLookup = new BillingSystem.dsZoneLookup();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBillMonth = new System.Windows.Forms.ComboBox();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBilling = new BillingSystem.dsBilling();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbBillingTableAdapter = new BillingSystem.dsBillingTableAdapters.tbBillingTableAdapter();
            this.tbZoneLookupTableAdapter = new BillingSystem.dsZoneLookupTableAdapters.tbZoneLookupTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZoneLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtBilledDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboZone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.comboBillMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 60);
            this.panel1.TabIndex = 0;
            // 
            // dtBilledDate
            // 
            this.dtBilledDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBilledDate.Location = new System.Drawing.Point(663, 20);
            this.dtBilledDate.Name = "dtBilledDate";
            this.dtBilledDate.Size = new System.Drawing.Size(88, 20);
            this.dtBilledDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Billed :";
            // 
            // comboZone
            // 
            this.comboZone.DataSource = this.tbZoneLookupBindingSource;
            this.comboZone.DisplayMember = "zone_uid";
            this.comboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZone.FormattingEnabled = true;
            this.comboZone.Location = new System.Drawing.Point(346, 18);
            this.comboZone.Name = "comboZone";
            this.comboZone.Size = new System.Drawing.Size(73, 21);
            this.comboZone.TabIndex = 4;
            this.comboZone.ValueMember = "zone_lookup_id";
            this.comboZone.SelectedIndexChanged += new System.EventHandler(this.comboZone_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Zone :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(442, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 28);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Bill File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboBillMonth
            // 
            this.comboBillMonth.DataSource = this.tbBillingBindingSource;
            this.comboBillMonth.DisplayMember = "billing_desc";
            this.comboBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBillMonth.FormattingEnabled = true;
            this.comboBillMonth.Location = new System.Drawing.Point(140, 18);
            this.comboBillMonth.Name = "comboBillMonth";
            this.comboBillMonth.Size = new System.Drawing.Size(91, 21);
            this.comboBillMonth.TabIndex = 1;
            this.comboBillMonth.ValueMember = "billing_id";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataMember = "tbBilling";
            this.tbBillingBindingSource.DataSource = this.dsBilling;
            // 
            // dsBilling
            // 
            this.dsBilling.DataSetName = "dsBilling";
            this.dsBilling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select BillMonth :";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint.Location = new System.Drawing.Point(604, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(148, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Export Bill File for Update";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnAddEntry);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 52);
            this.panel2.TabIndex = 1;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(140, 12);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(103, 28);
            this.btnAddEntry.TabIndex = 9;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Visible = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(930, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(787, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbBillingTableAdapter
            // 
            this.tbBillingTableAdapter.ClearBeforeFill = true;
            // 
            // tbZoneLookupTableAdapter
            // 
            this.tbZoneLookupTableAdapter.ClearBeforeFill = true;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radGridView1.Location = new System.Drawing.Point(0, 60);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "...";
            gridViewCheckBoxColumn2.Name = "column4";
            gridViewCheckBoxColumn2.Width = 40;
            gridViewTextBoxColumn19.AllowHide = false;
            gridViewTextBoxColumn19.FormatString = "";
            gridViewTextBoxColumn19.HeaderText = "Account No";
            gridViewTextBoxColumn19.Name = "column1";
            gridViewTextBoxColumn19.ReadOnly = true;
            gridViewTextBoxColumn19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn19.Width = 90;
            gridViewTextBoxColumn20.FormatString = "";
            gridViewTextBoxColumn20.HeaderText = "Name";
            gridViewTextBoxColumn20.Name = "column2";
            gridViewTextBoxColumn20.ReadOnly = true;
            gridViewTextBoxColumn20.Width = 250;
            gridViewTextBoxColumn21.FormatString = "";
            gridViewTextBoxColumn21.HeaderText = "Prev Rdg";
            gridViewTextBoxColumn21.Name = "column3";
            gridViewTextBoxColumn21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn21.Width = 80;
            gridViewTextBoxColumn22.AcceptsReturn = true;
            gridViewTextBoxColumn22.AcceptsTab = true;
            gridViewTextBoxColumn22.FormatString = "";
            gridViewTextBoxColumn22.HeaderText = "Pres Rdg";
            gridViewTextBoxColumn22.Name = "column5";
            gridViewTextBoxColumn22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.Width = 80;
            gridViewTextBoxColumn23.FormatString = "";
            gridViewTextBoxColumn23.HeaderText = "ID";
            gridViewTextBoxColumn23.IsVisible = false;
            gridViewTextBoxColumn23.Name = "column6";
            gridViewTextBoxColumn24.HeaderText = "Date Prev";
            gridViewTextBoxColumn24.Name = "column15";
            gridViewTextBoxColumn25.HeaderText = "Date Pres";
            gridViewTextBoxColumn25.Name = "column16";
            gridViewTextBoxColumn26.FormatString = "";
            gridViewTextBoxColumn26.HeaderText = "Volume";
            gridViewTextBoxColumn26.Name = "column7";
            gridViewTextBoxColumn26.ReadOnly = true;
            gridViewTextBoxColumn26.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn26.Width = 80;
            gridViewTextBoxColumn27.FormatString = "";
            gridViewTextBoxColumn27.HeaderText = "Current";
            gridViewTextBoxColumn27.Name = "column10";
            gridViewTextBoxColumn27.Width = 80;
            gridViewTextBoxColumn28.FormatString = "";
            gridViewTextBoxColumn28.HeaderText = "Arrears";
            gridViewTextBoxColumn28.Name = "column11";
            gridViewTextBoxColumn28.Width = 80;
            gridViewTextBoxColumn29.FormatString = "";
            gridViewTextBoxColumn29.HeaderText = "Inst Fee";
            gridViewTextBoxColumn29.Name = "column12";
            gridViewTextBoxColumn29.Width = 80;
            gridViewTextBoxColumn30.HeaderText = "Total Bill";
            gridViewTextBoxColumn30.Name = "column13";
            gridViewTextBoxColumn30.Width = 80;
            gridViewTextBoxColumn31.HeaderText = "Penalty";
            gridViewTextBoxColumn31.Name = "column17";
            gridViewTextBoxColumn32.HeaderText = "Cardno";
            gridViewTextBoxColumn32.Name = "column8";
            gridViewTextBoxColumn32.ReadOnly = true;
            gridViewTextBoxColumn32.Width = 80;
            gridViewTextBoxColumn33.HeaderText = "Zone";
            gridViewTextBoxColumn33.Name = "column9";
            gridViewTextBoxColumn33.ReadOnly = true;
            gridViewTextBoxColumn33.Width = 60;
            gridViewTextBoxColumn34.HeaderText = "masterID";
            gridViewTextBoxColumn34.Name = "column14";
            gridViewTextBoxColumn35.HeaderText = "Encoder";
            gridViewTextBoxColumn35.Name = "column18";
            gridViewTextBoxColumn36.HeaderText = "BillingDate";
            gridViewTextBoxColumn36.Name = "column19";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34,
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36});
            this.radGridView1.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(1061, 433);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "d";
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // formManualBillEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 545);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formManualBillEncode";
            this.Text = "Manual Billing";
            this.Load += new System.EventHandler(this.formManualBillEncode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoneLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZoneLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBilling)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsBilling dsBilling;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private dsBillingTableAdapters.tbBillingTableAdapter tbBillingTableAdapter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboZone;
        private dsZoneLookup dsZoneLookup;
        private System.Windows.Forms.BindingSource tbZoneLookupBindingSource;
        private dsZoneLookupTableAdapters.tbZoneLookupTableAdapter tbZoneLookupTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.DateTimePicker dtBilledDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}