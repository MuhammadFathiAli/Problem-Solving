using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            qwertyuiop
            //            asdfghjkl;
            //            zxcvbnm,./
            char dir = char.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            Dictionary<char, List<char>> keybd = new Dictionary<char, List<char>>();
            keybd.Add('q', new List<char> { 'w', ' ' });
            keybd.Add('w', new List<char> { 'e', 'q' });
            keybd.Add('e', new List<char> { 'r', 'w' });
            keybd.Add('r', new List<char> { 't', 'e' });
            keybd.Add('t', new List<char> { 'y', 'r' });
            keybd.Add('y', new List<char> { 'u', 't' });
            keybd.Add('u', new List<char> { 'i', 'y' });
            keybd.Add('i', new List<char> { 'o', 'u' });
            keybd.Add('o', new List<char> { 'p', 'i' });
            keybd.Add('p', new List<char> { ' ', 'o' });
            keybd.Add('a', new List<char> { 's', ' ' });
            keybd.Add('s', new List<char> { 'd', 'a' });
            keybd.Add('d', new List<char> { 'f', 's' });
            keybd.Add('f', new List<char> { 'g', 'd' });
            keybd.Add('g', new List<char> { 'h', 'f' });
            keybd.Add('h', new List<char> { 'j', 'g' });
            keybd.Add('j', new List<char> { 'k', 'h' });
            keybd.Add('k', new List<char> { 'l', 'j' });
            keybd.Add('l', new List<char> { ';', 'k' });
            keybd.Add(';', new List<char> { ' ', 'l' });
            keybd.Add('z', new List<char> { 'x', ' ' });
            keybd.Add('x', new List<char> { 'c', 'z' });
            keybd.Add('c', new List<char> { 'v', 'x' });
            keybd.Add('v', new List<char> { 'b', 'c' });
            keybd.Add('b', new List<char> { 'n', 'v' });
            keybd.Add('n', new List<char> { 'm', 'b' });
            keybd.Add('m', new List<char> { ',', 'n' });
            keybd.Add(',', new List<char> { '.', 'm' });
            keybd.Add('.', new List<char> { '/', ',' });
            keybd.Add('/', new List<char> { ' ', '.' });

            for (int i = 0; i < word.Length; i++)
            {
                if (dir == 'R')
                {
                    Console.Write(keybd[word[i]][1]);
                }
                else
                {
                    Console.Write(keybd[word[i]][0]);

                }
            }

        }
    }
}
