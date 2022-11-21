using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Paciente
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int codigopostal { get; set; }
        public string poblacion { get; set; }
        public string dni { get; set; }
        public int nhc { get; set; }

        public Paciente(string nombre, string apellidos, string direccion, int codigopostal, string poblacion, string dni, int nhc)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.codigopostal= codigopostal;
            this.poblacion = poblacion;
            this.dni = dni;
            this.nhc = nhc;
        }

        public Paciente() { }

        override
        public string ToString()
        {
            return nombre + ":" + apellidos + ":" + direccion + ":" + codigopostal+ ":" +poblacion + ":" + dni + ":" + nhc;
        }

    }
}
