
using System;
namespace Tabish_Console
{
    class Program
    {
        //OS___CLR---Main
        static void Main()
        {
            Console.WriteLine("telle me your name");
            string name = Console.ReadLine();//input statement
            Console.WriteLine("tell me your age");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello "+ name +" Your age is "+age);
            Console.WriteLine($"Hello {name} Your age is {age}");
            Console.WriteLine("Hello {0} your age is {1}", name,age);

            Console.ReadLine();

        }
    }
}
