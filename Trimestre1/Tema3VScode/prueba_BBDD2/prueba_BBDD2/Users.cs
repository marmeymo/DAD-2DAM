using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_BBDD2
{
    public partial class Users : Form
    {
        private Controllers.UsersController controller;
        public Users()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            controller = new Controllers.UsersController();

            //Añadimos linea a Datagridview
            dataGridView2.Rows.Add("10", "e3", "e3", "camarero", "12/12/2019", "");
            dataGridView2.Rows[1].Cells[0].Value = "11";
            dataGridView2.Rows[1].Cells[1].Value = "r4";
            dataGridView2.Rows[1].Cells[2].Value = "r4";
            dataGridView2.Rows[1].Cells[3].Value = "cocinero";
            dataGridView2.Rows[1].Cells[4].Value = "12/12/2019";
            dataGridView2.Rows[1].Cells[5].Value = "12/12/2019";

            dataGridView2.Update();

            //con DataAdapter
            dataGridView1.DataSource = controller.loadUsersDA();
            dataGridView1.Update();
            
        }


    }
}
