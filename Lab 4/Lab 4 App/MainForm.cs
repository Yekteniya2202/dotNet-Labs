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
    public partial class MainForm : Form
    {
        private InsuranceType _insType;
        private InsuranseBranch _branch;
        public MainForm()
        {
            InitializeComponent();
            ToolStripMenuItem сontractItem = new ToolStripMenuItem("Вид страхования");
            var CIAdd = new ToolStripMenuItem("Добавить");
            var CIEdit = new ToolStripMenuItem("Редактировать");
            CIAdd.Click += CIAdd_Click;
            CIEdit.Click += CIEdit_Click;
            сontractItem.DropDownItems.Add(CIAdd);
            сontractItem.DropDownItems.Add(CIEdit);

            
            menuStrip1.Items.Add(сontractItem);

            ToolStripMenuItem branchItem = new ToolStripMenuItem("Филиалы");
            var CBAdd = new ToolStripMenuItem("Добавить");
            var CBEdit = new ToolStripMenuItem("Редактировать");
            CBAdd.Click += CBAdd_Click;
            CBEdit.Click += CBEdit_Click;
            branchItem.DropDownItems.Add(CBAdd);
            branchItem.DropDownItems.Add(CBEdit);

            menuStrip1.Items.Add(branchItem);


           
        }

        void CIAdd_Click(object sender, EventArgs e)
        {
            _insType = new InsuranceType();
            InsuranceTypeForm cf = null;
            try
            {
                cf = new InsuranceTypeForm(_insType);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (cf.ShowDialog() == DialogResult.OK)
            {
                _insType = cf.InsuranceType;
            }

        }

        void CIEdit_Click(object sender, EventArgs e)
        {

            InsuranceTypeForm cf = null;
            try
            {
                cf = new InsuranceTypeForm(_insType);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (cf.ShowDialog() == DialogResult.OK)
            {
                _insType = cf.InsuranceType;
            }

        }

        void CBAdd_Click(object sender, EventArgs e)
        {
            _branch = new InsuranseBranch();
            BranchForm bf = null;
            try
            {
                bf = new BranchForm(_branch);
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (bf.ShowDialog() == DialogResult.OK)
            {
                _branch = bf.Branch;
            }

        }

        void CBEdit_Click(object sender, EventArgs e)
        {
            BranchForm bf = null;
            try
            {
                bf = new BranchForm(_branch);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (bf.ShowDialog() == DialogResult.OK)
            {
                _branch = bf.Branch;
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
