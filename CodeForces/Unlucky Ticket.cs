using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        string a = new string(s.Take(n).OrderBy(c => c).ToArray());
        string b = new string(s.Skip(n).OrderBy(c => c).ToArray());

        if (String.Compare(a, b) > 0)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        bool canSplit = true;

        for (int i = 0; i < n; i++)
        {
            if (a[i] >= b[i])
            {
                canSplit = false;
                break;
            }
        }

        Console.WriteLine(canSplit ? "YES" : "NO");
    }
}
