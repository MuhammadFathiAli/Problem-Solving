using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static long MagicPowderNeeded(long numOfCakes, long[] ingofOneCake, long[] ingOwned, long magicPowder)
        {
            long totalMagicPowderNeeded = 0;


            for (int i = 0; i < ingofOneCake.Length; i++)
            {
                //if (numOfCakes * ingofOneCake[i] < ingOwned[i])
                //{
                //    return 0;
                //}
                totalMagicPowderNeeded += Math.Max((((long)numOfCakes * (long)ingofOneCake[i]) - (long)ingOwned[i]), 0);
                if (long.MaxValue - totalMagicPowderNeeded < numOfCakes)
                {
                    return long.MaxValue;
                }
            }
            return totalMagicPowderNeeded;
        }
        static void Main(string[] args)
        {
            long[] input1 = Console.ReadLine().Split(" ").Select(x => Int64.Parse(x)).ToArray();
            long[] IngredientfoOneCake = Console.ReadLine().Split(" ").Select(x => Int64.Parse(x)).ToArray();
            long[] IngredientOwned = Console.ReadLine().Split(" ").Select(x => Int64.Parse(x)).ToArray();
            long length = input1[0];
            long MagicPoweder = input1[1];
            long start = 0;
            double end = 2e9;
            long mid = (start + (long)end) / 2;
            long ans = 0;

            while (start <= end)
            {
                mid = (start + (long)end) / 2;
                long target = MagicPowderNeeded(mid, IngredientfoOneCake, IngredientOwned, MagicPoweder);
                if (target == (long)MagicPoweder)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (target > (long)MagicPoweder)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                    ans = mid;
                }
            }
            Console.WriteLine(ans);
        }

    }

}