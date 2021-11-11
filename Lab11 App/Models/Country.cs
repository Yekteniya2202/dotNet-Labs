using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Lab11.Models
{
    public class Country
    {
        private static readonly string _selectUsersCommand = @"SELECT [CountryId], [CountryName], [CountryPolity] FROM [dbo].[Countries]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Countries] ([CountryName], [CountryPolity]) VALUES (@CountryName, @CountryPolity)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Countries] SET [CountryName] = @CountryName, [CountryPolity] = @CountryPolity WHERE [CountryId] = @CountryId";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Countries] WHERE [CountryId] = @CountryId";

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryPolity { get; set; }
        public byte[] CountryFlag { get; set; }

        public static List<Country> List(SqlConnection connection)
        {
            List<Country> countries = new List<Country>();
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
                        Country country = new Country
                        {
                            CountryName = (string)reader["CountryName"],
                            CountryPolity = (string)reader["CountryPolity"],
                            CountryId = (int)reader["CountryId"]
                        };
                        countries.Add(country);
                    }
                }
                catch (SqlException sqlex)
                {
                    throw new ApplicationException("Ошибка при взаимодействии с базой данных", sqlex);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return countries;
        }

        public static void Insert(SqlConnection connection, Country country)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CountryName", SqlDbType.NVarChar, 256).Value = country.CountryName;
                    command.Parameters.Add("@CountryPolity", SqlDbType.NVarChar, 256).Value = country.CountryPolity;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlex)
                {
                    throw new ApplicationException("Ошибка при взаимодействии с базой данных", sqlex);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Country country)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CountryName", SqlDbType.NVarChar, 256).Value = country.CountryName;
                    command.Parameters.Add("@CountryPolity", SqlDbType.NVarChar, 256).Value = country.CountryPolity;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = country.CountryId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlex)
                {
                    throw new ApplicationException("Ошибка при взаимодействии с базой данных", sqlex);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int countryId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = countryId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlex)
                {
                    throw new ApplicationException("Ошибка при взаимодействии с базой данных", sqlex);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
