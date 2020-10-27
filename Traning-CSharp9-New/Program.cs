using System;
using System.Collections.Generic;

namespace Traning_CSharp9_New
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new(2020, 10, 30);
            Console.WriteLine(date);
            ShowDate(new(2020, 10, 30));

            List<DateTime> datesList = new()
            {
                new(2020, 10, 01),
                new(2020, 10, 02),
                new(2020, 10, 03),
                new(2020, 10, 04),
                new(2020, 10, 05)
            };
        }

        static void ShowDate(DateTime date)
        {
            Console.WriteLine(date);
        }
    }
}
