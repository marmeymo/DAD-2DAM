using controller;
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
        AdministrativoController administrativoController = new AdministrativoController();

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
            int numericValue;
            if (txbNombre.Text != "")
            {
                if (txbApellidos.Text != "")
                {
                    if (txbDireccion.Text != "")
                    {
                        if (txbPoblacion.Text != "")
                        {
                            if (txbDni.Text != "")
                            {
                                if (txbNhc.Text != "")
                                {
                                    if(txbCodigoPostal.Text != "") { 

                                    if (administrativoController.VerificarDni(txbDni.Text)
                                        && administrativoController.findByDni(txbDni.Text) == null)
                                    {
                                            if (int.TryParse(txbNhc.Text, out numericValue) && administrativoController.findByNhc(int.Parse(txbNhc.Text)) == null)
                                            {
                                                if (administrativoController.GuardarPaciente(
                                                    txbNombre.Text,
                                                    txbApellidos.Text,
                                                    txbDireccion.Text,
                                                    int.Parse(txbCodigoPostal.Text),
                                                    txbPoblacion.Text,                                                    
                                                    txbDni.Text,
                                                    int.Parse(txbNhc.Text))
                                                    )
                                                    MessageBox.Show("El paciente ha sido guardado perfectamente");
                                                else
                                                    MessageBox.Show("El paciente no ha podido guardarse");
                                                this.Close();
                                            } else
                                                MessageBox.Show("El NHC dado no es numerico o ya existe un paciente con ese NHC");
                                        } else
                                            MessageBox.Show("El DNI dado no es valido o ya existe un paciente con ese DNI");
                                    } else
                                        MessageBox.Show("No se puede dejar el codigo postal en blanco");
                                } else
                                    MessageBox.Show("No se puede dejar el NHC en blanco");
                            } else
                                MessageBox.Show("No se puede dejar el DNI en blanco");
                        } else
                            MessageBox.Show("No se puede dejar la poblacion en blanco");
                    } else
                        MessageBox.Show("No se puede dejar la direccion en blanco");
                } else
                MessageBox.Show("No se puede dejar los apellidos en blanco");
            } else
                MessageBox.Show("No se puede dejar el nombre en blanco");

        }
    }
}
