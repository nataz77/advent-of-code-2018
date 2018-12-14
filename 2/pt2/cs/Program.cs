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
            var ids = ReadAllLines("input.txt");
            //init time
            HashSet<string> notmatching = new HashSet<string>();
            string mispelled1 = string.Empty;
            string mispelled2 = string.Empty;
            int i = 0;
            //iterate each id 
            foreach (var item in ids)
            {
                var charArr = item.ToCharArray();
                //need to add at least the first element
                if (i == 0) notmatching.Add(item);
                foreach (var not in notmatching.ToList())
                {
                    var missingChar = 0;
                    //need some optimization
                    for (int c = 0; c < item.Length; c++)
                    {
                        if (charArr[c] != not[c]) missingChar++;
                    }
                    if (missingChar == 1)
                    {
                        mispelled1 = item;
                        mispelled2 = not;
                    }
                    else notmatching.Add(item);
                }
                i++;
            }
            WriteLine($"Original word is {mispelled1} misspelled in {mispelled2}");
        }
    }
}
