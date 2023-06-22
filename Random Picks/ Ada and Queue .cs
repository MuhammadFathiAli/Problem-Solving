using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NoOfTestCases = int.Parse(Console.ReadLine());
            LinkedList<string> list = new LinkedList<string>();
            List<string> outputs = new List<string>();
            bool isReversed = false;
            while (NoOfTestCases-- > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string ins = inputs[0];
                string val = " ";
                if (inputs.Length > 1)
                    val = inputs[1];
                if (ins == "toFront")
                {
                    if (!isReversed)
                        list.AddFirst(val);
                    else
                        list.AddLast(val);
                }
                else if (ins == "push_back")
                {
                    if (!isReversed)
                        list.AddLast(val);
                    else
                        list.AddFirst(val);
                }
                else if (ins == "front")
                {
                    if (list.Count == 0)
                    {
                        outputs.Add("No job for Ada?");
                        //Console.WriteLine("No job for Ada?");
                    }
                    else if (!isReversed)
                    {
                        outputs.Add(list.First.Value);
                        //Console.WriteLine(list.First.Value);
                        list.RemoveFirst();
                    }
                    else
                    {
                        outputs.Add(list.Last.Value);
                        //Console.WriteLine(list.Last.Value);
                        list.RemoveLast();
                    }
                }
                else if (ins == "back")
                {
                    if (list.Count == 0)
                    {
                        outputs.Add("No job for Ada?");
                        //Console.WriteLine("No job for Ada?");
                    }
                    else if (!isReversed)
                    {
                        outputs.Add(list.Last.Value);
                        //Console.WriteLine(list.Last.Value);
                        list.RemoveLast();
                    }
                    else
                    {
                        outputs.Add(list.First.Value);
                        //Console.WriteLine(list.First.Value);
                        list.RemoveFirst();
                    }
                }
                else if (ins == "reverse" && list.Count > 0)
                {
                    isReversed = !isReversed;
                }
            }
            foreach (var item in outputs)
            {
                Console.WriteLine(item);
            }


        }
    }
}