
namespace Lab11_App
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.listViewCountries = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPolity = new System.Windows.Forms.ColumnHeader();
            this.toolStripCountries = new System.Windows.Forms.ToolStrip();
            this.toolStripCountriesButtonSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripCountriesButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripCountriesButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripCountriesButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.listViewCities = new System.Windows.Forms.ListView();
            this.columnHeaderCityId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCountryId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCityName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCityPopulation = new System.Windows.Forms.ColumnHeader();
            this.toolStripCities = new System.Windows.Forms.ToolStrip();
            this.toolStripCitiesButtonSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripCitiesButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripCitiesButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripCitiesButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            this.toolStripCountries.SuspendLayout();
            this.tabPageCities.SuspendLayout();
            this.toolStripCities.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCountries);
            this.tabControl1.Controls.Add(this.tabPageCities);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.listViewCountries);
            this.tabPageCountries.Controls.Add(this.toolStripCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 29);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(792, 417);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Countries";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // listViewCountries
            // 
            this.listViewCountries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderPolity});
            this.listViewCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCountries.FullRowSelect = true;
            this.listViewCountries.GridLines = true;
            this.listViewCountries.HideSelection = false;
            this.listViewCountries.Location = new System.Drawing.Point(3, 30);
            this.listViewCountries.Name = "listViewCountries";
            this.listViewCountries.Size = new System.Drawing.Size(786, 384);
            this.listViewCountries.TabIndex = 1;
            this.listViewCountries.UseCompatibleStateImageBehavior = false;
            this.listViewCountries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderPolity
            // 
            this.columnHeaderPolity.Text = "Polity";
            this.columnHeaderPolity.Width = 120;
            // 
            // toolStripCountries
            // 
            this.toolStripCountries.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCountries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCountriesButtonSelect,
            this.toolStripCountriesButtonInsert,
            this.toolStripCountriesButtonUpdate,
            this.toolStripCountriesButtonDelete});
            this.toolStripCountries.Location = new System.Drawing.Point(3, 3);
            this.toolStripCountries.Name = "toolStripCountries";
            this.toolStripCountries.Size = new System.Drawing.Size(786, 27);
            this.toolStripCountries.TabIndex = 0;
            this.toolStripCountries.Text = "toolStrip1";
            // 
            // toolStripCountriesButtonSelect
            // 
            this.toolStripCountriesButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCountriesButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCountriesButtonSelect.Image")));
            this.toolStripCountriesButtonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCountriesButtonSelect.Name = "toolStripCountriesButtonSelect";
            this.toolStripCountriesButtonSelect.Size = new System.Drawing.Size(62, 24);
            this.toolStripCountriesButtonSelect.Text = "Upload";
            this.toolStripCountriesButtonSelect.Click += new System.EventHandler(this.toolStripCountriesButtonSelect_Click);
            // 
            // toolStripCountriesButtonInsert
            // 
            this.toolStripCountriesButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCountriesButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCountriesButtonInsert.Image")));
            this.toolStripCountriesButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCountriesButtonInsert.Name = "toolStripCountriesButtonInsert";
            this.toolStripCountriesButtonInsert.Size = new System.Drawing.Size(49, 24);
            this.toolStripCountriesButtonInsert.Text = "Insert";
            this.toolStripCountriesButtonInsert.Click += new System.EventHandler(this.toolStripCountriesButtonInsert_Click);
            // 
            // toolStripCountriesButtonUpdate
            // 
            this.toolStripCountriesButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCountriesButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCountriesButtonUpdate.Image")));
            this.toolStripCountriesButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCountriesButtonUpdate.Name = "toolStripCountriesButtonUpdate";
            this.toolStripCountriesButtonUpdate.Size = new System.Drawing.Size(62, 24);
            this.toolStripCountriesButtonUpdate.Text = "Update";
            this.toolStripCountriesButtonUpdate.Click += new System.EventHandler(this.toolStripCountriesButtonUpdate_Click);
            // 
            // toolStripCountriesButtonDelete
            // 
            this.toolStripCountriesButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCountriesButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCountriesButtonDelete.Image")));
            this.toolStripCountriesButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCountriesButtonDelete.Name = "toolStripCountriesButtonDelete";
            this.toolStripCountriesButtonDelete.Size = new System.Drawing.Size(57, 24);
            this.toolStripCountriesButtonDelete.Text = "Delete";
            this.toolStripCountriesButtonDelete.Click += new System.EventHandler(this.toolStripCountriesButtonDelete_Click);
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.listViewCities);
            this.tabPageCities.Controls.Add(this.toolStripCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 29);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(792, 417);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Cities";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // listViewCities
            // 
            this.listViewCities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCityId,
            this.columnHeaderCountryId,
            this.columnHeaderCityName,
            this.columnHeaderCityPopulation});
            this.listViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCities.FullRowSelect = true;
            this.listViewCities.GridLines = true;
            this.listViewCities.HideSelection = false;
            this.listViewCities.Location = new System.Drawing.Point(3, 30);
            this.listViewCities.Name = "listViewCities";
            this.listViewCities.Size = new System.Drawing.Size(786, 384);
            this.listViewCities.TabIndex = 2;
            this.listViewCities.UseCompatibleStateImageBehavior = false;
            this.listViewCities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCityId
            // 
            this.columnHeaderCityId.Text = "Id";
            // 
            // columnHeaderCountryId
            // 
            this.columnHeaderCountryId.Text = "CountryId";
            this.columnHeaderCountryId.Width = 120;
            // 
            // columnHeaderCityName
            // 
            this.columnHeaderCityName.Text = "Name";
            this.columnHeaderCityName.Width = 120;
            // 
            // columnHeaderCityPopulation
            // 
            this.columnHeaderCityPopulation.Text = "Population";
            this.columnHeaderCityPopulation.Width = 120;
            // 
            // toolStripCities
            // 
            this.toolStripCities.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCitiesButtonSelect,
            this.toolStripCitiesButtonInsert,
            this.toolStripCitiesButtonUpdate,
            this.toolStripCitiesButtonDelete});
            this.toolStripCities.Location = new System.Drawing.Point(3, 3);
            this.toolStripCities.Name = "toolStripCities";
            this.toolStripCities.Size = new System.Drawing.Size(786, 27);
            this.toolStripCities.TabIndex = 1;
            this.toolStripCities.Text = "toolStrip1";
            // 
            // toolStripCitiesButtonSelect
            // 
            this.toolStripCitiesButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCitiesButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCitiesButtonSelect.Image")));
            this.toolStripCitiesButtonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCitiesButtonSelect.Name = "toolStripCitiesButtonSelect";
            this.toolStripCitiesButtonSelect.Size = new System.Drawing.Size(62, 24);
            this.toolStripCitiesButtonSelect.Text = "Upload";
            this.toolStripCitiesButtonSelect.Click += new System.EventHandler(this.toolStripCitiesButtonSelect_Click);
            // 
            // toolStripCitiesButtonInsert
            // 
            this.toolStripCitiesButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCitiesButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCitiesButtonInsert.Image")));
            this.toolStripCitiesButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCitiesButtonInsert.Name = "toolStripCitiesButtonInsert";
            this.toolStripCitiesButtonInsert.Size = new System.Drawing.Size(49, 24);
            this.toolStripCitiesButtonInsert.Text = "Insert";
            this.toolStripCitiesButtonInsert.Click += new System.EventHandler(this.toolStripCitiesButtonInsert_Click);
            // 
            // toolStripCitiesButtonUpdate
            // 
            this.toolStripCitiesButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCitiesButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCitiesButtonUpdate.Image")));
            this.toolStripCitiesButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCitiesButtonUpdate.Name = "toolStripCitiesButtonUpdate";
            this.toolStripCitiesButtonUpdate.Size = new System.Drawing.Size(62, 24);
            this.toolStripCitiesButtonUpdate.Text = "Update";
            this.toolStripCitiesButtonUpdate.Click += new System.EventHandler(this.toolStripCitiesButtonUpdate_Click);
            // 
            // toolStripCitiesButtonDelete
            // 
            this.toolStripCitiesButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCitiesButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCitiesButtonDelete.Image")));
            this.toolStripCitiesButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCitiesButtonDelete.Name = "toolStripCitiesButtonDelete";
            this.toolStripCitiesButtonDelete.Size = new System.Drawing.Size(57, 24);
            this.toolStripCitiesButtonDelete.Text = "Delete";
            this.toolStripCitiesButtonDelete.Click += new System.EventHandler(this.toolStripCitiesButtonDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            this.toolStripCountries.ResumeLayout(false);
            this.toolStripCountries.PerformLayout();
            this.tabPageCities.ResumeLayout(false);
            this.tabPageCities.PerformLayout();
            this.toolStripCities.ResumeLayout(false);
            this.toolStripCities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCountries;
        private System.Windows.Forms.ToolStrip toolStripCountries;
        private System.Windows.Forms.ToolStripButton toolStripCountriesButtonSelect;
        private System.Windows.Forms.ToolStripButton toolStripCountriesButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripCountriesButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripCountriesButtonDelete;
        private System.Windows.Forms.TabPage tabPageCities;
        private System.Windows.Forms.ListView listViewCountries;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPolity;
        private System.Windows.Forms.ListView listViewCities;
        private System.Windows.Forms.ColumnHeader columnHeaderCityId;
        private System.Windows.Forms.ColumnHeader columnHeaderCountryId;
        private System.Windows.Forms.ColumnHeader columnHeaderCityName;
        private System.Windows.Forms.ColumnHeader columnHeaderCityPopulation;
        private System.Windows.Forms.ToolStrip toolStripCities;
        private System.Windows.Forms.ToolStripButton toolStripCitiesButtonSelect;
        private System.Windows.Forms.ToolStripButton toolStripCitiesButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripCitiesButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripCitiesButtonDelete;
    }
}

