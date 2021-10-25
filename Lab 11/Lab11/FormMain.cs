using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CommentDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            listViewUsers.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewUsers.Items.Add(user.UserId.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.FirstName);
                listListViewItem.SubItems.Add(user.SecondName);
                listListViewItem.SubItems.Add(user.LastName);
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            FormUser formUser = new FormUser
            {
                User = new User()
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Insert(_connection, formUser.User);
            }
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            FormUser formUser = new FormUser
            {
                User = (User)listViewUsers.SelectedItems[0].Tag
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Update(_connection, formUser.User);
            }
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            User.Delete(_connection, ((User)listViewUsers.SelectedItems[0].Tag).UserId);
        }
    }
}
