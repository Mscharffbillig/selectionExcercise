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

            Console.WriteLine(favNum);
            Console.ReadLine();
        }
    }
}
