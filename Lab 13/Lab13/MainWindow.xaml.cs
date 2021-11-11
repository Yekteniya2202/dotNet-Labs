using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Data;
using Microsoft.Win32;

namespace Lab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CommentDBDataSet _commentDbDataSet;
        private CommentDBDataSetTableAdapters.UsersTableAdapter _commentDbDataSetUsersTableAdapter;
        private CommentDBDataSetTableAdapters.CommentsTableAdapter _commentDbDataSetCommentsTableAdapter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _commentDbDataSet = (CommentDBDataSet)FindResource("commentDBDataSet");
            // Загрузить данные в таблицу Users. Можно изменить этот код как требуется.
            _commentDbDataSetUsersTableAdapter = new CommentDBDataSetTableAdapters.UsersTableAdapter();
            _commentDbDataSetUsersTableAdapter.Fill(_commentDbDataSet.Users);
            var usersViewSource = (CollectionViewSource)FindResource("usersViewSource");
            usersViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Comments. Можно изменить этот код как требуется.
            _commentDbDataSetCommentsTableAdapter = new CommentDBDataSetTableAdapters.CommentsTableAdapter();
            _commentDbDataSetCommentsTableAdapter.Fill(_commentDbDataSet.Comments);
            var usersCommentsViewSource = (CollectionViewSource)FindResource("commentsViewSource");
            usersCommentsViewSource.View.MoveCurrentToFirst();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < usersDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = usersDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _commentDbDataSetUsersTableAdapter.Update(_commentDbDataSet.Users);
        }

        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {
            _commentDbDataSetUsersTableAdapter.Update(_commentDbDataSet.Users);
        }

        private void SaveComment_Click(object sender, RoutedEventArgs e)
        {
            _commentDbDataSetCommentsTableAdapter.Update(_commentDbDataSet.Comments);
        }

        private void DeleteComment_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < commentsDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = commentsDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            _commentDbDataSetCommentsTableAdapter.Update(_commentDbDataSet.Comments);
        }

        private void LoadImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (usersDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = usersDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as CommentDBDataSet.UsersRow;
                        if (dataRow != null)
                        {
                            dataRow.Photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}
