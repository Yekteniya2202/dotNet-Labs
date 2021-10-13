using InsuranseCompanyCL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_7_WFC
{
    public partial class UserControlContract : UserControl
    {
        private readonly InsuranseCompany _company = InsuranseCompany.Instance;
        public InsuranseContract Contract { get; }
        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControlContract)) continue;
                            var userControlCompany = control as UserControlContract;
                            if (userControlCompany != this)
                            {
                                userControlCompany.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }
        public UserControlContract()
        {

            InitializeComponent();
        }

        public UserControlContract(InsuranseContract contract)
        {
            InitializeComponent();
            Contract = contract;
        }

        private void UserControlCompany_Paint(object sender, PaintEventArgs e)
        {
            textBoxNumber.Text = $"{Contract.Number}";
            textBoxDateOfConclusion.Text = $@"{Contract.DateOfConclusion:dd MMMM yyyy}";
            textBoxAmount.Text = $"{ Contract.Amount}";
            textBoxTariffRate.Text = $"{ Contract.TarifRate}";
            textBoxBranch.Text = $"{ Contract.Branch.Name}";
            textBoxType.Text = $"{ Contract.InsuranceType.InsuranseName}";
            if (Contract.TarifRate > (decimal)0.3)
            {
                textBoxTariffRate.BackColor = Color.Red;
            }
            else if (Contract.TarifRate > (decimal)0.1)
            {
                textBoxTariffRate.BackColor = Color.Yellow;
            }
            else
            {
                textBoxTariffRate.BackColor = Color.Green;
            }

            if (Contract.Amount < 10000)
            {
                textBoxAmount.BackColor = Color.Red;
            }
            else if (Contract.Amount < 300000)
            {
                textBoxAmount.BackColor = Color.Yellow;
            }
            else 
            {
                textBoxAmount.BackColor = Color.Green;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlCompany_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _company.RemoveContract(Contract);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о договоре");
            }
        }
    }
}
