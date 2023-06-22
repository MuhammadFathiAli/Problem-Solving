using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(CountUnreadable(s, 0));
        }
        static string CountUnreadable(string s, int index)
        {
            if (index >= s.Length)
            {
                return "Yes";
            }

            if (index % 2 == 1 && Char.IsUpper(s[index]))
            {
                return CountUnreadable(s, index + 1);
            }
            if ((index % 2 == 0 || index == 0) && char.IsLower(s[index]))
            {
                return CountUnreadable(s, index + 1);
            }

            return "No";
        }
    }
}
