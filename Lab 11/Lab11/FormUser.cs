using System;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormUser : Form
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                textBoxFirstName.Text = _user.FirstName;
                textBoxLastName.Text = _user.LastName;
                textBoxSecondName.Text = _user.SecondName;
            }
        }
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User.FirstName = textBoxFirstName.Text;
            User.SecondName = textBoxSecondName.Text;
            User.LastName = textBoxLastName.Text;
        }
    }
}
