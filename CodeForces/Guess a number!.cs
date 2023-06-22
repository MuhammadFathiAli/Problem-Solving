using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trails = int.Parse(Console.ReadLine());
            int SuccessCounter = 0;
            long start = -2000000000, end = 2000000000, y = 0;
            long mid = 0;
            List<List<string>> input1 = new();
            for (int i = 0; i < trails; i++)
            {
                List<string> input11 = Console.ReadLine().Split(" ").ToList();
                input1.Add(input11);
            }
            for (int i = 0; i < trails; i++)
            {
                string oper = input1[i][0];
                long x = long.Parse(input1[i][1]);
                string res = input1[i][2];

                while (start <= end)
                {
                    mid = (end + start) / 2;
                    bool[] test = TrailSuccessGoUp(mid, x, oper, res);
                    bool isSuccess = test[0], isGoUp = test[1];
                    if (i == 0)
                    {
                        SuccessCounter = 0;
                        //break;
                    }
                    if (isSuccess)
                    {
                        SuccessCounter++;
                        //if (i == -1)
                        //{
                        //    i = 0;
                        //    //SuccessCounter = 0;
                        //}
                        break;
                    }
                    else if (isGoUp)
                    {
                        start = mid + 1;
                        i = -1;
                        SuccessCounter = 0;
                    }
                    else
                    {
                        end = mid - 1;
                        i = -1;
                        SuccessCounter = 0;
                    }
                }
            }

            bool[] TrailSuccessGoUp(long mid, long x, string oper, string res)
            {
                bool[] resbool = new bool[2];
                if (oper == ">")
                {
                    if ((mid > x && res == "Y") || (mid <= x && res == "N"))
                        return new bool[] { true, false };
                    else if (res == "Y")
                        return new bool[] { false, true };
                    else
                        return new bool[] { false, false };
                }
                else if (oper == ">=")
                {
                    if ((mid >= x && res == "Y") || (mid < x && res == "N"))
                        return new bool[] { true, false };
                    else if (res == "Y")
                        return new bool[] { false, true };
                    else
                        return new bool[] { false, false };
                }
                else if (oper == "<")
                {
                    if ((mid < x && res == "Y") || (mid >= x && res == "N"))
                        return new bool[] { true, false };
                    else if (res == "Y")
                        return new bool[] { false, false };
                    else
                        return new bool[] { false, true };
                }
                else if (oper == "<=")
                {
                    if ((mid <= x && res == "Y") || (mid > x && res == "N"))
                        return new bool[] { true, false };
                    else if (res == "Y")
                        return new bool[] { false, false };
                    else
                        return new bool[] { false, true };
                }
                return new bool[] { false, false };
            }
            if (SuccessCounter == trails)
                Console.WriteLine(mid);
            else
                Console.WriteLine("Impossible");
        }
    }
}