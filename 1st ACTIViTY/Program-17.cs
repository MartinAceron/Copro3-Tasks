using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumber
{
    class Program
    {
        public static void Main()
        {
            int j;
            Console.Write("Display the first 10 natural numbers:\n");
            Console.WriteLine("\n"+"The first 10 natural number are:");

            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.ReadKey();
        }
    }
}
    