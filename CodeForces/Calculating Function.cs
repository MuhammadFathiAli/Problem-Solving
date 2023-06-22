using System;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n / 2);
            else
                Console.WriteLine((n + 1) / -2);
        }
    }
}