using System;

class Solution
{
    static int GetNthPrime(int n)
    {
        int limit = 105000;
        bool[] primes = new bool[limit];

        for (int i = 0; i < limit; i++)
        {
            primes[i] = true;
        }

        for (int p = 2; p * p < limit; p++)
        {
            if (primes[p])
            {
                for (int i = p * p; i < limit; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        int count = 0;
        for (int i = 2; i < limit; i++)
        {
            if (primes[i])
            {
                count++;
                if (count == n)
                {
                    return i;
                }
            }
        }

        return -1; // If the nth prime is not found within the limit
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int nthPrime = GetNthPrime(n);
            Console.WriteLine(nthPrime);
        }
    }
}
