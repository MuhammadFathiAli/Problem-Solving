using System;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quest = Console.ReadLine();
            string questToPrint = string.Empty;
            int ones = 0, two = 0, three = 0;
            for (int i = 0; i < quest.Length; i += 2)
            {
                if (quest[i] == '1')
                    ones++;
                else if (quest[i] == '2')
                    two++;
                else
                    three++;
            }
            while (ones > 0)
            {
                questToPrint += "+1";
                ones--;
            }
            while (two > 0)
            {
                questToPrint += "+2";
                two--;
            }
            while (three > 0)
            {
                questToPrint += "+3";
                three--;
            }
            Console.WriteLine(questToPrint.Remove(0, 1));

        }
    }
}