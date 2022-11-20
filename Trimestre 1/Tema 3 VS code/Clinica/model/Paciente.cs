using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Paciente
    {
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string direccion { get; set; }
        private string poblacion { get; set; }
        private string dni { get; set; }
        private int nhc { get; set; }

        public Paciente(string nombre, string apellidos, string direccion, string poblacion, string dni, int nhc)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.dni = dni;
            this.nhc = nhc;
        }

        public Paciente() { }

        public string toString()
        {
            return nombre + ":" + apellidos + ":" + direccion + ":" + poblacion + ":" + dni + ":" + nhc;
        }

    }
}
