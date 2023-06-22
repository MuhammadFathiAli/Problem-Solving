using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            while (count-- > 0)
            {
                int counter = 0;
                int length = int.Parse(Console.ReadLine());
                string[] strings = Console.ReadLine().Split(" ");
                List<int> ints = new List<int>();
                for (int i = 0; i < length; i++)
                    ints.Add(int.Parse(strings[i]));
                for (int i = 0; i < ints.Count - 1; i++)
                {
                    if (2 * ints[i] < ints[i + 1])
                    {
                        ints.Insert(i + 1, ints[i] * 2);
                        counter++;
                    }
                    else if (ints[i] > 2 * ints[i + 1])
                    {
                        if (ints[i] % 2 > 0)
                            ints.Insert(i + 1, (ints[i] / 2) + 1);
                        else
                            ints.Insert(i + 1, ints[i] / 2);
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}   