using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num5;
            Console.Write("Check whether a given number is even or odd :");
            Console.Write("\nInput an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            num5 = num % 2;
            if (num5 == 0)
                Console.WriteLine("{0} is an even integer.\n", num);
            else
                Console.WriteLine("{0} is an odd integer.\n", num);
            Console.ReadKey();
        }
    }
}
    
