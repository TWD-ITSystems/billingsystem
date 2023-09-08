namespace BillingSystem
{
    partial class formBillingSchedule
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
            System.Windows.Forms.Label bill_nameLabel;
            System.Windows.Forms.Label billing_idLabel;
            System.Windows.Forms.Label date_bill_startLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.tbBillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbill_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_bill_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_bill_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaded_to_zones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.total_daysTextBox = new System.Windows.Forms.TextBox();
            this.total_arrears_amountTextBox = new System.Windows.Forms.TextBox();
            this.total_bill_amountTextBox = new System.Windows.Forms.TextBox();
            this.num_of_bills_arrearsTextBox = new System.Windows.Forms.TextBox();
            this.num_of_bills_processedTextBox = new System.Windows.Forms.TextBox();
            this.billing_descTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.billing_endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.billing_startDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.billing_idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.loaded_to_zonesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            bill_nameLabel = new System.Windows.Forms.Label();
            billing_idLabel = new System.Windows.Forms.Label();
            date_bill_startLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_descTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaded_to_zonesCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_nameLabel
            // 
            bill_nameLabel.AutoSize = true;
            bill_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_nameLabel.Location = new System.Drawing.Point(7, 68);
            bill_nameLabel.Name = "bill_nameLabel";
            bill_nameLabel.Size = new System.Drawing.Size(128, 17);
            bill_nameLabel.TabIndex = 0;
            bill_nameLabel.Text = "Billing Description :";
            // 
            // billing_idLabel
            // 
            billing_idLabel.AutoSize = true;
            billing_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            billing_idLabel.Location = new System.Drawing.Point(180, 30);
            billing_idLabel.Name = "billing_idLabel";
            billing_idLabel.Size = new System.Drawing.Size(70, 17);
            billing_idLabel.TabIndex = 2;
            billing_idLabel.Text = "Billing ID :";
            // 
            // date_bill_startLabel
            // 
            date_bill_startLabel.AutoSize = true;
            date_bill_startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_bill_startLabel.Location = new System.Drawing.Point(90, 102);
            date_bill_startLabel.Name = "date_bill_startLabel";
            date_bill_startLabel.Size = new System.Drawing.Size(56, 17);
            date_bill_startLabel.TabIndex = 4;
            date_bill_startLabel.Text = "FROM :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(230, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 17);
            label1.TabIndex = 6;
            label1.Text = "TO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(18, 246);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 17);
            label2.TabIndex = 13;
            label2.Text = "No. of Bills Processed :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(20, 282);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 17);
            label3.TabIndex = 15;
            label3.Text = "No. of Bills w/ Arrears :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(71, 317);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 17);
            label4.TabIndex = 17;
            label4.Text = "Total Amount :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(72, 349);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 17);
            label5.TabIndex = 19;
            label5.Text = "Total Arrears :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(81, 387);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 17);
            label6.TabIndex = 21;
            label6.Text = "No. of Days :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(18, 149);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 17);
            label7.TabIndex = 23;
            label7.Text = "Remarks :";
            // 
            // tbBillingBindingSource
            // 
            this.tbBillingBindingSource.DataSource = typeof(BillingSystem.tbBilling);
            this.tbBillingBindingSource.PositionChanged += new System.EventHandler(this.tbBillingBindingSource_PositionChanged);
            // 
            // tbBillingGridControl
            // 
            this.tbBillingGridControl.DataSource = this.tbBillingBindingSource;
            this.tbBillingGridControl.Location = new System.Drawing.Point(0, 3);
            this.tbBillingGridControl.MainView = this.gridView1;
            this.tbBillingGridControl.Name = "tbBillingGridControl";
            this.tbBillingGridControl.Size = new System.Drawing.Size(366, 428);
            this.tbBillingGridControl.TabIndex = 1;
            this.tbBillingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbill_name,
            this.coldate_bill_start,
            this.coldate_bill_end,
            this.colloaded_to_zones});
            this.gridView1.GridControl = this.tbBillingGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colbill_name
            // 
            this.colbill_name.Caption = "Month";
            this.colbill_name.FieldName = "billing_desc";
            this.colbill_name.Name = "colbill_name";
            this.colbill_name.Visible = true;
            this.colbill_name.VisibleIndex = 0;
            // 
            // coldate_bill_start
            // 
            this.coldate_bill_start.Caption = "From";
            this.coldate_bill_start.FieldName = "billing_start";
            this.coldate_bill_start.Name = "coldate_bill_start";
            this.coldate_bill_start.Visible = true;
            this.coldate_bill_start.VisibleIndex = 1;
            // 
            // coldate_bill_end
            // 
            this.coldate_bill_end.Caption = "To";
            this.coldate_bill_end.FieldName = "billing_end";
            this.coldate_bill_end.Name = "coldate_bill_end";
            this.coldate_bill_end.Visible = true;
            this.coldate_bill_end.VisibleIndex = 2;
            // 
            // colloaded_to_zones
            // 
            this.colloaded_to_zones.Caption = "Loaded to Zones";
            this.colloaded_to_zones.FieldName = "loaded_to_zones";
            this.colloaded_to_zones.Name = "colloaded_to_zones";
            this.colloaded_to_zones.Visible = true;
            this.colloaded_to_zones.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.remarksTextEdit);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.total_daysTextBox);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.total_arrears_amountTextBox);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.total_bill_amountTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.num_of_bills_arrearsTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.num_of_bills_processedTextBox);
            this.groupBox1.Controls.Add(this.billing_descTextEdit);
            this.groupBox1.Controls.Add(this.billing_endDateEdit);
            this.groupBox1.Controls.Add(this.billing_startDateEdit);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(date_bill_startLabel);
            this.groupBox1.Controls.Add(billing_idLabel);
            this.groupBox1.Controls.Add(this.billing_idTextBox);
            this.groupBox1.Controls.Add(bill_nameLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(372, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Billing Information ]";
            // 
            // remarksTextEdit
            // 
            this.remarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "remarks", true));
            this.remarksTextEdit.Location = new System.Drawing.Point(21, 169);
            this.remarksTextEdit.Name = "remarksTextEdit";
            this.remarksTextEdit.Properties.AutoHeight = false;
            this.remarksTextEdit.Size = new System.Drawing.Size(332, 60);
            this.remarksTextEdit.TabIndex = 3;
            // 
            // total_daysTextBox
            // 
            this.total_daysTextBox.BackColor = System.Drawing.Color.White;
            this.total_daysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "total_days", true));
            this.total_daysTextBox.Location = new System.Drawing.Point(192, 384);
            this.total_daysTextBox.Name = "total_daysTextBox";
            this.total_daysTextBox.ReadOnly = true;
            this.total_daysTextBox.Size = new System.Drawing.Size(116, 20);
            this.total_daysTextBox.TabIndex = 20;
            this.total_daysTextBox.TabStop = false;
            // 
            // total_arrears_amountTextBox
            // 
            this.total_arrears_amountTextBox.BackColor = System.Drawing.Color.White;
            this.total_arrears_amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_arrears_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "total_arrears_amount", true));
            this.total_arrears_amountTextBox.Location = new System.Drawing.Point(192, 349);
            this.total_arrears_amountTextBox.Name = "total_arrears_amountTextBox";
            this.total_arrears_amountTextBox.ReadOnly = true;
            this.total_arrears_amountTextBox.Size = new System.Drawing.Size(116, 20);
            this.total_arrears_amountTextBox.TabIndex = 18;
            this.total_arrears_amountTextBox.TabStop = false;
            // 
            // total_bill_amountTextBox
            // 
            this.total_bill_amountTextBox.BackColor = System.Drawing.Color.White;
            this.total_bill_amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_bill_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "total_bill_amount", true));
            this.total_bill_amountTextBox.Location = new System.Drawing.Point(192, 314);
            this.total_bill_amountTextBox.Name = "total_bill_amountTextBox";
            this.total_bill_amountTextBox.ReadOnly = true;
            this.total_bill_amountTextBox.Size = new System.Drawing.Size(116, 20);
            this.total_bill_amountTextBox.TabIndex = 16;
            this.total_bill_amountTextBox.TabStop = false;
            // 
            // num_of_bills_arrearsTextBox
            // 
            this.num_of_bills_arrearsTextBox.BackColor = System.Drawing.Color.White;
            this.num_of_bills_arrearsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_of_bills_arrearsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "num_of_bills_arrears", true));
            this.num_of_bills_arrearsTextBox.Location = new System.Drawing.Point(192, 279);
            this.num_of_bills_arrearsTextBox.Name = "num_of_bills_arrearsTextBox";
            this.num_of_bills_arrearsTextBox.ReadOnly = true;
            this.num_of_bills_arrearsTextBox.Size = new System.Drawing.Size(116, 20);
            this.num_of_bills_arrearsTextBox.TabIndex = 14;
            this.num_of_bills_arrearsTextBox.TabStop = false;
            // 
            // num_of_bills_processedTextBox
            // 
            this.num_of_bills_processedTextBox.BackColor = System.Drawing.Color.White;
            this.num_of_bills_processedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_of_bills_processedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "num_of_bills_processed", true));
            this.num_of_bills_processedTextBox.Location = new System.Drawing.Point(192, 243);
            this.num_of_bills_processedTextBox.Name = "num_of_bills_processedTextBox";
            this.num_of_bills_processedTextBox.ReadOnly = true;
            this.num_of_bills_processedTextBox.Size = new System.Drawing.Size(116, 20);
            this.num_of_bills_processedTextBox.TabIndex = 12;
            this.num_of_bills_processedTextBox.TabStop = false;
            this.num_of_bills_processedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // billing_descTextEdit
            // 
            this.billing_descTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_desc", true));
            this.billing_descTextEdit.EnterMoveNextControl = true;
            this.billing_descTextEdit.Location = new System.Drawing.Point(141, 67);
            this.billing_descTextEdit.Name = "billing_descTextEdit";
            this.billing_descTextEdit.Size = new System.Drawing.Size(215, 20);
            this.billing_descTextEdit.TabIndex = 0;
            // 
            // billing_endDateEdit
            // 
            this.billing_endDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_end", true));
            this.billing_endDateEdit.EditValue = null;
            this.billing_endDateEdit.EnterMoveNextControl = true;
            this.billing_endDateEdit.Location = new System.Drawing.Point(192, 122);
            this.billing_endDateEdit.Name = "billing_endDateEdit";
            this.billing_endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_endDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_endDateEdit.Size = new System.Drawing.Size(116, 20);
            this.billing_endDateEdit.TabIndex = 2;
            // 
            // billing_startDateEdit
            // 
            this.billing_startDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "billing_start", true));
            this.billing_startDateEdit.EditValue = null;
            this.billing_startDateEdit.EnterMoveNextControl = true;
            this.billing_startDateEdit.Location = new System.Drawing.Point(59, 122);
            this.billing_startDateEdit.Name = "billing_startDateEdit";
            this.billing_startDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.billing_startDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.billing_startDateEdit.Size = new System.Drawing.Size(116, 20);
            this.billing_startDateEdit.TabIndex = 1;
            // 
            // billing_idTextBox
            // 
            this.billing_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbBillingBindingSource, "billing_id", true));
            this.billing_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_idTextBox.Location = new System.Drawing.Point(256, 29);
            this.billing_idTextBox.Name = "billing_idTextBox";
            this.billing_idTextBox.ReadOnly = true;
            this.billing_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.billing_idTextBox.TabIndex = 3;
            this.billing_idTextBox.TabStop = false;
            this.billing_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(372, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(11, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(276, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(12, 447);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(111, 29);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load to Zones";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // loaded_to_zonesCheckEdit
            // 
            this.loaded_to_zonesCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbBillingBindingSource, "loaded_to_zones", true));
            this.loaded_to_zonesCheckEdit.Location = new System.Drawing.Point(10, 405);
            this.loaded_to_zonesCheckEdit.Name = "loaded_to_zonesCheckEdit";
            this.loaded_to_zonesCheckEdit.Properties.Caption = "checkEdit1";
            this.loaded_to_zonesCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.loaded_to_zonesCheckEdit.TabIndex = 10;
            this.loaded_to_zonesCheckEdit.TabStop = false;
            // 
            // formBillingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbBillingGridControl);
            this.Controls.Add(this.loaded_to_zonesCheckEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBillingSchedule";
            this.Text = " Billing Schedule";
            this.Load += new System.EventHandler(this.formBillingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_descTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_startDateEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loaded_to_zonesCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tbBillingBindingSource;
        private DevExpress.XtraGrid.GridControl tbBillingGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_bill_start;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_bill_end;
        private DevExpress.XtraGrid.Columns.GridColumn colbill_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox billing_idTextBox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colloaded_to_zones;
        private DevExpress.XtraEditors.DateEdit billing_endDateEdit;
        private DevExpress.XtraEditors.DateEdit billing_startDateEdit;
        private DevExpress.XtraEditors.TextEdit billing_descTextEdit;
        private DevExpress.XtraEditors.CheckEdit loaded_to_zonesCheckEdit;
        private System.Windows.Forms.TextBox num_of_bills_processedTextBox;
        private System.Windows.Forms.TextBox num_of_bills_arrearsTextBox;
        private System.Windows.Forms.TextBox total_bill_amountTextBox;
        private System.Windows.Forms.TextBox total_arrears_amountTextBox;
        private System.Windows.Forms.TextBox total_daysTextBox;
        private DevExpress.XtraEditors.TextEdit remarksTextEdit;
    }
}