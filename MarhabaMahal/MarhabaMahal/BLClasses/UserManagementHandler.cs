using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    class UserManagementHandler
    {
        public void addUser(string name, string username, string password, string type)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var user = entities.user_info.FirstOrDefault(u=>u.user_name == username);
            if (user != null)
            {
                MessageBox.Show("Username Already Exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            user = new user_info();
            user.user_name = username;
            user.name = name;
            user.password = password;
            user.type = ((type == "Admin") ? true:false);
            entities.user_info.Add(user);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void editUser(string name, string username, string password, string type)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var user = entities.user_info.FirstOrDefault(u => u.user_name == username);
            if (user == null)
            {
                MessageBox.Show("Username Doesn't Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.name = name;
            user.password = password;
            user.type = (type == "Admin" ? true : false);
            entities.user_info.AddOrUpdate(user);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void deleteUser(string username)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var user = entities.user_info.FirstOrDefault(u => u.user_name == username);
            if (user == null)
            {
                MessageBox.Show("User Doesn't Exists");
                return;
            }
            entities.user_info.Remove(user);
            entities.SaveChanges();
            entities.Dispose();
        }

        public user_info GetUserInfo(string username)
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.user_info.FirstOrDefault(u => u.user_name == username);
        }
    }
}
