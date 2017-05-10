using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        string s = Console.ReadLine();
        int i = 0;
        
        while (i < s.Length-1)
        {
            if (s[i] == s[i+1])
            {
                string s0 = i-1 >= 0 ? s.Substring(0, i) : "";
                string s1 = i+2 < s.Length ? s.Substring(i+2, (s.Length - i - 2)) : "";
                s = s0 + s1;
                i = 0;
            }
            else
                i++;
        }
        s = String.IsNullOrEmpty(s)? "Empty String" : s;
        Console.WriteLine($"{s}");
    }
}
