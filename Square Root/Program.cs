// See https://aka.ms/new-console-template for more information
using System;

namespace Square_Root
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double c = Convert.ToDouble(Console.ReadLine());

            calculation.SquareRoot(c);
        }
    }
    class calculation
    {
        public static void SquareRoot(double c)
        {
            double t = c;
            while(Math.Abs(t - c / t) > 1e-15 * t)
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine($"\n{c} square root is {t}");

        }
    }
}
