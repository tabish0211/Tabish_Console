using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Tabish_Console.AdoDotnet
{
    //Create ,Read,Update and Delete
    //Insert,Query,Update and delete
    public class CRUD
    {
        public int Add(Student student)
        {
            //
            string connectionString = "server=DESKTOP-UB4P45V;database=;";
            SqlConnection con = new SqlConnection(connectionString);
            return 0;
        }
    }
}
