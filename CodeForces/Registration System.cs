using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            Dictionary<string, int> map = new Dictionary<string, int>();

            while (times-- > 0)
            {
                string name = Console.ReadLine();
                if (!map.ContainsKey(name))
                {
                    map.Add(name, 0);
                    Console.WriteLine("OK");
                }
                else
                {
                    map[name]++;
                    Console.WriteLine($"{name}{map[name]}");
                    map.Add($"{name}{map[name]}", 0);
                }

            }
        }
    }
}