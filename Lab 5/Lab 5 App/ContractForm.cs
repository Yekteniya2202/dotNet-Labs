using InsuranseCompanyCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_App
{
    public partial class ContractForm : Form
    {
        public InsuranseContract Contract;
        public ContractForm()
        {
            InitializeComponent();
        }
        public ContractForm(InsuranseContract contract)
        {
            InitializeComponent();
            Contract = contract;
            NumberTextBox.Text = contract.Number.ToString();
            DateOfConclusionDateTimePicker.Value = contract.DateOfConclusion;
            SumNumericUpDown.Value = contract.Amount;
            TariffRateNumericUpDown.Value = contract.TarifRate;
            foreach(var item in InsuranseCompany.Branches)
            {
                BranchComboBox.Items.Add(item.Value);
            }
            BranchComboBox.SelectedItem = contract.Branch;
            foreach (var item in InsuranseCompany.Types)
            {
                InsuranseTypeComboBox.Items.Add(item.Value);
            }
            InsuranseTypeComboBox.SelectedItem = contract.InsuranceType;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SaveContractButton_Click(object sender, EventArgs e)
        {
            Contract.DateOfConclusion = DateOfConclusionDateTimePicker.Value;
            Contract.Amount = SumNumericUpDown.Value;
            Contract.TarifRate = TariffRateNumericUpDown.Value;
            Contract.Branch = BranchComboBox.SelectedItem as InsuranseBranch;
            Contract.InsuranceType = InsuranseTypeComboBox.SelectedItem as InsuranseType;
            if (Contract.IsValid == false)
            {
                MessageBox.Show("Неправильно введены данные");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
