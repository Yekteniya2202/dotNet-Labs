
namespace RiverForm
{
    partial class GetDeleteForm
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonGetDelete = new System.Windows.Forms.Button();
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
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(68, 10);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(224, 27);
            this.textBoxKey.TabIndex = 1;
            // 
            // buttonGetDelete
            // 
            this.buttonGetDelete.Location = new System.Drawing.Point(13, 47);
            this.buttonGetDelete.Name = "buttonGetDelete";
            this.buttonGetDelete.Size = new System.Drawing.Size(279, 29);
            this.buttonGetDelete.TabIndex = 2;
            this.buttonGetDelete.Text = "button1";
            this.buttonGetDelete.UseVisualStyleBackColor = true;
            this.buttonGetDelete.Click += new System.EventHandler(this.buttonGetDelete_Click);
            // 
            // GetDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 88);
            this.Controls.Add(this.buttonGetDelete);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Name = "GetDeleteForm";
            this.Text = "GetDeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonGetDelete;
    }
}