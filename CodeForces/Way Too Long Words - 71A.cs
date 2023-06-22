using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                if (word.Length > 10)
                {
                    Console.WriteLine(string.Concat(word[0], word.Length - 2, word[word.Length - 1]));
                }
                else
                    Console.WriteLine(word);
            }
        }
    }
}