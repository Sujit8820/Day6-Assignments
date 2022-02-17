// See https://aka.ms/new-console-template for more information
using System;

namespace Prime_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool Prime = true;

            for (int i = 2; i < number; i++)
            {
                int remainder = number % i;

                if (remainder == 0)
                {
                    Prime = false;
                }
            }

            if (Prime == true)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else if (Prime == false)
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }

    }

}


