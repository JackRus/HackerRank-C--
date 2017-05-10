using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        DateTime dt = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"{dt.ToString("HH:mm:ss")}");
    }
}
