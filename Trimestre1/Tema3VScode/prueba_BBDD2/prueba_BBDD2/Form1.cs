using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_BBDD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Parametros de la conexión
        private static readonly String HOST = "localhost";
        private static readonly String BD = "examen";
        private static readonly String USER = "root";
        private static readonly String PASSWORD = "";
        private void conexion_Click(object sender, EventArgs e)
        {
            //Instancia de la clase MySqlConnection
            MySqlConnection conexionBD = new MySqlConnection("Server=" + HOST + ";Database=" + BD + ";Uid=" + USER + ";Pwd=" + PASSWORD + ";SSL Mode=None");
            try
            {
                //abrimos la conexión
                conexionBD.Open();

                //Objeto 'DataReader' de MySQL
                MySqlDataReader reader = null;

                //Objeto 'SqlCommand' de MySQL
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexionBD);
                
                //ejecutamos la consulta sobre la BBDD
                reader = cmd.ExecuteReader();

                //Leemos las lineas
                while (reader.Read())
                {
                    //con reader.GetString(0) recogemos los valores de los registros
                    Console.WriteLine(reader.GetString(0));

                    //escribimos en listview
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    listView1.Items.Add(lvi);
                }
            }
            catch
            {
                //Recogemos la excepción de Base de datos
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users formUser = new Users();
            formUser.Show();
        }
    }
}
