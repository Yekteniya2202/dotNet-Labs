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
    public partial class InsuranseTypeForm : Form
    {
        private InsuranseType _insuranceType;
        public InsuranseType Type
        {
            get { return _insuranceType; }
            set
            {
                _insuranceType = value;
                InsuranceTypeTextBox1.Text = Type.InsuranseName;

            }
        }

        public InsuranseTypeForm()
        {
            InitializeComponent();
        }

        private void SaveInsuranceTypeButton_Click(object sender, EventArgs e)
        {

            Type.InsuranseName = InsuranceTypeTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void InsuranceTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
