
namespace InsuranseCompanyForms
{
    partial class BranchForm
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
            this.NameBranchTextBox = new System.Windows.Forms.TextBox();
            this.AddressBranchTextBox = new System.Windows.Forms.TextBox();
            this.SaveBranchButton = new System.Windows.Forms.Button();
            this.NameBranchLabel = new System.Windows.Forms.Label();
            this.AdressBranchLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneBranchTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NameBranchTextBox
            // 
            this.NameBranchTextBox.Location = new System.Drawing.Point(149, 9);
            this.NameBranchTextBox.Name = "NameBranchTextBox";
            this.NameBranchTextBox.Size = new System.Drawing.Size(247, 27);
            this.NameBranchTextBox.TabIndex = 7;
            // 
            // AddressBranchTextBox
            // 
            this.AddressBranchTextBox.Location = new System.Drawing.Point(149, 43);
            this.AddressBranchTextBox.Name = "AddressBranchTextBox";
            this.AddressBranchTextBox.Size = new System.Drawing.Size(247, 27);
            this.AddressBranchTextBox.TabIndex = 8;
            // 
            // SaveBranchButton
            // 
            this.SaveBranchButton.Location = new System.Drawing.Point(13, 195);
            this.SaveBranchButton.Name = "SaveBranchButton";
            this.SaveBranchButton.Size = new System.Drawing.Size(413, 29);
            this.SaveBranchButton.TabIndex = 9;
            this.SaveBranchButton.Text = "Сохранить";
            this.SaveBranchButton.UseVisualStyleBackColor = true;
            this.SaveBranchButton.Click += new System.EventHandler(this.SaveBranchButton_Click);
            // 
            // NameBranchLabel
            // 
            this.NameBranchLabel.AutoSize = true;
            this.NameBranchLabel.Location = new System.Drawing.Point(14, 10);
            this.NameBranchLabel.Name = "NameBranchLabel";
            this.NameBranchLabel.Size = new System.Drawing.Size(119, 20);
            this.NameBranchLabel.TabIndex = 10;
            this.NameBranchLabel.Text = "Наименование:";
            // 
            // AdressBranchLabel
            // 
            this.AdressBranchLabel.AutoSize = true;
            this.AdressBranchLabel.Location = new System.Drawing.Point(13, 43);
            this.AdressBranchLabel.Name = "AdressBranchLabel";
            this.AdressBranchLabel.Size = new System.Drawing.Size(54, 20);
            this.AdressBranchLabel.TabIndex = 11;
            this.AdressBranchLabel.Text = "Адрес:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 77);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(72, 20);
            this.PhoneNumberLabel.TabIndex = 12;
            this.PhoneNumberLabel.Text = "Телефон:";
            // 
            // PhoneBranchTextBox
            // 
            this.PhoneBranchTextBox.Location = new System.Drawing.Point(149, 77);
            this.PhoneBranchTextBox.Mask = "(999) 000-0000";
            this.PhoneBranchTextBox.Name = "PhoneBranchTextBox";
            this.PhoneBranchTextBox.Size = new System.Drawing.Size(247, 27);
            this.PhoneBranchTextBox.TabIndex = 13;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 236);
            this.Controls.Add(this.PhoneBranchTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.AdressBranchLabel);
            this.Controls.Add(this.NameBranchLabel);
            this.Controls.Add(this.SaveBranchButton);
            this.Controls.Add(this.AddressBranchTextBox);
            this.Controls.Add(this.NameBranchTextBox);
            this.Name = "BranchForm";
            this.Text = "BranchForm";
            this.Load += new System.EventHandler(this.BranchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBranchTextBox;
        private System.Windows.Forms.TextBox AddressBranchTextBox;
        private System.Windows.Forms.Button SaveBranchButton;
        private System.Windows.Forms.Label NameBranchLabel;
        private System.Windows.Forms.Label AdressBranchLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.MaskedTextBox PhoneBranchTextBox;
    }
}