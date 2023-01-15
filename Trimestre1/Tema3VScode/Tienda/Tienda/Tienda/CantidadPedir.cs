using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class CantidadPedir : Form
    {
        public int stock { get; set; }
        public int quantitypedida { get; set; }

        public CantidadPedir()
        {
            InitializeComponent();

        }

        public void setStock()
        {
            lblStock.Text = stock.ToString();
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (txbCantidadPedir.Text.Length < 0)
            {
                MessageBox.Show("Ha de dar una cantidad a pedir");
            }
            else if (Convert.ToInt32(txbCantidadPedir.Text) < stock)
            {
                quantitypedida = Convert.ToInt32(txbCantidadPedir.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("La cantidad a pedir es mayor que el stock que tenemos, pida menos o igual cantidad del stock");
            }
        }
    }
}
