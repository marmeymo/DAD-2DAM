using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class CrearPacienteForm : Form
    {
        public CrearPacienteForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbNombre.Text = "";
            txbDni.Text = "";
            txbApellidos.Text = "";
            txbNhc.Text = "";
            txbDireccion.Text = "";
            txbPoblacion.Text = "";
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
