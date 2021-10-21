
namespace RiverClient
{
    partial class FindRiver
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
            this.textBoxRiverKey = new System.Windows.Forms.TextBox();
            this.labelRiverKey = new System.Windows.Forms.Label();
            this.buttonFindRiver = new System.Windows.Forms.Button();
            this.textBoxTribCount = new System.Windows.Forms.TextBox();
            this.textBoxRiverFoundDate = new System.Windows.Forms.TextBox();
            this.labelRiverTribCount = new System.Windows.Forms.Label();
            this.labelRiverFounDate = new System.Windows.Forms.Label();
            this.textBoxRiverLength = new System.Windows.Forms.TextBox();
            this.labelRiverLength = new System.Windows.Forms.Label();
            this.textBoxRiverName = new System.Windows.Forms.TextBox();
            this.labelRiverTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRiverKey
            // 
            this.textBoxRiverKey.Location = new System.Drawing.Point(216, 6);
            this.textBoxRiverKey.Name = "textBoxRiverKey";
            this.textBoxRiverKey.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverKey.TabIndex = 33;
            // 
            // labelRiverKey
            // 
            this.labelRiverKey.AutoSize = true;
            this.labelRiverKey.Location = new System.Drawing.Point(164, 9);
            this.labelRiverKey.Name = "labelRiverKey";
            this.labelRiverKey.Size = new System.Drawing.Size(46, 20);
            this.labelRiverKey.TabIndex = 32;
            this.labelRiverKey.Text = "Ключ";
            // 
            // buttonFindRiver
            // 
            this.buttonFindRiver.Location = new System.Drawing.Point(14, 116);
            this.buttonFindRiver.Name = "buttonFindRiver";
            this.buttonFindRiver.Size = new System.Drawing.Size(501, 29);
            this.buttonFindRiver.TabIndex = 31;
            this.buttonFindRiver.Text = "Найти";
            this.buttonFindRiver.UseVisualStyleBackColor = true;
            this.buttonFindRiver.Click += new System.EventHandler(this.buttonFindRiver_Click);
            // 
            // textBoxTribCount
            // 
            this.textBoxTribCount.Location = new System.Drawing.Point(390, 78);
            this.textBoxTribCount.Name = "textBoxTribCount";
            this.textBoxTribCount.Size = new System.Drawing.Size(125, 27);
            this.textBoxTribCount.TabIndex = 30;
            // 
            // textBoxRiverFoundDate
            // 
            this.textBoxRiverFoundDate.Location = new System.Drawing.Point(390, 42);
            this.textBoxRiverFoundDate.Name = "textBoxRiverFoundDate";
            this.textBoxRiverFoundDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverFoundDate.TabIndex = 29;
            // 
            // labelRiverTribCount
            // 
            this.labelRiverTribCount.AutoSize = true;
            this.labelRiverTribCount.Location = new System.Drawing.Point(263, 81);
            this.labelRiverTribCount.Name = "labelRiverTribCount";
            this.labelRiverTribCount.Size = new System.Drawing.Size(122, 20);
            this.labelRiverTribCount.TabIndex = 28;
            this.labelRiverTribCount.Text = "Число притоков";
            // 
            // labelRiverFounDate
            // 
            this.labelRiverFounDate.AutoSize = true;
            this.labelRiverFounDate.Location = new System.Drawing.Point(263, 45);
            this.labelRiverFounDate.Name = "labelRiverFounDate";
            this.labelRiverFounDate.Size = new System.Drawing.Size(121, 20);
            this.labelRiverFounDate.TabIndex = 27;
            this.labelRiverFounDate.Text = "Дата основания";
            // 
            // textBoxRiverLength
            // 
            this.textBoxRiverLength.Location = new System.Drawing.Point(132, 77);
            this.textBoxRiverLength.Name = "textBoxRiverLength";
            this.textBoxRiverLength.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverLength.TabIndex = 26;
            // 
            // labelRiverLength
            // 
            this.labelRiverLength.AutoSize = true;
            this.labelRiverLength.Location = new System.Drawing.Point(13, 80);
            this.labelRiverLength.Name = "labelRiverLength";
            this.labelRiverLength.Size = new System.Drawing.Size(119, 20);
            this.labelRiverLength.TabIndex = 25;
            this.labelRiverLength.Text = "Протяженность";
            // 
            // textBoxRiverName
            // 
            this.textBoxRiverName.Location = new System.Drawing.Point(132, 42);
            this.textBoxRiverName.Name = "textBoxRiverName";
            this.textBoxRiverName.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverName.TabIndex = 24;
            // 
            // labelRiverTitle
            // 
            this.labelRiverTitle.AutoSize = true;
            this.labelRiverTitle.Location = new System.Drawing.Point(31, 45);
            this.labelRiverTitle.Name = "labelRiverTitle";
            this.labelRiverTitle.Size = new System.Drawing.Size(77, 20);
            this.labelRiverTitle.TabIndex = 23;
            this.labelRiverTitle.Text = "Название";
            // 
            // FindRiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 160);
            this.Controls.Add(this.textBoxRiverKey);
            this.Controls.Add(this.labelRiverKey);
            this.Controls.Add(this.buttonFindRiver);
            this.Controls.Add(this.textBoxTribCount);
            this.Controls.Add(this.textBoxRiverFoundDate);
            this.Controls.Add(this.labelRiverTribCount);
            this.Controls.Add(this.labelRiverFounDate);
            this.Controls.Add(this.textBoxRiverLength);
            this.Controls.Add(this.labelRiverLength);
            this.Controls.Add(this.textBoxRiverName);
            this.Controls.Add(this.labelRiverTitle);
            this.Name = "FindRiver";
            this.Text = "FindRiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRiverKey;
        private System.Windows.Forms.Label labelRiverKey;
        private System.Windows.Forms.Button buttonFindRiver;
        private System.Windows.Forms.TextBox textBoxTribCount;
        private System.Windows.Forms.TextBox textBoxRiverFoundDate;
        private System.Windows.Forms.Label labelRiverTribCount;
        private System.Windows.Forms.Label labelRiverFounDate;
        private System.Windows.Forms.TextBox textBoxRiverLength;
        private System.Windows.Forms.Label labelRiverLength;
        private System.Windows.Forms.TextBox textBoxRiverName;
        private System.Windows.Forms.Label labelRiverTitle;
    }
}