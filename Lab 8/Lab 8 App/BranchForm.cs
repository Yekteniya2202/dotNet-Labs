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
        private InsuranseBranch _branch;
        public InsuranseBranch Branch 
        {
            get { return _branch; }
            set 
            {
                _branch = value;
                NameBranchTextBox.Text = Branch.Name;
                AddressBranchTextBox.Text = Branch.Address;
                PhoneBranchTextBox.Text = Branch.PhoneNumber;
            }
        }
        public BranchForm()
        {
            InitializeComponent();
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
            _branch.Name = NameBranchTextBox.Text;
            _branch.Address = AddressBranchTextBox.Text;
            _branch.PhoneNumber = PhoneBranchTextBox.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {

        }

        private void PhoneBranchTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
