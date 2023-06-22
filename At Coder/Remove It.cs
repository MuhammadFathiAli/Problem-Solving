using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Skip(1).First();
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), n => int.Parse(n));
            var result = solve(arr, 0, 0, k);
            Console.WriteLine(string.Join(" ", arr.Take(result)));
        }

        static int solve(int[] arr, int i, int j, int val)
        {
            if (i >= arr.Length)
                return j;
            if (arr[i] != val)
            {
                arr[j] = arr[i];
                return solve(arr, i + 1, j + 1, val);
            }
            return solve(arr, i + 1, j, val);
        }
    }
}