using ClassLibraryRivers;
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
        private static Dictionary<string, River> _rivers = new Dictionary<string, River>();
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

        private void userControlRivers1_Load(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiverResponse rr = new RiverResponse();

            FindRiver fr = new FindRiver(rr);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                _rivers.Clear();
                _rivers.Add(rr.Key, rr.River);

            }
        }
    }
}
