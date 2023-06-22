using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int low = line[0];
            int high = line[1];
            var lowDivisors = GetDivisors(low);
            var highDivisors = GetDivisors(high);
            HashSet<int> result = new HashSet<int>();
            int t = int.Parse(Console.ReadLine());
            foreach (var num in lowDivisors)
                if (highDivisors.Contains(num))
                    result.Add(num);
            var list = result.ToList();
            list.Sort();
            while (t-- > 0)
            {
                var innerLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int a = innerLine[0];
                int b = innerLine[1];
                int ans = -1;
                foreach (var num in list)
                    if (a <= num && num <= b)
                        ans = num;
                Console.WriteLine(ans);
            }
        }

        public static HashSet<int> GetDivisors(int num)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    result.Add(i);
                    result.Add(num / i);
                }
            }
            return result;
        }
    }
}