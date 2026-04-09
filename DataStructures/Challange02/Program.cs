using System;
using System.Collections.Generic;
using System.Linq;

int[][] Merge(int[][] intervals)
{
    if (intervals.Length == 0) return intervals;

    // Ordenar os intervalos pelo início
    Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

    var result = new List<int[]> { intervals[0] };

    foreach (var interval in intervals.Skip(1))
    {
        var last = result[^1]; // ^1 = último elemento
        if (interval[0] <= last[1])
        {
            // Mesclar os intervalos
            last[1] = Math.Max(last[1], interval[1]);
        }
        else
        {
            result.Add(interval);
        }
    }

    return result.ToArray();
}

// Teste
int[][] intervals = new int[][] 
{ 
    new[] { 1, 3 }, 
    new[] { 2, 6 }, 
    new[] { 8, 10 }, 
    new[] { 15, 18 } 
};

var result = Merge(intervals);
foreach (var interval in result)
{
    Console.WriteLine($"[{interval[0]}, {interval[1]}]");
}