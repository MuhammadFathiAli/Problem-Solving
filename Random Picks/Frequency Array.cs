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
            int n = 0;
            List<int> inpts = new List<int>();
            HashSet<int> set = new HashSet<int>();
            bool isFalse = false;
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine().Trim());
                isFalse = false;
                inpts = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                set.Clear();
                for (int j = 0; j < inpts.Count; j++)
                {
                    if (set.Contains(inpts[j]))
                    {
                        isFalse = true;
                        break;
                    }
                    set.Add(inpts[j]);
                }
                if (isFalse)
                {
                    Console.WriteLine("ne krasivo");
                }
                else
                {
                    Console.WriteLine("prekrasnyy"); ;
                }
            }
        }
    }

}