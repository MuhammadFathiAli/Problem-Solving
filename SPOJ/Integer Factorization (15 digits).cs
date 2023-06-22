using System;

namespace PrimeFactorization
{
    class Program
    {
        static void Sieve(ulong n)
        {
            ulong count = 0;
            while (n % 2 == 0)
            {
                count++;
                n = n >> 1;
            }
            if (count > 0)
            {
                Console.Write("2^" + count + " ");
            }
            for (ulong i = 3; i * i <= n; i = i + 2)
            {
                count = 0;
                while (n % i == 0)
                {
                    count++;
                    n = n / i;
                }
                if (count > 0)
                {
                    Console.Write(i + "^" + count + " ");
                }
            }
            if (n > 2)
            {
                Console.Write(n + "^1");
            }
        }

        static void Main(string[] args)
        {
            ulong n;
            while (ulong.TryParse(Console.ReadLine(), out n) && n != 0)
            {
                Sieve(n);
                Console.WriteLine();
            }
        }
    }
}
