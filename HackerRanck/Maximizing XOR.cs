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

    public static int maximizingXor(int l, int r)
    {

        int maxXor = 0;

        for (int i = l; i <= r; i++)
        {
            for (int j = i; j <= r; j++)
            {
                int currentXor = i ^ j;
                maxXor = Math.Max(maxXor, currentXor);
            }
        }

        return maxXor;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        int r = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.maximizingXor(l, r);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
