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
            Console.Write("Greetings user, please enter a multi-digit whole number:  ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            do
            {
            var result = userInput * .1;
            var x = Convert.ToInt32(result % 1 * 10);
            Console.Write(x);
            userInput = (int)result;
            } while (userInput != 0);

        }
    }
}
