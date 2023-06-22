using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slot = Console.ReadLine();
            char x = slot[0];
            for (int i = 0; i < slot.Length; i++)
            {
                if (slot[i] != x)
                {
                    Console.WriteLine("Lost");
                    return;
                }
            }
            Console.WriteLine("Won");

        }
    }
}


