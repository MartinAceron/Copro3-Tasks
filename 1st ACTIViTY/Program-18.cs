using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;

            Console.Write("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\n");
            Console.Write("The Sum is : {0}", sum);
            Console.ReadKey();
        }
    }
}
    
