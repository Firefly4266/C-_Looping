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
            //string O, F, M, AL, X;
            Console.WriteLine(" Greetings user, please select from the following options:\n");
            Console.WriteLine(" O (nothing to report), F (firewall issue), M (malware detection), AL (account lockout), X (exit):  ");
            var userInput = Console.ReadLine().ToUpper();
            while (userInput != "X")
            {
                switch(userInput)
                {
                    case "O":
                        Console.WriteLine(@"You have selected 'nothing to report', thank you for your selection.");
                        break;
                    case "F":
                        Console.WriteLine(@"You have selected 'firewall issue', thank you for your selection.");
                        break;
                    case "M":
                        Console.WriteLine(@"You have selected 'malware detection', thank you for your selection.");
                        break;
                    case "AL":
                        Console.WriteLine(@"You have selected 'account lockout', thank you for your selection.");
                        break;
                    default:
                        Console.WriteLine($"You have entered {userInput} - RAISING THE ALARM!");
                        break;
                }
                    userInput = Console.ReadLine().ToUpper();
            }
            Console.WriteLine();
        }
    }
}
