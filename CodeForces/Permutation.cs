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
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Dictionary<int, int> map = new Dictionary<int, int>();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (list[i] > length || !map.TryAdd(list[i], 1))
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
