using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs1, eggs2, eggs3, eggs4;
            int totaleggs, dozens, eggs;

            Console.WriteLine("How many eggs from chicken 1? ");
            eggs1 = int.Parse(Console.ReadLine());

            Console.WriteLine("How many eggs from chicken 2? ");
            eggs2 = int.Parse(Console.ReadLine());

            Console.WriteLine("How many eggs from chicken 3? ");
            eggs3 = int.Parse(Console.ReadLine());

            Console.WriteLine("How many eggs from chicken 4? ");
            eggs4 = int.Parse(Console.ReadLine());

            totaleggs = eggs1 + eggs2 + eggs3 + eggs4;
            dozens = totaleggs / 12;
            eggs = totaleggs % 12;

            Console.WriteLine("A total of {0} eggs is {1} dozen and {2} eggs.", totaleggs, dozens, eggs);
        }
    }
}
