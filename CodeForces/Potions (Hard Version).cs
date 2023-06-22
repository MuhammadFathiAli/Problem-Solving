using System;
using System.Collections.Generic;
using System.Linq;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            List<int> nums = new List<int>();
            //List<int> sortednums = new List<int>();
            PriorityQueue<int, int> queue = new();
            int sum = 0;
            int Count = 0;
            //int min = 0;
            //int lessmin = 0;
            for (int i = 0; i < length; i++)
            {
                nums.Add(int.Parse(str[i]));
            }
            //sortednums.Sort((x, y) => x.CompareTo(y));
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                //Count++;
                //if (nums[i] < lessmin)
                //{
                //    if  (nums[i] < min)
                //    {
                //        lessmin = min;
                //        min = nums[i];
                //    }
                //    else
                //        lessmin = nums[i];
                //}
                //sortednums.Add(nums[i]);
                queue.Enqueue(nums[i], nums[i]);
                if (sum < 0)
                {
                    int toRemove = queue.Dequeue();
                    sum -= toRemove;
                    //min = lessmin;
                    nums[nums.IndexOf(toRemove)] = 0;
                    //sortednums.RemoveAt(0);
                    //Count--;
                }
            }
            Console.WriteLine(queue.Count);
        }
    }
}
