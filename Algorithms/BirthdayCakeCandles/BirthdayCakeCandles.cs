using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        
        int max = height.Max();
        Console.WriteLine($"{height.Where(x => x == max).Count()}");
    }
}
