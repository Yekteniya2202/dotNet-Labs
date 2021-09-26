
namespace WinFormsApp1
{
    partial class Form1
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
            this.BorderStyleButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.OpacityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorderStyleButton
            // 
            this.BorderStyleButton.Location = new System.Drawing.Point(12, 12);
            this.BorderStyleButton.Name = "BorderStyleButton";
            this.BorderStyleButton.Size = new System.Drawing.Size(147, 29);
            this.BorderStyleButton.TabIndex = 0;
            this.BorderStyleButton.Text = "Border Style";
            this.BorderStyleButton.UseVisualStyleBackColor = true;
            this.BorderStyleButton.Click += new System.EventHandler(this.BorderStyleButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Location = new System.Drawing.Point(12, 60);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(147, 29);
            this.ResizeButton.TabIndex = 1;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // OpacityButton
            // 
            this.OpacityButton.Location = new System.Drawing.Point(12, 110);
            this.OpacityButton.Name = "OpacityButton";
            this.OpacityButton.Size = new System.Drawing.Size(147, 29);
            this.OpacityButton.TabIndex = 2;
            this.OpacityButton.Text = "Opacity";
            this.OpacityButton.UseVisualStyleBackColor = true;
            this.OpacityButton.Click += new System.EventHandler(this.OpacityButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpacityButton);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.BorderStyleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BorderStyleButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button OpacityButton;
    }
}