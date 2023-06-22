using System;

namespace PrimeNumbers
{
    class Program
    {
        const int N = 1000001;
        static long[] cm = new long[N];
        static bool[] prime = new bool[N];

        static void Sieve()
        {
            Array.Fill(prime, true);
            prime[0] = prime[1] = false;

            for (int i = 2; i * i < N; i++)
            {
                if (prime[i])
                {
                    for (int j = i * i; j < N; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Sieve();

            cm[0] = 0;
            for (int i = 1; i < N; i++)
            {
                cm[i] = cm[i - 1] + (prime[i] ? i : 0);
            }

            int t, n;
            t = int.Parse(Console.ReadLine());
            while (t-- != 0)
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(cm[n]);
            }
        }
    }
}
