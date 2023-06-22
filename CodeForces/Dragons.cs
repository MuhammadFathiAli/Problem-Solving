using System;
using System.Collections.Generic;
using System.Linq;
namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ");
            int strength = int.Parse(input1[0]);
            int count = int.Parse(input1[1]);
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            PriorityQueue<Dictionary<int, int>, int> n = new();


            while (count-- > 0)
            {
                string[] input2 = Console.ReadLine().Split(" ");
                //map.Add(int.Parse(input2[0]), int.Parse(input2[1]));
                Dictionary<int, int> x = new Dictionary<int, int>();
                x.Add(int.Parse(input2[0]), int.Parse(input2[1]));
                n.Enqueue(x, int.Parse(input2[0]));
            }
            //List<int> keys = map.Keys.();
            //List<int> values = map.Values.ToList();

            while (n.Count > 0)
            {
                var x = n.Dequeue();

                if (strength > x.Keys.First())
                {
                    strength += x[x.Keys.First()];
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");


        }
    }
}


