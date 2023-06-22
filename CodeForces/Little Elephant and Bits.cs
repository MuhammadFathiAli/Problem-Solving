using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == '0')
                {
                    Console.WriteLine(input1.Substring(0, i) + input1.Substring(i + 1));
                    return;
                }
            }
            Console.WriteLine(input1.Substring(1));
        }
    }
}


