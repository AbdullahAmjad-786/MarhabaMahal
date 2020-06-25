using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarhabaMahal.BLClasses
{
    class Connection
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=WALEED;Initial Catalog=Marhaba;Integrated Security=True");
            return con;
        }

        public string getConnectionString()
        {
            string cone = "Data Source=WALEED;Initial Catalog=Marhaba;Integrated Security=True";
            return cone;
        }
    }
}
