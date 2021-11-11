using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class User
    {
        private static readonly string _selectUsersCommand = @"SELECT [UserId], [FirstName], [SecondName], [LastName] FROM [dbo].[Users]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Users] ([FirstName], [SecondName], [LastName]) VALUES (@FirstName, @SecondName, @LastName)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Users] SET [FirstName] = @FirstName, [SecondName] = @SecondName, [LastName] = @LastName WHERE [UserId] = @UserId";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Users] WHERE [UserId] = @UserId";

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }

        public static List<User> List(SqlConnection connection)
        {
            List<User> users = new List<User>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectUsersCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            FirstName = (string)reader["FirstName"],
                            SecondName = (string)reader["SecondName"],
                            LastName = (string)reader["LastName"],
                            UserId = (int)reader["UserId"]
                        };
                        users.Add(user);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return users;
        }

        public static void Insert(SqlConnection connection, User user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 32).Value = user.FirstName;
                    command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 32).Value = user.SecondName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 32).Value = user.LastName;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, User user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 32).Value = user.FirstName;
                    command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 32).Value = user.SecondName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 32).Value = user.LastName;
                    command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.UserId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int userId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
