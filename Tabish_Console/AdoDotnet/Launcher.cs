using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabish_Console.EF;

namespace Tabish_Console.AdoDotnet
{
    public class Launcher
    {
        public static void Main()
        {
            Console.WriteLine("Choose the options from below:\n 1.Add Record \n2.Modify record \n 3.Delete Record \n 4.Fetch \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddRecord();
                    break;


                case 2:
                    ModifyRecord();
                    break;

                case 3:
                    DeleteRecord();
                    break;

                case 4:
                    FetchAllRecord();
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            

            Console.ReadLine();


        }

        private static void FetchAllRecord()
        {
            try
            {

                //CRUD cRUD = new CRUD();
                //var students = cRUD.GetAll();

                CRUD_EF cRUD_EF = new CRUD_EF();
                var students = cRUD_EF.GetAll();


                foreach ( Student item in students)
                {
                    Console.WriteLine($"Roll number:{item.Id} | Name:{item.Name} |Class:{item.Class} | Gender:{item.Gender} | Fee : {item.Fee}");
                }

                var student = cRUD_EF.GetById(2);
                Console.WriteLine($"Roll number:{student.Id} | Name:{student.Name} |Class:{student.Class} | Gender:{student.Gender} | Fee : {student.Fee}");

                Console.WriteLine(  );

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void DeleteRecord()
        {
            Console.WriteLine("Enter RollNumber");
            int id = Convert.ToInt32(Console.ReadLine());

            //CRUD cRUD = new CRUD();
            //string result = cRUD.Delete(id);

            CRUD_EF cRUD_EF = new CRUD_EF();
            string result = cRUD_EF.Delete(id);
            Console.WriteLine(result);
        }

        private static void ModifyRecord()
        {
            Console.WriteLine("Enter RollNumber");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            //Console.WriteLine("Enter Fee");
            //decimal fee = Convert.ToDecimal(Console.ReadLine());

            //Student student = new Student { Id = id,Name = name, Fee = fee };

            //CRUD cRUD = new CRUD();
            //string result = cRUD.Update(student);

            CRUD_EF cRUD = new CRUD_EF();
            string result = cRUD.Update(id,name);
            Console.WriteLine(result);
        }

        private static void AddRecord()
        {

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter class");
            int clas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            string gender =Console.ReadLine();

            Console.WriteLine("Enter Fee");
            decimal fee = Convert.ToDecimal(Console.ReadLine());

            Student student = new Student { Name = name, Class = clas, Gender = gender, Fee = fee };

            //CRUD cRUD = new CRUD();
            //string result = cRUD.Add(student);

            CRUD_EF cRUD = new CRUD_EF();
            string result = cRUD.Add(student);
            Console.WriteLine(result);
        }
    }
}
