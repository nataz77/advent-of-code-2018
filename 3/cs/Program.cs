using System;
using static System.IO.File;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadAllLines("../test.txt");
            var ClaimsList = new List<ClaimModel>();
            foreach (var item in input)
            {
                var claim = new ClaimModel(item);
                claim.PrintProperties();
                ClaimsList.Add(claim);
            }
        }
    }
}
