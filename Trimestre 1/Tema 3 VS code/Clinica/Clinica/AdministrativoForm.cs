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
    public partial class AdministrativoForm : Form
    {
        public AdministrativoForm()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void centroDeDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Centro de día");
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Cita");
        }

        private void guardarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Guardar actividad");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult messageoption = MessageBox.Show("Estas seguro de terminar la aplicación?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageoption == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void CrearPacientetoolStripButton_Click(object sender, EventArgs e)
        {
            CrearPacienteForm crearPacienteForm = new CrearPacienteForm();
            crearPacienteForm.ShowDialog();
        }

        private void BuscarPacientetoolStripButton_Click(object sender, EventArgs e)
        {
            BuscarPacienteForm buscarPacienteForm = new BuscarPacienteForm();
            buscarPacienteForm.ShowDialog();
        }

        private void EliminarPacientetoolStripButton_Click(object sender, EventArgs e)
        {
            BorrarPacienteForm borrarPacienteForm = new BorrarPacienteForm();
            borrarPacienteForm.ShowDialog();
        }
    }
}
