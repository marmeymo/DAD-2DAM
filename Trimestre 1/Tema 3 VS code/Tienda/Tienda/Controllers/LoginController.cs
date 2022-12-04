using Models;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class LoginController
    {
        UsuarioDAO usuariodao = new UsuarioDAO();
        private List<User> getAllUsers()
        {
            return usuariodao.loadUsers();
        }

        public int LoginVerify(int id_staff, String password)
        {
            List<User> usersDB = getAllUsers();
            foreach (User u in usersDB)
            {
                if (u.id_staff == id_staff)
                {
                    if (u.password == password)
                    {
                        switch (u.role)
                        {
                            case "basic":
                                return 1;
                            case "admin":
                                return 2;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return -1;
        }
    }
}
