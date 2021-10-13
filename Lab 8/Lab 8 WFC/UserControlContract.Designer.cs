
namespace Lab_7_WFC
{
    partial class UserControlContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlContract));
            this.labelBranch = new System.Windows.Forms.Label();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelDateOfConclusion = new System.Windows.Forms.Label();
            this.textBoxDateOfConclusion = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelTariffRate = new System.Windows.Forms.Label();
            this.textBoxTariffRate = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(0, 80);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(65, 20);
            this.labelBranch.TabIndex = 0;
            this.labelBranch.Text = "Филиал:";
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(71, 77);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.ReadOnly = true;
            this.textBoxBranch.Size = new System.Drawing.Size(181, 27);
            this.textBoxBranch.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(258, 80);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(130, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Тип страхования:";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(394, 77);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(149, 27);
            this.textBoxType.TabIndex = 3;
            // 
            // labelDateOfConclusion
            // 
            this.labelDateOfConclusion.AutoSize = true;
            this.labelDateOfConclusion.Location = new System.Drawing.Point(202, 5);
            this.labelDateOfConclusion.Name = "labelDateOfConclusion";
            this.labelDateOfConclusion.Size = new System.Drawing.Size(132, 20);
            this.labelDateOfConclusion.TabIndex = 4;
            this.labelDateOfConclusion.Text = "Дата заключения:";
            // 
            // textBoxDateOfConclusion
            // 
            this.textBoxDateOfConclusion.Location = new System.Drawing.Point(341, 5);
            this.textBoxDateOfConclusion.Name = "textBoxDateOfConclusion";
            this.textBoxDateOfConclusion.ReadOnly = true;
            this.textBoxDateOfConclusion.Size = new System.Drawing.Size(208, 27);
            this.textBoxDateOfConclusion.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 41);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(58, 20);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Сумма:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(71, 41);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(152, 27);
            this.textBoxAmount.TabIndex = 7;
            // 
            // labelTariffRate
            // 
            this.labelTariffRate.AutoSize = true;
            this.labelTariffRate.Location = new System.Drawing.Point(229, 44);
            this.labelTariffRate.Name = "labelTariffRate";
            this.labelTariffRate.Size = new System.Drawing.Size(129, 20);
            this.labelTariffRate.TabIndex = 8;
            this.labelTariffRate.Text = "Тарифная ставка:";
            // 
            // textBoxTariffRate
            // 
            this.textBoxTariffRate.Location = new System.Drawing.Point(364, 41);
            this.textBoxTariffRate.Name = "textBoxTariffRate";
            this.textBoxTariffRate.ReadOnly = true;
            this.textBoxTariffRate.Size = new System.Drawing.Size(185, 27);
            this.textBoxTariffRate.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(555, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(38, 27);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(4, 5);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(60, 20);
            this.labelNumber.TabIndex = 11;
            this.labelNumber.Text = "Номер:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(71, 5);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(125, 27);
            this.textBoxNumber.TabIndex = 12;
            // 
            // UserControlCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxTariffRate);
            this.Controls.Add(this.labelTariffRate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxDateOfConclusion);
            this.Controls.Add(this.labelDateOfConclusion);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxBranch);
            this.Controls.Add(this.labelBranch);
            this.Name = "UserControlCompany";
            this.Size = new System.Drawing.Size(598, 119);
            this.Click += new System.EventHandler(this.UserControlCompany_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlCompany_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelDateOfConclusion;
        private System.Windows.Forms.TextBox textBoxDateOfConclusion;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelTariffRate;
        private System.Windows.Forms.TextBox textBoxTariffRate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
    }
}
