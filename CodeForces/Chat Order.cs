using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                if (!map.ContainsKey(name))
                {
                    map.Add(name, i);
                }
                else
                {
                    map[name] = i;
                }
            }
            var myList = map.ToList();

            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            foreach (var item in myList)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}