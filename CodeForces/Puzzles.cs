using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ");
            int students = int.Parse(input1[0]);
            int puzzles = int.Parse(input1[1]);
            string[] nums = Console.ReadLine().Split(" ");
            List<int> result = new List<int>();
            for (int i = 0; i < puzzles; i++)
            {
                result.Add(int.Parse(nums[i]));
            }
            result.Sort();

            int min = 1000;
            for (int i = 0; i <= puzzles - students; i++)
            {
                int y = (result[i + students - 1] - result[i]);

                if (y < min)
                {
                    min = y;
                }
            }
            Console.WriteLine(min);
        }
    }
}


