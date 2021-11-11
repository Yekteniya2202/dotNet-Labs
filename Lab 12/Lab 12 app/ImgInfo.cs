using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_app
{
    public partial class ImgInfo : Form
    {
        public ImgInfo(Image img)
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = img;
        }
    }
}
