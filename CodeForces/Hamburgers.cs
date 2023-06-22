using System;
using System.Collections.Generic;
using System.Linq;

namespace ps
{
    internal class Program
    {
        static long bPrice = 0;
        static long sPrice = 0;
        static long cPrice = 0;
        static long bRecipe = 0;
        static long sRecipe = 0;
        static long cRecipe = 0;
        static long bKitchen = 0;
        static long sKitchen = 0;
        static long cKitchen = 0;

        static void Main(string[] args)
        {
            #region prepare
            string strrecipe = Console.ReadLine();
            string[] strkitchen = Console.ReadLine().Split(' ');
            string[] strPrices = Console.ReadLine().Split(' ');
            long r = long.Parse(Console.ReadLine());
            List<long> recipe = new List<long>() { 0, 0, 0 };
            List<long> kitchen = new List<long>();
            List<long> Prices = new List<long>();
            long B = 0, C = 0, S = 0;
            for (int i = 0; i < strrecipe.Length; i++)
            {
                if (strrecipe[i] == 'B')
                    recipe[0]++;
                else if (strrecipe[i] == 'S')
                    recipe[1]++;
                else if (strrecipe[i] == 'C')
                    recipe[2]++;
            }
            for (int i = 0; i < 3; i++)
            {
                kitchen.Add(long.Parse(strkitchen[i]));
                Prices.Add(long.Parse(strPrices[i]));
            }
            bPrice = Prices[0];
            sPrice = Prices[1];
            cPrice = Prices[2];
            bRecipe = recipe[0];
            sRecipe = recipe[1];
            cRecipe = recipe[2];
            bKitchen = kitchen[0];
            sKitchen = kitchen[1];
            cKitchen = kitchen[2];
            #endregion
            long low = 0, high = 10000000000000, mid = 0, priceofmid = 0, ans = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                priceofmid = cost(mid);
                if (priceofmid == r)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (priceofmid > r)
                    high = mid - 1;
                else
                {
                    low = mid + 1;
                    ans = mid;
                }
            }
            Console.WriteLine(ans);
        }
        static long cost(long number)
        {
            long bCost = Math.Max((number * bRecipe - bKitchen), 0);
            long cCost = Math.Max((number * cRecipe - cKitchen), 0);
            long sCost = Math.Max((number * sRecipe - sKitchen), 0);
            return bCost * bPrice + cCost * cPrice + sCost * sPrice;
        }
    }
}