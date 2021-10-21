
namespace RiverForm
{
    partial class UpdateForm
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
            this.labelKey = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTrib = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxTribCount = new System.Windows.Forms.TextBox();
            this.textBoxFounDate = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(13, 13);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(49, 20);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "Ключ:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(13, 87);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(122, 20);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Протяженность:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 126);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(113, 20);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата открытия:";
            // 
            // labelTrib
            // 
            this.labelTrib.AutoSize = true;
            this.labelTrib.Location = new System.Drawing.Point(13, 167);
            this.labelTrib.Name = "labelTrib";
            this.labelTrib.Size = new System.Drawing.Size(125, 20);
            this.labelTrib.TabIndex = 4;
            this.labelTrib.Text = "Число притоков:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(144, 10);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(179, 27);
            this.textBoxKey.TabIndex = 5;
            // 
            // textBoxTribCount
            // 
            this.textBoxTribCount.Location = new System.Drawing.Point(144, 164);
            this.textBoxTribCount.Name = "textBoxTribCount";
            this.textBoxTribCount.Size = new System.Drawing.Size(179, 27);
            this.textBoxTribCount.TabIndex = 6;
            // 
            // textBoxFounDate
            // 
            this.textBoxFounDate.Location = new System.Drawing.Point(144, 123);
            this.textBoxFounDate.Name = "textBoxFounDate";
            this.textBoxFounDate.Size = new System.Drawing.Size(179, 27);
            this.textBoxFounDate.TabIndex = 7;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(144, 84);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(179, 27);
            this.textBoxLength.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(144, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(179, 27);
            this.textBoxTitle.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(13, 207);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(310, 29);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 248);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxFounDate);
            this.Controls.Add(this.textBoxTribCount);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelTrib);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelKey);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTrib;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxTribCount;
        private System.Windows.Forms.TextBox textBoxFounDate;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonUpdate;
    }
}