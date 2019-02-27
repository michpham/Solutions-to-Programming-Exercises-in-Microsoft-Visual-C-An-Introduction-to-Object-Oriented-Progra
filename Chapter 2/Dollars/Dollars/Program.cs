using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int money, twenties, tens, fives, ones;

            Console.WriteLine("How much money do you have? ");
            money = int.Parse(Console.ReadLine());

            twenties = money / 20;
            tens = (money % 20) / 10;
            fives = ((money % 20) % 10) / 5;
            ones = (((money % 20) % 10) % 5) / 1;

            Console.WriteLine("{0} twenties, {1} tens, {2} fives, {3} ones", twenties, tens, fives, ones);
        }
    }
}
