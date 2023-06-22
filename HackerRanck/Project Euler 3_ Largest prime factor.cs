using System;

public class ps
{
    public static long GCD(long a, long b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }

    public static long LCM(int n)
    {
        long ans = 1;
        for (long i = 1; i <= n; i++)
        {
            ans = (ans * i) / GCD(ans, i);
        }
        return ans;
    }

    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(LCM(n));
        }
    }
}
