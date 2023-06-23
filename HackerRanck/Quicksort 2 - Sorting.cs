using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void QuickSort(List<int> arr)
    {
        if (arr.Count < 2)
        {
            return; // array is already sorted
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int p = arr[0];
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < p)
            {
                left.Add(arr[i]);
            }
            else if (arr[i] > p)
            {
                right.Add(arr[i]);
            }
        }

        QuickSort(left);
        QuickSort(right);

        for (int i = 0; i < left.Count; i++)
        {
            arr[i] = left[i];
            Console.Write(left[i] + " ");
        }

        arr[left.Count] = p;
        Console.Write(p + " ");

        for (int i = 0; i < right.Count; i++)
        {
            arr[left.Count + i + 1] = right[i];
            Console.Write(right[i] + " ");
        }
        Console.WriteLine();
    }


    /* Tail starts here */
    static void Main(String[] args)
    {

        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        List<int> _ar = new List<int>();
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar.Add(Convert.ToInt32(split_elements[_ar_i]));
        }

        QuickSort(_ar);
    }
}