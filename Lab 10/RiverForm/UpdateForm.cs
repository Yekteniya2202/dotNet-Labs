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

namespace RiverForm
{
    public partial class UpdateForm : Form
    {
        public River River;
        public string Key;
        public UpdateForm(string btnText)
        {
            InitializeComponent();
            buttonUpdate.Text = btnText;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Key = textBoxKey.Text;
            River.Title = textBoxTitle.Text;

            double len = River.Length;
            double.TryParse(textBoxLength.Text, out len);

            River.Length = len;

            DateTime dt = River.FoundationDate;
            DateTime.TryParse(textBoxFounDate.Text, out dt);

            River.FoundationDate = dt;

            int tribcount = River.TributaryCount;
            int.TryParse(textBoxTribCount.Text, out tribcount);

            River.TributaryCount = tribcount;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
