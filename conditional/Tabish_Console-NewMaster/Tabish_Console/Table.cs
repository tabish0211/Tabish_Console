using System;

namespace Tabish_Console
{
    internal class Table
    {

        static string Table_Data(int number)
        {
            if (number >= 0)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(number * i);
                }

                return "Table printed successfully";
            }

            return "Wrong input";
        }
    }
}