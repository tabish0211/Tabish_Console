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
        public string Add(Student student)
        {
            //creae a connection object 
            string connectionString = "server=DESKTOP-UB4P45V;database=students_db;Integrated security=true;";
            //string connectionString = "server=DESKTOP-UB4P45V;database=students_db;user name=xxxxx;password=yyyyyy";
            SqlConnection con = new SqlConnection(connectionString);
            //open connection
            con.Open();

            //create record query
            string cmd_str = @"insert into student(sname,class,gender,Fee) values(@sname,@class,@gender,@my_fee)";

            //Prepare command
            SqlCommand cmd = new SqlCommand(cmd_str,con);
            cmd.CommandType = CommandType.Text;
            //optional step
            cmd.Parameters.AddWithValue("@sname", student.Name);
            cmd.Parameters.AddWithValue("@class", student.Class);
            cmd.Parameters.AddWithValue("@gender", student.Gender);
            cmd.Parameters.AddWithValue("@my_fee", student.Fee);

            //Firing the command s like Insert,Update/Delete
            int record = cmd.ExecuteNonQuery();

            //close the connection
            con.Close();

            if (record > 0) return "Record added successfully";
            return "Error while creating record";


            
        }

        public string Update(Student student)
        {
            //creae a connection object 
            string connectionString = "server=DESKTOP-UB4P45V;database=students_db;Integrated security=true;";
            //string connectionString = "server=DESKTOP-UB4P45V;database=students_db;user name=xxxxx;password=yyyyyy";
            SqlConnection con = new SqlConnection(connectionString);
            //open connection
            con.Open();

            //create record query
            string cmd_str = @"update student set sname=@sname, Fee=@my_fee where Rid=@rid";

            //Prepare command
            SqlCommand cmd = new SqlCommand(cmd_str, con);
            cmd.CommandType = CommandType.Text;
            //optional step
            cmd.Parameters.AddWithValue("@rid", student.Id);
            cmd.Parameters.AddWithValue("@sname", student.Name);          
            cmd.Parameters.AddWithValue("@my_fee", student.Fee);

            //Firing the command s like Insert,Update/Delete
            int record = cmd.ExecuteNonQuery();

            //close the connection
            con.Close();

            if (record > 0) return "Record modified successfully";
            return "Error while modifying record";



        }

        public string Delete(int id)
        {
            //creae a connection object 
            string connectionString = "server=DESKTOP-UB4P45V;database=students_db;Integrated security=true;";
            //string connectionString = "server=DESKTOP-UB4P45V;database=students_db;user name=xxxxx;password=yyyyyy";
            SqlConnection con = new SqlConnection(connectionString);
            //open connection
            con.Open();

            //create record query
            string cmd_str = @"Delete from student where Rid=@rid";

            //Prepare command
            SqlCommand cmd = new SqlCommand(cmd_str, con);
            cmd.CommandType = CommandType.Text;
            //optional step
            cmd.Parameters.AddWithValue("@rid",id);
           

            //Firing the command s like Insert,Update/Delete
            int record = cmd.ExecuteNonQuery();

            //close the connection
            con.Close();

            if (record > 0) return "Record deleted successfully";
            return "Error while deleting record";



        }

        public IList<Student> GetAll()
        {
            //creae a connection object 
            string connectionString = "server=DESKTOP-UB4P45V;database=students_db;Integrated security=true;";
            //string connectionString = "server=DESKTOP-UB4P45V;database=students_db;user name=xxxxx;password=yyyyyy";
            SqlConnection con = new SqlConnection(connectionString);
            //open connection
            con.Open();

            //create record query
            string cmd_str = @"Select * from student";

            //Prepare command
            SqlCommand cmd = new SqlCommand(cmd_str, con);
            cmd.CommandType = CommandType.Text;
            
            //Sqldatareader
            var reader=cmd.ExecuteReader();
            List<Student> students = null;
            if (reader.HasRows)
            {
                students = new List<Student>();
                while (reader.Read())
                {
                    Student s = new Student {

                        Id = Convert.ToInt32(reader["Rid"].ToString()),
                        Name= reader["sname"].ToString(),
                        Class= Convert.ToInt32(reader["class"].ToString()),
                        Gender = reader["gender"].ToString(),
                        Fee= Convert.ToDecimal(reader["Fee"].ToString()),
                    };

                    students.Add(s);
                }
            }

            reader.Close();
            //close the connection
            con.Close();

            if (students.Any()) return students;
            throw new Exception("nO RECORDFOUND");



        }
    }
}
