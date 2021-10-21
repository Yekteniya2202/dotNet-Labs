
namespace RiverClient
{
    partial class RiverForm
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
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllRiversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlRivers1 = new WinFormsControlLibraryRiver.UserControlRivers();
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
            this.addNewToolStripMenuItem,
            this.removeByKeyToolStripMenuItem,
            this.updateByKeyToolStripMenuItem,
            this.findToolStripMenuItem,
            this.getAllRiversToolStripMenuItem});
            this.riverToolStripMenuItem.Name = "riverToolStripMenuItem";
            this.riverToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.riverToolStripMenuItem.Text = "River";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // removeByKeyToolStripMenuItem
            // 
            this.removeByKeyToolStripMenuItem.Name = "removeByKeyToolStripMenuItem";
            this.removeByKeyToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.removeByKeyToolStripMenuItem.Text = "Remove by key";
            this.removeByKeyToolStripMenuItem.Click += new System.EventHandler(this.removeByKeyToolStripMenuItem_Click);
            // 
            // updateByKeyToolStripMenuItem
            // 
            this.updateByKeyToolStripMenuItem.Name = "updateByKeyToolStripMenuItem";
            this.updateByKeyToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.updateByKeyToolStripMenuItem.Text = "Update by key";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // getAllRiversToolStripMenuItem
            // 
            this.getAllRiversToolStripMenuItem.Name = "getAllRiversToolStripMenuItem";
            this.getAllRiversToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.getAllRiversToolStripMenuItem.Text = "Get all rivers";
            // 
            // userControlRivers1
            // 
            this.userControlRivers1.Location = new System.Drawing.Point(12, 31);
            this.userControlRivers1.Name = "userControlRivers1";
            this.userControlRivers1.River = null;
            this.userControlRivers1.Size = new System.Drawing.Size(666, 154);
            this.userControlRivers1.TabIndex = 1;
            this.userControlRivers1.Load += new System.EventHandler(this.userControlRivers1_Load);
            // 
            // RiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlRivers1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RiverForm";
            this.Text = "Rivers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeByKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateByKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllRiversToolStripMenuItem;
        private WinFormsControlLibraryRiver.UserControlRivers userControl11;
        private WinFormsControlLibraryRiver.UserControlRivers userControlRivers1;
    }
}

