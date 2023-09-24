
using System;
namespace Tabish_Console
{
    class Program : Table
    {
 
        static void Main()
        {
            //checking 
            //Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0,
            //0 when m is 0 and -1 when m is less than 0.
            // DisplayFlagValue();

            ////Write a C# Sharp program to find the largest of three numbers||lowest ||Eldest|younger
            ////1. we will take three integer number from user but that should be in main
            ////2.Business will be inside LargestAmongsThree() so we have to pass by value all three inputs
            ////After calculation the methods should return the message lioke " {x} is laregst among three " to the caller method and the caller metod will print the message

            //// we will take three integer number from user but that should be in main
            //int num1, num2, num3;
            //Console.WriteLine("Enter three numbers");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //num3 = Convert.ToInt32(Console.ReadLine());

            ////pass the values
            //string message1 = LargestAmongsThree(num1, num2, num3);
            //Console.WriteLine(message1);
            //string message= LargestAmongsThreeUisngConditionalOperator(num1,num2,num3);
            //Console.WriteLine(message);


            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

            // find the co-ordinates  using switch case and conditional operator
            // get the co-ordinates
            int x = 0, y = 0;
            Console.WriteLine("Enter the co-ordinates");
            x = Convert.ToInt32(Console.ReadLine());
           y = Convert.ToInt32(Console.ReadLine());

            string message =FindQuadrants(x, y);
            Console.WriteLine(message);
            Console.ReadLine();

        }

        private static string FindQuadrants(int x,int y)
        {
            if(x>0 && y> 0)
            {
                return $"Given co-ordibate is {x},{y} lies in[first Quadrant]";

            }
            else if (x < 0 && y > 0)
                return $"Given co-ordibate is {x},{y} lies in[second Quadrant]";
            else if (x < 0 && y < 0)
                return $"Given co-ordibate is {x},{y} lies in[3rd Quadrant]";
            else
                return $"Given co-ordibate is {x},{y} lies in[4th Quadrant]";

        }

        private static string LargestAmongsThree(int num1,int num2,int num3)
        {
            if (num1>num2)
            {
                if (num1>num3)
                {
                    return $"Largest number is {num1}";
                }
                else
                {
                    return $"Largest number is {num3}";
                }

            }

            else
            {
                if (num2 > num3)
                {
                    return $"Largest number is {num2}";
                }
                else
                {
                    return $"Largest number is {num3}";
                }
            }
            
        }
        private static string LargestAmongsThreeUisngConditionalOperator(int num1, int num2, int num3)
        {
            string message = num1 > num2 ? (num1 > num3 ? $"Largest number is {num1}" : $"Largest number is {num3}") : (num2 > num3 ? $"Largest number is {num2}" : $"Largest number is {num3}");
            return message;

        }

        private static void DisplayFlagValue()
        {
            Console.WriteLine("Enter the integer value");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = -1;
            if (m>0)
            {
                n = 1;
                Console.WriteLine($"The value of n is {n} for the value of m as  {m}");
            }
            else if (m==0)
            {
                n = 0;
                Console.WriteLine($"The value of n is {n} for the value of m as {m}");
            }
            else
            {
                Console.WriteLine($"The value of n is {n} for the value of m as {m}");
            }
        }
    }
}
