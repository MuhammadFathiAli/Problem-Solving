using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dicesNum = int.Parse(Console.ReadLine());
            int topface = int.Parse(Console.ReadLine());
            int topfaceAdj = 7 - topface;
            bool res = true;
            for (int i = 0; i < dicesNum; i++)
            {
                string[] strfaces = Console.ReadLine().Split(' ');
                int rightface = int.Parse(strfaces[0]);
                int leftface = int.Parse(strfaces[1]);
                if (rightface == topface || rightface == topfaceAdj || leftface == topface || leftface == topfaceAdj)
                    res = false;
            }
            if (res)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}