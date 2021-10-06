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

        private readonly InsuranseCompany _company = InsuranseCompany.Instance;
        readonly InsuranseTypeForm _typeForm = new InsuranseTypeForm();
        readonly BranchForm _branchForm = new BranchForm();
        readonly ContractForm _contractForm = new ContractForm();

        public MainForm()
        {
            InitializeComponent();
            _company.TypeAdded += _company_TypeAdded;
            _company.TypeRemoved += _company_TypeRemoved;
            _company.BranchAdded += _company_BranchAdded;
            _company.BranchRemoved += _company_BranchRemoved;
            _company.ContractAdded += _company_ContractAdded;
            _company.ContractRemoved += _company_ContractRemoved;
        }
        private void _company_TypeAdded(object sender, EventArgs e)
        {
            var type = sender as InsuranseType;
            if (type != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = type,
                    Text = type.InsuranseName.ToString()
                };
                InsuranseTypeListView.Items.Add(listViewItem);
            }
        }

        private void _company_TypeRemoved(object sender, EventArgs e)
        {
            int number = (int)sender;
            for (int i = 0; i < InsuranseTypeListView.Items.Count; i++)
            {
                
                if (((InsuranseType)InsuranseTypeListView.Items[i].Tag).Number == number)
                    {
                    InsuranseTypeListView.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_BranchAdded(object sender, EventArgs e)
        {
            var branch = sender as InsuranseBranch;
            if (branch != null)
            {
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

        private void _company_BranchRemoved(object sender, EventArgs e)
        {
            int number = (int)sender;
            for (int i = 0; i < InsuranseBranchListView.Items.Count; i++)
            {

                if (((InsuranseBranch)InsuranseBranchListView.Items[i].Tag).Number == number)
                {
                    InsuranseBranchListView.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _company_ContractAdded(object sender, EventArgs e)
        {
            var contract = sender as InsuranseContract;
            if (contract != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = contract,
                    Text = contract.Number.ToString()
                };
                listViewItem.SubItems.Add(contract.DateOfConclusion.ToString());
                listViewItem.SubItems.Add(contract.Amount.ToString()); 
                listViewItem.SubItems.Add(contract.TarifRate.ToString());
                listViewItem.SubItems.Add(contract.Branch.Name); 
                listViewItem.SubItems.Add(contract.InsuranceType.InsuranseName);
                InsuranseContractListView.Items.Add(listViewItem);
            }
        }

        private void _company_ContractRemoved(object sender, EventArgs e)
        {
            int number = (int)(((InsuranseContract)sender).Number);
            for (int i = 0; i < InsuranseContractListView.Items.Count; i++)
            {

                if (((InsuranseContract)InsuranseContractListView.Items[i].Tag).Number == number)
                {
                    InsuranseContractListView.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddInsuranseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var type = new InsuranseType();
            _typeForm.Type = type;
            if(_typeForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddType(type);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void EditInsuranseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var type = InsuranseTypeListView.SelectedItems[0].Tag as InsuranseType;
                _typeForm.Type = type;
                if (_typeForm.ShowDialog() == DialogResult.OK)
                {
                    InsuranseTypeListView.SelectedItems[0].Text = _typeForm.Type.InsuranseName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с типом страхования");
            }
        }
       
        private void AddInsuranseBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var branch = new InsuranseBranch();
            _branchForm.Branch = branch;
            if (_branchForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddBranch(branch);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void EditInsuranseBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var branch = InsuranseBranchListView.SelectedItems[0].Tag as InsuranseBranch;
                _branchForm.Branch = branch;
                if (_branchForm.ShowDialog() == DialogResult.OK)
                {
                    var row = InsuranseBranchListView.SelectedItems[0].SubItems;
                    row[0].Text = _branchForm.Branch.Name;
                    row[1].Text = _branchForm.Branch.Address;
                    row[2].Text = _branchForm.Branch.PhoneNumber;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с типом страхования");
            }
        }

        private void AddInsuranseContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contract = new InsuranseContract();
            _contractForm.Contract = contract;
            if (_contractForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddContract(contract);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void EditInsuranseContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var contract = InsuranseTypeListView.SelectedItems[0].Tag as InsuranseContract;
                _contractForm.Contract = contract;
                if (_contractForm.ShowDialog() == DialogResult.OK)
                {
                    var row = InsuranseContractListView.SelectedItems[0].SubItems;
                    row[0].Text = contract.DateOfConclusion.ToString();
                    row[0].Text = contract.Amount.ToString();
                    row[0].Text = contract.TarifRate.ToString();
                    row[0].Text = contract.Branch.Name;
                    row[0].Text = contract.InsuranceType.InsuranseName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с типом страхования");
            }
        }

        private void InsuranseTypeListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var type = InsuranseTypeListView.SelectedItems[0].Tag as InsuranseType;
                    if (type != null)
                    {
                        _company.RemoveType(type.Number);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с клиентом");
                }
            }
        }

        private void InsuranseBranchListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var bracnh = InsuranseBranchListView.SelectedItems[0].Tag as InsuranseBranch;
                    if (bracnh != null)
                    {
                        _company.RemoveBranch(bracnh.Number);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с клиентом");
                }
            }
        }

        private void InsuranseContractListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var contract = InsuranseContractListView.SelectedItems[0].Tag as InsuranseContract;
                    if (contract != null)
                    {
                        _company.RemoveContract(contract);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
