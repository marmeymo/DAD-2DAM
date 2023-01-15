using model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class LoginController
    {
        private GestorFicheroLogin gestorFichero;
        
        public LoginController() 
        { 
            gestorFichero = new GestorFicheroLogin();
        }

        public int LoginVerificar(String usuario, String password)
        {
            return gestorFichero.LeerUser(new User(usuario, password));
        }
    }
}
