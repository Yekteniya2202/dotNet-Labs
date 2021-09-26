
namespace InsuranseCompanyForms
{
    partial class InsuranseTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.InsuranceTypeTextBox1 = new System.Windows.Forms.TextBox();
            this.SaveInsuranceTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид страхования:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsuranceTypeTextBox1
            // 
            this.InsuranceTypeTextBox1.Location = new System.Drawing.Point(165, 29);
            this.InsuranceTypeTextBox1.Name = "InsuranceTypeTextBox1";
            this.InsuranceTypeTextBox1.Size = new System.Drawing.Size(169, 27);
            this.InsuranceTypeTextBox1.TabIndex = 1;
            // 
            // SaveInsuranceTypeButton
            // 
            this.SaveInsuranceTypeButton.Location = new System.Drawing.Point(13, 179);
            this.SaveInsuranceTypeButton.Name = "SaveInsuranceTypeButton";
            this.SaveInsuranceTypeButton.Size = new System.Drawing.Size(364, 29);
            this.SaveInsuranceTypeButton.TabIndex = 2;
            this.SaveInsuranceTypeButton.Text = "Сохранить";
            this.SaveInsuranceTypeButton.UseVisualStyleBackColor = true;
            this.SaveInsuranceTypeButton.Click += new System.EventHandler(this.SaveInsuranceTypeButton_Click);
            // 
            // InsuranceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 220);
            this.Controls.Add(this.SaveInsuranceTypeButton);
            this.Controls.Add(this.InsuranceTypeTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "InsuranceTypeForm";
            this.Text = "InsuranceTypeForm";
            this.Load += new System.EventHandler(this.InsuranceTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsuranceTypeTextBox1;
        private System.Windows.Forms.Button SaveInsuranceTypeButton;
    }
}