using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                string b = Console.ReadLine();
                string a = string.Empty;
                if (b.Length > 2)
                {
                    a += b[0];
                    for (int j = 1; j < b.Length; j++)
                    {
                        a += b[j];
                        j++;
                    }
                    Console.WriteLine(a);
                }
                else
                    Console.WriteLine(b);

            }
        }
    }
}