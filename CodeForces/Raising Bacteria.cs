using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            int n = 0;
            while (tests > 0)
            {
                n += tests & 1;
                tests >>= 1;
            }
            Console.WriteLine(n);
            //000000000001001
            //000000000000001
            //000000000000000
        }


    }
}
