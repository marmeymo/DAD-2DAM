using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Models
{
    public class CatmanDAO
    {
        private static DBConnection dataSource;
        public CatmanDAO()
        {
            dataSource = DBConnection.getInstance();
        }
        public List<Catman> loadCatmans()
        {
            List<Catman> catmans = new List<Catman>();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM catman;";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.

                while (mysqlReader.Read())
                {
                    int id = Convert.ToInt32(mysqlReader["id_category"]);
                    string name = mysqlReader["name"].ToString();
                    string category = mysqlReader["category"].ToString();
                    string description = mysqlReader["description"].ToString();
                    double price = Convert.ToDouble(mysqlReader["price"]);
                    int quantity = Convert.ToInt32(mysqlReader["quantity"]);
                    catmans.Add(new Catman(id, name, category, description, price, quantity));

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
            return catmans;
        }

        public DataTable loadDataAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM catman;";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                datos = new DataTable();
                mysqlDAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlDAdapter.Fill(datos);

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlDAdapter != null) mysqlDAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return datos;
        }

        public DataTable loadDataAdapterByCategory(String category)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM catman WHERE category = @category;";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                mysqlCmd.Parameters.AddWithValue("@category", category);

                datos = new DataTable();
                mysqlDAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlDAdapter.Fill(datos);

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlDAdapter != null) mysqlDAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return datos;
        }

        public Boolean UpdateCatman(Catman catman)
        {
            List<Catman> catmans = new List<Catman>();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "UPDATE catman SET quantity = @quantity WHERE id = @id";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@quantity", catman.quantity);
                mysqlCmd.Parameters.AddWithValue("@id", catman.id);
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
