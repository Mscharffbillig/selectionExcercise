using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNum = r.Next(1, 1000);
            
            Console.Write("Guess my favorite number between 1 and 1000: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess > favNum)
            {
                Console.WriteLine("Too high.");
            }
            else if (guess < favNum)
            {
                Console.WriteLine("Too low.");
            }
            else
            { 
                Console.WriteLine("Nevermind");
            }

            Console.ReadLine();
        }
    }
}
