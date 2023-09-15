
using System;
namespace Tabish_Console
{
    class Program : Table
    {
        //OS___CLR---Main
        static void Main()
        {
            //WAP to calculate gross salary
            // CalculateGrossSalary();
            //WAP to swap the 2 numbers
            //SwapNumbers();

            //WAP to find the aggregate marks and percentage of the student assuming  number subjet=5 and each subject=max marks 100
            // CalculateMarks();
            //WAP input5 digit number---calculate the sum of the digits---11111=5
            // CalculateSumofFiveDigitsNumber();//CamelCase---Methods.Class<namespace
            //variables---pascalCase
            //python---sum_of_digits----snake_case
            //WAP for reverse the three digits
            // ReverseTheDigits();

            //CalculateExpressioForIncrementOperator();

            //BoolDemo();

            //Decision control Demo
            //DecisionControl();
            //Looping Sytax

            //int x1,x2,x3,x54---
            //    x1 = 2 * 1;
            //Console.WriteLine(x1);
            //x1 = 2 * 2;
            //Console.WriteLine(x1);
            // LoopDemo();



            //Method types
            //No return --no parameters---void xyz()
            //No return--with paarmeters---void xyz(int x)
            //with return--no parameters---int xyz()
            //with return ---with parameters---int xyz(int y)
            // SampleCodeDay_One();

            //Console.WriteLine("Enter roll number");
            //int rollNumber = Convert.ToInt32(Console.ReadLine());//10
            // DisplayData(rollNumber); //Pass by Value--10

            Console.WriteLine("Enter the number for which you want a table to print");
            int number = Convert.ToInt32(Console.ReadLine());
             string message=Table(number);

            Console.WriteLine(message);
            //Console.WriteLine("");
            Console.ReadLine();

        }

        static void DisplayData(int rollNumber)
        {
           // rollNumber += 1;
            Console.WriteLine($"Welcome roll number :{rollNumber}");
        ///welcome roll number---user passed roll number
        }

        static void LoopDemo()
        {

            //top testing
            //for (int i = 1; i < 11; i++)
            //{
            //    console.writeline(2*i);
            //}

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(2*i);
            //    i++;

            //} while (i<11);//bottom testing

            //int i = 1;
            //char a = 'a';
            //char b = 'b';
            ////top testing
            //while (a<b)
            //{
            //    Console.WriteLine(2*i);
            //    i++;
            //}


            //foreach (var item in "Tabish")
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 1; i < 11; i++)
            //{
            //    if (i==6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);//1,2,3,4,5,6,7,8,9,10-----1,2,3,4,5
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    if (i == 6 || i==9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);//1,2,3,4,5,6,7,8,9,10-----1,2,3,4,5,7,8,10
            //}
        }

        static void DecisionControl()
        {
            if (true)
            {
                //true--if block 
                //logic exceute --if this condition true
            }
            else
            {
                //false condition
            }


            //Ladder if else
            if (true)
            {
                //1st situation
            }

            else if(true)
            {
                //second situation

            }

            else
            {

            }


            //Nested if-else


            //rahim,suresh,mahesh
            if (true)
            {
                //above scenario gets true
                //plese check

                if (true)
                {

                }

                else
                {

                }
            }

            //Switch statement---as alternative for ladder if -else

            //switch (switch_on)
            //{
            //    case 1:
            //        //do this
            //        break;

            //    case 2:
            //        //do this
            //        break;

            //    case 3:
            //        //do this
            //        break;

            //    case 4:
            //        //do this
            //        break;

            //    default:
            //        //to-do
            //        break;
            //}

            //conditional operator
            //var epression= x>y?(logic--true):(logic--false)\
            int x = 1, y = 2,z=3;
            string result  = x > y ? (x>z?("x is the largest one"):("z is largest one")) : (y > z ? ("y is the largest one") : ("z is largest one"));

            Console.WriteLine(z);

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
        static void CalculateSumofFiveDigitsNumber()
        {
            Console.WriteLine("Please enter five digit number");
            int num = Convert.ToInt32(Console.ReadLine());//12345--1+2+3+4+5
            Console.WriteLine($"Input Given={num}");
            int a = num % 10;//5;
            num = num / 10;//1234
            int b = num % 10;//4
            num = num / 10;//123;
            int c = num % 10;//3
            num = num / 10;//12;
            int d = num % 10;//2
            num = num / 10;//1;

            int sum = a + b + c + d + num;

            Console.WriteLine($"Sum of the 5 digits ={sum} ");

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
        static void CalculateMarks()
        {
            Console.WriteLine("Enter marks for subject 1");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 1");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 1");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 1");
            int m4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 1");
            int m5 = Convert.ToInt32(Console.ReadLine());

            double aggreagteMarks = m1 + m2 + m3 + m4 + m5;

            double percentage = (aggreagteMarks * 100 / 500);

            Console.WriteLine($"Marks Obtained = {aggreagteMarks} and percentage obtained ={percentage}");
        }

        static void SwapNumbers()
        {
            int x = 10, y = 20;
            Console.WriteLine($"Old values x={x} and y={y} ");
            //int temp;
            //temp = x;//10
            //x = y;//20--y--20
            //y = temp;//10
            //x = x + y;//30
            //y = x - y;//--30-20--10
            //x = x - y;//30-10==20

            //Assignment---Do this using XOR gate
            Console.WriteLine($"New values x={x} and y={y} ");


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
