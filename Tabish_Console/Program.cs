
using System;
namespace Tabish_Console
{
    class Program
    {
        //OS___CLR---Main
        static void Main()
        {
            // check branch test
            //WAP to calculate gross salary
            // CalculateGrossSalary();
            //WAP to swap the 2 numbers
            SwapNumbers();

            //WAP to find the aggregate marks and percentage of the student assuming  number subjet=5 and each subject=max marks 100
            CalculateMarks();
            //WAP input5 digit number---calculate the sum of the digits---11111=5
             CalculateSumofFiveDigitsNumber();//CamelCase---Methods.Class<namespace
            //variables---pascalCase
            //python---sum_of_digits----snake_case
            //WAP for reverse the three digits
            // ReverseTheDigits();

            //CalculateExpressioForIncrementOperator();

            //BoolDemo();
            // SampleCodeDay_One();
            Console.ReadLine();

        }

        static void BoolDemo()
        {
            bool flag=false;
            int a = 3, b = 5;
            flag = (a != b) && b > 2;//&& T --T===T   || If any one is True ---T
            Console.WriteLine(flag);
            

        }

        static void CalculateExpressioForIncrementOperator()
        {
            int x = 1;
            int y = x + ++x + x + x++ + 2 * (++x);//1+1---2

            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //int m = 1;
            //int z = m + ++m;//1+2=3
            //Console.WriteLine(z);





        }



        //assignment
        //Get 5 digits number from user and do the summation for first and last digit
        //
        /// <summary>
        /// i assumbed user typed 5 digit number. i collect the number stored in var num then do modolo to get the last digit assigned into var a and 
        ///  devide the number by 10000 to get the Msb digit of the 5 digit number and assigned to num var finally i add both a and num variable and assigned to var sum 
        /// </summary>
        static void CalculateSumofFiveDigitsNumber()
        {
            Console.WriteLine("Please enter five digit number");
            int num = Convert.ToInt32(Console.ReadLine());//12345--1+2+3+4+5
            Console.WriteLine($"Input Given={num}");
            int a = num % 10;
            num = num / 10000;
            int sum = a + num;
            /* int a = num % 10;//5;
             num = num / 10;//1234
             int b = num % 10;//4
             num = num / 10;//123;
             int c = num % 10;//3
             num = num / 10;//12;
             int d = num % 10;//2
             num = num / 10;//1;

             int sum = a + b + c + d + num;
            */
       

            Console.WriteLine($"Sum of the 1st and last digit of given 5 digits ={sum} ");

        }

        static void ReverseTheDigits()
        {
            Console.WriteLine("Please enter 3 digit number");
            int num = Convert.ToInt32(Console.ReadLine());//123
            Console.WriteLine($"Input Given={num}");
            int a = num % 10;//last digit---3
            num = num / 10;//reduced to 2 digit--12
            int b = num % 10;//extraction of middle one---2
            num = num / 10;//reduce to single---first digit in the given input---1
                           //last*100+b*10+1st
            int reverseNumber = a * 100 + b * 10 + num;


            Console.WriteLine($"Reverse number ={reverseNumber} ");

        }

        //Formatting--ctrl+k+d

        //Get input of Marksobtained of 5 students  from teacher
        //What is average score of you students?
        /// <summary>
        /// get 5 marks from the terminal and add and divide by 5 (Average=total marks /number of student )
        /// </summary>
        static void CalculateMarks()
        {
            Console.WriteLine("Enter marks for student 1");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for student 2");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for student 3");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for student 4");
            int m4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for student 5");
            int m5 = Convert.ToInt32(Console.ReadLine());

            double aggreagteMarks = m1 + m2 + m3 + m4 + m5;

            double averageMarks = (aggreagteMarks / 5);

            //double percentage = (aggreagteMarks * 100 / 500);

            Console.WriteLine($"Total Marks Obtained = {aggreagteMarks} and Average marks obtained ={averageMarks}");
        }

        //Assignment---Do this using XOR gate
        /// <summary>
        /// below Swapnumber method i used Xor(^)logic based on the logic table(T--T,F--F =F)
        ///                                    
        /// </summary>
        static void SwapNumbers()
        {
            int x = 10, y = 20;
            Console.WriteLine($"Before Swapp x={x} and y={y} ");
            //int temp;
            //temp = x;//10
            //x = y;//20--y--20
            //y = temp;//10
            //x = x + y;//30
            //y = x - y;//--30-20--10
            //x = x - y;//30-10==20
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Console.WriteLine($"After the Swapp x={x} and y={y} ");


        }

        static void CalculateGrossSalary()
        {
            //asked bs, ta=10% da=20%--gs=bs +10%ofbs +20%ofbs
            Console.WriteLine("Enter you basic salary");
            long basicSalary = Convert.ToInt64(Console.ReadLine());//variable is pascalCase
            double ta = 0.1 * basicSalary;
            double da = 0.2 * basicSalary;

            double gs = basicSalary + ta + da;
            Console.WriteLine($"your basic salary ={basicSalary} , TA ={ta} , DA={da} and Gross salary ={gs}");



        }

        static void SampleCodeDay_One()
        {
            Console.WriteLine("telle me your name");
            string name = Console.ReadLine();//input statement
            Console.WriteLine("tell me your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " Your age is " + age);
            Console.WriteLine($"Hello {name} Your age is {age}");
            Console.WriteLine("Hello {0} your age is {1}", name, age);
        }
    }
}
