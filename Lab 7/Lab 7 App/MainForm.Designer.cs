
namespace InsuranseCompanyForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InsuranseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddInsuranseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInsuranseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsuranseBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddInsuranseBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInsuranseBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsuranseContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddInsuranseContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInsuranseContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsuranseCompanyTabControl = new System.Windows.Forms.TabControl();
            this.InsuranseTypesTabPage = new System.Windows.Forms.TabPage();
            this.InsuranseTypeListView = new System.Windows.Forms.ListView();
            this.InsuranseTypeNameСolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.InsuranseBranchesTabPage = new System.Windows.Forms.TabPage();
            this.InsuranseBranchListView = new System.Windows.Forms.ListView();
            this.InsuranseBranchNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.InsuranseBranchAddressColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.InsuranseBranchPhoneColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.InsuranseContractsTabPage = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.InsuranseCompanyTabControl.SuspendLayout();
            this.InsuranseTypesTabPage.SuspendLayout();
            this.InsuranseBranchesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsuranseTypeToolStripMenuItem,
            this.InsuranseBranchToolStripMenuItem,
            this.InsuranseContractToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // InsuranseTypeToolStripMenuItem
            // 
            this.InsuranseTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInsuranseTypeToolStripMenuItem,
            this.EditInsuranseTypeToolStripMenuItem});
            this.InsuranseTypeToolStripMenuItem.Name = "InsuranseTypeToolStripMenuItem";
            this.InsuranseTypeToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.InsuranseTypeToolStripMenuItem.Text = "Вид страхования";
            // 
            // AddInsuranseTypeToolStripMenuItem
            // 
            this.AddInsuranseTypeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.AddInsuranseTypeToolStripMenuItem.Name = "AddInsuranseTypeToolStripMenuItem";
            this.AddInsuranseTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.AddInsuranseTypeToolStripMenuItem.Text = "Добавить";
            this.AddInsuranseTypeToolStripMenuItem.Click += new System.EventHandler(this.AddInsuranseTypeToolStripMenuItem_Click);
            // 
            // EditInsuranseTypeToolStripMenuItem
            // 
            this.EditInsuranseTypeToolStripMenuItem.Name = "EditInsuranseTypeToolStripMenuItem";
            this.EditInsuranseTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.EditInsuranseTypeToolStripMenuItem.Text = "Редактировать";
            this.EditInsuranseTypeToolStripMenuItem.Click += new System.EventHandler(this.EditInsuranseTypeToolStripMenuItem_Click);
            // 
            // InsuranseBranchToolStripMenuItem
            // 
            this.InsuranseBranchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInsuranseBranchToolStripMenuItem,
            this.EditInsuranseBranchToolStripMenuItem});
            this.InsuranseBranchToolStripMenuItem.Name = "InsuranseBranchToolStripMenuItem";
            this.InsuranseBranchToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.InsuranseBranchToolStripMenuItem.Text = "Филиал";
            // 
            // AddInsuranseBranchToolStripMenuItem
            // 
            this.AddInsuranseBranchToolStripMenuItem.Name = "AddInsuranseBranchToolStripMenuItem";
            this.AddInsuranseBranchToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.AddInsuranseBranchToolStripMenuItem.Text = "Добавить";
            this.AddInsuranseBranchToolStripMenuItem.Click += new System.EventHandler(this.AddInsuranseBranchToolStripMenuItem_Click);
            // 
            // EditInsuranseBranchToolStripMenuItem
            // 
            this.EditInsuranseBranchToolStripMenuItem.Name = "EditInsuranseBranchToolStripMenuItem";
            this.EditInsuranseBranchToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.EditInsuranseBranchToolStripMenuItem.Text = "Редактировать";
            this.EditInsuranseBranchToolStripMenuItem.Click += new System.EventHandler(this.EditInsuranseBranchToolStripMenuItem_Click);
            // 
            // InsuranseContractToolStripMenuItem
            // 
            this.InsuranseContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInsuranseContractToolStripMenuItem,
            this.EditInsuranseContractToolStripMenuItem});
            this.InsuranseContractToolStripMenuItem.Name = "InsuranseContractToolStripMenuItem";
            this.InsuranseContractToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.InsuranseContractToolStripMenuItem.Text = "Договор";
            // 
            // AddInsuranseContractToolStripMenuItem
            // 
            this.AddInsuranseContractToolStripMenuItem.Name = "AddInsuranseContractToolStripMenuItem";
            this.AddInsuranseContractToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.AddInsuranseContractToolStripMenuItem.Text = "Добавить";
            this.AddInsuranseContractToolStripMenuItem.Click += new System.EventHandler(this.AddInsuranseContractToolStripMenuItem_Click);
            // 
            // EditInsuranseContractToolStripMenuItem
            // 
            this.EditInsuranseContractToolStripMenuItem.Name = "EditInsuranseContractToolStripMenuItem";
            this.EditInsuranseContractToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.EditInsuranseContractToolStripMenuItem.Text = "Редактировать";
            this.EditInsuranseContractToolStripMenuItem.Click += new System.EventHandler(this.EditInsuranseContractToolStripMenuItem_Click);
            // 
            // InsuranseCompanyTabControl
            // 
            this.InsuranseCompanyTabControl.Controls.Add(this.InsuranseTypesTabPage);
            this.InsuranseCompanyTabControl.Controls.Add(this.InsuranseBranchesTabPage);
            this.InsuranseCompanyTabControl.Controls.Add(this.InsuranseContractsTabPage);
            this.InsuranseCompanyTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsuranseCompanyTabControl.Location = new System.Drawing.Point(0, 28);
            this.InsuranseCompanyTabControl.Name = "InsuranseCompanyTabControl";
            this.InsuranseCompanyTabControl.SelectedIndex = 0;
            this.InsuranseCompanyTabControl.Size = new System.Drawing.Size(1093, 512);
            this.InsuranseCompanyTabControl.TabIndex = 1;
            // 
            // InsuranseTypesTabPage
            // 
            this.InsuranseTypesTabPage.Controls.Add(this.InsuranseTypeListView);
            this.InsuranseTypesTabPage.Location = new System.Drawing.Point(4, 29);
            this.InsuranseTypesTabPage.Name = "InsuranseTypesTabPage";
            this.InsuranseTypesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsuranseTypesTabPage.Size = new System.Drawing.Size(1085, 479);
            this.InsuranseTypesTabPage.TabIndex = 0;
            this.InsuranseTypesTabPage.Text = "Виды страхования";
            this.InsuranseTypesTabPage.UseVisualStyleBackColor = true;
            // 
            // InsuranseTypeListView
            // 
            this.InsuranseTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InsuranseTypeNameСolumnHeader});
            this.InsuranseTypeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsuranseTypeListView.FullRowSelect = true;
            this.InsuranseTypeListView.GridLines = true;
            this.InsuranseTypeListView.HideSelection = false;
            this.InsuranseTypeListView.Location = new System.Drawing.Point(3, 3);
            this.InsuranseTypeListView.MultiSelect = false;
            this.InsuranseTypeListView.Name = "InsuranseTypeListView";
            this.InsuranseTypeListView.Size = new System.Drawing.Size(1079, 473);
            this.InsuranseTypeListView.TabIndex = 0;
            this.InsuranseTypeListView.UseCompatibleStateImageBehavior = false;
            this.InsuranseTypeListView.View = System.Windows.Forms.View.Details;
            this.InsuranseTypeListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InsuranseTypeListView_KeyUp);
            // 
            // InsuranseTypeNameСolumnHeader
            // 
            this.InsuranseTypeNameСolumnHeader.Text = "Наименование";
            this.InsuranseTypeNameСolumnHeader.Width = 200;
            // 
            // InsuranseBranchesTabPage
            // 
            this.InsuranseBranchesTabPage.Controls.Add(this.InsuranseBranchListView);
            this.InsuranseBranchesTabPage.Location = new System.Drawing.Point(4, 29);
            this.InsuranseBranchesTabPage.Name = "InsuranseBranchesTabPage";
            this.InsuranseBranchesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsuranseBranchesTabPage.Size = new System.Drawing.Size(1085, 479);
            this.InsuranseBranchesTabPage.TabIndex = 1;
            this.InsuranseBranchesTabPage.Text = "Филиалы";
            this.InsuranseBranchesTabPage.UseVisualStyleBackColor = true;
            // 
            // InsuranseBranchListView
            // 
            this.InsuranseBranchListView.CausesValidation = false;
            this.InsuranseBranchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InsuranseBranchNameColumnHeader,
            this.InsuranseBranchAddressColumnHeader,
            this.InsuranseBranchPhoneColumnHeader});
            this.InsuranseBranchListView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsuranseBranchListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsuranseBranchListView.FullRowSelect = true;
            this.InsuranseBranchListView.GridLines = true;
            this.InsuranseBranchListView.HideSelection = false;
            this.InsuranseBranchListView.LabelEdit = true;
            this.InsuranseBranchListView.Location = new System.Drawing.Point(3, 3);
            this.InsuranseBranchListView.MultiSelect = false;
            this.InsuranseBranchListView.Name = "InsuranseBranchListView";
            this.InsuranseBranchListView.Size = new System.Drawing.Size(1079, 473);
            this.InsuranseBranchListView.TabIndex = 0;
            this.InsuranseBranchListView.UseCompatibleStateImageBehavior = false;
            this.InsuranseBranchListView.View = System.Windows.Forms.View.Details;
            this.InsuranseBranchListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InsuranseBranchListView_KeyUp);
            // 
            // InsuranseBranchNameColumnHeader
            // 
            this.InsuranseBranchNameColumnHeader.Text = "Наименование";
            this.InsuranseBranchNameColumnHeader.Width = 200;
            // 
            // InsuranseBranchAddressColumnHeader
            // 
            this.InsuranseBranchAddressColumnHeader.Text = "Адрес";
            this.InsuranseBranchAddressColumnHeader.Width = 200;
            // 
            // InsuranseBranchPhoneColumnHeader
            // 
            this.InsuranseBranchPhoneColumnHeader.Text = "Телефон";
            this.InsuranseBranchPhoneColumnHeader.Width = 200;
            // 
            // InsuranseContractsTabPage
            // 
            this.InsuranseContractsTabPage.Location = new System.Drawing.Point(4, 29);
            this.InsuranseContractsTabPage.Name = "InsuranseContractsTabPage";
            this.InsuranseContractsTabPage.Size = new System.Drawing.Size(1085, 479);
            this.InsuranseContractsTabPage.TabIndex = 2;
            this.InsuranseContractsTabPage.Text = "Договоры";
            this.InsuranseContractsTabPage.UseVisualStyleBackColor = true;
            this.InsuranseContractsTabPage.Click += new System.EventHandler(this.InsuranseContractsTabPage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 540);
            this.Controls.Add(this.InsuranseCompanyTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InsuranseCompanyTabControl.ResumeLayout(false);
            this.InsuranseTypesTabPage.ResumeLayout(false);
            this.InsuranseBranchesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InsuranseTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddInsuranseTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditInsuranseTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsuranseBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddInsuranseBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditInsuranseBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsuranseContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddInsuranseContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditInsuranseContractToolStripMenuItem;
        private System.Windows.Forms.TabControl InsuranseCompanyTabControl;
        private System.Windows.Forms.TabPage InsuranseTypesTabPage;
        private System.Windows.Forms.TabPage InsuranseBranchesTabPage;
        private System.Windows.Forms.TabPage InsuranseContractsTabPage;
        private System.Windows.Forms.ListView InsuranseTypeListView;
        private System.Windows.Forms.ColumnHeader InsuranseTypeNameСolumnHeader;
        private System.Windows.Forms.ListView InsuranseBranchListView;
        private System.Windows.Forms.ColumnHeader InsuranseBranchNameColumnHeader;
        private System.Windows.Forms.ColumnHeader InsuranseBranchAddressColumnHeader;
        private System.Windows.Forms.ColumnHeader InsuranseBranchPhoneColumnHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}