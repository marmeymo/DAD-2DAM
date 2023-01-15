using model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace model
{
    public class GestorFicheroLogin
    {
        public int LeerUser(User usuario) {
            string lineas = Properties.Resources.users;
            string[] lineasarray = lineas.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var linea in lineasarray)
            {
                string[] lineaarray = linea.Split(':');
                if (lineaarray[0] == usuario.username && lineaarray[1] == usuario.password)
                {
                    switch(lineaarray[2])
                    {
                        case "direccion":
                            return 1;
                        case "administrador":
                            return 2;
                        case "administrativo":
                            return 2;
                        case "personalsanitario":
                            return 4;
                    }
                } 
            }
            return 0;
        }
    }
}
