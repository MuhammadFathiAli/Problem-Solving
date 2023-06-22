using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                long gCD = 1;
                for (long i = x; i > 0; i--)
                    if (i * 2 <= x)
                    {
                        gCD = i;
                        break;
                    }

                Console.WriteLine(gCD);
            }
        }
        static int GCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            return GCD(y, x % y);
        }
    }
}
