using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] primeSieve = new bool[1001];
            primeSieve[0] = primeSieve[1] = true;
            for (int i = 2; i * i < primeSieve.Length; i++)
                if (!primeSieve[i])
                    for (int j = i + i; j < primeSieve.Length; j += i)
                        primeSieve[j] = true;
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> primes = primeSieve.Take(line[0] + 1).Select((x, num) => new { prime = !x, number = num }).Where(x => x.prime).Select(x => x.number).ToList();
            int count = 0;
            for (int i = 2; i < primes.Count; i++)
            {
                int j = i;
                while (j - 2 >= 0)
                {
                    if (primes[j - 1] + primes[j - 2] + 1 == primes[i])
                        count++;
                    j--;
                }
            }
            Console.WriteLine(count >= line[1] ? "YES" : "NO");
        }
    }
}
