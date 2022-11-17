using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica;
using controller;

namespace LoginView
{
    public partial class LoginForm : Form
    {
        LoginController controllerlogin = new LoginController();
        PersonalSanitarioForm personalSanitarioForm = new PersonalSanitarioForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { 
            switch (controllerlogin.LoginVerificar(txbUsuario.Text))
            {
                case (1): //direccion
                    MessageBox.Show("Lo lamentamos, esta sección esta en construcción.",
                        "Direccion login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case (2): //administrativo
                    break;
                case (3): //admin
                    MessageBox.Show("Lo lamentamos, esta sección esta en construcción.",
                        "administrador login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case (4): //personalsani
                    personalSanitarioForm.Show();
                    break;

                default:
                    MessageBox.Show("No existe tal usuario",
                        "Error login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
