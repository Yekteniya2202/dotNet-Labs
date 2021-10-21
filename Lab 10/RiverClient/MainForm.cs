using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverClient
{
    public partial class RiverForm : Form
    {
        public RiverForm()
        {
            InitializeComponent();
        }

        private void byTributeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeByKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRiverForm nrform = new NewRiverForm();
        }
    }
}
