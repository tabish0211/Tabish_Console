using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                CRUD cRUD = new CRUD();
                var students = cRUD.GetAll();

                foreach ( Student item in students)
                {
                    Console.WriteLine($"Roll number:{item.RollNumber} | Name:{item.Name} |Class:{item.Class} | Gender:{item.Gender} | Fee : {item.Fee}");
                }
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

            CRUD cRUD = new CRUD();
            string result = cRUD.Delete(id);
            Console.WriteLine(result);
        }

        private static void ModifyRecord()
        {
            Console.WriteLine("Enter RollNumber");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Fee");
            decimal fee = Convert.ToDecimal(Console.ReadLine());

            Student student = new Student { RollNumber=id,Name = name, Fee = fee };

            CRUD cRUD = new CRUD();
            string result = cRUD.Update(student);
            Console.WriteLine(result);
        }

        private static void AddRecord()
        {

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter class");
            int clas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Fee");
            decimal fee = Convert.ToDecimal(Console.ReadLine());

            Student student = new Student { Name = name, Class = clas, Gender = gender, Fee = fee };

            CRUD cRUD = new CRUD();
            string result = cRUD.Add(student);
            Console.WriteLine(result);
        }
    }
}
