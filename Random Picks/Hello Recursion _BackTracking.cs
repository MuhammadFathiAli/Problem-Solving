using System;
using System.Collections.Generic;
using System.Linq;

namespace ps02
{
    internal class Program
    {
        static int Summation(int[] arr, int n)
        {
            if (n == 0)
                return 0;
            else
                return arr[n - 1] + Summation(arr, n - 1);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int testCase = 1; testCase <= t; testCase++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(input[i + 1]);
                }

                int sum = Summation(arr, n);
                Console.WriteLine("Case " + testCase + ": " + sum);
            }
        }

    }
}

