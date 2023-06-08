using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = projectWinform; Integrated Security = True");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
    }
}
