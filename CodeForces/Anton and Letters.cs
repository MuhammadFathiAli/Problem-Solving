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
            string set = Console.ReadLine();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 1; i < set.Length - 1; i += 3)
            {
                if (!keyValuePairs.ContainsKey(set[i]))
                    keyValuePairs.Add(set[i], i);
            }
            Console.WriteLine(keyValuePairs.Count);
        }
    }
}