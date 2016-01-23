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

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");

            Console.ForegroundColor = oldColor;
        }

    }
}
