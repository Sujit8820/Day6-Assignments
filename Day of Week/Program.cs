// See https://aka.ms/new-console-template for more information
using System;
namespace Day_of_Week
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a date");
            Console.WriteLine("Enter a day from 1 to 31 ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a month from 1 to 12 ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a year");
            int y = Convert.ToInt32(Console.ReadLine());

            date.DayOfWeek(d, m, y);

        }
    }
    class date
    {
        public static void DayOfWeek(int d, int m, int y)
        {
            int y1 = y - (14 - m) / 12;
            int x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            int m1 = m + 12 * ((14 - m) / 12) - 2;
            int d1 = (d + x + (31 * m1) / 12) % 7;

            switch (d1)
            {
                case 0:
                    Console.WriteLine("\n Sunday");
                    break;
                case 1:
                    Console.WriteLine("\n Monday");
                    break;
                case 2:
                    Console.WriteLine("\n Tuesday");
                    break;
                case 3:
                    Console.WriteLine("\n wednesday");
                    break;
                case 4:
                    Console.WriteLine("\n Thursday");
                    break;
                case 5:
                    Console.WriteLine("\n Firday");
                    break;
                case 6:
                    Console.WriteLine("\n Saturday");
                    break;

            }

        }
    }
}
