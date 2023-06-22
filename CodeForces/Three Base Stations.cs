using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt32(Console.ReadLine());
            var x = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x) * 2).ToList();
            x.Sort();

            long l = 0;
            long h = 2 * 1_000_000_000;
            long mid;

            while (l < h)
            {
                mid = (l + h) / 2;
                if (IsValidAnswer(mid, x))
                    h = mid;
                else
                    l = mid + 1;
            }

            double d = 1.0 * l / 2;
            Console.WriteLine(d);

            double lastCovered = -1;
            List<double> result = new();
            for (int i = 0; i < x.Count; ++i)
            {
                if (x[i] / 2 > lastCovered)
                {
                    lastCovered = (x[i] / 2.0) + d + d;
                    result.Add(lastCovered - d);
                }
            }
            for (int i = result.Count; i < 3; ++i)
            {
                result.Add(result[i - 1]);
            }
            Console.WriteLine(string.Join(' ', result.Select(d => $"{d:F6}")));

        }

        private static bool IsValidAnswer(long distance, List<int> x)
        {
            int count = 0;
            long lastCovered = -1;
            for (int i = 0; i < x.Count; ++i)
            {
                if (x[i] > lastCovered)
                {
                    lastCovered = x[i] + distance + distance;
                    ++count;
                }
            }
            return count <= 3;
        }

    }
}
