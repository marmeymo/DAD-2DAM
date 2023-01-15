using Controllers;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Login : Form
    {
        LoginController loginController = new LoginController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            if (txbId_staff.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Se necesita ambos, un id de staff y una contraseña para validar");
                txbId_staff.Text = "";
                txbPassword.Text = "";
            }
            else
            {
                switch (loginController.LoginVerify(int.Parse(txbId_staff.Text), txbPassword.Text))
                {
                    case 1: // usuario basic
                        categories.ShowDialog();
                        txbId_staff.Text = "";
                        txbPassword.Text = "";
                        break;
                    case 2: // usuario admin
                        categories.ShowDialog();
                        txbId_staff.Text = "";
                        txbPassword.Text = "";
                        break;
                    case 0: // Fallo al verificar el password
                        MessageBox.Show("Existe un usuario con la id " + txbId_staff.Text + ", pero la password es erronea. Pruebe de nuevo");
                        txbId_staff.Text = "";
                        txbPassword.Text = "";
                        break;
                    case -1: // No se ha encontrado un usuario
                        MessageBox.Show("No existe un usuario con la id " + txbId_staff.Text + ". Pruebe de nuevo");
                        txbId_staff.Text = "";
                        txbPassword.Text = "";
                        break;
                }
            }
        }
    }
}
