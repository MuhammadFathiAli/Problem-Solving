using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            List<int> inpts = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> cumArr = new List<int>();
            List<int> line = new List<int>();
            cumArr.Add(inpts[0]);
            for (int i = 1; i < inpts.Count; i++)
            {
                cumArr.Add(cumArr[i - 1] + inpts[i]);
            }
            int q = int.Parse(Console.ReadLine().Trim());
            for (int i = 0; i < q; i++)
            {
                line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                if (line[0] - 1 < 0)
                {
                    Console.WriteLine(cumArr[line[1]]);
                }
                else
                {
                    Console.WriteLine(cumArr[line[1]] - cumArr[line[0] - 1]); ;

                }
            }
        }
    }

}