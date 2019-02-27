using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs1 = 127, eggs2 = 135, eggs3 = 97, eggs4 = 203;
            int totaleggs, dozens, eggs;

            totaleggs = eggs1 + eggs2 + eggs3 + eggs4;
            dozens = totaleggs / 12;
            eggs = totaleggs % 12;

            Console.WriteLine("A total of {0} eggs is {1} dozen and {2} eggs.", totaleggs, dozens, eggs);
        }
    }
}
