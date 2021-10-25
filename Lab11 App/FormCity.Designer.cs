﻿
namespace Lab11_App
{
    partial class FormCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownCountryId = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPopulation = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CountryId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Population";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // numericUpDownCountryId
            // 
            this.numericUpDownCountryId.Location = new System.Drawing.Point(103, 13);
            this.numericUpDownCountryId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCountryId.Name = "numericUpDownCountryId";
            this.numericUpDownCountryId.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownCountryId.TabIndex = 4;
            // 
            // numericUpDownPopulation
            // 
            this.numericUpDownPopulation.Location = new System.Drawing.Point(103, 81);
            this.numericUpDownPopulation.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownPopulation.Name = "numericUpDownPopulation";
            this.numericUpDownPopulation.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPopulation.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 114);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 29);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 152);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownPopulation);
            this.Controls.Add(this.numericUpDownCountryId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCity";
            this.Text = "FormCity";
            this.Load += new System.EventHandler(this.FormCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownCountryId;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulation;
        private System.Windows.Forms.Button buttonSave;
    }
}