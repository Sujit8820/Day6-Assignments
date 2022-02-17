// See https://aka.ms/new-console-template for more information
using System;
namespace Vending_Machine
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Calculate calculate = new Calculate();
            calculate.Change(amount);

        }
            
    }
}
