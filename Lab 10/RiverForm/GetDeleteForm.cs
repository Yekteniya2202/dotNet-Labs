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
    public partial class GetDeleteForm : Form
    {
        public string Key;

        public GetDeleteForm(string butText)
        {
            InitializeComponent();
            buttonGetDelete.Text = butText;
        }

        private void buttonGetDelete_Click(object sender, EventArgs e)
        {
            Key = textBoxKey.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
