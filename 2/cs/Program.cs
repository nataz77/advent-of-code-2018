using System;
using static System.IO.File;
using static System.Console;
using System.Linq;
namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var ids = ReadAllLines("../input.txt");
            int twice = 0, trice = 0;
            foreach (var id in ids)
            {
                var count = id.GroupBy(c => c).Where(c => c.Count() >= 2).Select(c => c.Count()).OrderBy(x => x).LastOrDefault();
                if (count == 2) twice++;
                if (count == 3) trice++;
            }
            Console.WriteLine($"Checksum is {twice * trice}");
        }
    }
}
