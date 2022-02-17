// See https://aka.ms/new-console-template for more information
using System;
namespace Fibonacci_Series
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int series = Convert.ToInt32(Console.ReadLine());
            int previousValue = 0;
            int value = 1;
            int ans = 0;

            for(int i = 1; i <= series; i++)
            {
                ans = previousValue + value;
                previousValue = value;
                value = ans;

                Console.WriteLine(ans);
            }

        }
    }
}