using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m < n)
                Console.WriteLine("No")
            else
                Console.WriteLine("Yes")

        }
    }
}
