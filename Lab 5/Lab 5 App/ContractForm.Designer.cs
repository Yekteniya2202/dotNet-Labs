
namespace Lab_5_App
{
    partial class ContractForm
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
            this.ConratcNunberLabel = new System.Windows.Forms.Label();
            this.DateOfConclusionLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TariffRateLabel = new System.Windows.Forms.Label();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.InsuranseTypeLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.DateOfConclusionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TariffRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.InsuranseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveContractButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffRateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ConratcNunberLabel
            // 
            this.ConratcNunberLabel.AutoSize = true;
            this.ConratcNunberLabel.Location = new System.Drawing.Point(13, 13);
            this.ConratcNunberLabel.Name = "ConratcNunberLabel";
            this.ConratcNunberLabel.Size = new System.Drawing.Size(134, 20);
            this.ConratcNunberLabel.TabIndex = 0;
            this.ConratcNunberLabel.Text = "Номер договора: ";
            // 
            // DateOfConclusionLabel
            // 
            this.DateOfConclusionLabel.AutoSize = true;
            this.DateOfConclusionLabel.Location = new System.Drawing.Point(13, 60);
            this.DateOfConclusionLabel.Name = "DateOfConclusionLabel";
            this.DateOfConclusionLabel.Size = new System.Drawing.Size(132, 20);
            this.DateOfConclusionLabel.TabIndex = 1;
            this.DateOfConclusionLabel.Text = "Дата заключения:";
            this.DateOfConclusionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(13, 107);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(132, 20);
            this.SumLabel.TabIndex = 2;
            this.SumLabel.Text = "Страховая сумма:";
            // 
            // TariffRateLabel
            // 
            this.TariffRateLabel.AutoSize = true;
            this.TariffRateLabel.Location = new System.Drawing.Point(13, 154);
            this.TariffRateLabel.Name = "TariffRateLabel";
            this.TariffRateLabel.Size = new System.Drawing.Size(133, 20);
            this.TariffRateLabel.TabIndex = 3;
            this.TariffRateLabel.Text = "Тарифная ставка: ";
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(13, 201);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(65, 20);
            this.BranchLabel.TabIndex = 4;
            this.BranchLabel.Text = "Филиал:";
            // 
            // InsuranseTypeLabel
            // 
            this.InsuranseTypeLabel.AutoSize = true;
            this.InsuranseTypeLabel.Location = new System.Drawing.Point(13, 249);
            this.InsuranseTypeLabel.Name = "InsuranseTypeLabel";
            this.InsuranseTypeLabel.Size = new System.Drawing.Size(130, 20);
            this.InsuranseTypeLabel.TabIndex = 5;
            this.InsuranseTypeLabel.Text = "Вид страхования:";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(153, 6);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(250, 27);
            this.NumberTextBox.TabIndex = 6;
            // 
            // DateOfConclusionDateTimePicker
            // 
            this.DateOfConclusionDateTimePicker.Location = new System.Drawing.Point(153, 53);
            this.DateOfConclusionDateTimePicker.Name = "DateOfConclusionDateTimePicker";
            this.DateOfConclusionDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.DateOfConclusionDateTimePicker.TabIndex = 7;
            // 
            // SumNumericUpDown
            // 
            this.SumNumericUpDown.Location = new System.Drawing.Point(153, 100);
            this.SumNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SumNumericUpDown.Name = "SumNumericUpDown";
            this.SumNumericUpDown.Size = new System.Drawing.Size(250, 27);
            this.SumNumericUpDown.TabIndex = 8;
            // 
            // TariffRateNumericUpDown
            // 
            this.TariffRateNumericUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.TariffRateNumericUpDown.DecimalPlaces = 5;
            this.TariffRateNumericUpDown.Location = new System.Drawing.Point(153, 147);
            this.TariffRateNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TariffRateNumericUpDown.Name = "TariffRateNumericUpDown";
            this.TariffRateNumericUpDown.Size = new System.Drawing.Size(250, 27);
            this.TariffRateNumericUpDown.TabIndex = 9;
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(153, 194);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(250, 28);
            this.BranchComboBox.TabIndex = 10;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // InsuranseTypeComboBox
            // 
            this.InsuranseTypeComboBox.FormattingEnabled = true;
            this.InsuranseTypeComboBox.Location = new System.Drawing.Point(153, 242);
            this.InsuranseTypeComboBox.Name = "InsuranseTypeComboBox";
            this.InsuranseTypeComboBox.Size = new System.Drawing.Size(250, 28);
            this.InsuranseTypeComboBox.TabIndex = 11;
            // 
            // SaveContractButton
            // 
            this.SaveContractButton.Location = new System.Drawing.Point(13, 296);
            this.SaveContractButton.Name = "SaveContractButton";
            this.SaveContractButton.Size = new System.Drawing.Size(390, 29);
            this.SaveContractButton.TabIndex = 12;
            this.SaveContractButton.Text = "Сохранить";
            this.SaveContractButton.UseVisualStyleBackColor = true;
            this.SaveContractButton.Click += new System.EventHandler(this.SaveContractButton_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 337);
            this.Controls.Add(this.SaveContractButton);
            this.Controls.Add(this.InsuranseTypeComboBox);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.TariffRateNumericUpDown);
            this.Controls.Add(this.SumNumericUpDown);
            this.Controls.Add(this.DateOfConclusionDateTimePicker);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.InsuranseTypeLabel);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.TariffRateLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.DateOfConclusionLabel);
            this.Controls.Add(this.ConratcNunberLabel);
            this.Name = "ContractForm";
            this.Text = "ContractForm";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffRateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConratcNunberLabel;
        private System.Windows.Forms.Label DateOfConclusionLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TariffRateLabel;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.Label InsuranseTypeLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.DateTimePicker DateOfConclusionDateTimePicker;
        private System.Windows.Forms.NumericUpDown SumNumericUpDown;
        private System.Windows.Forms.NumericUpDown TariffRateNumericUpDown;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.ComboBox InsuranseTypeComboBox;
        private System.Windows.Forms.Button SaveContractButton;
    }
}