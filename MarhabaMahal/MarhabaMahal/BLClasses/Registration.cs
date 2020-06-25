using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarhabaMahal.BLClasses
{
    class Registration
    {
        public SqlConnection getcon()
        {
            Connection co = new Connection();
            return co.getConnection();
        }

        public SqlCommand getInsertionCommand(SqlConnection con, string name, string username, string password, string phno)
        {
            string query = "INSERT INTO user_info (user_id,name,user_name,password,ph_no) VALUES ('" + 1 + "','" + name + "','" + username + "','" + password + "','" + phno + "')";
            SqlCommand com = new SqlCommand(query, con);
            return com;
        }

    }
}
