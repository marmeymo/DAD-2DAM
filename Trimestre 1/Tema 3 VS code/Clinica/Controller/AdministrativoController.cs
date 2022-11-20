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

        public Boolean GuardarPaciente(string nombre, string apellidos, string direccion, string poblacion, string dni, int nhc)
        {

            Paciente paciente = new Paciente(nombre, apellidos, direccion, poblacion, dni, nhc);
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

        public Boolean BorrarPaciente(string dni)
        {
            return gestorFicherosPaciente.DeletePaciente(dni);
        }

        public Boolean VerificarDni(string dni)
        {
            return gestorFicherosPaciente.verificarDni(dni);
        }
    }
}
