using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string colors = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < length-1; i++)
            {
                char current = colors[i];
                char next = colors[i+1];
                if (current == next)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}

CodeForces-266A
 Stones on the Table - 266A