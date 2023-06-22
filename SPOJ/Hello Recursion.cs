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
            for (int i = 1; i <= tests; i++)
            {
                long[] ints = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
                long x = Sum(ints, ints[0]);
                Console.WriteLine($"Case {i}: {x}");
            }
        }
        static long Sum(long[] nums, long i)
        {
            if (i == 1)
                return nums[1];
            else
                return nums[i] + Sum(nums, i - 1);
        }
    }
}
