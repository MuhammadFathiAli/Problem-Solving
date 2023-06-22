using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            List<int> sizes = new List<int>();
            for (int i = 0; i < len; i++)
            {
                int size = int.Parse(Console.ReadLine());
                sizes.Add(size);
            }
            sizes.Sort();
            int count = 0;
            int start = (len / 2) - 1, end = len - 1;
            while (start <= end && start >= 0 && end > (len / 2) - 1)
            {
                int target = sizes[start] * 2;
                if (sizes[end] >= target)
                {
                    count++;
                    start--;
                    end--;
                }
                else
                    start--;
            }
            Console.WriteLine(len - count);

        }
    }
}