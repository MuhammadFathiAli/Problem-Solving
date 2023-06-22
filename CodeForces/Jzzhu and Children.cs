using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int length = int.Parse(inputs[0]);
            int giftCount = int.Parse(inputs[1]);
            string[] students = Console.ReadLine().Split(' ');
            int index =0;
            Queue<int> queue = new Queue<int>(length);
            Queue<int> queue1 = new Queue<int>(length);
            for (int i = 0; i < students.Length; i++)
            {
                int x = int.Parse(students[i]);
                queue.Enqueue(x);
                queue1.Enqueue(i+1);
            }
            while(queue.Count > 0)
            {
                int student = queue.Dequeue();
                index = queue1.Dequeue();
                if (student - giftCount > 0)
                {
                    queue.Enqueue(student - giftCount);
                    queue1.Enqueue(index);
                }
            }
            Console.WriteLine(index);
        }
    }
}  