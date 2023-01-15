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
    public partial class PersonalSanitarioForm : Form
    {
        public PersonalSanitarioForm()
        {
            InitializeComponent();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Buscar paciente");
        }

        private void verFichaPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Ver ficha paciente");
        }

        private void sacarEtiquetasDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Sacar etiquetas del paciente");
        }

        private void verActasClínicosDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Ver actas clinicos del paciente");
        }

        private void buscarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Buscar nota");
        }

        private void crearNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Crear nota");
        }

        private void modificarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Modificar nota");
        }

        private void eliminarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Eliminar nota");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult messageoption = MessageBox.Show("Estas seguro de terminar la aplicación?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(messageoption == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
