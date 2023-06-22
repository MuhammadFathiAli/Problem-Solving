using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Resul
{
    public static void plusMinus(List<int> arr)
    {
        int length = arr.Count;
        float positives = 0;
        float zeros = 0;
        float negatives = 0;
        for (int i = 0; i < length; i++)
        {
            if (arr[i] > 0)
                positives++;
            else if (arr[i] < 0)
                negatives++;
            else
                zeros++;
        }
        Console.WriteLine(positives / length);
        Console.WriteLine(negatives / length);
        Console.WriteLine(zeros / length);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
