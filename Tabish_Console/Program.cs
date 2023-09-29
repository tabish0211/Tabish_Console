
using System;
namespace Tabish_Console
{
    class Program : Table
    {

        static void Main()
        {
            //WAP to input user roll numbers store it as an array and display once user done with input
            //datattype[] arr=new datatype[size] 
            //int[] arrRollNumbers = new int[10];//0,0,0,0,0,0,0---
            //Console.WriteLine(arrRollNumbers[5]);

            //int size = GetSizeofAnArray();
            //int[] records = InputUserRollNumbers(size);

            //DisplayRollNumbers(records);

            //Console.WriteLine("tell me no of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("tell me no of columns");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] records = new int[rows, columns];

            //Demo2D(records);

            JaggedArrayDemo();

            Console.ReadLine();

        }

        private static void JaggedArrayDemo()
        {
            int[][] data= new int[3][];
            data[0] = new int[2];
            data[1] = new int[1];
            data[2] = new int[3];

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine(data[i][j]);
                }
            }

        }

        public static void Demo2D(int[,] array_2d)
        {
            Console.WriteLine("Enter data ");
            for (int i = 0; i < array_2d.GetLength(0); i++)
            {
                for (int j = 0; j < array_2d.GetLength(1); j++)
                {
                    array_2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("***********Records added in 2 d as*********");

            for (int i = 0; i < array_2d.GetLength(0); i++)
            {
                for (int j = 0; j < array_2d.GetLength(1); j++)
                {
                    Console.Write(array_2d[i,j]+"\t");
                }

                Console.WriteLine();
            }
        }

        private static void DisplayRollNumbers(int[] records)
        {
             Array.Sort(records);//ascending 

             Array.Reverse(records);

            for (int i = 0; i < records.Length; i++)
            {
                Console.WriteLine($"Roll numbers {i + 1}:{records[i]}");
            }
        }

        private static int[] InputUserRollNumbers(int size)
        {
            int[] rollNumbers = new int[size];

            Console.WriteLine("Enter roll numbers");
            for (int i = 0; i < rollNumbers.Length; i++)
            {
                rollNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return rollNumbers;

        }

        private static int GetSizeofAnArray()
        {
            Console.WriteLine("Enter the number of user for which roll number has to capture:");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }
    }
}
