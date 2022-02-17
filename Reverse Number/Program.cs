// See https://aka.ms/new-console-template for more information
using System;
namespace Perfect_Number
{
    class Program
    {
        static int factor = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            while(number > 0)
            {
                int a = number % 10;
                ans = ans * 10 + a;
                number = number / 10;   

            }
            Console.WriteLine("\nReverse Number: "+ans);
        }
    }
}