namespace BillingSystem
{
    partial class formLoadSchedZones
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
            System.Windows.Forms.Label billing_descLabel;
            System.Windows.Forms.Label billing_startLabel;
            System.Windows.Forms.Label billing_endLabel;
            System.Windows.Forms.Label remarksLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.remarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billing_endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.billing_startDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.billing_descTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbBillingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingScheduleGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldate_rdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_bill_serve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_due_disco_arrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_due_disco_noarrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_due_office = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_due_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_gen_penalty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_download_agents = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            billing_descLabel = new System.Windows.Forms.Label();
            billing_startLabel = new System.Windows.Forms.Label();
            billing_endLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_descTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // billing_descLabel
            // 
            billing_descLabel.AutoSize = true;
            billing_descLabel.Location = new System.Drawing.Point(11, 28);
            billing_descLabel.Name = "billing_descLabel";
            billing_descLabel.Size = new System.Drawing.Size(96, 13);
            billing_descLabel.TabIndex = 0;
            billing_descLabel.Text = "Billing Description :";
            // 
            // billing_startLabel
            // 
            billing_startLabel.AutoSize = true;
            billing_startLabel.Location = new System.Drawing.Point(71, 54);
            billing_startLabel.Name = "billing_startLabel";
            billing_startLabel.Size = new System.Drawing.Size(36, 13);
            billing_startLabel.TabIndex = 2;
            billing_startLabel.Text = "From :";
            // 
            // billing_endLabel
            // 
            billing_endLabel.AutoSize = true;
            billing_endLabel.Location = new System.Drawing.Point(249, 54);
            billing_endLabel.Name = "billing_endLabel";
            billing_endLabel.Size = new System.Drawing.Size(26, 13);
            billing_endLabel.TabIndex = 4;
            billing_endLabel.Text = "To :";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(464, 28);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 6;
            remarksLabel.Text = "Remarks:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(remarksLabel);
            this.groupBox1.Controls.Add(this.remarksTextEdit);
            this.groupBox1.Controls.Add(billing_endLabel);
            this.groupBox1.Controls.Add(this.billing_endDateEdit);
            this.groupBox1.Controls.Add(billing_startLabel);
            this.groupBox1.Controls.Add(this.billing_startDateEdit);
            this.groupBox1.Controls.Add(billing_descLabel);
            this.groupBox1.Controls.Add(this.billing_descTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[  Billing Information  ]";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(332, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel Schedule";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(172, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Schedule";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(14, 79);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(128, 30);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load to Zones";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // remarksTextEdit
            // 
            this.remarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "remarks", true));
            this.remarksTextEdit.Location = new System.Drawing.Point(522, 23);
            this.remarksTextEdit.Name = "remarksTextEdit";
            this.remarksTextEdit.Properties.AutoHeight = false;
            this.remarksTextEdit.Properties.ReadOnly = true;
            this.remarksTextEdit.Size = new System.Drawing.Size(427, 76);
            this.remarksTextEdit.TabIndex = 7;
            this.remarksTextEdit.TabStop = false;
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataSource = typeof(BillingSystem.tbBilling);
            // 
            // billing_endDateEdit
            // 
            this.billing_endDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_end", true));
            this.billing_endDateEdit.EditValue = null;
            this.billing_endDateEdit.Location = new System.Drawing.Point(281, 51);
            this.billing_endDateEdit.Name = "billing_endDateEdit";
            this.billing_endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_endDateEdit.Properties.ReadOnly = true;
            this.billing_endDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_endDateEdit.Size = new System.Drawing.Size(107, 20);
            this.billing_endDateEdit.TabIndex = 5;
            this.billing_endDateEdit.TabStop = false;
            // 
            // billing_startDateEdit
            // 
            this.billing_startDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_start", true));
            this.billing_startDateEdit.EditValue = null;
            this.billing_startDateEdit.Location = new System.Drawing.Point(113, 51);
            this.billing_startDateEdit.Name = "billing_startDateEdit";
            this.billing_startDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_startDateEdit.Properties.ReadOnly = true;
            this.billing_startDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_startDateEdit.Size = new System.Drawing.Size(107, 20);
            this.billing_startDateEdit.TabIndex = 3;
            this.billing_startDateEdit.TabStop = false;
            // 
            // billing_descTextEdit
            // 
            this.billing_descTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_desc", true));
            this.billing_descTextEdit.Location = new System.Drawing.Point(113, 25);
            this.billing_descTextEdit.Name = "billing_descTextEdit";
            this.billing_descTextEdit.Properties.ReadOnly = true;
            this.billing_descTextEdit.Size = new System.Drawing.Size(275, 20);
            this.billing_descTextEdit.TabIndex = 1;
            this.billing_descTextEdit.TabStop = false;
            // 
            // tbBillingScheduleBindingSource
            // 
            this.tbBillingScheduleBindingSource.DataSource = typeof(BillingSystem.tbBillingSchedule);
            // 
            // tbBillingScheduleGridControl
            // 
            this.tbBillingScheduleGridControl.DataSource = this.tbBillingScheduleBindingSource;
            this.tbBillingScheduleGridControl.Location = new System.Drawing.Point(1, 155);
            this.tbBillingScheduleGridControl.MainView = this.gridView1;
            this.tbBillingScheduleGridControl.Name = "tbBillingScheduleGridControl";
            this.tbBillingScheduleGridControl.Size = new System.Drawing.Size(962, 323);
            this.tbBillingScheduleGridControl.TabIndex = 1;
            this.tbBillingScheduleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldate_rdg,
            this.coldate_bill_serve,
            this.coldate_due_disco_arrears,
            this.coldate_due_disco_noarrears,
            this.coldate_due_office,
            this.coldate_due_bank,
            this.coldate_gen_penalty,
            this.coldate_download_agents,
            this.colzone});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(803, 445, 208, 175);
            this.gridView1.GridControl = this.tbBillingScheduleGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldate_rdg
            // 
            this.coldate_rdg.Caption = "Reading Date";
            this.coldate_rdg.FieldName = "date_rdg";
            this.coldate_rdg.Name = "coldate_rdg";
            this.coldate_rdg.Visible = true;
            this.coldate_rdg.VisibleIndex = 1;
            // 
            // coldate_bill_serve
            // 
            this.coldate_bill_serve.Caption = "Bill Served";
            this.coldate_bill_serve.FieldName = "date_bill_serve";
            this.coldate_bill_serve.Name = "coldate_bill_serve";
            this.coldate_bill_serve.Visible = true;
            this.coldate_bill_serve.VisibleIndex = 2;
            // 
            // coldate_due_disco_arrears
            // 
            this.coldate_due_disco_arrears.Caption = "Disco w/ Arrears";
            this.coldate_due_disco_arrears.FieldName = "date_due_disco_arrears";
            this.coldate_due_disco_arrears.Name = "coldate_due_disco_arrears";
            this.coldate_due_disco_arrears.Visible = true;
            this.coldate_due_disco_arrears.VisibleIndex = 3;
            // 
            // coldate_due_disco_noarrears
            // 
            this.coldate_due_disco_noarrears.Caption = "Disco w/o Arrears";
            this.coldate_due_disco_noarrears.FieldName = "date_due_disco_noarrears";
            this.coldate_due_disco_noarrears.Name = "coldate_due_disco_noarrears";
            this.coldate_due_disco_noarrears.Visible = true;
            this.coldate_due_disco_noarrears.VisibleIndex = 4;
            // 
            // coldate_due_office
            // 
            this.coldate_due_office.Caption = "Current(Office)";
            this.coldate_due_office.FieldName = "date_due_office";
            this.coldate_due_office.Name = "coldate_due_office";
            this.coldate_due_office.Visible = true;
            this.coldate_due_office.VisibleIndex = 6;
            // 
            // coldate_due_bank
            // 
            this.coldate_due_bank.Caption = "Current(Bank)";
            this.coldate_due_bank.FieldName = "date_due_bank";
            this.coldate_due_bank.Name = "coldate_due_bank";
            this.coldate_due_bank.Visible = true;
            this.coldate_due_bank.VisibleIndex = 5;
            // 
            // coldate_gen_penalty
            // 
            this.coldate_gen_penalty.Caption = "Generate Penalty";
            this.coldate_gen_penalty.FieldName = "date_gen_penalty";
            this.coldate_gen_penalty.Name = "coldate_gen_penalty";
            this.coldate_gen_penalty.Visible = true;
            this.coldate_gen_penalty.VisibleIndex = 7;
            // 
            // coldate_download_agents
            // 
            this.coldate_download_agents.Caption = "Download to Agents";
            this.coldate_download_agents.FieldName = "date_download_agents";
            this.coldate_download_agents.Name = "coldate_download_agents";
            this.coldate_download_agents.Visible = true;
            this.coldate_download_agents.VisibleIndex = 8;
            // 
            // colzone
            // 
            this.colzone.AppearanceCell.Options.UseTextOptions = true;
            this.colzone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colzone.Caption = "Zone";
            this.colzone.FieldName = "zone";
            this.colzone.MaxWidth = 50;
            this.colzone.Name = "colzone";
            this.colzone.Visible = true;
            this.colzone.VisibleIndex = 0;
            this.colzone.Width = 50;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUE DATES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLoadSchedZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBillingScheduleGridControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoadSchedZones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Schedule to Zones";
            this.Load += new System.EventHandler(this.formLoadSchedZones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_descTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingScheduleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit billing_descTextEdit;
        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private DevExpress.XtraEditors.DateEdit billing_endDateEdit;
        private DevExpress.XtraEditors.DateEdit billing_startDateEdit;
        private DevExpress.XtraEditors.TextEdit remarksTextEdit;
        private System.Windows.Forms.BindingSource tbBillingScheduleBindingSource;
        private DevExpress.XtraGrid.GridControl tbBillingScheduleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_rdg;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_bill_serve;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_due_disco_arrears;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_due_disco_noarrears;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_due_office;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_due_bank;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_gen_penalty;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_download_agents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colzone;
        private System.Windows.Forms.Button btnCancel;
    }
}