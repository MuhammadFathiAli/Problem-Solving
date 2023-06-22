using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        if (m % n != 0)
        {
            Console.WriteLine(-1);
            return;
        }

        int count = 0;
        int factor = m / n;
        while (factor % 2 == 0)
        {
            factor /= 2;
            count++;
        }
        while (factor % 3 == 0)
        {
            factor /= 3;
            count++;
        }

        if (factor != 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(count);
        }
    }
}
