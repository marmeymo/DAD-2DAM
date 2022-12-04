using Controllers;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class CategoryMan : Form
    {
        CatmanController catmanController = new CatmanController();
        BasketController basketController = new BasketController();

        public CategoryMan()
        {


            InitializeComponent();
            dgvCatman.DataSource = catmanController.getCatmansDA();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (ltbFilter.GetItemText(ltbFilter.SelectedItem).Length < 0)
            {
                MessageBox.Show("No se ha seleccionado ningun metodo de filtrado");
            }
            else
            {
                switch (ltbFilter.GetItemText(ltbFilter.SelectedItem))
                {
                    case "ALL":
                        dgvCatman.DataSource = catmanController.getCatmansDA();
                        break;
                    default:
                        dgvCatman.DataSource = catmanController.getCatmansByCategoryDA(ltbFilter.GetItemText(ltbFilter.SelectedItem));
                        break;
                }
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvCatman.SelectedRows.Count;
            if (selectedRowCount < 0)
            {
                MessageBox.Show("Tienes que seleccionar una linea de la lista de catmans para mostrarla");
            }
            else
            {
                DataGridViewRow row = dgvCatman.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string category = row.Cells[2].Value.ToString();
                string description = row.Cells[3].Value.ToString();
                double price = Convert.ToDouble(row.Cells[4].Value.ToString());
                int quantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                MessageBox.Show("ID: " + id + "\nName: " + name + "\nCategory: " + category + "\nQuantity: " + quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int selectedRowCount = dgvCatman.SelectedRows.Count;
            if (selectedRowCount < 0)
            {
                MessageBox.Show("Tienes que seleccionar una linea de la lista de catmans para mostrarla");
            }
            else
            {
                DataGridViewRow row = dgvCatman.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string category = row.Cells[2].Value.ToString();
                string description = row.Cells[3].Value.ToString();
                double price = Convert.ToDouble(row.Cells[4].Value.ToString());
                int quantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                CantidadPedir cantidadPedir = new CantidadPedir();
                cantidadPedir.stock = quantity;
                cantidadPedir.setStock();
                cantidadPedir.ShowDialog();
                int quantitypedida = cantidadPedir.quantitypedida;
                if (basketController.saveBasket(id, name, (price * quantitypedida)) && catmanController.UpdateCatman(id, name, category, description, price, quantitypedida))
                {
                    MessageBox.Show("Pedido creado correctamente");
                }
                else
                {
                    MessageBox.Show("Pedido no ha sido posible crearlo correctamente");
                }
                dgvCatman.DataSource = catmanController.getCatmansDA();
            }
        }
    }
}
