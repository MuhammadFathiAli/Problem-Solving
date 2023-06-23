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

class Result
{
    public static List<int> quickSort(List<int> arr)
    {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> mid = new List<int>();
        int pivot = arr[0];
        for (int i = 0; i < arr.Count; i++)
        {
            if (pivot < arr[i])
                right.Add(arr[i]);
            else if (pivot > arr[i])
                left.Add(arr[i]);
            else
                mid.Add(arr[i]);
        }
        left.AddRange(mid);
        left.AddRange(right);
        return left;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.quickSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
