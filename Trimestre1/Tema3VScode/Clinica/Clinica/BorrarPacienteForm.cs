using controller;
using model;
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
    public partial class BorrarPacienteForm : Form
    {
        AdministrativoController administrativoController = new AdministrativoController();
        public BorrarPacienteForm()
        {
            InitializeComponent();
        }

        private void lvPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                if (lvPacientes.SelectedItems.Count == 1)
                {
                    if (MessageBox.Show("¿Desea borrar este paciente?", "Borrar Paciente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ListViewItem item = lvPacientes.SelectedItems[0];
                        Paciente paciente = new Paciente(item.SubItems[0].Text,
                                                         item.SubItems[1].Text,
                                                         item.SubItems[2].Text,
                                                         int.Parse(item.SubItems[3].Text),
                                                         item.SubItems[4].Text,
                                                         item.SubItems[5].Text,
                                                         int.Parse(item.SubItems[6].Text));
                        if (administrativoController.BorrarPacienteByNhc(paciente.nhc))
                        {
                            MessageBox.Show("Borrado correctamente");
                            lvPacientes.Items.Clear();
                        }
                        else
                            MessageBox.Show("El paciente no ha sido borrado");
                    }
                }
                else
                    MessageBox.Show("Se ha de seleccionar al menos 1 item de la lista");

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numberout;
            lvPacientes.Items.Clear();
            if (txbBuscar.Text != "")
            {
                if (cbBuscar.Text == "NHC")
                {
                    if (int.TryParse(txbBuscar.Text, out numberout))
                    {
                        Paciente paciente = administrativoController.findByNhc(int.Parse(txbBuscar.Text));
                        if (paciente != null)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Checked = true;
                            item.Text = paciente.nombre;
                            item.SubItems.Add(paciente.apellidos);
                            item.SubItems.Add(paciente.direccion);
                            item.SubItems.Add(paciente.codigopostal.ToString());
                            item.SubItems.Add(paciente.poblacion);
                            item.SubItems.Add(paciente.dni);
                            item.SubItems.Add(paciente.nhc.ToString());
                            lvPacientes.Items.Add(item);
                        }
                        else
                            MessageBox.Show("No existe tal usuario");
                    }  else
                        MessageBox.Show("El NHC ha de ser numerico");
                }
                else if (cbBuscar.Text == "DNI")
                {
                    Paciente paciente = administrativoController.findByDni(txbBuscar.Text);
                        if (paciente != null)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Checked = true;
                            item.Text = paciente.nombre;
                            item.SubItems.Add(paciente.apellidos);
                            item.SubItems.Add(paciente.direccion);
                            item.SubItems.Add(paciente.codigopostal.ToString());
                            item.SubItems.Add(paciente.poblacion);
                            item.SubItems.Add(paciente.dni);
                            item.SubItems.Add(paciente.nhc.ToString());
                            lvPacientes.Items.Add(item);
                        }
                        else
                            MessageBox.Show("No existe tal usuario");
                }
                else
                    MessageBox.Show("Has de seleccionar una opción, buscar por NHC o por DNI");
            }
            else
            {
                List<Paciente> pacientes = administrativoController.findAll();
                foreach (Paciente paciente in pacientes)
                {
                    ListViewItem item = new ListViewItem();
                    item.Checked= true;
                    item.Text = paciente.nombre;
                    item.SubItems.Add(paciente.apellidos);
                    item.SubItems.Add(paciente.direccion);
                    item.SubItems.Add(paciente.codigopostal.ToString());
                    item.SubItems.Add(paciente.poblacion);
                    item.SubItems.Add(paciente.dni);
                    item.SubItems.Add(paciente.nhc.ToString());
                    lvPacientes.Items.Add(item);
                }
            }
        }
    }
}
