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
            for (int row = 0; row < 11; row++)// this will give me the number of rows I will have and the row var serves as a position marker.
            {
                for (var space = 0; space < 11 - row; space +=2)// Here we need to insert spaces. The number of spaces will never be greater than 1/2 of the number of columns/rows(11) in relation to the row we are on...hence 11 - row. We accomplish this through incrimenting by two cutting the distance across the row in half.
                {
                    Console.Write(" x");// this is the actual space being printed out.  I substituted an 'x' for better illustration.
                }
                for (int column = 6; column < row + 6; column++)// This loop establishes the column position as in which column we are presently located. When the condition of the first loop is met, we drop into this loop.  We start at the midpoint because that is the furthest the first loop will go.
                {
                    Console.Write(" *");// Here we will print until the condition is met.
                }
                Console.WriteLine();// This will move us to the next row.
            }
        }
    }
}
