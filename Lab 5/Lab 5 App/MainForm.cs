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
using Lab_5_App;

namespace InsuranseCompanyForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void ShowInsuransBranchForm(InsuranseBranch branch)
        {
            BranchForm formBranch = new BranchForm(branch);
            if (formBranch.ShowDialog() == DialogResult.OK)
            {
                InsuranseCompany.Branches.Add(branch.Number, branch);
                UpdateBranchesList();
            }

        }
        private void UpdateTypesList()
        {
            InsuranseTypeListView.Items.Clear();
            foreach (var item in InsuranseCompany.Types)
            {
                var type = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = type,
                    Text = type.ToString()
                };
                InsuranseTypeListView.Items.Add(listViewItem);
            }
        }

        private void UpdateBranchesList()
        {
            InsuranseBranchListView.Items.Clear();
            foreach (var item in InsuranseCompany.Branches)
            {
                var branch = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = branch,
                    Text = branch.Name
                };

                listViewItem.SubItems.Add(branch.Address);
                listViewItem.SubItems.Add(branch.PhoneNumber);
                InsuranseBranchListView.Items.Add(listViewItem);
            }
        }

        private void UpdateContractsList()
        {
            InsuranseContractListView.Items.Clear();
            foreach (var item in InsuranseCompany.Contracts)
            {
                var contract = item;
                var listViewItem = new ListViewItem
                {
                    Tag = contract,
                    Text = contract.Number.ToString()
                };
                listViewItem.SubItems.Add(contract.DateOfConclusion.ToString());
                listViewItem.SubItems.Add(contract.Amount.ToString());
                listViewItem.SubItems.Add(contract.TarifRate.ToString());
                listViewItem.SubItems.Add(contract.Branch.Name.ToString());
                listViewItem.SubItems.Add(contract.InsuranceType.InsuranseName.ToString());
                InsuranseContractListView.Items.Add(listViewItem);
            }
        }
        private void AddInsuranseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var type = new InsuranseType();
            InsuranseTypeForm formType = new InsuranseTypeForm(type);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                InsuranseCompany.Types.Add(type.Number, type);
                UpdateTypesList();
            }
        }

        private void EditInsuranseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var type = InsuranseTypeListView.SelectedItems[0].Tag as InsuranseType;
            InsuranseTypeForm formType = new InsuranseTypeForm(type);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                UpdateTypesList();
            }
        }
       
        private void AddInsuranseBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var branch = new InsuranseBranch();
            BranchForm formType = new BranchForm(branch);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                InsuranseCompany.Branches.Add(branch.Number, branch);
                UpdateBranchesList();
            }
        }

        private void EditInsuranseBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var branch = InsuranseBranchListView.SelectedItems[0].Tag as InsuranseBranch;
            BranchForm formType = new BranchForm(branch);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                UpdateBranchesList();
            }
        }

        private void AddInsuranseContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contract = new InsuranseContract();
            ContractForm formType = new ContractForm(contract);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                InsuranseCompany.Contracts.Add(contract);
                UpdateContractsList();
            }
        }

        private void EditInsuranseContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contract = InsuranseContractListView.SelectedItems[0].Tag as InsuranseContract;
            ContractForm formType = new ContractForm(contract);
            var DialogResult = formType.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                UpdateContractsList();
            }
        }

        
    }
}
