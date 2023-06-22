using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NoOfTestCases = int.Parse(Console.ReadLine());
            while (NoOfTestCases > 0)
            {
                int length = int.Parse(Console.ReadLine());
                string[] strNums = Console.ReadLine().Split(' ');
                int[] nums = new int[strNums.Length];
                for (int i = 0; i < strNums.Length; i++)
                    nums[i] = int.Parse(strNums[i]);

                int differ = int.MaxValue;
                Array.Sort(nums);
                for (int i = 0; i < length - 1; i++)
                {
                    if (Math.Abs(nums[i] - nums[i + 1]) < differ)
                    {
                        differ = Math.Abs(nums[i] - nums[i + 1]);
                    }
                }

                NoOfTestCases--;
                Console.WriteLine(differ);
            }

        }
    }
}