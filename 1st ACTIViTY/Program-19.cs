using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            int j, n, sum = 0;
            Double avg;

            Console.Write("\n\n");
            Console.Write("Read 10 numbers and calculate sum and average:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 10 numbers : \n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("Number-{0} :", j);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
            Console.ReadKey();
        }
    }
}

    

