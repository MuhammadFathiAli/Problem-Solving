using System;
using System.Collections.Generic;

class Program
{
    static ulong l, r, s;
    static SortedSet<ulong> S = new SortedSet<ulong>();

    static void f(ulong x)
    {
        S.Add(x);
        if (x < r)
        {
            f(x * 10 + 4);
            f(x * 10 + 7);
        }
    }

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        l = ulong.Parse(input[0]);
        r = ulong.Parse(input[1]);

        f(0);

        while (l <= r)
        {
            var it = S.GetViewBetween(l, ulong.MaxValue).GetEnumerator();
            if (it.MoveNext())
            {
                s += (Math.Min(r, it.Current) - l + 1) * it.Current;
                l = it.Current + 1;
            }
        }

        Console.WriteLine(s);
    }
}
