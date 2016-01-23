using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)

        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("I ");
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("am sexy and i know it");

            Console.ForegroundColor = oldColor;
        }

    }
}
