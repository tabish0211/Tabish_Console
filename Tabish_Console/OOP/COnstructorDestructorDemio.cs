using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console
{
   public class COnstructorDestructorDemio
    {
        public static int Id { get; set; }
        public COnstructorDestructorDemio()
        {
            //Id = 1;
            //Console.WriteLine("Initialization of class variable");

            Console.WriteLine("I am reading a file ");
            //dotnet system---external system---io resource

        }

        //static COnstructorDestructorDemio()
        //{
        //    Id = 1;
        //    Console.WriteLine("Initailized those varaible which you need one time during the call");
        //    //

        //}

        //public static void MyData()
        //{
        //    Console.WriteLine(Id);
        //    //

        //}

        public void close()
        {

            Console.WriteLine("logic for closing file reading channel if any error comes or the program completed succefully");

        }

        ~COnstructorDestructorDemio()

        {
            close();
            Console.ReadLine(); 
        }
    }
}
