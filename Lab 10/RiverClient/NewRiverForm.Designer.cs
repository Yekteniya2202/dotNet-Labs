
namespace RiverClient
{
    partial class NewRiverForm
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
            this.textBoxTribCount = new System.Windows.Forms.TextBox();
            this.textBoxRiverFoundDate = new System.Windows.Forms.TextBox();
            this.labelRiverTribCount = new System.Windows.Forms.Label();
            this.labelRiverFounDate = new System.Windows.Forms.Label();
            this.textBoxRiverLength = new System.Windows.Forms.TextBox();
            this.labelRiverLength = new System.Windows.Forms.Label();
            this.textBoxRiverName = new System.Windows.Forms.TextBox();
            this.labelRiverTitle = new System.Windows.Forms.Label();
            this.buttonNewRiver = new System.Windows.Forms.Button();
            this.labelRiverKey = new System.Windows.Forms.Label();
            this.textBoxRiverKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTribCount
            // 
            this.textBoxTribCount.Location = new System.Drawing.Point(388, 84);
            this.textBoxTribCount.Name = "textBoxTribCount";
            this.textBoxTribCount.Size = new System.Drawing.Size(125, 27);
            this.textBoxTribCount.TabIndex = 19;
            // 
            // textBoxRiverFoundDate
            // 
            this.textBoxRiverFoundDate.Location = new System.Drawing.Point(388, 48);
            this.textBoxRiverFoundDate.Name = "textBoxRiverFoundDate";
            this.textBoxRiverFoundDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverFoundDate.TabIndex = 18;
            // 
            // labelRiverTribCount
            // 
            this.labelRiverTribCount.AutoSize = true;
            this.labelRiverTribCount.Location = new System.Drawing.Point(261, 87);
            this.labelRiverTribCount.Name = "labelRiverTribCount";
            this.labelRiverTribCount.Size = new System.Drawing.Size(122, 20);
            this.labelRiverTribCount.TabIndex = 17;
            this.labelRiverTribCount.Text = "Число притоков";
            // 
            // labelRiverFounDate
            // 
            this.labelRiverFounDate.AutoSize = true;
            this.labelRiverFounDate.Location = new System.Drawing.Point(261, 51);
            this.labelRiverFounDate.Name = "labelRiverFounDate";
            this.labelRiverFounDate.Size = new System.Drawing.Size(121, 20);
            this.labelRiverFounDate.TabIndex = 16;
            this.labelRiverFounDate.Text = "Дата основания";
            // 
            // textBoxRiverLength
            // 
            this.textBoxRiverLength.Location = new System.Drawing.Point(130, 83);
            this.textBoxRiverLength.Name = "textBoxRiverLength";
            this.textBoxRiverLength.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverLength.TabIndex = 15;
            // 
            // labelRiverLength
            // 
            this.labelRiverLength.AutoSize = true;
            this.labelRiverLength.Location = new System.Drawing.Point(11, 86);
            this.labelRiverLength.Name = "labelRiverLength";
            this.labelRiverLength.Size = new System.Drawing.Size(119, 20);
            this.labelRiverLength.TabIndex = 14;
            this.labelRiverLength.Text = "Протяженность";
            // 
            // textBoxRiverName
            // 
            this.textBoxRiverName.Location = new System.Drawing.Point(130, 48);
            this.textBoxRiverName.Name = "textBoxRiverName";
            this.textBoxRiverName.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverName.TabIndex = 13;
            // 
            // labelRiverTitle
            // 
            this.labelRiverTitle.AutoSize = true;
            this.labelRiverTitle.Location = new System.Drawing.Point(29, 51);
            this.labelRiverTitle.Name = "labelRiverTitle";
            this.labelRiverTitle.Size = new System.Drawing.Size(77, 20);
            this.labelRiverTitle.TabIndex = 12;
            this.labelRiverTitle.Text = "Название";
            // 
            // buttonNewRiver
            // 
            this.buttonNewRiver.Location = new System.Drawing.Point(12, 122);
            this.buttonNewRiver.Name = "buttonNewRiver";
            this.buttonNewRiver.Size = new System.Drawing.Size(501, 29);
            this.buttonNewRiver.TabIndex = 20;
            this.buttonNewRiver.Text = "Создать";
            this.buttonNewRiver.UseVisualStyleBackColor = true;
            this.buttonNewRiver.Click += new System.EventHandler(this.buttonNewRiver_Click);
            // 
            // labelRiverKey
            // 
            this.labelRiverKey.AutoSize = true;
            this.labelRiverKey.Location = new System.Drawing.Point(162, 15);
            this.labelRiverKey.Name = "labelRiverKey";
            this.labelRiverKey.Size = new System.Drawing.Size(46, 20);
            this.labelRiverKey.TabIndex = 21;
            this.labelRiverKey.Text = "Ключ";
            this.labelRiverKey.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxRiverKey
            // 
            this.textBoxRiverKey.Location = new System.Drawing.Point(214, 12);
            this.textBoxRiverKey.Name = "textBoxRiverKey";
            this.textBoxRiverKey.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverKey.TabIndex = 22;
            // 
            // NewRiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 158);
            this.Controls.Add(this.textBoxRiverKey);
            this.Controls.Add(this.labelRiverKey);
            this.Controls.Add(this.buttonNewRiver);
            this.Controls.Add(this.textBoxTribCount);
            this.Controls.Add(this.textBoxRiverFoundDate);
            this.Controls.Add(this.labelRiverTribCount);
            this.Controls.Add(this.labelRiverFounDate);
            this.Controls.Add(this.textBoxRiverLength);
            this.Controls.Add(this.labelRiverLength);
            this.Controls.Add(this.textBoxRiverName);
            this.Controls.Add(this.labelRiverTitle);
            this.Name = "NewRiverForm";
            this.Text = "NewRiverForm";
            this.Load += new System.EventHandler(this.NewRiverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTribCount;
        private System.Windows.Forms.TextBox textBoxRiverFoundDate;
        private System.Windows.Forms.Label labelRiverTribCount;
        private System.Windows.Forms.Label labelRiverFounDate;
        private System.Windows.Forms.TextBox textBoxRiverLength;
        private System.Windows.Forms.Label labelRiverLength;
        private System.Windows.Forms.TextBox textBoxRiverName;
        private System.Windows.Forms.Label labelRiverTitle;
        private System.Windows.Forms.Button buttonNewRiver;
        private System.Windows.Forms.Label labelRiverKey;
        private System.Windows.Forms.TextBox textBoxRiverKey;
    }
}