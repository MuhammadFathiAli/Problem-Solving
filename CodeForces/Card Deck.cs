using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            while (counts-- > 0)
            {
                int length = int.Parse(Console.ReadLine());
                string[] strinputs = Console.ReadLine().Split(' ');
                List<int> inputs = new();
                List<int> newStack = new();
                for (int i = 0; i < length; i++)
                {
                    inputs.Add(int.Parse(strinputs[i]));
                }
                while (inputs.Count > 0)
                {
                    int max = inputs.Max();
                    int maxindex = inputs.IndexOf(max);
                    newStack.AddRange(inputs.GetRange(maxindex, inputs.Count - maxindex));
                    inputs.RemoveRange(maxindex, inputs.Count - maxindex);
                }
                for (int i = 0; i < newStack.Count; i++)
                {
                    Console.Write(newStack[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}