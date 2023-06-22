using System;
using System.Collections.Generic;
using System.Linq;
namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            string[] input2 = Console.ReadLine().Split(" ");
            long sum = 0;
            for (int i = 0; i < input1; i++)
            {
                sum += Math.Abs(int.Parse(input2[i]));
            }
            Console.WriteLine(sum);
        }
    }
}


