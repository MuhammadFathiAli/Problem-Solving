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
            while (tests-- > 0)
            {
                long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                Console.WriteLine(arr[1] ^ arr[0]);
            }
        }


    }
}
