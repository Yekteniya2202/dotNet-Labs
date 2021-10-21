
namespace WinFormsControlLibraryRiver
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRiverKey = new System.Windows.Forms.Label();
            this.textBoxRiverKey = new System.Windows.Forms.TextBox();
            this.labelRiverTitle = new System.Windows.Forms.Label();
            this.textBoxRiverName = new System.Windows.Forms.TextBox();
            this.labelRiverLength = new System.Windows.Forms.Label();
            this.textBoxRiverLength = new System.Windows.Forms.TextBox();
            this.labelRiverFounDate = new System.Windows.Forms.Label();
            this.labelRiverTribCount = new System.Windows.Forms.Label();
            this.textBoxTribCount = new System.Windows.Forms.TextBox();
            this.textBoxRiverFoundDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRiverKey
            // 
            this.labelRiverKey.AutoSize = true;
            this.labelRiverKey.Location = new System.Drawing.Point(39, 7);
            this.labelRiverKey.Name = "labelRiverKey";
            this.labelRiverKey.Size = new System.Drawing.Size(46, 20);
            this.labelRiverKey.TabIndex = 0;
            this.labelRiverKey.Text = "Ключ";
            // 
            // textBoxRiverKey
            // 
            this.textBoxRiverKey.Location = new System.Drawing.Point(126, 4);
            this.textBoxRiverKey.Name = "textBoxRiverKey";
            this.textBoxRiverKey.ReadOnly = true;
            this.textBoxRiverKey.Size = new System.Drawing.Size(77, 27);
            this.textBoxRiverKey.TabIndex = 1;
            // 
            // labelRiverTitle
            // 
            this.labelRiverTitle.AutoSize = true;
            this.labelRiverTitle.Location = new System.Drawing.Point(25, 43);
            this.labelRiverTitle.Name = "labelRiverTitle";
            this.labelRiverTitle.Size = new System.Drawing.Size(77, 20);
            this.labelRiverTitle.TabIndex = 2;
            this.labelRiverTitle.Text = "Название";
            // 
            // textBoxRiverName
            // 
            this.textBoxRiverName.Location = new System.Drawing.Point(126, 40);
            this.textBoxRiverName.Name = "textBoxRiverName";
            this.textBoxRiverName.ReadOnly = true;
            this.textBoxRiverName.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverName.TabIndex = 3;
            // 
            // labelRiverLength
            // 
            this.labelRiverLength.AutoSize = true;
            this.labelRiverLength.Location = new System.Drawing.Point(7, 78);
            this.labelRiverLength.Name = "labelRiverLength";
            this.labelRiverLength.Size = new System.Drawing.Size(119, 20);
            this.labelRiverLength.TabIndex = 4;
            this.labelRiverLength.Text = "Протяженность";
            // 
            // textBoxRiverLength
            // 
            this.textBoxRiverLength.Location = new System.Drawing.Point(126, 75);
            this.textBoxRiverLength.Name = "textBoxRiverLength";
            this.textBoxRiverLength.ReadOnly = true;
            this.textBoxRiverLength.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverLength.TabIndex = 5;
            // 
            // labelRiverFounDate
            // 
            this.labelRiverFounDate.AutoSize = true;
            this.labelRiverFounDate.Location = new System.Drawing.Point(259, 7);
            this.labelRiverFounDate.Name = "labelRiverFounDate";
            this.labelRiverFounDate.Size = new System.Drawing.Size(121, 20);
            this.labelRiverFounDate.TabIndex = 6;
            this.labelRiverFounDate.Text = "Дата основания";
            // 
            // labelRiverTribCount
            // 
            this.labelRiverTribCount.AutoSize = true;
            this.labelRiverTribCount.Location = new System.Drawing.Point(259, 43);
            this.labelRiverTribCount.Name = "labelRiverTribCount";
            this.labelRiverTribCount.Size = new System.Drawing.Size(122, 20);
            this.labelRiverTribCount.TabIndex = 7;
            this.labelRiverTribCount.Text = "Число притоков";
            // 
            // textBoxTribCount
            // 
            this.textBoxTribCount.Location = new System.Drawing.Point(386, 40);
            this.textBoxTribCount.Name = "textBoxTribCount";
            this.textBoxTribCount.ReadOnly = true;
            this.textBoxTribCount.Size = new System.Drawing.Size(125, 27);
            this.textBoxTribCount.TabIndex = 9;
            // 
            // textBoxRiverFoundDate
            // 
            this.textBoxRiverFoundDate.Location = new System.Drawing.Point(386, 4);
            this.textBoxRiverFoundDate.Name = "textBoxRiverFoundDate";
            this.textBoxRiverFoundDate.ReadOnly = true;
            this.textBoxRiverFoundDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxRiverFoundDate.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTribCount);
            this.Controls.Add(this.textBoxRiverFoundDate);
            this.Controls.Add(this.labelRiverTribCount);
            this.Controls.Add(this.labelRiverFounDate);
            this.Controls.Add(this.textBoxRiverLength);
            this.Controls.Add(this.labelRiverLength);
            this.Controls.Add(this.textBoxRiverName);
            this.Controls.Add(this.labelRiverTitle);
            this.Controls.Add(this.textBoxRiverKey);
            this.Controls.Add(this.labelRiverKey);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(533, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRiverKey;
        private System.Windows.Forms.TextBox textBoxRiverKey;
        private System.Windows.Forms.Label labelRiverTitle;
        private System.Windows.Forms.TextBox textBoxRiverName;
        private System.Windows.Forms.Label labelRiverLength;
        private System.Windows.Forms.TextBox textBoxRiverLength;
        private System.Windows.Forms.Label labelRiverFounDate;
        private System.Windows.Forms.Label labelRiverTribCount;
        private System.Windows.Forms.TextBox textBoxTribCount;
        private System.Windows.Forms.TextBox textBoxRiverFoundDate;
    }
}
