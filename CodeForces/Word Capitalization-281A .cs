using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = default(string);
            if (((byte)input[0]) >= 97)
            {
                int capitalized = ((byte)input[0]) - 32;
                char x = (char)capitalized;
                output = String.Concat(x, input.Substring(1));
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}