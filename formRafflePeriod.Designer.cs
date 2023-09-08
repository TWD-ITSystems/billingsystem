namespace BillingSystem
{
    partial class formRafflePeriod
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDrawDate = new System.Windows.Forms.DateTimePicker();
            this.dtCutOff = new System.Windows.Forms.DateTimePicker();
            this.txCoverage = new System.Windows.Forms.TextBox();
            this.txDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToTable = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbRafflePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRafflePeriod = new BillingSystem.dbRafflePeriod();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colraffle_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colraffle_period = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcutoff_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldraw_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladded_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladded_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenerated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqualified_entries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbRafflePeriodTableAdapter = new BillingSystem.dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txRemarks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtDrawDate);
            this.panel1.Controls.Add(this.dtCutOff);
            this.panel1.Controls.Add(this.txCoverage);
            this.panel1.Controls.Add(this.txDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddToTable);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 163);
            this.panel1.TabIndex = 0;
            // 
            // txRemarks
            // 
            this.txRemarks.Location = new System.Drawing.Point(386, 10);
            this.txRemarks.Multiline = true;
            this.txRemarks.Name = "txRemarks";
            this.txRemarks.Size = new System.Drawing.Size(360, 54);
            this.txRemarks.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remarks:";
            // 
            // dtDrawDate
            // 
            this.dtDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDrawDate.Location = new System.Drawing.Point(108, 89);
            this.dtDrawDate.Name = "dtDrawDate";
            this.dtDrawDate.Size = new System.Drawing.Size(85, 20);
            this.dtDrawDate.TabIndex = 9;
            // 
            // dtCutOff
            // 
            this.dtCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCutOff.Location = new System.Drawing.Point(108, 63);
            this.dtCutOff.Name = "dtCutOff";
            this.dtCutOff.Size = new System.Drawing.Size(85, 20);
            this.dtCutOff.TabIndex = 8;
            // 
            // txCoverage
            // 
            this.txCoverage.Location = new System.Drawing.Point(108, 37);
            this.txCoverage.Name = "txCoverage";
            this.txCoverage.Size = new System.Drawing.Size(202, 20);
            this.txCoverage.TabIndex = 7;
            // 
            // txDescription
            // 
            this.txDescription.Location = new System.Drawing.Point(108, 11);
            this.txDescription.Name = "txDescription";
            this.txDescription.Size = new System.Drawing.Size(202, 20);
            this.txDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Draw Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cut-off Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coverage Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description :";
            // 
            // btnAddToTable
            // 
            this.btnAddToTable.Location = new System.Drawing.Point(225, 126);
            this.btnAddToTable.Name = "btnAddToTable";
            this.btnAddToTable.Size = new System.Drawing.Size(103, 23);
            this.btnAddToTable.TabIndex = 1;
            this.btnAddToTable.Text = "Save to Database";
            this.btnAddToTable.UseVisualStyleBackColor = true;
            this.btnAddToTable.Click += new System.EventHandler(this.btnAddToTable_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(108, 126);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tbRafflePeriodBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 181);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(755, 264);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbRafflePeriodBindingSource
            // 
            this.tbRafflePeriodBindingSource.DataMember = "tbRafflePeriod";
            this.tbRafflePeriodBindingSource.DataSource = this.dbRafflePeriod;
            // 
            // dbRafflePeriod
            // 
            this.dbRafflePeriod.DataSetName = "dbRafflePeriod";
            this.dbRafflePeriod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colraffle_description,
            this.colraffle_period,
            this.colcutoff_date,
            this.coldraw_date,
            this.coladded_date,
            this.coladded_by,
            this.colgenerated_date,
            this.colqualified_entries,
            this.colremarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colraffle_description
            // 
            this.colraffle_description.Caption = "Description";
            this.colraffle_description.FieldName = "raffle_description";
            this.colraffle_description.Name = "colraffle_description";
            this.colraffle_description.Visible = true;
            this.colraffle_description.VisibleIndex = 0;
            this.colraffle_description.Width = 120;
            // 
            // colraffle_period
            // 
            this.colraffle_period.Caption = "Covered Period";
            this.colraffle_period.FieldName = "raffle_period";
            this.colraffle_period.Name = "colraffle_period";
            this.colraffle_period.Visible = true;
            this.colraffle_period.VisibleIndex = 1;
            this.colraffle_period.Width = 120;
            // 
            // colcutoff_date
            // 
            this.colcutoff_date.Caption = "Cut-off Date";
            this.colcutoff_date.FieldName = "cutoff_date";
            this.colcutoff_date.Name = "colcutoff_date";
            this.colcutoff_date.Visible = true;
            this.colcutoff_date.VisibleIndex = 2;
            this.colcutoff_date.Width = 83;
            // 
            // coldraw_date
            // 
            this.coldraw_date.Caption = "Draw Date";
            this.coldraw_date.FieldName = "draw_date";
            this.coldraw_date.Name = "coldraw_date";
            this.coldraw_date.Visible = true;
            this.coldraw_date.VisibleIndex = 3;
            this.coldraw_date.Width = 69;
            // 
            // coladded_date
            // 
            this.coladded_date.Caption = "Date Added";
            this.coladded_date.FieldName = "added_date";
            this.coladded_date.Name = "coladded_date";
            this.coladded_date.Visible = true;
            this.coladded_date.VisibleIndex = 4;
            this.coladded_date.Width = 69;
            // 
            // coladded_by
            // 
            this.coladded_by.Caption = "Added by";
            this.coladded_by.FieldName = "added_by";
            this.coladded_by.Name = "coladded_by";
            this.coladded_by.Visible = true;
            this.coladded_by.VisibleIndex = 5;
            this.coladded_by.Width = 69;
            // 
            // colgenerated_date
            // 
            this.colgenerated_date.Caption = "Date Generated";
            this.colgenerated_date.FieldName = "generated_date";
            this.colgenerated_date.Name = "colgenerated_date";
            this.colgenerated_date.Visible = true;
            this.colgenerated_date.VisibleIndex = 6;
            this.colgenerated_date.Width = 69;
            // 
            // colqualified_entries
            // 
            this.colqualified_entries.Caption = "Qualified Entries";
            this.colqualified_entries.FieldName = "qualified_entries";
            this.colqualified_entries.Name = "colqualified_entries";
            this.colqualified_entries.Visible = true;
            this.colqualified_entries.VisibleIndex = 7;
            this.colqualified_entries.Width = 69;
            // 
            // colremarks
            // 
            this.colremarks.Caption = "Remarks";
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 8;
            this.colremarks.Width = 69;
            // 
            // tbRafflePeriodTableAdapter
            // 
            this.tbRafflePeriodTableAdapter.ClearBeforeFill = true;
            // 
            // formRafflePeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 457);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "formRafflePeriod";
            this.Text = "Raffle Period";
            this.Load += new System.EventHandler(this.formRafflePeriod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToTable;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDrawDate;
        private System.Windows.Forms.DateTimePicker dtCutOff;
        private System.Windows.Forms.TextBox txCoverage;
        private System.Windows.Forms.TextBox txDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txRemarks;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colraffle_description;
        private DevExpress.XtraGrid.Columns.GridColumn colraffle_period;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private DevExpress.XtraGrid.Columns.GridColumn colcutoff_date;
        private DevExpress.XtraGrid.Columns.GridColumn coldraw_date;
        private DevExpress.XtraGrid.Columns.GridColumn coladded_date;
        private DevExpress.XtraGrid.Columns.GridColumn coladded_by;
        private DevExpress.XtraGrid.Columns.GridColumn colqualified_entries;
        private DevExpress.XtraGrid.Columns.GridColumn colgenerated_date;
        private dbRafflePeriod dbRafflePeriod;
        private System.Windows.Forms.BindingSource tbRafflePeriodBindingSource;
        private dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter tbRafflePeriodTableAdapter;

    }
}