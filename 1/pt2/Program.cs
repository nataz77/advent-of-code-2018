using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Simone\Desktop\adventofcode\1\input.txt");
            int res = 0;
            List<int> fqChanges = new List<int>();
            List<int> dupl = new List<int>();
            foreach (var item in lines.Select(int.Parse))
            {
                WriteLine($"Current frequency: {res}, change of: {item}, resulting frequency {res += item}");
                WriteLine($"Checking for previous frequency hits...");
                if (!fqChanges.Any(x => x == res))
                {
                    WriteLine("Did not find any previous frequency hits");
                    fqChanges.Add(res);
                }
                else
                {
                    dupl.Add(res);
                    WriteLine($"Found: {res}");
                }
            }
        }
    }
}
