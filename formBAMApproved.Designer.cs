namespace BillingSystem
{
    partial class formBAMApproved
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
            System.Windows.Forms.Label bamnoLabel;
            System.Windows.Forms.Label acctnoLabel;
            System.Windows.Forms.Label acctnameLabel;
            System.Windows.Forms.Label bam_dateLabel;
            System.Windows.Forms.Label zonenoLabel;
            System.Windows.Forms.Label cardnoLabel;
            System.Windows.Forms.Label case_descLabel;
            System.Windows.Forms.Label explanationLabel;
            System.Windows.Forms.Label last_readingLabel;
            System.Windows.Forms.Label billmonthLabel;
            System.Windows.Forms.Label cum_as_billedLabel;
            System.Windows.Forms.Label cum_should_beLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.vwBAMEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBAMEntries = new BillingSystem.dsBAMEntries();
            this.vwBAMEntriesTableAdapter = new BillingSystem.dsBAMEntriesTableAdapters.vwBAMEntriesTableAdapter();
            this.tableAdapterManager = new BillingSystem.dsBAMEntriesTableAdapters.TableAdapterManager();
            this.bamnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acctnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acctnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bam_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.zonenoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cardnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.case_descTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.explanationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.last_readingSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.billmonthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cum_as_billedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cum_should_beTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cum_adjustmentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accounttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtdebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBAMJournalEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBAMJournal = new BillingSystem.dsBAMJournal();
            this.tbBAMJournalEntryTableAdapter = new BillingSystem.dsBAMJournalTableAdapters.tbBAMJournalEntryTableAdapter();
            this.debitSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.creditSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txMasterID = new DevExpress.XtraEditors.SpinEdit();
            this.bamcase_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnList = new System.Windows.Forms.Button();
            bamnoLabel = new System.Windows.Forms.Label();
            acctnoLabel = new System.Windows.Forms.Label();
            acctnameLabel = new System.Windows.Forms.Label();
            bam_dateLabel = new System.Windows.Forms.Label();
            zonenoLabel = new System.Windows.Forms.Label();
            cardnoLabel = new System.Windows.Forms.Label();
            case_descLabel = new System.Windows.Forms.Label();
            explanationLabel = new System.Windows.Forms.Label();
            last_readingLabel = new System.Windows.Forms.Label();
            billmonthLabel = new System.Windows.Forms.Label();
            cum_as_billedLabel = new System.Windows.Forms.Label();
            cum_should_beLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwBAMEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bam_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bam_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonenoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.case_descTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explanationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_readingSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billmonthTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_as_billedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_should_beTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_adjustmentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBAMJournalEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMasterID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamcase_idSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bamnoLabel
            // 
            bamnoLabel.AutoSize = true;
            bamnoLabel.Location = new System.Drawing.Point(51, 19);
            bamnoLabel.Name = "bamnoLabel";
            bamnoLabel.Size = new System.Drawing.Size(64, 16);
            bamnoLabel.TabIndex = 0;
            bamnoLabel.Text = "BAM No.:";
            // 
            // acctnoLabel
            // 
            acctnoLabel.AutoSize = true;
            acctnoLabel.Location = new System.Drawing.Point(29, 47);
            acctnoLabel.Name = "acctnoLabel";
            acctnoLabel.Size = new System.Drawing.Size(86, 16);
            acctnoLabel.TabIndex = 2;
            acctnoLabel.Text = "Account No. :";
            // 
            // acctnameLabel
            // 
            acctnameLabel.AutoSize = true;
            acctnameLabel.Location = new System.Drawing.Point(10, 76);
            acctnameLabel.Name = "acctnameLabel";
            acctnameLabel.Size = new System.Drawing.Size(105, 16);
            acctnameLabel.TabIndex = 4;
            acctnameLabel.Text = "Concessionaire:";
            // 
            // bam_dateLabel
            // 
            bam_dateLabel.AutoSize = true;
            bam_dateLabel.Location = new System.Drawing.Point(670, 19);
            bam_dateLabel.Name = "bam_dateLabel";
            bam_dateLabel.Size = new System.Drawing.Size(43, 16);
            bam_dateLabel.TabIndex = 6;
            bam_dateLabel.Text = "Date :";
            // 
            // zonenoLabel
            // 
            zonenoLabel.AutoSize = true;
            zonenoLabel.Location = new System.Drawing.Point(478, 49);
            zonenoLabel.Name = "zonenoLabel";
            zonenoLabel.Size = new System.Drawing.Size(45, 16);
            zonenoLabel.TabIndex = 8;
            zonenoLabel.Text = "Zone :";
            // 
            // cardnoLabel
            // 
            cardnoLabel.AutoSize = true;
            cardnoLabel.Location = new System.Drawing.Point(649, 47);
            cardnoLabel.Name = "cardnoLabel";
            cardnoLabel.Size = new System.Drawing.Size(64, 16);
            cardnoLabel.TabIndex = 10;
            cardnoLabel.Text = "Card No.:";
            // 
            // case_descLabel
            // 
            case_descLabel.AutoSize = true;
            case_descLabel.Location = new System.Drawing.Point(39, 105);
            case_descLabel.Name = "case_descLabel";
            case_descLabel.Size = new System.Drawing.Size(78, 16);
            case_descLabel.TabIndex = 12;
            case_descLabel.Text = "BAM Case :";
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Location = new System.Drawing.Point(36, 134);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new System.Drawing.Size(81, 16);
            explanationLabel.TabIndex = 14;
            explanationLabel.Text = "Explanation:";
            // 
            // last_readingLabel
            // 
            last_readingLabel.AutoSize = true;
            last_readingLabel.Location = new System.Drawing.Point(628, 104);
            last_readingLabel.Name = "last_readingLabel";
            last_readingLabel.Size = new System.Drawing.Size(85, 16);
            last_readingLabel.TabIndex = 16;
            last_readingLabel.Text = "Last reading:";
            // 
            // billmonthLabel
            // 
            billmonthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            billmonthLabel.Location = new System.Drawing.Point(6, 257);
            billmonthLabel.Name = "billmonthLabel";
            billmonthLabel.Size = new System.Drawing.Size(99, 16);
            billmonthLabel.TabIndex = 18;
            billmonthLabel.Text = "BillMonth";
            billmonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cum_as_billedLabel
            // 
            cum_as_billedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cum_as_billedLabel.Location = new System.Drawing.Point(107, 257);
            cum_as_billedLabel.Name = "cum_as_billedLabel";
            cum_as_billedLabel.Size = new System.Drawing.Size(100, 16);
            cum_as_billedLabel.TabIndex = 20;
            cum_as_billedLabel.Text = "As Billed";
            cum_as_billedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cum_should_beLabel
            // 
            cum_should_beLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cum_should_beLabel.Location = new System.Drawing.Point(209, 257);
            cum_should_beLabel.Name = "cum_should_beLabel";
            cum_should_beLabel.Size = new System.Drawing.Size(98, 16);
            cum_should_beLabel.TabIndex = 22;
            cum_should_beLabel.Text = "Should be";
            cum_should_beLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            label1.Location = new System.Drawing.Point(309, 257);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 16);
            label1.TabIndex = 24;
            label1.Text = "Adjustment";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(563, 386);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 16);
            label2.TabIndex = 28;
            label2.Text = "Total :";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Blue;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(5, 229);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(402, 26);
            label3.TabIndex = 33;
            label3.Text = "Consumption";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Blue;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(414, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(405, 26);
            label4.TabIndex = 34;
            label4.Text = "Journal Entry";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vwBAMEntriesBindingSource
            // 
            this.vwBAMEntriesBindingSource.DataMember = "vwBAMEntries";
            this.vwBAMEntriesBindingSource.DataSource = this.dsBAMEntries;
            // 
            // dsBAMEntries
            // 
            this.dsBAMEntries.DataSetName = "dsBAMEntries";
            this.dsBAMEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwBAMEntriesTableAdapter
            // 
            this.vwBAMEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dsBAMEntriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bamnoTextEdit
            // 
            this.bamnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "bamno", true));
            this.bamnoTextEdit.Location = new System.Drawing.Point(123, 16);
            this.bamnoTextEdit.Name = "bamnoTextEdit";
            this.bamnoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamnoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.bamnoTextEdit.Size = new System.Drawing.Size(100, 22);
            this.bamnoTextEdit.TabIndex = 1;
            // 
            // acctnoTextEdit
            // 
            this.acctnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "acctno", true));
            this.acctnoTextEdit.Location = new System.Drawing.Point(123, 44);
            this.acctnoTextEdit.Name = "acctnoTextEdit";
            this.acctnoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.acctnoTextEdit.Size = new System.Drawing.Size(100, 22);
            this.acctnoTextEdit.TabIndex = 3;
            // 
            // acctnameTextEdit
            // 
            this.acctnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "acctname", true));
            this.acctnameTextEdit.Location = new System.Drawing.Point(123, 72);
            this.acctnameTextEdit.Name = "acctnameTextEdit";
            this.acctnameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.acctnameTextEdit.Size = new System.Drawing.Size(349, 22);
            this.acctnameTextEdit.TabIndex = 5;
            // 
            // bam_dateDateEdit
            // 
            this.bam_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "bam_date", true));
            this.bam_dateDateEdit.EditValue = null;
            this.bam_dateDateEdit.Location = new System.Drawing.Point(719, 16);
            this.bam_dateDateEdit.Name = "bam_dateDateEdit";
            this.bam_dateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bam_dateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.bam_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bam_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bam_dateDateEdit.Size = new System.Drawing.Size(100, 22);
            this.bam_dateDateEdit.TabIndex = 7;
            // 
            // zonenoTextEdit
            // 
            this.zonenoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "zoneno", true));
            this.zonenoTextEdit.Location = new System.Drawing.Point(531, 44);
            this.zonenoTextEdit.Name = "zonenoTextEdit";
            this.zonenoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zonenoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.zonenoTextEdit.Size = new System.Drawing.Size(100, 22);
            this.zonenoTextEdit.TabIndex = 9;
            // 
            // cardnoTextEdit
            // 
            this.cardnoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "cardno", true));
            this.cardnoTextEdit.Location = new System.Drawing.Point(719, 44);
            this.cardnoTextEdit.Name = "cardnoTextEdit";
            this.cardnoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.cardnoTextEdit.Size = new System.Drawing.Size(100, 22);
            this.cardnoTextEdit.TabIndex = 11;
            // 
            // case_descTextEdit
            // 
            this.case_descTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "case_desc", true));
            this.case_descTextEdit.Location = new System.Drawing.Point(123, 101);
            this.case_descTextEdit.Name = "case_descTextEdit";
            this.case_descTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case_descTextEdit.Properties.Appearance.Options.UseFont = true;
            this.case_descTextEdit.Size = new System.Drawing.Size(349, 22);
            this.case_descTextEdit.TabIndex = 13;
            // 
            // explanationTextEdit
            // 
            this.explanationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "explanation", true));
            this.explanationTextEdit.Location = new System.Drawing.Point(123, 130);
            this.explanationTextEdit.Name = "explanationTextEdit";
            this.explanationTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationTextEdit.Properties.Appearance.Options.UseFont = true;
            this.explanationTextEdit.Properties.AutoHeight = false;
            this.explanationTextEdit.Size = new System.Drawing.Size(696, 89);
            this.explanationTextEdit.TabIndex = 15;
            // 
            // last_readingSpinEdit
            // 
            this.last_readingSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "last_reading", true));
            this.last_readingSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.last_readingSpinEdit.Location = new System.Drawing.Point(719, 102);
            this.last_readingSpinEdit.Name = "last_readingSpinEdit";
            this.last_readingSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_readingSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.last_readingSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.last_readingSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.last_readingSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.last_readingSpinEdit.Size = new System.Drawing.Size(100, 22);
            this.last_readingSpinEdit.TabIndex = 17;
            // 
            // billmonthTextEdit
            // 
            this.billmonthTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "billmonth", true));
            this.billmonthTextEdit.Location = new System.Drawing.Point(5, 276);
            this.billmonthTextEdit.Name = "billmonthTextEdit";
            this.billmonthTextEdit.Properties.AutoHeight = false;
            this.billmonthTextEdit.Size = new System.Drawing.Size(100, 101);
            this.billmonthTextEdit.TabIndex = 19;
            // 
            // cum_as_billedTextEdit
            // 
            this.cum_as_billedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "cum_as_billed", true));
            this.cum_as_billedTextEdit.Location = new System.Drawing.Point(107, 276);
            this.cum_as_billedTextEdit.Name = "cum_as_billedTextEdit";
            this.cum_as_billedTextEdit.Properties.AutoHeight = false;
            this.cum_as_billedTextEdit.Size = new System.Drawing.Size(100, 101);
            this.cum_as_billedTextEdit.TabIndex = 21;
            // 
            // cum_should_beTextEdit
            // 
            this.cum_should_beTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "cum_should_be", true));
            this.cum_should_beTextEdit.Location = new System.Drawing.Point(208, 276);
            this.cum_should_beTextEdit.Name = "cum_should_beTextEdit";
            this.cum_should_beTextEdit.Properties.AutoHeight = false;
            this.cum_should_beTextEdit.Size = new System.Drawing.Size(100, 101);
            this.cum_should_beTextEdit.TabIndex = 23;
            // 
            // cum_adjustmentTextEdit
            // 
            this.cum_adjustmentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "cum_adjustment", true));
            this.cum_adjustmentTextEdit.Location = new System.Drawing.Point(308, 276);
            this.cum_adjustmentTextEdit.Name = "cum_adjustmentTextEdit";
            this.cum_adjustmentTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cum_adjustmentTextEdit.Properties.Appearance.Options.UseFont = true;
            this.cum_adjustmentTextEdit.Properties.AutoHeight = false;
            this.cum_adjustmentTextEdit.Size = new System.Drawing.Size(100, 101);
            this.cum_adjustmentTextEdit.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accounttitleDataGridViewTextBoxColumn,
            this.accountcodeDataGridViewTextBoxColumn,
            this.amtdebitDataGridViewTextBoxColumn,
            this.amtcreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbBAMJournalEntryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(414, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(406, 120);
            this.dataGridView1.TabIndex = 27;
            // 
            // accounttitleDataGridViewTextBoxColumn
            // 
            this.accounttitleDataGridViewTextBoxColumn.DataPropertyName = "account_title";
            this.accounttitleDataGridViewTextBoxColumn.HeaderText = "Acct Title";
            this.accounttitleDataGridViewTextBoxColumn.Name = "accounttitleDataGridViewTextBoxColumn";
            this.accounttitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountcodeDataGridViewTextBoxColumn
            // 
            this.accountcodeDataGridViewTextBoxColumn.DataPropertyName = "account_code";
            this.accountcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.accountcodeDataGridViewTextBoxColumn.Name = "accountcodeDataGridViewTextBoxColumn";
            this.accountcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amtdebitDataGridViewTextBoxColumn
            // 
            this.amtdebitDataGridViewTextBoxColumn.DataPropertyName = "amt_debit";
            this.amtdebitDataGridViewTextBoxColumn.HeaderText = "Debit";
            this.amtdebitDataGridViewTextBoxColumn.Name = "amtdebitDataGridViewTextBoxColumn";
            this.amtdebitDataGridViewTextBoxColumn.ReadOnly = true;
            this.amtdebitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // amtcreditDataGridViewTextBoxColumn
            // 
            this.amtcreditDataGridViewTextBoxColumn.DataPropertyName = "amt_credit";
            this.amtcreditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.amtcreditDataGridViewTextBoxColumn.Name = "amtcreditDataGridViewTextBoxColumn";
            this.amtcreditDataGridViewTextBoxColumn.ReadOnly = true;
            this.amtcreditDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbBAMJournalEntryBindingSource
            // 
            this.tbBAMJournalEntryBindingSource.DataMember = "tbBAMJournalEntry";
            this.tbBAMJournalEntryBindingSource.DataSource = this.dsBAMJournal;
            // 
            // dsBAMJournal
            // 
            this.dsBAMJournal.DataSetName = "dsBAMJournal";
            this.dsBAMJournal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBAMJournalEntryTableAdapter
            // 
            this.tbBAMJournalEntryTableAdapter.ClearBeforeFill = true;
            // 
            // debitSpinEdit
            // 
            this.debitSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "debit", true));
            this.debitSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.debitSpinEdit.Location = new System.Drawing.Point(608, 382);
            this.debitSpinEdit.Name = "debitSpinEdit";
            this.debitSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.debitSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.debitSpinEdit.Size = new System.Drawing.Size(106, 22);
            this.debitSpinEdit.TabIndex = 29;
            // 
            // creditSpinEdit
            // 
            this.creditSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "credit", true));
            this.creditSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.creditSpinEdit.Location = new System.Drawing.Point(719, 382);
            this.creditSpinEdit.Name = "creditSpinEdit";
            this.creditSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.creditSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.creditSpinEdit.Size = new System.Drawing.Size(100, 22);
            this.creditSpinEdit.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(354, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Approve this BAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txMasterID
            // 
            this.txMasterID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "master_id", true));
            this.txMasterID.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txMasterID.Location = new System.Drawing.Point(125, 198);
            this.txMasterID.Name = "txMasterID";
            this.txMasterID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txMasterID.Size = new System.Drawing.Size(90, 20);
            this.txMasterID.TabIndex = 32;
            this.txMasterID.TabStop = false;
            // 
            // bamcase_idSpinEdit
            // 
            this.bamcase_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vwBAMEntriesBindingSource, "bamcase_id", true));
            this.bamcase_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bamcase_idSpinEdit.Location = new System.Drawing.Point(125, 163);
            this.bamcase_idSpinEdit.Name = "bamcase_idSpinEdit";
            this.bamcase_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.bamcase_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bamcase_idSpinEdit.TabIndex = 35;
            this.bamcase_idSpinEdit.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Blue;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(413, 381);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(86, 29);
            this.btnList.TabIndex = 36;
            this.btnList.Text = "View List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Visible = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // formBAMApproved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 499);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.explanationTextEdit);
            this.Controls.Add(this.bamcase_idSpinEdit);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txMasterID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creditSpinEdit);
            this.Controls.Add(this.debitSpinEdit);
            this.Controls.Add(label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cum_adjustmentTextEdit);
            this.Controls.Add(label1);
            this.Controls.Add(cum_should_beLabel);
            this.Controls.Add(this.cum_should_beTextEdit);
            this.Controls.Add(cum_as_billedLabel);
            this.Controls.Add(this.cum_as_billedTextEdit);
            this.Controls.Add(billmonthLabel);
            this.Controls.Add(this.billmonthTextEdit);
            this.Controls.Add(last_readingLabel);
            this.Controls.Add(this.last_readingSpinEdit);
            this.Controls.Add(explanationLabel);
            this.Controls.Add(case_descLabel);
            this.Controls.Add(this.case_descTextEdit);
            this.Controls.Add(cardnoLabel);
            this.Controls.Add(this.cardnoTextEdit);
            this.Controls.Add(zonenoLabel);
            this.Controls.Add(this.zonenoTextEdit);
            this.Controls.Add(bam_dateLabel);
            this.Controls.Add(this.bam_dateDateEdit);
            this.Controls.Add(acctnameLabel);
            this.Controls.Add(this.acctnameTextEdit);
            this.Controls.Add(acctnoLabel);
            this.Controls.Add(this.acctnoTextEdit);
            this.Controls.Add(bamnoLabel);
            this.Controls.Add(this.bamnoTextEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBAMApproved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View / Approved";
            this.Load += new System.EventHandler(this.formBAMApproved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwBAMEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bam_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bam_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonenoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.case_descTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explanationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_readingSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billmonthTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_as_billedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_should_beTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cum_adjustmentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBAMJournalEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBAMJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMasterID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamcase_idSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBAMEntries dsBAMEntries;
        private System.Windows.Forms.BindingSource vwBAMEntriesBindingSource;
        private dsBAMEntriesTableAdapters.vwBAMEntriesTableAdapter vwBAMEntriesTableAdapter;
        private dsBAMEntriesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit bamnoTextEdit;
        private DevExpress.XtraEditors.TextEdit acctnoTextEdit;
        private DevExpress.XtraEditors.TextEdit acctnameTextEdit;
        private DevExpress.XtraEditors.DateEdit bam_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit zonenoTextEdit;
        private DevExpress.XtraEditors.TextEdit cardnoTextEdit;
        private DevExpress.XtraEditors.TextEdit case_descTextEdit;
        private DevExpress.XtraEditors.TextEdit explanationTextEdit;
        private DevExpress.XtraEditors.SpinEdit last_readingSpinEdit;
        private DevExpress.XtraEditors.TextEdit billmonthTextEdit;
        private DevExpress.XtraEditors.TextEdit cum_as_billedTextEdit;
        private DevExpress.XtraEditors.TextEdit cum_should_beTextEdit;
        private DevExpress.XtraEditors.TextEdit cum_adjustmentTextEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBAMJournal dsBAMJournal;
        private System.Windows.Forms.BindingSource tbBAMJournalEntryBindingSource;
        private dsBAMJournalTableAdapters.tbBAMJournalEntryTableAdapter tbBAMJournalEntryTableAdapter;
        private DevExpress.XtraEditors.SpinEdit debitSpinEdit;
        private DevExpress.XtraEditors.SpinEdit creditSpinEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn accounttitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtdebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtcreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SpinEdit txMasterID;
        private DevExpress.XtraEditors.SpinEdit bamcase_idSpinEdit;
        private System.Windows.Forms.Button btnList;
    }
}