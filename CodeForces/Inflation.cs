using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long[] arr;
            long n, K;

            while (t-- > 0)
            {
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                n = arr[0]; K = arr[1];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

                Console.WriteLine(Solve(arr, n, K));
            }

            long Solve(long[] arr, long n, decimal k)
            {
                var before = new long[n];
                var after = new long[n];
                var error = new long[n];

                before[0] = arr[0];
                after[0] = arr[0];
                long sum = 0;
                for (int i = 1; i < n; i++)
                {
                    before[i] = (long)Math.Ceiling(arr[i] * 100 / k);
                    after[i] = Math.Max(after[i - 1], before[i]) + arr[i];
                    error[i] = before[i] - after[i - 1];

                    if (error[i] > 0)
                        sum += error[i];
                }

                return sum;
            }


        }


    }
}