using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
                {
                case "math":
                    Console.WriteLine(favSubject);
                    Console.WriteLine("ah, algebra and geometry. Nice!");
                    Console.ReadLine();
                    break;

                case "science":
                    Console.WriteLine(favSubject);
                    Console.WriteLine("Chemistry and Physics. My favorite!");
                    Console.ReadLine();
                    break;

                case "history":
                    Console.WriteLine(favSubject);
                    Console.WriteLine("Kings and Conquerers. Good choice.");
                    Console.ReadLine();

                    break;

                case "english":
                    Console.WriteLine(favSubject);
                    Console.WriteLine("I too like the written word. Fascinating!");
                    Console.ReadLine();
                    break;

                case "gym":
                    Console.WriteLine(favSubject);
                    Console.WriteLine("One of those active people huh? Weird seeing you in coding classes.");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine(favSubject);
                    Console.WriteLine("Never thought about that...");
                    Console.ReadLine();
                    break;

                
            }

        }
    }
}
