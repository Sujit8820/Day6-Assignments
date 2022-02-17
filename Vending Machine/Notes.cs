using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Notes
    {
     
        public int Thousand(int amount)
        {
            if (amount >= 1000)
            {
                int thousand = amount / 1000;
                Console.WriteLine($"{thousand} notes of 1000");
                amount = amount % 1000;
            }
                return amount;

        }
        public int FiveHundred(int amount)
        {
            if (amount >= 500)
            {
                int fiveHundred = amount / 500;
                Console.WriteLine($"{fiveHundred} notes of 500");
                amount = amount % 500;
            }
            return amount;
        }
        public int Hundred(int amount)
        {
            if (amount >= 100)
            {
                int hundred = amount / 100;
                Console.WriteLine($"{hundred} notes of 100");
                amount = amount % 100;
            }
            return amount;
        }
        public int Fifty(int amount)
        {
            if (amount >= 50)
            {
                int fifty = amount / 50;
                Console.WriteLine($"{fifty} notes of 50");
                amount = amount % 50;
            }
            return amount;
        }
        public int Ten(int amount)
        {
            if (amount >= 10)
            {
                int ten = amount / 10;
                Console.WriteLine($"{ten} notes of 10");
                amount = amount % 10;
            }
            return amount;
        }
        public int Five(int amount)
        {
            if (amount >= 5)
            {
                int five = amount / 5;
                Console.WriteLine($"{five} notes of 5");
                amount = amount % 5;
            }
            return amount;
        }
        public int Two(int amount)
        {
            if (amount >= 2)
            {
                int two = amount / 2;
                Console.WriteLine($"{two} notes of 2");
                amount = amount % 2;
            }
            return amount;
        }
    }
}
