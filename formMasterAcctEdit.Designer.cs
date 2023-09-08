namespace BillingSystem
{
    partial class formMasterAcctEdit
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
            System.Windows.Forms.Label bill_currentLabel;
            System.Windows.Forms.Label bill_balanceLabel;
            System.Windows.Forms.Label bill_arrearsLabel;
            System.Windows.Forms.Label arrears_curr_yrLabel;
            System.Windows.Forms.Label arrears_prev_yrsLabel;
            System.Windows.Forms.Label penaltyLabel;
            System.Windows.Forms.Label senior_amtLabel;
            System.Windows.Forms.Label iFBalanceLabel;
            System.Windows.Forms.Label iFArrearsLabel;
            System.Windows.Forms.Label rdg_presLabel;
            System.Windows.Forms.Label rdg_prevLabel;
            System.Windows.Forms.Label bill_arrears_monthsLabel;
            System.Windows.Forms.Label mtrDmg_BalanceLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dsMasterAccts = new BillingSystem.dsMasterAccts();
            this.tbMasterAcctsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMasterAcctsTableAdapter = new BillingSystem.dsMasterAcctsTableAdapters.tbMasterAcctsTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsMasterAcctsTableAdapters.TableAdapterManager();
            this.bill_currentSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bill_balanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bill_arrearsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.arrears_curr_yrSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.arrears_prev_yrsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.penaltySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.senior_amtSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dsLedger = new BillingSystem.dsLedger();
            this.tbLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbLedgerTableAdapter = new BillingSystem.dsLedgerTableAdapters.tbLedgerTableAdapter();
            this.tableAdapterManager1 = new BillingSystem.dsLedgerTableAdapters.TableAdapterManager();
            this.tbLedgerGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colledger_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresrdg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrans_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colother = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colencoder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbilling_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzoneuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.iFBalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.iFArrearsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rdg_presSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rdg_prevSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dsBillingDetails = new BillingSystem.dsBillingDetails();
            this.tbBillingDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBillingDetailsTableAdapter = new BillingSystem.dsBillingDetailsTableAdapters.tbBillingDetailsTableAdapter();
            this.tableAdapterManager2 = new BillingSystem.dsBillingDetailsTableAdapters.TableAdapterManager();
            this.tbBillingDetailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbillingdetails_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmrs_ref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colave_vol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_pres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_prev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpenalty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmtr_mtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrdg_pres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrdg_prev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillproc_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreadtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsr_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsenior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinst_fee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmtr_dmg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbill_ref_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmtr_read_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colread_edit_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colother_fees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colother_fee_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarrears_month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bill_arrears_monthsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtrDmg_BalanceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            bill_currentLabel = new System.Windows.Forms.Label();
            bill_balanceLabel = new System.Windows.Forms.Label();
            bill_arrearsLabel = new System.Windows.Forms.Label();
            arrears_curr_yrLabel = new System.Windows.Forms.Label();
            arrears_prev_yrsLabel = new System.Windows.Forms.Label();
            penaltyLabel = new System.Windows.Forms.Label();
            senior_amtLabel = new System.Windows.Forms.Label();
            iFBalanceLabel = new System.Windows.Forms.Label();
            iFArrearsLabel = new System.Windows.Forms.Label();
            rdg_presLabel = new System.Windows.Forms.Label();
            rdg_prevLabel = new System.Windows.Forms.Label();
            bill_arrears_monthsLabel = new System.Windows.Forms.Label();
            mtrDmg_BalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAccts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAcctsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_currentSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_balanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrearsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_curr_yrSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_prev_yrsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_amtSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_presSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_prevSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrears_monthsSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrDmg_BalanceSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_currentLabel
            // 
            bill_currentLabel.AutoSize = true;
            bill_currentLabel.Location = new System.Drawing.Point(28, 110);
            bill_currentLabel.Name = "bill_currentLabel";
            bill_currentLabel.Size = new System.Drawing.Size(58, 13);
            bill_currentLabel.TabIndex = 4;
            bill_currentLabel.Text = "bill current:";
            // 
            // bill_balanceLabel
            // 
            bill_balanceLabel.AutoSize = true;
            bill_balanceLabel.Location = new System.Drawing.Point(23, 84);
            bill_balanceLabel.Name = "bill_balanceLabel";
            bill_balanceLabel.Size = new System.Drawing.Size(63, 13);
            bill_balanceLabel.TabIndex = 6;
            bill_balanceLabel.Text = "bill balance:";
            // 
            // bill_arrearsLabel
            // 
            bill_arrearsLabel.AutoSize = true;
            bill_arrearsLabel.Location = new System.Drawing.Point(29, 136);
            bill_arrearsLabel.Name = "bill_arrearsLabel";
            bill_arrearsLabel.Size = new System.Drawing.Size(57, 13);
            bill_arrearsLabel.TabIndex = 8;
            bill_arrearsLabel.Text = "bill arrears:";
            // 
            // arrears_curr_yrLabel
            // 
            arrears_curr_yrLabel.AutoSize = true;
            arrears_curr_yrLabel.Location = new System.Drawing.Point(12, 162);
            arrears_curr_yrLabel.Name = "arrears_curr_yrLabel";
            arrears_curr_yrLabel.Size = new System.Drawing.Size(74, 13);
            arrears_curr_yrLabel.TabIndex = 10;
            arrears_curr_yrLabel.Text = "arrears curr yr:";
            // 
            // arrears_prev_yrsLabel
            // 
            arrears_prev_yrsLabel.AutoSize = true;
            arrears_prev_yrsLabel.Location = new System.Drawing.Point(4, 188);
            arrears_prev_yrsLabel.Name = "arrears_prev_yrsLabel";
            arrears_prev_yrsLabel.Size = new System.Drawing.Size(82, 13);
            arrears_prev_yrsLabel.TabIndex = 12;
            arrears_prev_yrsLabel.Text = "arrears prev yrs:";
            // 
            // penaltyLabel
            // 
            penaltyLabel.AutoSize = true;
            penaltyLabel.Location = new System.Drawing.Point(254, 84);
            penaltyLabel.Name = "penaltyLabel";
            penaltyLabel.Size = new System.Drawing.Size(44, 13);
            penaltyLabel.TabIndex = 14;
            penaltyLabel.Text = "penalty:";
            // 
            // senior_amtLabel
            // 
            senior_amtLabel.AutoSize = true;
            senior_amtLabel.Location = new System.Drawing.Point(240, 110);
            senior_amtLabel.Name = "senior_amtLabel";
            senior_amtLabel.Size = new System.Drawing.Size(58, 13);
            senior_amtLabel.TabIndex = 16;
            senior_amtLabel.Text = "senior amt:";
            // 
            // iFBalanceLabel
            // 
            iFBalanceLabel.AutoSize = true;
            iFBalanceLabel.Location = new System.Drawing.Point(455, 84);
            iFBalanceLabel.Name = "iFBalanceLabel";
            iFBalanceLabel.Size = new System.Drawing.Size(58, 13);
            iFBalanceLabel.TabIndex = 22;
            iFBalanceLabel.Text = "IFBalance:";
            // 
            // iFArrearsLabel
            // 
            iFArrearsLabel.AutoSize = true;
            iFArrearsLabel.Location = new System.Drawing.Point(461, 110);
            iFArrearsLabel.Name = "iFArrearsLabel";
            iFArrearsLabel.Size = new System.Drawing.Size(52, 13);
            iFArrearsLabel.TabIndex = 23;
            iFArrearsLabel.Text = "IFArrears:";
            // 
            // rdg_presLabel
            // 
            rdg_presLabel.AutoSize = true;
            rdg_presLabel.Location = new System.Drawing.Point(250, 136);
            rdg_presLabel.Name = "rdg_presLabel";
            rdg_presLabel.Size = new System.Drawing.Size(48, 13);
            rdg_presLabel.TabIndex = 24;
            rdg_presLabel.Text = "rdg pres:";
            // 
            // rdg_prevLabel
            // 
            rdg_prevLabel.AutoSize = true;
            rdg_prevLabel.Location = new System.Drawing.Point(249, 162);
            rdg_prevLabel.Name = "rdg_prevLabel";
            rdg_prevLabel.Size = new System.Drawing.Size(49, 13);
            rdg_prevLabel.TabIndex = 26;
            rdg_prevLabel.Text = "rdg prev:";
            // 
            // bill_arrears_monthsLabel
            // 
            bill_arrears_monthsLabel.AutoSize = true;
            bill_arrears_monthsLabel.Location = new System.Drawing.Point(204, 188);
            bill_arrears_monthsLabel.Name = "bill_arrears_monthsLabel";
            bill_arrears_monthsLabel.Size = new System.Drawing.Size(94, 13);
            bill_arrears_monthsLabel.TabIndex = 29;
            bill_arrears_monthsLabel.Text = "bill arrears months:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No. :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbMasterAcctsTableAdapter = this.tbMasterAcctsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsMasterAcctsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bill_currentSpinEdit
            // 
            this.bill_currentSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "bill_current", true));
            this.bill_currentSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_currentSpinEdit.Location = new System.Drawing.Point(92, 107);
            this.bill_currentSpinEdit.Name = "bill_currentSpinEdit";
            this.bill_currentSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_currentSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_currentSpinEdit.TabIndex = 5;
            // 
            // bill_balanceSpinEdit
            // 
            this.bill_balanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "bill_balance", true));
            this.bill_balanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_balanceSpinEdit.EnterMoveNextControl = true;
            this.bill_balanceSpinEdit.Location = new System.Drawing.Point(92, 81);
            this.bill_balanceSpinEdit.Name = "bill_balanceSpinEdit";
            this.bill_balanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_balanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_balanceSpinEdit.TabIndex = 1;
            // 
            // bill_arrearsSpinEdit
            // 
            this.bill_arrearsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "bill_arrears", true));
            this.bill_arrearsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_arrearsSpinEdit.Location = new System.Drawing.Point(92, 133);
            this.bill_arrearsSpinEdit.Name = "bill_arrearsSpinEdit";
            this.bill_arrearsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_arrearsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_arrearsSpinEdit.TabIndex = 9;
            // 
            // arrears_curr_yrSpinEdit
            // 
            this.arrears_curr_yrSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "arrears_curr_yr", true));
            this.arrears_curr_yrSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.arrears_curr_yrSpinEdit.Location = new System.Drawing.Point(92, 159);
            this.arrears_curr_yrSpinEdit.Name = "arrears_curr_yrSpinEdit";
            this.arrears_curr_yrSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.arrears_curr_yrSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.arrears_curr_yrSpinEdit.TabIndex = 11;
            // 
            // arrears_prev_yrsSpinEdit
            // 
            this.arrears_prev_yrsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "arrears_prev_yrs", true));
            this.arrears_prev_yrsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.arrears_prev_yrsSpinEdit.Location = new System.Drawing.Point(92, 185);
            this.arrears_prev_yrsSpinEdit.Name = "arrears_prev_yrsSpinEdit";
            this.arrears_prev_yrsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.arrears_prev_yrsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.arrears_prev_yrsSpinEdit.TabIndex = 13;
            // 
            // penaltySpinEdit
            // 
            this.penaltySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "penalty", true));
            this.penaltySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.penaltySpinEdit.Location = new System.Drawing.Point(304, 81);
            this.penaltySpinEdit.Name = "penaltySpinEdit";
            this.penaltySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.penaltySpinEdit.Size = new System.Drawing.Size(100, 20);
            this.penaltySpinEdit.TabIndex = 15;
            // 
            // senior_amtSpinEdit
            // 
            this.senior_amtSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "senior_amt", true));
            this.senior_amtSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.senior_amtSpinEdit.Location = new System.Drawing.Point(304, 107);
            this.senior_amtSpinEdit.Name = "senior_amtSpinEdit";
            this.senior_amtSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.senior_amtSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.senior_amtSpinEdit.TabIndex = 17;
            // 
            // dsLedger
            // 
            this.dsLedger.DataSetName = "dsLedger";
            this.dsLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLedgerBindingSource
            // 
            this.tbLedgerBindingSource.DataMember = "tbLedger";
            this.tbLedgerBindingSource.DataSource = this.dsLedger;
            this.tbLedgerBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tbLedgerBindingSource_AddingNew);
            // 
            // tbLedgerTableAdapter
            // 
            this.tbLedgerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbLedgerTableAdapter = this.tbLedgerTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BillingSystem.dsLedgerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbLedgerGridControl
            // 
            this.tbLedgerGridControl.DataSource = this.tbLedgerBindingSource;
            this.tbLedgerGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.tbLedgerGridControl_EmbeddedNavigator_ButtonClick);
            this.tbLedgerGridControl.Location = new System.Drawing.Point(7, 211);
            this.tbLedgerGridControl.MainView = this.gridView1;
            this.tbLedgerGridControl.Name = "tbLedgerGridControl";
            this.tbLedgerGridControl.Size = new System.Drawing.Size(892, 322);
            this.tbLedgerGridControl.TabIndex = 18;
            this.tbLedgerGridControl.UseEmbeddedNavigator = true;
            this.tbLedgerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colledger_id,
            this.colcode,
            this.colref,
            this.colpresrdg,
            this.coltrans_date,
            this.colvolume,
            this.colsymbol,
            this.colamount,
            this.colbalance,
            this.colother,
            this.colencoder,
            this.colremarks,
            this.colmaster_id1,
            this.colbilling_id,
            this.colzoneuid});
            this.gridView1.GridControl = this.tbLedgerGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // colledger_id
            // 
            this.colledger_id.FieldName = "ledger_id";
            this.colledger_id.Name = "colledger_id";
            this.colledger_id.OptionsColumn.ReadOnly = true;
            this.colledger_id.Visible = true;
            this.colledger_id.VisibleIndex = 0;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            // 
            // colref
            // 
            this.colref.FieldName = "ref";
            this.colref.Name = "colref";
            this.colref.Visible = true;
            this.colref.VisibleIndex = 2;
            // 
            // colpresrdg
            // 
            this.colpresrdg.FieldName = "presrdg";
            this.colpresrdg.Name = "colpresrdg";
            this.colpresrdg.Visible = true;
            this.colpresrdg.VisibleIndex = 3;
            // 
            // coltrans_date
            // 
            this.coltrans_date.FieldName = "trans_date";
            this.coltrans_date.Name = "coltrans_date";
            this.coltrans_date.Visible = true;
            this.coltrans_date.VisibleIndex = 4;
            // 
            // colvolume
            // 
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 5;
            // 
            // colsymbol
            // 
            this.colsymbol.FieldName = "symbol";
            this.colsymbol.Name = "colsymbol";
            this.colsymbol.Visible = true;
            this.colsymbol.VisibleIndex = 6;
            // 
            // colamount
            // 
            this.colamount.FieldName = "amount";
            this.colamount.Name = "colamount";
            this.colamount.Visible = true;
            this.colamount.VisibleIndex = 9;
            // 
            // colbalance
            // 
            this.colbalance.FieldName = "balance";
            this.colbalance.Name = "colbalance";
            this.colbalance.Visible = true;
            this.colbalance.VisibleIndex = 10;
            // 
            // colother
            // 
            this.colother.FieldName = "other";
            this.colother.Name = "colother";
            this.colother.Visible = true;
            this.colother.VisibleIndex = 11;
            // 
            // colencoder
            // 
            this.colencoder.FieldName = "encoder";
            this.colencoder.Name = "colencoder";
            this.colencoder.Visible = true;
            this.colencoder.VisibleIndex = 7;
            // 
            // colremarks
            // 
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 8;
            // 
            // colmaster_id1
            // 
            this.colmaster_id1.FieldName = "master_id";
            this.colmaster_id1.Name = "colmaster_id1";
            this.colmaster_id1.Visible = true;
            this.colmaster_id1.VisibleIndex = 12;
            // 
            // colbilling_id
            // 
            this.colbilling_id.FieldName = "billing_id";
            this.colbilling_id.Name = "colbilling_id";
            this.colbilling_id.Visible = true;
            this.colbilling_id.VisibleIndex = 13;
            // 
            // colzoneuid
            // 
            this.colzoneuid.FieldName = "zoneuid";
            this.colzoneuid.Name = "colzoneuid";
            this.colzoneuid.Visible = true;
            this.colzoneuid.VisibleIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(22, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name :";
            // 
            // iFBalanceSpinEdit
            // 
            this.iFBalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "IFBalance", true));
            this.iFBalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFBalanceSpinEdit.Location = new System.Drawing.Point(519, 81);
            this.iFBalanceSpinEdit.Name = "iFBalanceSpinEdit";
            this.iFBalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.iFBalanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFBalanceSpinEdit.TabIndex = 23;
            // 
            // iFArrearsSpinEdit
            // 
            this.iFArrearsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "IFArrears", true));
            this.iFArrearsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iFArrearsSpinEdit.Location = new System.Drawing.Point(519, 107);
            this.iFArrearsSpinEdit.Name = "iFArrearsSpinEdit";
            this.iFArrearsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.iFArrearsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iFArrearsSpinEdit.TabIndex = 24;
            // 
            // rdg_presSpinEdit
            // 
            this.rdg_presSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "rdg_pres", true));
            this.rdg_presSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rdg_presSpinEdit.Location = new System.Drawing.Point(304, 133);
            this.rdg_presSpinEdit.Name = "rdg_presSpinEdit";
            this.rdg_presSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rdg_presSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.rdg_presSpinEdit.TabIndex = 25;
            // 
            // rdg_prevSpinEdit
            // 
            this.rdg_prevSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "rdg_prev", true));
            this.rdg_prevSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rdg_prevSpinEdit.Location = new System.Drawing.Point(304, 159);
            this.rdg_prevSpinEdit.Name = "rdg_prevSpinEdit";
            this.rdg_prevSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rdg_prevSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.rdg_prevSpinEdit.TabIndex = 27;
            // 
            // dsBillingDetails
            // 
            this.dsBillingDetails.DataSetName = "dsBillingDetails";
            this.dsBillingDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBillingDetailsBindingSource
            // 
            this.tbBillingDetailsBindingSource.DataMember = "tbBillingDetails";
            this.tbBillingDetailsBindingSource.DataSource = this.dsBillingDetails;
            // 
            // tbBillingDetailsTableAdapter
            // 
            this.tbBillingDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.tbBillingDetailsTableAdapter = this.tbBillingDetailsTableAdapter;
            this.tableAdapterManager2.UpdateOrder = BillingSystem.dsBillingDetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbBillingDetailsGridControl
            // 
            this.tbBillingDetailsGridControl.DataSource = this.tbBillingDetailsBindingSource;
            this.tbBillingDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBillingDetailsGridControl.Location = new System.Drawing.Point(0, 564);
            this.tbBillingDetailsGridControl.MainView = this.gridView2;
            this.tbBillingDetailsGridControl.Name = "tbBillingDetailsGridControl";
            this.tbBillingDetailsGridControl.Size = new System.Drawing.Size(919, 149);
            this.tbBillingDetailsGridControl.TabIndex = 28;
            this.tbBillingDetailsGridControl.UseEmbeddedNavigator = true;
            this.tbBillingDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbillingdetails_id,
            this.colmrs_ref,
            this.colave_vol,
            this.colcurrent,
            this.coldate_pres,
            this.coldate_prev,
            this.colvolume1,
            this.colpenalty,
            this.colmtr_mtn,
            this.colrdg_pres,
            this.colrdg_prev,
            this.colmaster_id,
            this.colbillproc_id,
            this.colreadtime,
            this.colarrears,
            this.colremarks1,
            this.colsr_id,
            this.colsenior,
            this.colinst_fee,
            this.colmtr_dmg,
            this.colbill_ref_num,
            this.colmtr_read_by,
            this.colread_edit_by,
            this.colother_fees,
            this.colother_fee_code,
            this.colarrears_month});
            this.gridView2.GridControl = this.tbBillingDetailsGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colbillingdetails_id
            // 
            this.colbillingdetails_id.FieldName = "billingdetails_id";
            this.colbillingdetails_id.Name = "colbillingdetails_id";
            this.colbillingdetails_id.OptionsColumn.ReadOnly = true;
            this.colbillingdetails_id.Visible = true;
            this.colbillingdetails_id.VisibleIndex = 0;
            // 
            // colmrs_ref
            // 
            this.colmrs_ref.FieldName = "mrs_ref";
            this.colmrs_ref.Name = "colmrs_ref";
            this.colmrs_ref.Visible = true;
            this.colmrs_ref.VisibleIndex = 1;
            // 
            // colave_vol
            // 
            this.colave_vol.FieldName = "ave_vol";
            this.colave_vol.Name = "colave_vol";
            this.colave_vol.Visible = true;
            this.colave_vol.VisibleIndex = 2;
            // 
            // colcurrent
            // 
            this.colcurrent.FieldName = "current";
            this.colcurrent.Name = "colcurrent";
            this.colcurrent.Visible = true;
            this.colcurrent.VisibleIndex = 3;
            // 
            // coldate_pres
            // 
            this.coldate_pres.FieldName = "date_pres";
            this.coldate_pres.Name = "coldate_pres";
            this.coldate_pres.Visible = true;
            this.coldate_pres.VisibleIndex = 4;
            // 
            // coldate_prev
            // 
            this.coldate_prev.FieldName = "date_prev";
            this.coldate_prev.Name = "coldate_prev";
            this.coldate_prev.Visible = true;
            this.coldate_prev.VisibleIndex = 5;
            // 
            // colvolume1
            // 
            this.colvolume1.FieldName = "volume";
            this.colvolume1.Name = "colvolume1";
            this.colvolume1.Visible = true;
            this.colvolume1.VisibleIndex = 6;
            // 
            // colpenalty
            // 
            this.colpenalty.FieldName = "penalty";
            this.colpenalty.Name = "colpenalty";
            this.colpenalty.Visible = true;
            this.colpenalty.VisibleIndex = 7;
            // 
            // colmtr_mtn
            // 
            this.colmtr_mtn.FieldName = "mtr_mtn";
            this.colmtr_mtn.Name = "colmtr_mtn";
            this.colmtr_mtn.Visible = true;
            this.colmtr_mtn.VisibleIndex = 8;
            // 
            // colrdg_pres
            // 
            this.colrdg_pres.FieldName = "rdg_pres";
            this.colrdg_pres.Name = "colrdg_pres";
            this.colrdg_pres.Visible = true;
            this.colrdg_pres.VisibleIndex = 9;
            // 
            // colrdg_prev
            // 
            this.colrdg_prev.FieldName = "rdg_prev";
            this.colrdg_prev.Name = "colrdg_prev";
            this.colrdg_prev.Visible = true;
            this.colrdg_prev.VisibleIndex = 10;
            // 
            // colmaster_id
            // 
            this.colmaster_id.FieldName = "master_id";
            this.colmaster_id.Name = "colmaster_id";
            this.colmaster_id.Visible = true;
            this.colmaster_id.VisibleIndex = 11;
            // 
            // colbillproc_id
            // 
            this.colbillproc_id.FieldName = "billproc_id";
            this.colbillproc_id.Name = "colbillproc_id";
            this.colbillproc_id.Visible = true;
            this.colbillproc_id.VisibleIndex = 12;
            // 
            // colreadtime
            // 
            this.colreadtime.FieldName = "readtime";
            this.colreadtime.Name = "colreadtime";
            this.colreadtime.Visible = true;
            this.colreadtime.VisibleIndex = 13;
            // 
            // colarrears
            // 
            this.colarrears.FieldName = "arrears";
            this.colarrears.Name = "colarrears";
            this.colarrears.Visible = true;
            this.colarrears.VisibleIndex = 14;
            // 
            // colremarks1
            // 
            this.colremarks1.FieldName = "remarks";
            this.colremarks1.Name = "colremarks1";
            this.colremarks1.Visible = true;
            this.colremarks1.VisibleIndex = 15;
            // 
            // colsr_id
            // 
            this.colsr_id.FieldName = "sr_id";
            this.colsr_id.Name = "colsr_id";
            this.colsr_id.Visible = true;
            this.colsr_id.VisibleIndex = 16;
            // 
            // colsenior
            // 
            this.colsenior.FieldName = "senior";
            this.colsenior.Name = "colsenior";
            this.colsenior.Visible = true;
            this.colsenior.VisibleIndex = 17;
            // 
            // colinst_fee
            // 
            this.colinst_fee.FieldName = "inst_fee";
            this.colinst_fee.Name = "colinst_fee";
            this.colinst_fee.Visible = true;
            this.colinst_fee.VisibleIndex = 18;
            // 
            // colmtr_dmg
            // 
            this.colmtr_dmg.FieldName = "mtr_dmg";
            this.colmtr_dmg.Name = "colmtr_dmg";
            this.colmtr_dmg.Visible = true;
            this.colmtr_dmg.VisibleIndex = 19;
            // 
            // colbill_ref_num
            // 
            this.colbill_ref_num.FieldName = "bill_ref_num";
            this.colbill_ref_num.Name = "colbill_ref_num";
            this.colbill_ref_num.Visible = true;
            this.colbill_ref_num.VisibleIndex = 20;
            // 
            // colmtr_read_by
            // 
            this.colmtr_read_by.FieldName = "mtr_read_by";
            this.colmtr_read_by.Name = "colmtr_read_by";
            this.colmtr_read_by.Visible = true;
            this.colmtr_read_by.VisibleIndex = 21;
            // 
            // colread_edit_by
            // 
            this.colread_edit_by.FieldName = "read_edit_by";
            this.colread_edit_by.Name = "colread_edit_by";
            this.colread_edit_by.Visible = true;
            this.colread_edit_by.VisibleIndex = 22;
            // 
            // colother_fees
            // 
            this.colother_fees.FieldName = "other_fees";
            this.colother_fees.Name = "colother_fees";
            this.colother_fees.Visible = true;
            this.colother_fees.VisibleIndex = 23;
            // 
            // colother_fee_code
            // 
            this.colother_fee_code.FieldName = "other_fee_code";
            this.colother_fee_code.Name = "colother_fee_code";
            this.colother_fee_code.Visible = true;
            this.colother_fee_code.VisibleIndex = 24;
            // 
            // colarrears_month
            // 
            this.colarrears_month.FieldName = "arrears_month";
            this.colarrears_month.Name = "colarrears_month";
            this.colarrears_month.Visible = true;
            this.colarrears_month.VisibleIndex = 25;
            // 
            // bill_arrears_monthsSpinEdit
            // 
            this.bill_arrears_monthsSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "bill_arrears_months", true));
            this.bill_arrears_monthsSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bill_arrears_monthsSpinEdit.Location = new System.Drawing.Point(304, 185);
            this.bill_arrears_monthsSpinEdit.Name = "bill_arrears_monthsSpinEdit";
            this.bill_arrears_monthsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bill_arrears_monthsSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bill_arrears_monthsSpinEdit.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Master ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Zoneuid :";
            // 
            // mtrDmg_BalanceLabel
            // 
            mtrDmg_BalanceLabel.AutoSize = true;
            mtrDmg_BalanceLabel.Location = new System.Drawing.Point(421, 136);
            mtrDmg_BalanceLabel.Name = "mtrDmg_BalanceLabel";
            mtrDmg_BalanceLabel.Size = new System.Drawing.Size(92, 13);
            mtrDmg_BalanceLabel.TabIndex = 33;
            mtrDmg_BalanceLabel.Text = "Mtr Dmg Balance:";
            // 
            // mtrDmg_BalanceSpinEdit
            // 
            this.mtrDmg_BalanceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbMasterAcctsBindingSource, "MtrDmg_Balance", true));
            this.mtrDmg_BalanceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mtrDmg_BalanceSpinEdit.Location = new System.Drawing.Point(519, 133);
            this.mtrDmg_BalanceSpinEdit.Name = "mtrDmg_BalanceSpinEdit";
            this.mtrDmg_BalanceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.mtrDmg_BalanceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.mtrDmg_BalanceSpinEdit.TabIndex = 34;
            // 
            // formMasterAcctEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 713);
            this.Controls.Add(mtrDmg_BalanceLabel);
            this.Controls.Add(this.mtrDmg_BalanceSpinEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(bill_arrears_monthsLabel);
            this.Controls.Add(this.bill_arrears_monthsSpinEdit);
            this.Controls.Add(this.tbBillingDetailsGridControl);
            this.Controls.Add(rdg_prevLabel);
            this.Controls.Add(this.rdg_prevSpinEdit);
            this.Controls.Add(rdg_presLabel);
            this.Controls.Add(this.rdg_presSpinEdit);
            this.Controls.Add(iFArrearsLabel);
            this.Controls.Add(this.iFArrearsSpinEdit);
            this.Controls.Add(iFBalanceLabel);
            this.Controls.Add(this.iFBalanceSpinEdit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbLedgerGridControl);
            this.Controls.Add(senior_amtLabel);
            this.Controls.Add(this.senior_amtSpinEdit);
            this.Controls.Add(penaltyLabel);
            this.Controls.Add(this.penaltySpinEdit);
            this.Controls.Add(arrears_prev_yrsLabel);
            this.Controls.Add(this.arrears_prev_yrsSpinEdit);
            this.Controls.Add(arrears_curr_yrLabel);
            this.Controls.Add(this.arrears_curr_yrSpinEdit);
            this.Controls.Add(bill_arrearsLabel);
            this.Controls.Add(this.bill_arrearsSpinEdit);
            this.Controls.Add(bill_balanceLabel);
            this.Controls.Add(this.bill_balanceSpinEdit);
            this.Controls.Add(bill_currentLabel);
            this.Controls.Add(this.bill_currentSpinEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "formMasterAcctEdit";
            this.Text = "Edit Master Account";
            this.Load += new System.EventHandler(this.formMasterAcctEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMasterAccts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasterAcctsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_currentSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_balanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrearsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_curr_yrSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrears_prev_yrsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_amtSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLedgerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFBalanceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFArrearsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_presSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_prevSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillingDetailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_arrears_monthsSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrDmg_BalanceSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private dsMasterAccts dsMasterAccts;
        private System.Windows.Forms.BindingSource tbMasterAcctsBindingSource;
        private dsMasterAcctsTableAdapters.tbMasterAcctsTableAdapter tbMasterAcctsTableAdapter;
        private dsMasterAcctsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit bill_currentSpinEdit;
        private DevExpress.XtraEditors.SpinEdit bill_balanceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit bill_arrearsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit arrears_curr_yrSpinEdit;
        private DevExpress.XtraEditors.SpinEdit arrears_prev_yrsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit penaltySpinEdit;
        private DevExpress.XtraEditors.SpinEdit senior_amtSpinEdit;
        private dsLedger dsLedger;
        private System.Windows.Forms.BindingSource tbLedgerBindingSource;
        private dsLedgerTableAdapters.tbLedgerTableAdapter tbLedgerTableAdapter;
        private dsLedgerTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl tbLedgerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colledger_id;
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
        private DevExpress.XtraGrid.Columns.GridColumn colother;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelName;
        private DevExpress.XtraEditors.SpinEdit iFBalanceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit iFArrearsSpinEdit;
        private DevExpress.XtraEditors.SpinEdit rdg_presSpinEdit;
        private DevExpress.XtraEditors.SpinEdit rdg_prevSpinEdit;
        private dsBillingDetails dsBillingDetails;
        private System.Windows.Forms.BindingSource tbBillingDetailsBindingSource;
        private dsBillingDetailsTableAdapters.tbBillingDetailsTableAdapter tbBillingDetailsTableAdapter;
        private dsBillingDetailsTableAdapters.TableAdapterManager tableAdapterManager2;
        private DevExpress.XtraGrid.GridControl tbBillingDetailsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colbillingdetails_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmrs_ref;
        private DevExpress.XtraGrid.Columns.GridColumn colave_vol;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_pres;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_prev;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume1;
        private DevExpress.XtraGrid.Columns.GridColumn colpenalty;
        private DevExpress.XtraGrid.Columns.GridColumn colmtr_mtn;
        private DevExpress.XtraGrid.Columns.GridColumn colrdg_pres;
        private DevExpress.XtraGrid.Columns.GridColumn colrdg_prev;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbillproc_id;
        private DevExpress.XtraGrid.Columns.GridColumn colreadtime;
        private DevExpress.XtraGrid.Columns.GridColumn colarrears;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks1;
        private DevExpress.XtraGrid.Columns.GridColumn colsr_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsenior;
        private DevExpress.XtraGrid.Columns.GridColumn colinst_fee;
        private DevExpress.XtraGrid.Columns.GridColumn colmtr_dmg;
        private DevExpress.XtraGrid.Columns.GridColumn colbill_ref_num;
        private DevExpress.XtraGrid.Columns.GridColumn colmtr_read_by;
        private DevExpress.XtraGrid.Columns.GridColumn colread_edit_by;
        private DevExpress.XtraGrid.Columns.GridColumn colother_fees;
        private DevExpress.XtraGrid.Columns.GridColumn colother_fee_code;
        private DevExpress.XtraGrid.Columns.GridColumn colarrears_month;
        private DevExpress.XtraEditors.SpinEdit bill_arrears_monthsSpinEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_id1;
        private DevExpress.XtraGrid.Columns.GridColumn colbilling_id;
        private DevExpress.XtraGrid.Columns.GridColumn colzoneuid;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit mtrDmg_BalanceSpinEdit;
    }
}