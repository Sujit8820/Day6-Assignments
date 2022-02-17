// See https://aka.ms/new-console-template for more information
using System;
namespace Binary
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double value = Convert.ToInt32(Console.ReadLine());

            Binary.ToBinary(value);
        }
    }
    class Binary
    {
        public static int Getpower(double value)
        {
            double power = 0;
            int i = 0;

            while (value >= power)
            {
                i = i + 1;

                power = Math.Pow(2, i);

            }
            return i-1;
        }

        public static void ToBinary(double value)
        { 
            int limit = Binary.Getpower(value);

            int binary = 0;
            double power = 0;
            int[] Array = new int [limit +1 ];   

            for (int i = limit ; i > 0; i--)
            { 
              power = Math.Pow(2,i);

                if (value >= power)
                {
                    binary = 1;
                    value -= power;
                }
                else
                {
                    binary = 0;
                }
                Array[i] = binary;
               
            }
            Console.WriteLine(string.Join(" ", Array.Reverse()));

        }
    }
}
