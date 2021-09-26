﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranseCompanyCL;
namespace InsuranseCompanyForms
{
    public partial class InsuranceTypeForm : Form
    {
        public InsuranceType InsuranceType;
        public InsuranceTypeForm()
        {
            InitializeComponent();
        }
        public InsuranceTypeForm(InsuranceType insuranceType)
        {
            InitializeComponent();
            if (insuranceType == null) throw new ApplicationException("Нельзя отредактировать несуществующий филиал");
            InsuranceType = insuranceType;
            InsuranceTypeTextBox1.Text = InsuranceType.InsuranseName;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveInsuranceTypeButton_Click(object sender, EventArgs e)
        {

            InsuranceType.InsuranseName = InsuranceTypeTextBox1.Text;
            if (InsuranceType.IsValid == false)
            {
                MessageBox.Show("Неправильно введены данные");
                return;
            }
            this.Dispose();
        }

        private void InsuranceTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
