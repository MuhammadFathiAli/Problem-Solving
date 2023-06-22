using System;
using System.Collections.Generic;

namespace problem_solving
{
    internal class Program
    {

        static List<char> text = new List<char>();
        static Stack<string> stack = new Stack<string>();
        static string toUndo = string.Empty;
        static operation state = operation.append;
        static void Main(string[] args)
        {
            int NoOfTestCases = int.Parse(Console.ReadLine());

            while (NoOfTestCases-- > 0)
            {
                string? input = Console.ReadLine();
                string[] inputs = input?.Split(' ');
                operation ins = (operation)Enum.Parse(typeof(operation), inputs[0] ?? "1");
                string val = string.Empty;
                if (ins != operation.undo)
                    val = inputs[1] ?? " ";
                switch (ins)
                {
                    case operation.append:
                        {
                            stack.Push(input);
                            append(val);
                            break;
                        }
                    case operation.delete:
                        {
                            string toRoll = delete(int.Parse(val));
                            stack.Push(inputs[0] + " " + toRoll);
                            break;
                        }
                    case operation.print:
                        {
                            print(int.Parse(val));
                            break;
                        }
                    case operation.undo:
                        {
                            undo();
                            break;
                        }
                }
            }

        }
        static void append(string w)
        {
            //stack.Push(w);
            //toUndo= string.Empty;
            //toUndo= w;
            text.AddRange(w);
            //state = operation.append;
        }
        static string delete(int k)
        {
            toUndo = string.Empty;
            for (int i = text.Count - k; i < text.Count; i++)
                toUndo += text[i];
            text.RemoveRange(text.Count - k, k);
            return toUndo;
            //state = operation.delete;
        }
        static void print(int k) => Console.WriteLine(text[k - 1]);
        static void undo()
        {
            string instoUndo = stack.Pop();
            string[] x = instoUndo.Split(' ');
            toUndo = x[1];
            state = (operation)Enum.Parse(typeof(operation), x[0]);
            switch (state)
            {
                case operation.append:
                    {
                        delete(toUndo.Length);
                        break;
                    }
                case operation.delete:
                    {
                        append(toUndo);
                        break;
                    }
            }
        }
    }
    internal enum operation
    {
        append = 1,
        delete = 2,
        print = 3,
        undo = 4
    }
}

/*
 * need a list of strings
 * append is adding a string in this list
 * delete deletes srting from the list from last elememnt to the no of chars
 * print console the char by index
 * undo the append and delete: 
 * create a stack for orders 
    *   when append ins, insert append in stack 
    *   when delete insert it in stack 
   * when undo if last was append then undo
 */