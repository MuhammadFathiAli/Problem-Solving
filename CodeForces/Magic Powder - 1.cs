using System;
using System.Collections.Generic;
using System.Linq;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            string[] line3 = Console.ReadLine().Split(' ');
            int len = int.Parse(line1[0]);
            int magicPowder = int.Parse(line1[1]);
            List<int> needed_Ingredients = new List<int>();
            List<int> owned_Ingredients = new List<int>();
            List<int> numberOfCookiesPerIngred = new List<int>();
            int Count = 0;
            for (int i = 0; i < len; i++)
            {
                needed_Ingredients.Add(int.Parse(line2[i]));
                owned_Ingredients.Add(int.Parse(line3[i]));
                numberOfCookiesPerIngred.Add(int.Parse(line3[i]) / int.Parse(line2[i]));
            }
            while (true)
            {
                for (int i = 0; i < len; i++)
                {
                    if (owned_Ingredients[i] >= needed_Ingredients[i])
                    {
                        owned_Ingredients[i] -= needed_Ingredients[i];
                    }
                    else
                    {
                        magicPowder -= (needed_Ingredients[i] - owned_Ingredients[i]);
                        owned_Ingredients[i] = 0;
                    }
                }
                if (magicPowder >= 0)
                    Count++;
                else
                    break;
            }
            Console.WriteLine(Count);
        }
    }
}