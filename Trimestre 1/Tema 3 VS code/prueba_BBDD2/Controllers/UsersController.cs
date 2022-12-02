using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsersController
    {
        public DataTable modelData;
       // public List<MySqlDataReader> modelReader;
        public UserAdo modelUser;

        public UsersController()
        {
            modelUser = new UserAdo();
        }
        public DataTable loadUsersDR()
        {
           // modelData = new List<MySqlDataReader>();
           // modelData = modelUser.loadUsers();
            return modelData;
        }
        public DataTable loadUsersDA()
        {
            modelData = new DataTable();
            modelData = modelUser.LoadDataAdapter();
            return modelData;
        }

    }
}
