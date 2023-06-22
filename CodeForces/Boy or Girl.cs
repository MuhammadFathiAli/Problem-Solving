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
            string name = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var item in name)
            {
                chars.TryAdd(item, 1);
            }
            if (chars.Count % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");
        }
    }
}