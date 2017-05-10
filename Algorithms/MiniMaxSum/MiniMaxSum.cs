using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{

    static void Main(String[] args) 
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,Int64.Parse);

        Console.WriteLine($"{arr.Sum() - arr.Max()} {arr.Sum() - arr.Min()}");
    }
}
