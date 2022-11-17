using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class LoginController
    {
        public int LoginVerificar(String usuario)
        {
            switch(usuario.ToLower())
            {
                case "direccion":
                    return 1;
                case "administrativo":
                    return 2;
                case "administrador":
                    return 3;
                case "admin":
                    return 3;
                case "personalsanitario":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
