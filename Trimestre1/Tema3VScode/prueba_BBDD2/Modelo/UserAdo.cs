using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UserAdo
    {
        private static DBConnection dataSource;
        static List<String> list;
        public UserAdo()
        {
            dataSource = DBConnection.getInstance();
        }
        public List<string> loadUsers()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM users;";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                 mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.

                while (mysqlReader.Read())
                {
                    int id = Convert.ToInt32(mysqlReader["id"]);
                    string username = mysqlReader["username"].ToString();
                    string password = mysqlReader["password"].ToString();
                    string role = mysqlReader["role"].ToString();
                    DateTime createdOn = Convert.ToDateTime(mysqlReader["createdOn"]);
                    // PENDIENTE OTRA FECHA int quantity = Convert.ToInt32(mysqlReader["quantity"]);

                    //aquí ya podemos usar los valores para gestionar los objetos
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error "+ e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
            }
            return list;
        }

        public DataTable LoadDataAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM users;";
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

    }
}
