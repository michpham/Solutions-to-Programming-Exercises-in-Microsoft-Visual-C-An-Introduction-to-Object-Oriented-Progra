using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int feetInAMile = 5280;
            double distance = 8.5;
            double distanceInFeet;

            distanceInFeet = feetInAMile * distance;

            Console.WriteLine("The distance to my uncle's house is {0} miles or {1} feet.", distance, distanceInFeet);

        }
    }
}
