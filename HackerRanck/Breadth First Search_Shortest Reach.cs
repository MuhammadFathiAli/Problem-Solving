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

    public static List<int> bfs(int nodesNo, int edgesNo, List<List<int>> edges, int startingNode)
    {
        Dictionary<int, List<int>> Dictedges = SetEdges(nodesNo, edgesNo, edges);
        int[] bfs = new int[nodesNo + 1];
        for (int i = 1; i < bfs.Length; i++)
            bfs[i] = -1;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(startingNode);
        bfs[startingNode] = 0;
        int currentNode;
        while (queue.Count > 0)
        {
            currentNode = queue.Dequeue();
            foreach (var item in Dictedges[currentNode])
            {
                if (bfs[item] == -1)
                {
                    bfs[item] = bfs[currentNode] + 6;
                    queue.Enqueue(item);
                }
            }
        }
        var result = new int[nodesNo - 1];
        int resultIndex = 0;
        for (int i = 1; i <= nodesNo; i++)
        {
            if (i != startingNode)
            {
                result[resultIndex++] = bfs[i];
            }
        }

        return result.ToList();
    }

    private static Dictionary<int, List<int>> SetEdges(int nodesNo, int edgesNo, List<List<int>> edges)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        for (int i = 1; i <= nodesNo; i++)
        {
            map[i] = new List<int>();
        }
        foreach (var item in edges)
        {
            map[item[0]].Add(item[1]);
            map[item[1]].Add(item[0]);
        }
        return map;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> edges = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                edges.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(edgesTemp => Convert.ToInt32(edgesTemp)).ToList());
            }

            int s = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> result = Result.bfs(n, m, edges, s);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

