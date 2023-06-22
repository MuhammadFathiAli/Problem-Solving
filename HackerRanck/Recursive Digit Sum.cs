using System;

class Solution
{
    static int superDigit(string n, int k)
    {
        if (n.Length == 1)
        {
            return int.Parse(n);
        }

        long sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            sum += int.Parse(n[i].ToString());
        }
        sum *= k;

        return superDigit(sum.ToString(), 1);
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');
        string n = nk[0];
        int k = int.Parse(nk[1]);

        int result = superDigit(n, k);
        Console.WriteLine(result);
    }
}
