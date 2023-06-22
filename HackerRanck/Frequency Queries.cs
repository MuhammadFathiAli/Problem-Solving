using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine().Trim());
            List<int> inpts = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < t; i++)
            {
                inpts = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                if (inpts[0] == 1)
                {
                    if (dict.ContainsKey(inpts[1]))
                    {
                        dict[inpts[1]]++;
                    }
                    else
                    {
                        dict.Add(inpts[1], 1);
                    }
                }
                else if (inpts[0] == 2)
                {
                    if (dict.ContainsKey(inpts[1]) && dict[inpts[1]] > 0)
                    {
                        dict[inpts[1]]--;
                    }
                }
                else
                {
                    if (dict.ContainsValue(inpts[1]))
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }
    }

}