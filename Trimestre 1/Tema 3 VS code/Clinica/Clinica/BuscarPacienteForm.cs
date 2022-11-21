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
    public partial class BuscarPacienteForm : Form
    {
        AdministrativoController administrativoController = new AdministrativoController();
        public BuscarPacienteForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lvPacientes.Items.Clear();
            int numericValue;
            if (txbDni.Text == "" && txbNhc.Text == "")
            {
                List<Paciente> pacientes = administrativoController.findAll();
                foreach (Paciente paciente in pacientes)
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
            }
            else if (txbDni.Text != "" && txbNhc.Text == "")
            {
                Paciente paciente = administrativoController.findByDni(txbDni.Text);
                if (paciente == null)
                {
                    MessageBox.Show("No existe el paciente con el dni " + txbDni.Text);
                }
                else
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

            }
            else if (txbDni.Text == "" && txbNhc.Text != "")
            {
                if (int.TryParse(txbNhc.Text, out numericValue))
                {
                    Paciente paciente = administrativoController.findByNhc(int.Parse(txbNhc.Text));
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
                    MessageBox.Show("El NHC ha de ser numerico");
            }
            else
                MessageBox.Show("No se puede buscar pacientes de manera dinamica entre los dos datos");

        }
    }
}
