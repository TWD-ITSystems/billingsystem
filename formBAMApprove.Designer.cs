namespace BillingSystem
{
    partial class formBAMApprove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBAMApprove));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwBAMEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBAMEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBAMEntries = new BillingSystem.dsBAMEntries();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbamdetail_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbam_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbamno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcase_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwBAMEntriesTableAdapter = new BillingSystem.dsBAMEntriesTableAdapters.vwBAMEntriesTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBAMEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 49);
            this.toolStripButton1.Text = "       View      ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 333);
            this.panel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwBAMEntriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(783, 333);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwBAMEntriesBindingSource
            // 
            this.vwBAMEntriesBindingSource.DataMember = "vwBAMEntries";
            this.vwBAMEntriesBindingSource.DataSource = this.dsBAMEntriesBindingSource;
            this.vwBAMEntriesBindingSource.Filter = "processed=0";
            // 
            // dsBAMEntriesBindingSource
            // 
            this.dsBAMEntriesBindingSource.DataSource = this.dsBAMEntries;
            this.dsBAMEntriesBindingSource.Filter = "";
            this.dsBAMEntriesBindingSource.Position = 0;
            // 
            // dsBAMEntries
            // 
            this.dsBAMEntries.DataSetName = "dsBAMEntries";
            this.dsBAMEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbamdetail_id,
            this.colbam_date,
            this.colbamno,
            this.colacctno,
            this.colacctname,
            this.colcase_desc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.RowHeight = 30;
            // 
            // colbamdetail_id
            // 
            this.colbamdetail_id.FieldName = "bamdetail_id";
            this.colbamdetail_id.Name = "colbamdetail_id";
            this.colbamdetail_id.Width = 30;
            // 
            // colbam_date
            // 
            this.colbam_date.Caption = "Date Prepared";
            this.colbam_date.FieldName = "bam_date";
            this.colbam_date.Name = "colbam_date";
            this.colbam_date.Visible = true;
            this.colbam_date.VisibleIndex = 0;
            this.colbam_date.Width = 100;
            // 
            // colbamno
            // 
            this.colbamno.Caption = "BAM No.";
            this.colbamno.FieldName = "bamno";
            this.colbamno.Name = "colbamno";
            this.colbamno.Visible = true;
            this.colbamno.VisibleIndex = 1;
            this.colbamno.Width = 100;
            // 
            // colacctno
            // 
            this.colacctno.Caption = "Account No.";
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 2;
            this.colacctno.Width = 100;
            // 
            // colacctname
            // 
            this.colacctname.Caption = "Concessioner";
            this.colacctname.FieldName = "acctname";
            this.colacctname.Name = "colacctname";
            this.colacctname.Visible = true;
            this.colacctname.VisibleIndex = 3;
            this.colacctname.Width = 200;
            // 
            // colcase_desc
            // 
            this.colcase_desc.Caption = "BAM Case";
            this.colcase_desc.FieldName = "case_desc";
            this.colcase_desc.Name = "colcase_desc";
            this.colcase_desc.Visible = true;
            this.colcase_desc.VisibleIndex = 4;
            this.colcase_desc.Width = 265;
            // 
            // vwBAMEntriesTableAdapter
            // 
            this.vwBAMEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // formBAMApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBAMApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outstanding BAMs";
            this.Load += new System.EventHandler(this.formBAMApprove_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBAMEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource dsBAMEntriesBindingSource;
        private dsBAMEntries dsBAMEntries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vwBAMEntriesBindingSource;
        private dsBAMEntriesTableAdapters.vwBAMEntriesTableAdapter vwBAMEntriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colbamdetail_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbamno;
        private DevExpress.XtraGrid.Columns.GridColumn colbam_date;
        private DevExpress.XtraGrid.Columns.GridColumn colacctname;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colcase_desc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}