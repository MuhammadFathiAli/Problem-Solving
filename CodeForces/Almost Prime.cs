using System;

class Solution
{
    static bool[] GetPrimeSieve(int n)
    {
        bool[] isPrime = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            isPrime[i] = true;
        }

        isPrime[0] = isPrime[1] = false;

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        return isPrime;
    }

    static int CountAlmostPrimes(int n)
    {
        bool[] isPrime = GetPrimeSieve(n);
        int count = 0;

        for (int i = 2; i <= n; i++)
        {
            int primeFactors = 0;

            for (int j = 2; j <= i; j++)
            {
                if (isPrime[j] && i % j == 0)
                {
                    primeFactors++;
                }
            }

            if (primeFactors == 2)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = CountAlmostPrimes(n);
        Console.WriteLine(count);
    }
}
