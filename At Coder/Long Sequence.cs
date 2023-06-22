using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            string[] strcycle = Console.ReadLine().Split(' ');
            long limit = long.Parse(Console.ReadLine());
            List<long> cycle = new List<long>();
            long sumOfCycle = 0;
            long res = 0;

            for (long i = 0; i < size; i++)
                cycle.Add(long.Parse(strcycle[i]));

            for (int i = 0; i < cycle.Count; i++)
                sumOfCycle += cycle[i];

            long numOfCycles = limit / sumOfCycle;
            long mod = limit % sumOfCycle;
            if (mod == 0)
                res = (numOfCycles * size) + 1;
            else
            {
                int counter = 0;
                for (int i = 0; i < size; i++)
                {
                    mod -= cycle[i];
                    counter++;
                    if (mod < 0)
                        break;
                }
                res = counter + (numOfCycles * size);
            }
            Console.WriteLine(res);
        }
    }
}