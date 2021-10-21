using System;
using System.Windows.Forms;
using ClassLibraryRivers;

namespace WinFormsControlLibraryRiver
{
    public partial class UserControlRivers : UserControl
    {
        public River River { get; set; }
        public UserControlRivers()
        {
            InitializeComponent();

        }
        public UserControlRivers(River river, string key) : this()
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
