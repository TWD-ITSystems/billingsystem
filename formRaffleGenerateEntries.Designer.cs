namespace BillingSystem
{
    partial class formRaffleGenerateEntries
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
            System.Windows.Forms.Label raffle_periodLabel;
            System.Windows.Forms.Label cutoff_dateLabel;
            System.Windows.Forms.Label draw_dateLabel;
            this.dbRafflePeriod = new BillingSystem.dbRafflePeriod();
            this.tbRafflePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRafflePeriodTableAdapter = new BillingSystem.dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter();
            this.tableAdapterManager = new BillingSystem.dbRafflePeriodTableAdapters.TableAdapterManager();
            this.raffle_periodComboBox = new System.Windows.Forms.ComboBox();
            this.cutoff_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.draw_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            raffle_periodLabel = new System.Windows.Forms.Label();
            cutoff_dateLabel = new System.Windows.Forms.Label();
            draw_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutoff_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutoff_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_dateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_dateDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dbRafflePeriod
            // 
            this.dbRafflePeriod.DataSetName = "dbRafflePeriod";
            this.dbRafflePeriod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRafflePeriodBindingSource
            // 
            this.tbRafflePeriodBindingSource.DataMember = "tbRafflePeriod";
            this.tbRafflePeriodBindingSource.DataSource = this.dbRafflePeriod;
            // 
            // tbRafflePeriodTableAdapter
            // 
            this.tbRafflePeriodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbRafflePeriodTableAdapter = this.tbRafflePeriodTableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSystem.dbRafflePeriodTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // raffle_periodLabel
            // 
            raffle_periodLabel.AutoSize = true;
            raffle_periodLabel.Location = new System.Drawing.Point(33, 26);
            raffle_periodLabel.Name = "raffle_periodLabel";
            raffle_periodLabel.Size = new System.Drawing.Size(71, 13);
            raffle_periodLabel.TabIndex = 2;
            raffle_periodLabel.Text = "Raffle Period:";
            // 
            // raffle_periodComboBox
            // 
            this.raffle_periodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbRafflePeriodBindingSource, "raffle_period", true));
            this.raffle_periodComboBox.DataSource = this.tbRafflePeriodBindingSource;
            this.raffle_periodComboBox.DisplayMember = "raffle_period";
            this.raffle_periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raffle_periodComboBox.FormattingEnabled = true;
            this.raffle_periodComboBox.Location = new System.Drawing.Point(110, 23);
            this.raffle_periodComboBox.Name = "raffle_periodComboBox";
            this.raffle_periodComboBox.Size = new System.Drawing.Size(166, 21);
            this.raffle_periodComboBox.TabIndex = 3;
            this.raffle_periodComboBox.ValueMember = "raffle_id";
            // 
            // cutoff_dateLabel
            // 
            cutoff_dateLabel.AutoSize = true;
            cutoff_dateLabel.Location = new System.Drawing.Point(43, 53);
            cutoff_dateLabel.Name = "cutoff_dateLabel";
            cutoff_dateLabel.Size = new System.Drawing.Size(64, 13);
            cutoff_dateLabel.TabIndex = 3;
            cutoff_dateLabel.Text = "Cutoff Date:";
            // 
            // cutoff_dateDateEdit
            // 
            this.cutoff_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbRafflePeriodBindingSource, "cutoff_date", true));
            this.cutoff_dateDateEdit.EditValue = null;
            this.cutoff_dateDateEdit.Location = new System.Drawing.Point(110, 50);
            this.cutoff_dateDateEdit.Name = "cutoff_dateDateEdit";
            this.cutoff_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cutoff_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cutoff_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.cutoff_dateDateEdit.TabIndex = 4;
            // 
            // draw_dateLabel
            // 
            draw_dateLabel.AutoSize = true;
            draw_dateLabel.Location = new System.Drawing.Point(47, 79);
            draw_dateLabel.Name = "draw_dateLabel";
            draw_dateLabel.Size = new System.Drawing.Size(61, 13);
            draw_dateLabel.TabIndex = 5;
            draw_dateLabel.Text = "Draw Date:";
            // 
            // draw_dateDateEdit
            // 
            this.draw_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbRafflePeriodBindingSource, "draw_date", true));
            this.draw_dateDateEdit.EditValue = null;
            this.draw_dateDateEdit.Location = new System.Drawing.Point(110, 76);
            this.draw_dateDateEdit.Name = "draw_dateDateEdit";
            this.draw_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.draw_dateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.draw_dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.draw_dateDateEdit.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressPanel1.Description = "Generating ...";
            this.progressPanel1.Location = new System.Drawing.Point(175, 53);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(174, 72);
            this.progressPanel1.TabIndex = 8;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // formRaffleGenerateEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 181);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(draw_dateLabel);
            this.Controls.Add(this.draw_dateDateEdit);
            this.Controls.Add(cutoff_dateLabel);
            this.Controls.Add(this.cutoff_dateDateEdit);
            this.Controls.Add(raffle_periodLabel);
            this.Controls.Add(this.raffle_periodComboBox);
            this.Name = "formRaffleGenerateEntries";
            this.Text = "Generate Raffle Entries";
            this.Load += new System.EventHandler(this.formRaffleGenerateEntries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbRafflePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRafflePeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutoff_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutoff_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_dateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_dateDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbRafflePeriod dbRafflePeriod;
        private System.Windows.Forms.BindingSource tbRafflePeriodBindingSource;
        private dbRafflePeriodTableAdapters.tbRafflePeriodTableAdapter tbRafflePeriodTableAdapter;
        private dbRafflePeriodTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox raffle_periodComboBox;
        private DevExpress.XtraEditors.DateEdit cutoff_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit draw_dateDateEdit;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}