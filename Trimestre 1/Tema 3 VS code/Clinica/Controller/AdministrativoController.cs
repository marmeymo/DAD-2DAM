using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class AdministrativoController
    {

        GestorFicherosPaciente gestorFicherosPaciente { get; set; }

        public AdministrativoController() 
        {
            gestorFicherosPaciente = new GestorFicherosPaciente();
        }

        public Boolean GuardarPaciente(string nombre, string apellidos, string direccion, int codigopostal, string poblacion, string dni, int nhc)
        {

            Paciente paciente = new Paciente(nombre, apellidos, direccion, codigopostal, poblacion, dni, nhc);
            return gestorFicherosPaciente.GuardarPaciente(paciente);
        }

        public Paciente findByDni(string dni) 
        {
            return gestorFicherosPaciente.findByDni(dni);
        }

        public Paciente findByNhc(int nhc)
        {
            return gestorFicherosPaciente.findByNhc(nhc);
        }

        public Boolean BorrarPacienteByDni(string dni)
        {
            return gestorFicherosPaciente.DeletePacienteByDni(dni);
        }

        public Boolean BorrarPacienteByNhc(int nhc)
        {
            return gestorFicherosPaciente.DeletePacienteByNhc(nhc);
        }

        public List<Paciente> findAll()
        {
            return gestorFicherosPaciente.findAll();
        }

        public Boolean VerificarDni(string dni)
        {
            return gestorFicherosPaciente.verificarDni(dni);
        }
    }
}
