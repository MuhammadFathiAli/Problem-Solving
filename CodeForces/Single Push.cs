using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            while (count-- > 0)
            {
                int length = int.Parse(Console.ReadLine());
                string[] arr1 = Console.ReadLine().Split(" ");
                string[] arr2 = Console.ReadLine().Split(" ");
                List<int> ints1 = new List<int>();
                List<int> ints2 = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    ints1.Add(int.Parse(arr1[i]));
                    ints2.Add(int.Parse(arr2[i]));
                }
                int diff = 0;
                int counter = 0;
                int index = 0;

                bool success = true;
                for (int i = 0; i < length; i++)
                {
                    if (ints1[i] > ints2[i])
                    {
                        success = false;
                        break;
                    }
                    else if (ints1[i] < ints2[i])
                    {
                        if (counter < 1)
                        {
                            diff = ints2[i] - ints1[i];
                            counter++;
                            index = i;
                        }
                        else if ((counter >= 1 && (ints2[i] - ints1[i]) != diff) || i != ++index)
                        {
                            success = false;
                            break;
                        }
                    }

                }
                if (success)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}