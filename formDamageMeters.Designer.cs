namespace BillingSystem
{
    partial class formDamageMeters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDamageMeters));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbDMTRAccntsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDMTR = new BillingSystem.dsDMTR();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldmtr_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMtrDmg_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMtrDmg_Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMtrDmg_Monthly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoded_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoded_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbDMTRAccntsTableAdapter = new BillingSystem.dsDMTRTableAdapters.tbDMTRAccntsTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMTRAccntsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDMTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 49);
            this.toolStripButton1.Text = "     New    ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 49);
            this.toolStripButton3.Text = "     Print    ";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbDMTRAccntsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 417);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbDMTRAccntsBindingSource
            // 
            this.tbDMTRAccntsBindingSource.DataMember = "tbDMTRAccnts";
            this.tbDMTRAccntsBindingSource.DataSource = this.dsDMTR;
            // 
            // dsDMTR
            // 
            this.dsDMTR.DataSetName = "dsDMTR";
            this.dsDMTR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldmtr_id,
            this.colmaster_id,
            this.colacctno,
            this.colname,
            this.coladdress,
            this.colMtrDmg_Amount,
            this.colMtrDmg_Balance,
            this.colMtrDmg_Monthly,
            this.colencoded_date,
            this.colencoded_by});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // coldmtr_id
            // 
            this.coldmtr_id.FieldName = "dmtr_id";
            this.coldmtr_id.Name = "coldmtr_id";
            this.coldmtr_id.OptionsColumn.ReadOnly = true;
            // 
            // colmaster_id
            // 
            this.colmaster_id.FieldName = "master_id";
            this.colmaster_id.Name = "colmaster_id";
            // 
            // colacctno
            // 
            this.colacctno.Caption = "AcctNo";
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 0;
            this.colacctno.Width = 60;
            // 
            // colname
            // 
            this.colname.Caption = "Concessionaire";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 150;
            // 
            // coladdress
            // 
            this.coladdress.Caption = "Address";
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 2;
            this.coladdress.Width = 250;
            // 
            // colMtrDmg_Amount
            // 
            this.colMtrDmg_Amount.Caption = "Amount";
            this.colMtrDmg_Amount.FieldName = "MtrDmg_Amount";
            this.colMtrDmg_Amount.Name = "colMtrDmg_Amount";
            this.colMtrDmg_Amount.Visible = true;
            this.colMtrDmg_Amount.VisibleIndex = 3;
            this.colMtrDmg_Amount.Width = 60;
            // 
            // colMtrDmg_Balance
            // 
            this.colMtrDmg_Balance.Caption = "Balance";
            this.colMtrDmg_Balance.FieldName = "MtrDmg_Balance";
            this.colMtrDmg_Balance.Name = "colMtrDmg_Balance";
            this.colMtrDmg_Balance.Visible = true;
            this.colMtrDmg_Balance.VisibleIndex = 4;
            this.colMtrDmg_Balance.Width = 60;
            // 
            // colMtrDmg_Monthly
            // 
            this.colMtrDmg_Monthly.Caption = "Monthly";
            this.colMtrDmg_Monthly.FieldName = "MtrDmg_Monthly";
            this.colMtrDmg_Monthly.Name = "colMtrDmg_Monthly";
            this.colMtrDmg_Monthly.Visible = true;
            this.colMtrDmg_Monthly.VisibleIndex = 5;
            this.colMtrDmg_Monthly.Width = 60;
            // 
            // colencoded_date
            // 
            this.colencoded_date.Caption = "EncodedDate";
            this.colencoded_date.FieldName = "encoded_date";
            this.colencoded_date.Name = "colencoded_date";
            this.colencoded_date.Visible = true;
            this.colencoded_date.VisibleIndex = 6;
            this.colencoded_date.Width = 60;
            // 
            // colencoded_by
            // 
            this.colencoded_by.Caption = "EncodedBy";
            this.colencoded_by.FieldName = "encoded_by";
            this.colencoded_by.Name = "colencoded_by";
            this.colencoded_by.Visible = true;
            this.colencoded_by.VisibleIndex = 7;
            this.colencoded_by.Width = 73;
            // 
            // tbDMTRAccntsTableAdapter
            // 
            this.tbDMTRAccntsTableAdapter.ClearBeforeFill = true;
            // 
            // formDamageMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formDamageMeters";
            this.Text = "Damage/Stolen Meters Menu";
            this.Load += new System.EventHandler(this.formDamageMeters_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMTRAccntsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDMTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private dsDMTR dsDMTR;
        private System.Windows.Forms.BindingSource tbDMTRAccntsBindingSource;
        private dsDMTRTableAdapters.tbDMTRAccntsTableAdapter tbDMTRAccntsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldmtr_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colMtrDmg_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colMtrDmg_Balance;
        private DevExpress.XtraGrid.Columns.GridColumn colMtrDmg_Monthly;
        private DevExpress.XtraGrid.Columns.GridColumn colencoded_date;
        private DevExpress.XtraGrid.Columns.GridColumn colencoded_by;
    }
}