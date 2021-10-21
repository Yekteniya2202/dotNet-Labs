using System;
using System.Windows.Forms;
using ClassLibraryRivers;

namespace WinFormsControlLibraryRiver
{
    public partial class UserControl1 : UserControl
    {
        public River River { get; set; }
        public UserControl1()
        {
            InitializeComponent();

        }
        public UserControl1(River river, string key) : this()
        {
            River = river;
            textBoxRiverKey.Text = key;
            textBoxRiverName.Text = River.Title;
            textBoxRiverLength.Text = River.Length.ToString() + " км.";
            textBoxRiverFoundDate.Text = River.FoundationDate.ToString();
            textBoxTribCount.Text = River.TributaryCount.ToString();
        }
    }
}
