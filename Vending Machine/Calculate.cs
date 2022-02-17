using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
     class Calculate
    {
        public void Change(int amount)
        {
            Notes notes = new Notes();
            amount = notes.Thousand(amount);
            amount = notes.FiveHundred(amount);
            amount = notes.Hundred(amount);
            amount = notes.Fifty(amount);
            amount = notes.Ten(amount);
            amount = notes.Five(amount);
            amount = notes.Two(amount);
            if (amount >= 1)
            {
                Console.WriteLine($"{amount} note of 1");
            }


        }
    }
}
