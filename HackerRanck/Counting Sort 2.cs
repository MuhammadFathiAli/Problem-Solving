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

	/*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

	public static List<int> countingSort(List<int> list)
	{
		List<int> sortedList = new();
		List<int> freqArray = CountingSortFrequencyArray(list);

		for (int i = 0; i < freqArray.Count; i++)
		{
			while (freqArray[i] > 0)
			{
				sortedList.Add(i);
				freqArray[i]--;
			}
		}
		return sortedList;
	}

	static List<int> CountingSortFrequencyArray(List<int> list)
	{
		List<int> frqArray = new int[100].ToList();
		for (int i = 0; i < list.Count; i++)
		{
			frqArray[list[i]]++;
		}
		return frqArray;
	}

}

class Solution
{
	public static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine().Trim());

		List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

		List<int> result = Result.countingSort(arr);

		textWriter.WriteLine(String.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}
