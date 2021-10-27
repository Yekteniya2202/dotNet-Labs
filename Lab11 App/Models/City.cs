using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_App.Models
{
    public class City
    {
        private static readonly string _selectUsersCommand = @"SELECT [CityId], [CountryId], [CityName], [CityPopulation] FROM [dbo].[Cities]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Cities] ([CountryId], [CityName], [CityPopulation]) VALUES (@CountryId, @CityName, @CityPopulation)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Cities] SET [CountryId] = @CountryId, [CityName] = @CityName, [CityPopulation] = @CityPopulation WHERE [CityId] = @CityId";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Cities] WHERE [CityId] = @CityId";

        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public int CityPopulation { get; set; }

        public static List<City> List(SqlConnection connection)
        {
            List<City> cities = new List<City>();
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
                        City city = new City
                        {
                            CityName = (string)reader["CityName"],
                            CityPopulation = (int)reader["CityPopulation"],
                            CountryId = (int)reader["CountryId"],
                            CityId = (int)reader["CityId"]
                        };
                        cities.Add(city);
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
            return cities;
        }

        public static void Insert(SqlConnection connection, City city)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CityName", SqlDbType.NVarChar, 256).Value = city.CityName;
                    command.Parameters.Add("@CityPopulation", SqlDbType.Int).Value = city.CityPopulation;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = city.CountryId;
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

        public static void Update(SqlConnection connection, City city)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CityName", SqlDbType.NVarChar, 256).Value = city.CityName;
                    command.Parameters.Add("@CityPopulation", SqlDbType.Int).Value = city.CityPopulation;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = city.CountryId;
                    command.Parameters.Add("@CityId", SqlDbType.Int).Value = city.CityId;
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

        public static void Delete(SqlConnection connection, int cityId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CityId", SqlDbType.Int).Value = cityId;
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
