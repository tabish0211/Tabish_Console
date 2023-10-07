using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
    class Launcher
    {

        public static void Main()
        {

            //Console.WriteLine("Do you want to enter id and name both ,press 1 for yes");
            //int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter default id");
            int id = Convert.ToInt32(Console.ReadLine());

            //if (option==1)
            //{

            //    Console.WriteLine("Enter default name");
            //    string name = Console.ReadLine();

            //    StudentSystem studentSystemType_1 = new StudentSystem(id,name);
            //}
            //else
            //{
            //  //  StudentSystem studentSystem = new StudentSystem(id);

            //}

            StudentSystem studentSystem = new StudentSystem(id);

            Console.WriteLine("Enter real  id");
            int realId = Convert.ToInt32(Console.ReadLine());

            // studentSystem.SetDataID(realId);
            studentSystem.Id = realId;//set

            //Console.WriteLine("Enter real  Name");
            //string realName = Console.ReadLine();
            //studentSystem.SetDataName(realName);


            //int callingId = studentSystem.GetDataID();
            int callingId = studentSystem.Id;//get
           // string callingName = studentSystem.GetDataName();

           // Console.WriteLine($"your id is :{callingId} and name is {callingName}");

            //right side is object ---left is reference variable
            //  studentSystem.SetData(id, name);


            Console.ReadLine();
        
             
        
        }
    }
}



//(new StudentSystem()).ShowData();
//(new StudentSystem()).GetData();