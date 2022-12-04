using Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Models.DAO
{
    public class BasketDAO
    {
        private static DBConnection dataSource;
        public BasketDAO()
        {
            dataSource = DBConnection.getInstance();
        }
        public Boolean saveBasket(Basket basket)
        {
            List<Category> categories = new List<Category>();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "INSERT INTO basket VALUES (@id, @name, @total)";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                mysqlCmd.Parameters.AddWithValue("@id", basket.id);
                mysqlCmd.Parameters.AddWithValue("@name", basket.name);
                mysqlCmd.Parameters.AddWithValue("@total", basket.total);

                int rowsAfected = mysqlCmd.ExecuteNonQuery();

                if (rowsAfected < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
                return false;
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
            }
        }
    }
}
