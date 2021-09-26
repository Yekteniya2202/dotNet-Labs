using System;
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
    public partial class BranchForm : Form
    {
        public InsuranseBranch Branch;
        public BranchForm()
        {
            InitializeComponent();
        }
        public BranchForm(InsuranseBranch branch)
        {
            InitializeComponent();
            if (branch == null) throw new ApplicationException("Нельзя отредактировать несуществующий филиал");
            Branch = branch;
            NameBranchTextBox.Text = Branch.Name;
            AddressBranchTextBox.Text = Branch.Address;
            PhoneBranchTextBox.Text = Branch.PhoneNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBranchButton_Click(object sender, EventArgs e)
        {
            Branch.Name = NameBranchTextBox.Text;
            Branch.Address = AddressBranchTextBox.Text;
            Branch.PhoneNumber = PhoneBranchTextBox.Text;

            if(Branch.IsValid == false)
            {
                MessageBox.Show("Неправильно введены данные");
                return;
            }
            this.Dispose();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
