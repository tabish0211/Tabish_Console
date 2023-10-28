using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
    public class KeywordsDemo
    {
        public void Sum(ref int x, ref int y, out int z, out int m)
        {
            x = 3; y = 5;
            z = x + y;
            m = x - y;
           
        }


        public static Tuple<string[],int,double> TupleDemo()
        {
            string[] str = { "A", "B", "C" };
            string name = "Rakesh";
            int salary = 10000;
            double hra = 100.00;

           return Tuple.Create(str, salary,hra);


        }

    }

    class StudentsStrenghth
    {
        public readonly  int capacity ;

        public int RollNo { get; set; }
        public string Name { get; set; }

        public int Class { get; set; }

        
        public StudentsStrenghth(int cap)
        {
            capacity = cap;


        }

        public StudentsStrenghth()
        {
            

        }





    }

}
