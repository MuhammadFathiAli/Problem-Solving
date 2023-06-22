using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(inputs[i]);
                    continue;
                }
                if (stack.Peek() == inputs[i])
                    stack.Pop();
                else
                    stack.Push(inputs[i]);
            }
            if (stack.Count == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}