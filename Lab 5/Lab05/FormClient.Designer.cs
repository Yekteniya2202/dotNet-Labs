namespace Lab05
{
    partial class FormClient
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxIssuer = new System.Windows.Forms.TextBox();
            this.labelIssuer = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxSeria = new System.Windows.Forms.TextBox();
            this.labelSeria = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.groupBoxPassport = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxPassport.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 20);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(74, 17);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(105, 16);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(175, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(105, 48);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(175, 22);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 52);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(105, 80);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(175, 22);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(16, 84);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(75, 17);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxIssuer
            // 
            this.textBoxIssuer.Location = new System.Drawing.Point(123, 127);
            this.textBoxIssuer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIssuer.Name = "textBoxIssuer";
            this.textBoxIssuer.Size = new System.Drawing.Size(192, 22);
            this.textBoxIssuer.TabIndex = 7;
            // 
            // labelIssuer
            // 
            this.labelIssuer.AutoSize = true;
            this.labelIssuer.Location = new System.Drawing.Point(8, 130);
            this.labelIssuer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssuer.Name = "labelIssuer";
            this.labelIssuer.Size = new System.Drawing.Size(83, 17);
            this.labelIssuer.TabIndex = 6;
            this.labelIssuer.Text = "Кем выдан:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(8, 98);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(99, 17);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата выдачи:";
            // 
            // textBoxSeria
            // 
            this.textBoxSeria.AllowDrop = true;
            this.textBoxSeria.Location = new System.Drawing.Point(123, 63);
            this.textBoxSeria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSeria.Name = "textBoxSeria";
            this.textBoxSeria.Size = new System.Drawing.Size(192, 22);
            this.textBoxSeria.TabIndex = 11;
            // 
            // labelSeria
            // 
            this.labelSeria.AutoSize = true;
            this.labelSeria.Location = new System.Drawing.Point(8, 66);
            this.labelSeria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeria.Name = "labelSeria";
            this.labelSeria.Size = new System.Drawing.Size(53, 17);
            this.labelSeria.TabIndex = 10;
            this.labelSeria.Text = "Серия:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(123, 31);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(192, 22);
            this.textBoxNumber.TabIndex = 13;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(8, 34);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(55, 17);
            this.labelNumber.TabIndex = 12;
            this.labelNumber.Text = "Номер:";
            // 
            // groupBoxPassport
            // 
            this.groupBoxPassport.Controls.Add(this.dateTimePickerDate);
            this.groupBoxPassport.Controls.Add(this.labelNumber);
            this.groupBoxPassport.Controls.Add(this.textBoxNumber);
            this.groupBoxPassport.Controls.Add(this.labelIssuer);
            this.groupBoxPassport.Controls.Add(this.textBoxIssuer);
            this.groupBoxPassport.Controls.Add(this.textBoxSeria);
            this.groupBoxPassport.Controls.Add(this.labelDate);
            this.groupBoxPassport.Controls.Add(this.labelSeria);
            this.groupBoxPassport.Location = new System.Drawing.Point(289, 15);
            this.groupBoxPassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPassport.Name = "groupBoxPassport";
            this.groupBoxPassport.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPassport.Size = new System.Drawing.Size(324, 166);
            this.groupBoxPassport.TabIndex = 14;
            this.groupBoxPassport.TabStop = false;
            this.groupBoxPassport.Text = "Паспортные данные";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(123, 95);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(192, 22);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(481, 188);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 37);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormClient
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 240);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxPassport);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBoxPassport.ResumeLayout(false);
            this.groupBoxPassport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxIssuer;
        private System.Windows.Forms.Label labelIssuer;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxSeria;
        private System.Windows.Forms.Label labelSeria;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.GroupBox groupBoxPassport;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonSave;
    }
}