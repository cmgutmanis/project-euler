using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1:");
            Console.WriteLine(Problem1());
        }
        

        /// <summary>
        /// https://projecteuler.net/problem=1
        /// finds sum of all multiples of 3 or 5 up to 1000
        /// </summary>
        /// <returns></returns>
        private static int Problem1()
        {
            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
