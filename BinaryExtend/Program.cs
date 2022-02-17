// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
namespace BinaryExtended
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
            return i;
        }

        public static void ToBinary(double value)
        {
            int limit = Binary.Getpower(value);

            int binary = 0;
            double power = 0;
            int[] binaryArray = new int[limit + 1];

            for (int i = limit; i > 0; i--)
            {
                power = Math.Pow(2, i);

                if (value >= power)
                {
                    binary = 1;
                    value -= power;
                }
                else
                {
                    binary = 0;
                }
                binaryArray[i] = binary;
            }



            Array.Reverse(binaryArray);
            Console.WriteLine(string.Join(" ", binaryArray));


            int[] firstArray = binaryArray.Take(binaryArray.Length / 2).ToArray();
            int[] secondArray = binaryArray.Skip(binaryArray.Length / 2).ToArray();


            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

            var myList = new List<int>();
            myList.AddRange(secondArray);
            myList.AddRange(firstArray);

            int[] newArray = myList.ToArray();
            Console.WriteLine(string.Join(" ", newArray));


            Array.Reverse(newArray);

            double ans = 0;
            double number = 0;
            for (int i = 0; i < newArray.Length; i++)
            {

                if (newArray[i] == 1)
                {
                    ans = Math.Pow(2, i);
                }
                else
                {
                    ans = 0;
                }
                number = number + ans;
            }

            Console.WriteLine(number);
        }
    }
}

