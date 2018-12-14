using System;
using static System.IO.File;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace cs
{
    //part 1
    class Program
    {
        static void Main(string[] args)
        {
            var ids = ReadAllLines("../../input.txt");
            int twice = 0, thrice = 0;
            foreach (var id in ids)
            {
                var duplicateCount = Evaluate(id.ToCharArray());
                if (duplicateCount.containsTwice) twice++;
                if (duplicateCount.containsThrice) thrice++;
            }
            Console.WriteLine($"Checksum is {twice * thrice}");
        }

        static EvaluatedModel Evaluate(char[] str)
        {
            var uniqueCount = new Dictionary<char, int>();
            foreach (var c in str)
            {
                var count = Array.FindAll(str, x => x == c).Count();
                if (!uniqueCount.Any(x => x.Key == c))
                    uniqueCount.Add(c, count);
            }
            var res = new EvaluatedModel();
            res.containsTwice = uniqueCount.Any(x => x.Value == 2);
            res.containsThrice = uniqueCount.Any(x => x.Value == 3);
            return res;
        }
    }

    class EvaluatedModel
    {
        public bool containsTwice { get; set; }
        public bool containsThrice { get; set; }
    }
}
