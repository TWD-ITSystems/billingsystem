namespace BillingSystem
{
    partial class frmServiceRequestMenu
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
            System.Windows.Forms.Label sr_noLabel;
            System.Windows.Forms.Label acctnoLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label request_recd_dateLabel;
            System.Windows.Forms.Label requested_byLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label complain_descLabel;
            System.Windows.Forms.Label work_doneLabel;
            System.Windows.Forms.Label inspected_byLabel;
            System.Windows.Forms.Label inspected_dateLabel;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwServiceRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServiceRequest = new BillingSystem.dsServiceRequest();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsr_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacctno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrequested_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inspected_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.inspected_byTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.work_doneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.complain_descTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.statusSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.requested_byTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.request_recd_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acctnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sr_noTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnServe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.vwServiceRequestTableAdapter = new BillingSystem.dsServiceRequestTableAdapters.vwServiceRequestTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsServiceRequestTableAdapters.TableAdapterManager();
            sr_noLabel = new System.Windows.Forms.Label();
            acctnoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            request_recd_dateLabel = new System.Windows.Forms.Label();
            requested_byLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            complain_descLabel = new System.Windows.Forms.Label();
            work_doneLabel = new System.Windows.Forms.Label();
            inspected_byLabel = new System.Windows.Forms.Label();
            inspected_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServiceRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_byTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.work_doneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complain_descTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requested_byTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.request_recd_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.request_recd_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_noTextEdit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sr_noLabel
            // 
            sr_noLabel.AutoSize = true;
            sr_noLabel.Location = new System.Drawing.Point(17, 26);
            sr_noLabel.Name = "sr_noLabel";
            sr_noLabel.Size = new System.Drawing.Size(42, 13);
            sr_noLabel.TabIndex = 0;
            sr_noLabel.Text = "SR No:";
            // 
            // acctnoLabel
            // 
            acctnoLabel.AutoSize = true;
            acctnoLabel.Location = new System.Drawing.Point(254, 26);
            acctnoLabel.Name = "acctnoLabel";
            acctnoLabel.Size = new System.Drawing.Size(44, 13);
            acctnoLabel.TabIndex = 2;
            acctnoLabel.Text = "Acctno:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(11, 99);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // request_recd_dateLabel
            // 
            request_recd_dateLabel.AutoSize = true;
            request_recd_dateLabel.Location = new System.Drawing.Point(11, 159);
            request_recd_dateLabel.Name = "request_recd_dateLabel";
            request_recd_dateLabel.Size = new System.Drawing.Size(82, 13);
            request_recd_dateLabel.TabIndex = 8;
            request_recd_dateLabel.Text = "Date Received:";
            // 
            // requested_byLabel
            // 
            requested_byLabel.AutoSize = true;
            requested_byLabel.Location = new System.Drawing.Point(17, 189);
            requested_byLabel.Name = "requested_byLabel";
            requested_byLabel.Size = new System.Drawing.Size(76, 13);
            requested_byLabel.TabIndex = 10;
            requested_byLabel.Text = "Requested by:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(260, 159);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // complain_descLabel
            // 
            complain_descLabel.AutoSize = true;
            complain_descLabel.Location = new System.Drawing.Point(37, 221);
            complain_descLabel.Name = "complain_descLabel";
            complain_descLabel.Size = new System.Drawing.Size(56, 13);
            complain_descLabel.TabIndex = 15;
            complain_descLabel.Text = "Complain :";
            // 
            // work_doneLabel
            // 
            work_doneLabel.AutoSize = true;
            work_doneLabel.Location = new System.Drawing.Point(28, 258);
            work_doneLabel.Name = "work_doneLabel";
            work_doneLabel.Size = new System.Drawing.Size(65, 13);
            work_doneLabel.TabIndex = 17;
            work_doneLabel.Text = "Work Done:";
            // 
            // inspected_byLabel
            // 
            inspected_byLabel.AutoSize = true;
            inspected_byLabel.Location = new System.Drawing.Point(43, 291);
            inspected_byLabel.Name = "inspected_byLabel";
            inspected_byLabel.Size = new System.Drawing.Size(50, 13);
            inspected_byLabel.TabIndex = 19;
            inspected_byLabel.Text = "Work by:";
            // 
            // inspected_dateLabel
            // 
            inspected_dateLabel.AutoSize = true;
            inspected_dateLabel.Location = new System.Drawing.Point(28, 321);
            inspected_dateLabel.Name = "inspected_dateLabel";
            inspected_dateLabel.Size = new System.Drawing.Size(65, 13);
            inspected_dateLabel.TabIndex = 21;
            inspected_dateLabel.Text = "Work Date :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(855, 470);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwServiceRequestBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(419, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwServiceRequestBindingSource
            // 
            this.vwServiceRequestBindingSource.DataMember = "vwServiceRequest";
            this.vwServiceRequestBindingSource.DataSource = this.dsServiceRequest;
            this.vwServiceRequestBindingSource.Sort = "sr_id DESC";
            this.vwServiceRequestBindingSource.PositionChanged += new System.EventHandler(this.vwServiceRequestBindingSource_PositionChanged);
            // 
            // dsServiceRequest
            // 
            this.dsServiceRequest.DataSetName = "dsServiceRequest";
            this.dsServiceRequest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstatus,
            this.colsr_no,
            this.colacctno,
            this.colname,
            this.colcode_desc,
            this.colrequested_by});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.OptionsColumn.ReadOnly = true;
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 0;
            this.colstatus.Width = 34;
            // 
            // colsr_no
            // 
            this.colsr_no.FieldName = "sr_no";
            this.colsr_no.Name = "colsr_no";
            this.colsr_no.OptionsColumn.ReadOnly = true;
            this.colsr_no.Visible = true;
            this.colsr_no.VisibleIndex = 1;
            this.colsr_no.Width = 38;
            // 
            // colacctno
            // 
            this.colacctno.FieldName = "acctno";
            this.colacctno.Name = "colacctno";
            this.colacctno.OptionsColumn.ReadOnly = true;
            this.colacctno.Visible = true;
            this.colacctno.VisibleIndex = 2;
            this.colacctno.Width = 44;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 3;
            this.colname.Width = 83;
            // 
            // colcode_desc
            // 
            this.colcode_desc.FieldName = "code_desc";
            this.colcode_desc.Name = "colcode_desc";
            this.colcode_desc.OptionsColumn.ReadOnly = true;
            this.colcode_desc.Visible = true;
            this.colcode_desc.VisibleIndex = 4;
            this.colcode_desc.Width = 83;
            // 
            // colrequested_by
            // 
            this.colrequested_by.FieldName = "requested_by";
            this.colrequested_by.Name = "colrequested_by";
            this.colrequested_by.OptionsColumn.ReadOnly = true;
            this.colrequested_by.Visible = true;
            this.colrequested_by.VisibleIndex = 5;
            this.colrequested_by.Width = 79;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(inspected_dateLabel);
            this.panel2.Controls.Add(this.inspected_dateDateEdit);
            this.panel2.Controls.Add(inspected_byLabel);
            this.panel2.Controls.Add(this.inspected_byTextEdit);
            this.panel2.Controls.Add(work_doneLabel);
            this.panel2.Controls.Add(this.work_doneTextEdit);
            this.panel2.Controls.Add(complain_descLabel);
            this.panel2.Controls.Add(this.complain_descTextEdit);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(statusLabel);
            this.panel2.Controls.Add(this.statusSpinEdit);
            this.panel2.Controls.Add(requested_byLabel);
            this.panel2.Controls.Add(this.requested_byTextEdit);
            this.panel2.Controls.Add(request_recd_dateLabel);
            this.panel2.Controls.Add(this.request_recd_dateDateEdit);
            this.panel2.Controls.Add(addressLabel);
            this.panel2.Controls.Add(this.addressTextEdit);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(this.nameTextEdit);
            this.panel2.Controls.Add(acctnoLabel);
            this.panel2.Controls.Add(this.acctnoTextEdit);
            this.panel2.Controls.Add(sr_noLabel);
            this.panel2.Controls.Add(this.sr_noTextEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 419);
            this.panel2.TabIndex = 1;
            // 
            // inspected_dateDateEdit
            // 
            this.inspected_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "inspected_date", true));
            this.inspected_dateDateEdit.EditValue = null;
            this.inspected_dateDateEdit.Location = new System.Drawing.Point(99, 318);
            this.inspected_dateDateEdit.Name = "inspected_dateDateEdit";
            this.inspected_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.inspected_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.inspected_dateDateEdit.Size = new System.Drawing.Size(129, 20);
            this.inspected_dateDateEdit.TabIndex = 22;
            // 
            // inspected_byTextEdit
            // 
            this.inspected_byTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "inspected_by", true));
            this.inspected_byTextEdit.Location = new System.Drawing.Point(99, 288);
            this.inspected_byTextEdit.Name = "inspected_byTextEdit";
            this.inspected_byTextEdit.Size = new System.Drawing.Size(304, 20);
            this.inspected_byTextEdit.TabIndex = 20;
            // 
            // work_doneTextEdit
            // 
            this.work_doneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "work_done", true));
            this.work_doneTextEdit.Location = new System.Drawing.Point(99, 255);
            this.work_doneTextEdit.Name = "work_doneTextEdit";
            this.work_doneTextEdit.Size = new System.Drawing.Size(304, 20);
            this.work_doneTextEdit.TabIndex = 18;
            // 
            // complain_descTextEdit
            // 
            this.complain_descTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "complain_desc", true));
            this.complain_descTextEdit.Location = new System.Drawing.Point(99, 218);
            this.complain_descTextEdit.Name = "complain_descTextEdit";
            this.complain_descTextEdit.Size = new System.Drawing.Size(304, 20);
            this.complain_descTextEdit.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(303, 156);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(69, 20);
            this.txtStatus.TabIndex = 14;
            // 
            // statusSpinEdit
            // 
            this.statusSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "status", true));
            this.statusSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.statusSpinEdit.Location = new System.Drawing.Point(372, 122);
            this.statusSpinEdit.Name = "statusSpinEdit";
            this.statusSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.statusSpinEdit.Size = new System.Drawing.Size(48, 20);
            this.statusSpinEdit.TabIndex = 13;
            this.statusSpinEdit.Visible = false;
            // 
            // requested_byTextEdit
            // 
            this.requested_byTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "requested_by", true));
            this.requested_byTextEdit.Location = new System.Drawing.Point(99, 186);
            this.requested_byTextEdit.Name = "requested_byTextEdit";
            this.requested_byTextEdit.Size = new System.Drawing.Size(129, 20);
            this.requested_byTextEdit.TabIndex = 11;
            // 
            // request_recd_dateDateEdit
            // 
            this.request_recd_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "request_recd_date", true));
            this.request_recd_dateDateEdit.EditValue = null;
            this.request_recd_dateDateEdit.Location = new System.Drawing.Point(99, 156);
            this.request_recd_dateDateEdit.Name = "request_recd_dateDateEdit";
            this.request_recd_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.request_recd_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.request_recd_dateDateEdit.Size = new System.Drawing.Size(129, 20);
            this.request_recd_dateDateEdit.TabIndex = 9;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(65, 96);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(338, 20);
            this.addressTextEdit.TabIndex = 7;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(65, 63);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(338, 20);
            this.nameTextEdit.TabIndex = 5;
            // 
            // acctnoTextEdit
            // 
            this.acctnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "acctno", true));
            this.acctnoTextEdit.Location = new System.Drawing.Point(303, 22);
            this.acctnoTextEdit.Name = "acctnoTextEdit";
            this.acctnoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.acctnoTextEdit.TabIndex = 3;
            // 
            // sr_noTextEdit
            // 
            this.sr_noTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwServiceRequestBindingSource, "sr_no", true));
            this.sr_noTextEdit.Location = new System.Drawing.Point(65, 22);
            this.sr_noTextEdit.Name = "sr_noTextEdit";
            this.sr_noTextEdit.Size = new System.Drawing.Size(100, 20);
            this.sr_noTextEdit.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnServe);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(128, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 25);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Selected";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnServe
            // 
            this.btnServe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServe.Location = new System.Drawing.Point(14, 14);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(100, 25);
            this.btnServe.TabIndex = 1;
            this.btnServe.Text = "Served Request";
            this.btnServe.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(329, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vwServiceRequestTableAdapter
            // 
            this.vwServiceRequestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsServiceRequestTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmServiceRequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 470);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmServiceRequestMenu";
            this.Text = "Service Request Menu";
            this.Load += new System.EventHandler(this.frmServiceRequestMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServiceRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspected_byTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.work_doneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complain_descTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requested_byTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.request_recd_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.request_recd_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_noTextEdit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private dsServiceRequest dsServiceRequest;
        private System.Windows.Forms.BindingSource vwServiceRequestBindingSource;
        private dsServiceRequestTableAdapters.vwServiceRequestTableAdapter vwServiceRequestTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colsr_no;
        private DevExpress.XtraGrid.Columns.GridColumn colacctno;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colrequested_by;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit acctnoTextEdit;
        private DevExpress.XtraEditors.TextEdit sr_noTextEdit;
        private dsServiceRequestTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit request_recd_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit requested_byTextEdit;
        private DevExpress.XtraEditors.SpinEdit statusSpinEdit;
        private System.Windows.Forms.TextBox txtStatus;
        private DevExpress.XtraEditors.DateEdit inspected_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit inspected_byTextEdit;
        private DevExpress.XtraEditors.TextEdit work_doneTextEdit;
        private DevExpress.XtraEditors.TextEdit complain_descTextEdit;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.Button btnPrint;
    }
}