using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;

namespace Sheet1
{
    class Program
    {
        static bool Valid(long median, List<long> arr, long k)
        {
            long r = BinarySearch(arr, median);
            long sum = 0;
            for (int i = arr.Count / 2; i <= r; ++i)
                sum += median - arr[i];

            return sum <= k;
        }
        static long BinarySearch(List<long> arr, long target)
        {
            long l = -1, r = arr.Count;
            while (l + 1 < r)
            {
                long m = (l + r) / 2;
                if (arr[(int)m] < target) l = m;
                else r = m;
            }

            return l;
        }

        static void Main(string[] args)
        {

            long[] line1 = Console.ReadLine().Trim().Split(" ").Select(x => Convert.ToInt64(x)).ToArray();
            long n = line1[0], k = line1[1];
            List<long> line2 = Console.ReadLine().Trim().Split(" ").Select(x => Convert.ToInt64(x)).ToList();
            line2.Sort();
            long l = -1, r = (long)1e10;
            while (l + 1 < r)
            {
                long m = (l + r) / 2;
                if (Valid(m, line2, k)) l = m;
                else r = m;
            }

            Console.WriteLine(l);
        }

    }
}





