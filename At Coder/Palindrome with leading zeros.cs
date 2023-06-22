using System;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quest = Console.ReadLine();
            int length = quest.Length;
            bool pand = false;
            if (length <= 1)
            {
                Console.WriteLine("Yes");
                return;
            }
            int leadingZeros = 0, laggingZeros = 0;
            for (int i = 0; i < length; i++)
            {
                if (quest[i] != '0')
                    break;
                leadingZeros++;
            }
            for (int i = length - 1; i >= 0; i--)
            {
                if (quest[i] != '0')
                    break;
                laggingZeros++;
            }
            while (laggingZeros > leadingZeros)
            {
                quest = "0" + quest;
                length++;
                laggingZeros--;
            }
            for (int i = 0; i < length / 2; i++)
            {
                if (quest[i] != quest[length - i - 1])
                {
                    pand = false;
                    break;
                }
                pand = true;
            }

            if (pand)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}