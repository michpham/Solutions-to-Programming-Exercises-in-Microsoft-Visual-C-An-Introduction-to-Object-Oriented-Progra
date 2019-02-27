using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            double RATE = 0.50;
            double weight, totalPrice, days;

            Console.WriteLine("What's your dog's weight?");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's the number of days?");
            days = double.Parse(Console.ReadLine());

            totalPrice = (weight * RATE) * days;

            Console.WriteLine("Total: ${0}", totalPrice);
        }
    }
}
