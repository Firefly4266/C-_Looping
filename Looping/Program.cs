using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            while (x < 100)
            {
                if (x % 15 == 0)
                {
                    Console.WriteLine(" Fizz-Buzz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine(" Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine(" Fizz");
                }
                else
                    Console.WriteLine($" {x}");
                x++;
            }
        }
    }
}
