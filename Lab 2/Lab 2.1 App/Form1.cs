using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BorderStyleButton_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void OpacityButton_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
