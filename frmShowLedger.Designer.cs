namespace BillingSystem
{
    partial class frmShowLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLedger));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLedger = new BillingSystem.dsLedger();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colledger_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrans_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colother = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tbMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster = new BillingSystem.dsMaster();
            this.labelAcctNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLedgerTableAdapter = new BillingSystem.dsLedgerTableAdapters.tbLedgerTableAdapter();
            this.tbMasterTableAdapter = new BillingSystem.dsMasterTableAdapters.tbMasterTableAdapter();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridControl1);
            this.mainPanel.Controls.Add(this.panelTop);
            this.mainPanel.Controls.Add(this.panelBottom);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(808, 547);
            this.mainPanel.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbLedgerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(808, 408);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tbLedgerBindingSource
            // 
            this.tbLedgerBindingSource.DataMember = "tbLedger";
            this.tbLedgerBindingSource.DataSource = this.dsLedger;
            // 
            // dsLedger
            // 
            this.dsLedger.DataSetName = "dsLedger";
            this.dsLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colledger_id,
            this.coltrans_date,
            this.colcode,
            this.colref,
            this.colpresrdg,
            this.colvolume,
            this.colsymbol,
            this.colother,
            this.colamount,
            this.colbalance,
            this.colencoder,
            this.colremarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colledger_id
            // 
            this.colledger_id.FieldName = "ledger_id";
            this.colledger_id.Name = "colledger_id";
            this.colledger_id.Visible = true;
            this.colledger_id.VisibleIndex = 0;
            // 
            // coltrans_date
            // 
            this.coltrans_date.AppearanceCell.Options.UseTextOptions = true;
            this.coltrans_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrans_date.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrans_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrans_date.Caption = "Date";
            this.coltrans_date.FieldName = "trans_date";
            this.coltrans_date.Name = "coltrans_date";
            this.coltrans_date.Visible = true;
            this.coltrans_date.VisibleIndex = 1;
            this.coltrans_date.Width = 79;
            // 
            // colcode
            // 
            this.colcode.AppearanceCell.Options.UseTextOptions = true;
            this.colcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcode.Caption = "Code";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 2;
            this.colcode.Width = 60;
            // 
            // colref
            // 
            this.colref.AppearanceCell.Options.UseTextOptions = true;
            this.colref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colref.AppearanceHeader.Options.UseTextOptions = true;
            this.colref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colref.Caption = "Ref#";
            this.colref.FieldName = "ref";
            this.colref.Name = "colref";
            this.colref.Visible = true;
            this.colref.VisibleIndex = 3;
            this.colref.Width = 81;
            // 
            // colpresrdg
            // 
            this.colpresrdg.AppearanceCell.Options.UseTextOptions = true;
            this.colpresrdg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpresrdg.AppearanceHeader.Options.UseTextOptions = true;
            this.colpresrdg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpresrdg.Caption = "Pres Rdg";
            this.colpresrdg.FieldName = "presrdg";
            this.colpresrdg.Name = "colpresrdg";
            this.colpresrdg.Visible = true;
            this.colpresrdg.VisibleIndex = 4;
            this.colpresrdg.Width = 70;
            // 
            // colvolume
            // 
            this.colvolume.AppearanceCell.Options.UseTextOptions = true;
            this.colvolume.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvolume.AppearanceHeader.Options.UseTextOptions = true;
            this.colvolume.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvolume.Caption = "Volume";
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 5;
            this.colvolume.Width = 60;
            // 
            // colsymbol
            // 
            this.colsymbol.AppearanceCell.Options.UseTextOptions = true;
            this.colsymbol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsymbol.AppearanceHeader.Options.UseTextOptions = true;
            this.colsymbol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsymbol.Caption = " ";
            this.colsymbol.FieldName = "symbol";
            this.colsymbol.Name = "colsymbol";
            this.colsymbol.Visible = true;
            this.colsymbol.VisibleIndex = 6;
            this.colsymbol.Width = 40;
            // 
            // colother
            // 
            this.colother.Caption = "Others";
            this.colother.DisplayFormat.FormatString = "#,##0.00";
            this.colother.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colother.FieldName = "other";
            this.colother.Name = "colother";
            this.colother.Visible = true;
            this.colother.VisibleIndex = 7;
            // 
            // colamount
            // 
            this.colamount.AppearanceCell.Options.UseTextOptions = true;
            this.colamount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamount.AppearanceHeader.Options.UseTextOptions = true;
            this.colamount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamount.Caption = "Amount";
            this.colamount.DisplayFormat.FormatString = "#,##0.00";
            this.colamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colamount.FieldName = "amount";
            this.colamount.Name = "colamount";
            this.colamount.Visible = true;
            this.colamount.VisibleIndex = 8;
            this.colamount.Width = 97;
            // 
            // colbalance
            // 
            this.colbalance.AppearanceCell.Options.UseTextOptions = true;
            this.colbalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colbalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbalance.Caption = "Balance";
            this.colbalance.DisplayFormat.FormatString = "#,##0.00";
            this.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbalance.FieldName = "balance";
            this.colbalance.Name = "colbalance";
            this.colbalance.Visible = true;
            this.colbalance.VisibleIndex = 9;
            this.colbalance.Width = 90;
            // 
            // colencoder
            // 
            this.colencoder.AppearanceCell.Options.UseTextOptions = true;
            this.colencoder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colencoder.AppearanceHeader.Options.UseTextOptions = true;
            this.colencoder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colencoder.Caption = "Encoder";
            this.colencoder.FieldName = "encoder";
            this.colencoder.Name = "colencoder";
            this.colencoder.Visible = true;
            this.colencoder.VisibleIndex = 10;
            this.colencoder.Width = 77;
            // 
            // colremarks
            // 
            this.colremarks.Caption = "Remarks";
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 11;
            this.colremarks.Width = 136;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.labelBalance);
            this.panelTop.Controls.Add(this.labelAddress);
            this.panelTop.Controls.Add(this.labelAcctNo);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(808, 71);
            this.panelTop.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account No :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // labelBalance
            // 
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(686, 37);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(110, 24);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "1200";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMasterBindingSource, "address", true));
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(104, 37);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(422, 24);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "1336 Osmena Ext. Tagum City";
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
            // labelAcctNo
            // 
            this.labelAcctNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMasterBindingSource, "acctno", true));
            this.labelAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcctNo.Location = new System.Drawing.Point(685, 9);
            this.labelAcctNo.Name = "labelAcctNo";
            this.labelAcctNo.Size = new System.Drawing.Size(111, 24);
            this.labelAcctNo.TabIndex = 1;
            this.labelAcctNo.Text = "006110";
            this.labelAcctNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMasterBindingSource, "name", true));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(105, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(426, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Gerald P. Calotes";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.textBox1);
            this.panelBottom.Controls.Add(this.checkBox1);
            this.panelBottom.Controls.Add(this.button1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 479);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(808, 68);
            this.panelBottom.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Filter by Year :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(673, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLedgerTableAdapter
            // 
            this.tbLedgerTableAdapter.ClearBeforeFill = true;
            // 
            // tbMasterTableAdapter
            // 
            this.tbMasterTableAdapter.ClearBeforeFill = true;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl1;
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // frmShowLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLedger";
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.frmShowLedger_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsLedger dsLedger;
        private System.Windows.Forms.BindingSource tbLedgerBindingSource;
        private dsLedgerTableAdapters.tbLedgerTableAdapter tbLedgerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colref;
        private DevExpress.XtraGrid.Columns.GridColumn colpresrdg;
        private DevExpress.XtraGrid.Columns.GridColumn coltrans_date;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colsymbol;
        private DevExpress.XtraGrid.Columns.GridColumn colencoder;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private DevExpress.XtraGrid.Columns.GridColumn colamount;
        private DevExpress.XtraGrid.Columns.GridColumn colbalance;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAcctNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private dsMaster dsMaster;
        private System.Windows.Forms.BindingSource tbMasterBindingSource;
        private dsMasterTableAdapters.tbMasterTableAdapter tbMasterTableAdapter;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colother;
        private DevExpress.XtraGrid.Columns.GridColumn colledger_id;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}