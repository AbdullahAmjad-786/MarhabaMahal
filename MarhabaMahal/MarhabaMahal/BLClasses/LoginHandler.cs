using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    class LoginHandler
    {
        private MarhabaEntities entities;

        public LoginHandler()
        {
            entities = new MarhabaEntities();
        }

        public bool verifyUserLogin(string username, string password)
        {
            var user = entities.user_info.FirstOrDefault(u => u.user_name == username && u.password == password);
            if (user != null)
                return true;
            return false;
        }

        public bool typeOfUser(string username)
        {
            var user = entities.user_info.FirstOrDefault(u => u.user_name == username);
            return user.type;
        }
    }
}
