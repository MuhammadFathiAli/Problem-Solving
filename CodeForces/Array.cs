using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] strinputs = Console.ReadLine().Split(' ');
            List<int> inputs = new();
            int negCount = 0;
            int count2 = 0;
            for (int i = 0; i < length; i++)
            {
                if (int.Parse(strinputs[i]) < 0)
                    negCount++;
                inputs.Add(int.Parse(strinputs[i]));
            }
            List<int> less = new(), more = new(), zero = new();
            for (int i = 0; i < length; i++)
            {
                if (inputs[i] < 0)
                {
                    if (less.Count == 0)
                        less.Add(inputs[i]);
                    else if (negCount % 2 > 0 || (negCount % 2 == 0 && negCount > 3 && count2 < 2))
                    {
                        count2++;
                        more.Add(inputs[i]);
                    }
                    else
                        zero.Add(inputs[i]);
                }
                else if (inputs[i] > 0)
                    more.Add(inputs[i]);
                else
                    zero.Add(inputs[i]);
            }
            Console.Write(less.Count + " ");
            for (int i = 0; i < less.Count; i++)
            {
                Console.Write(less[i] + " ");
            }
            Console.WriteLine();
            Console.Write(more.Count + " ");
            for (int i = 0; i < more.Count; i++)
            {
                Console.Write(more[i] + " ");
            }
            Console.WriteLine();
            Console.Write(zero.Count + " ");
            for (int i = 0; i < zero.Count; i++)
            {
                Console.Write(zero[i] + " ");
            }
        }
    }
}