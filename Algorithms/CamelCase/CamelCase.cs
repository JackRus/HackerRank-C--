using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
        string s = Console.ReadLine();
        int w = s.Where(x => x >= 65 && x <= 90).Count();
        Console.WriteLine($"{w+1}");
    }
}
