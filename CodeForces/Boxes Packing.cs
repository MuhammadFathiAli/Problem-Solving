using System;
using System.Collections.Generic;
using System.Linq;

namespace ps02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<int> boxes = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < boxes.Count; i++)
            {
                if (!map.TryAdd(boxes[i], 1))
                    map[boxes[i]]++;
            }
            Console.WriteLine(map.Values.Max());
        }
    }
}
