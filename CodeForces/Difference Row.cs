using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(" ");
            List<int> pos = new();
            for (int i = 0; i < count; i++)
            {
                pos.Add(int.Parse(nums[i]));
            }
            pos.Sort((x, y) => x.CompareTo(y));
            int temp = pos[0];
            pos[0] = pos[count - 1];
            pos[count - 1] = temp;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{pos[i]} ");
            }
        }
    }
}


