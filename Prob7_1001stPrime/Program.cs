using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7_1001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primectr = 0;
            int lastprime;
            long i = 2;
            long j = 0;
            double s;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            while (primectr < 10001)
            {
                //if (primectr == 99)
                //    lastprime = 2;
                j = 2;
                s = Math.Sqrt(i);
                if (i % 2 != 0)
                    while ((i % j != 0) && j < s)
                        j++;
                if (j > s)
                {
                    primectr++;
                    Console.WriteLine(primectr + " " + i);
                }
                i++;
            }
            Console.WriteLine("Hello World!  " + (i - 1));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
