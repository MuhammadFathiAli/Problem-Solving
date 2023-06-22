using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trails = int.Parse(Console.ReadLine());
            while (trails > 0)
            {

                string[] strelements = Console.ReadLine().Split(' ');
                string[] elements01 = Console.ReadLine().Split(' ');
                int n = int.Parse(strelements[0]);
                int d = int.Parse(strelements[1]);

                List<int> elements = new List<int>();
                bool res = false;
                for (int i = 0; i < elements01.Length; i++)
                {
                    elements.Add(int.Parse(elements01[i]));
                }
                elements.Sort();
                if (elements[elements.Count - 1] > d)
                {
                    if ((elements[0] + elements[1]) <= d)
                        res = true;
                }
                else
                {
                    res = true;
                }
                if (res == true)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                trails--;
            }
        }
    }
}