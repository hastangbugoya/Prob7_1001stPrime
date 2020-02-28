using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

Problem #7 :  10001st prime
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number? 

 */
namespace Prob7_1001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primectr = 0;
            long i = 2;
            long j = 0;
            double s;
            while (primectr < 10001)
            {
                j = 2;
                s = Math.Sqrt(i);
                if (i % 2 != 0)
                    while ((i % j != 0) && j < s)
                        j++;
                if (j > s)
                {
                    primectr++;
                    //Console.WriteLine(primectr + " " + i);
                }
                i++;
            }
            Console.WriteLine("Hello World!  " + (i - 1));
            Console.ReadKey();
         }
    }
}
