using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
    public interface ICalculator
    {
        void Add();
       
    }

    public interface ICalculatorNew
    {
        void Add();
        void Sub();
    }


    public class A: ICalculator
    {
        //this only pass to the customer-2023
        public void Add()
        {

            Console.WriteLine("add logic");
        }

       
    }


    public class B : ICalculatorNew
    {
        //this only pass to the customer-2023
        public void Add()
        {
            Console.WriteLine("logic");
        }

        public void Sub()
        {
            Console.WriteLine("");
        }
    }

    public static class InstanceCreator {

        public static ICalculatorNew CReateV2()
        {
            ICalculatorNew obj = new B();
            return obj;
        }
        public static ICalculator CreateV1()
        {

            ICalculator obj = new A();
            return obj;


        }
    
    }
}
