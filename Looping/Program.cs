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
            for (int row = 0; row < 11; row++)
            {
                for (var space = 0; space < 11 - row; space +=2)
                {
                    Console.Write("  ");
                }
                for (int column = 6; column < row + 6; column++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
