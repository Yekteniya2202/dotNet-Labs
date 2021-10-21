
namespace RiverForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWithKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riverToolStripMenuItem
            // 
            this.riverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getByKeyToolStripMenuItem,
            this.deleteByKeyToolStripMenuItem,
            this.updateByKeyToolStripMenuItem,
            this.addWithKeyToolStripMenuItem});
            this.riverToolStripMenuItem.Name = "riverToolStripMenuItem";
            this.riverToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.riverToolStripMenuItem.Text = "River";
            // 
            // getByKeyToolStripMenuItem
            // 
            this.getByKeyToolStripMenuItem.Name = "getByKeyToolStripMenuItem";
            this.getByKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getByKeyToolStripMenuItem.Text = "Get by key";
            this.getByKeyToolStripMenuItem.Click += new System.EventHandler(this.getByKeyToolStripMenuItem_Click);
            // 
            // deleteByKeyToolStripMenuItem
            // 
            this.deleteByKeyToolStripMenuItem.Name = "deleteByKeyToolStripMenuItem";
            this.deleteByKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteByKeyToolStripMenuItem.Text = "Delete by key";
            this.deleteByKeyToolStripMenuItem.Click += new System.EventHandler(this.deleteByKeyToolStripMenuItem_Click);
            // 
            // updateByKeyToolStripMenuItem
            // 
            this.updateByKeyToolStripMenuItem.Name = "updateByKeyToolStripMenuItem";
            this.updateByKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateByKeyToolStripMenuItem.Text = "Update by key";
            this.updateByKeyToolStripMenuItem.Click += new System.EventHandler(this.updateByKeyToolStripMenuItem_Click);
            // 
            // addWithKeyToolStripMenuItem
            // 
            this.addWithKeyToolStripMenuItem.Name = "addWithKeyToolStripMenuItem";
            this.addWithKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addWithKeyToolStripMenuItem.Text = "Add with key";
            this.addWithKeyToolStripMenuItem.Click += new System.EventHandler(this.addWithKeyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getByKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteByKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateByKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWithKeyToolStripMenuItem;
    }
}

