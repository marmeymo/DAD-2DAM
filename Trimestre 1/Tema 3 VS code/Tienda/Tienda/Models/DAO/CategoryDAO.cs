using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Models
{
    public class CategoryDAO
    {
        private static DBConnection dataSource;
        public CategoryDAO()
        {
            dataSource = DBConnection.getInstance();
        }
        public List<Category> loadCategories()
        {
            List<Category> categories = new List<Category>();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM categories;";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.

                while (mysqlReader.Read())
                {
                    int id_category = Convert.ToInt32(mysqlReader["id_category"]);
                    string description = mysqlReader["description"].ToString();
                    categories.Add(new Category(id_category, description));

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
            }
            return categories;
        }
    }
}
