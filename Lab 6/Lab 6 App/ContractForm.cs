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
        private InsuranseContract _contract;
        public InsuranseContract Contract
        {
            get { return _contract; }
            set
            {
                _contract = value;
                NumberTextBox.Text = Contract.Number.ToString();
                DateOfConclusionDateTimePicker.Value = Contract.DateOfConclusion;
                SumNumericUpDown.Value = Contract.Amount;
                TariffRateNumericUpDown.Value = Contract.TarifRate;
            }
        }

        private readonly InsuranseCompany _company = InsuranseCompany.Instance;

        public ContractForm()
        {
            InitializeComponent();
            _company.TypeAdded += _company_TypeAdded;
            _company.TypeRemoved += _company_TypeRemoved;
            _company.BranchAdded += _company_BranchAdded;
            _company.BranchRemoved += _company_BranchRemoved;
            foreach(var type in _company.Types)
            {
                InsuranseTypeComboBox.Items.Add(type);
            }
            foreach (var branch in _company.Branches)
            {
                BranchComboBox.Items.Add(branch);
            }
        }
        
        private void _company_TypeAdded(object sender, EventArgs e)
        {
            InsuranseTypeComboBox.Items.Add(sender);
        }

        private void _company_TypeRemoved(object sender, EventArgs e)
        {
            int number = (int)sender;
            for (int i = 0; i < InsuranseTypeComboBox.Items.Count; i++)
            {
                var type = InsuranseTypeComboBox.Items[i] as InsuranseType;
                if (type?.Number == number)
                {
                    InsuranseTypeComboBox.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_BranchAdded(object sender, EventArgs e)
        {
            BranchComboBox.Items.Add(sender);
        }

        private void _company_BranchRemoved(object sender, EventArgs e)
        {
            int number = (int)sender;
            for (int i = 0; i < BranchComboBox.Items.Count; i++)
            {
                var branch = BranchComboBox.Items[i] as InsuranseBranch;
                if (branch?.Number == number)
                {
                    BranchComboBox.Items.RemoveAt(i);
                    break;
                }
            }
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

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
