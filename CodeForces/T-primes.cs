class Solution
{

    static void Main(String[] args)
    {
        var notPrimes = SeiveNoPrimes(10000000);

        int n = Convert.ToInt32(Console.ReadLine());

        List<long> lst = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToList();

        bool result;
        foreach (var item in lst)
        {
            result = false;
            if (HasSqrt(item, out long sqr))
            {
                result = notPrimes[sqr] == false;
            }
            Console.WriteLine(result ? "YES" : "NO");
        }
    }

    private static bool HasSqrt(long n, out long sqrt)
    {
        double sqr = Math.Sqrt(n);
        long sqrFloor = (long)Math.Floor(sqr);
        if (sqr == sqrFloor)
        {
            sqrt = sqrFloor;
            return true;
        }
        sqrt = -1;
        return false;
    }
    public static bool[] SeiveNoPrimes(int n)
    {
        bool[] notPrimes = new bool[n];

        if (n < 2) return notPrimes;

        notPrimes[0] = true;
        notPrimes[1] = true;

        for (int i = 2; i < (n / i) + 1; ++i)
            if (notPrimes[i] == false)
                for (int j = 2; i * j < n; ++j)
                    notPrimes[i * j] = true;

        return notPrimes;
    }
}
