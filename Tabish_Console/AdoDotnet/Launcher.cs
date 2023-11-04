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

            Console.WriteLine("Enter RollNumber");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter class");
            int clas = Convert.ToInt32(Console.ReadLine());

            Student student = new Student { RollNumber = id, Name = name, Class = clas };

            CRUD cRUD = new CRUD();
            cRUD.Add(student);

            Console.ReadLine();


        }
    }
}
