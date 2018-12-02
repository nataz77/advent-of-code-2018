using System;
using Xunit;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( +3, +3, +4, -2, -4 )]
        public void ShoudFindTen(params int[] testData)
        {
            int res = 0;
            List<int> fqChanges = new List<int>();
            List<int> dupl = new List<int>(){};
            foreach (var item in testData)
            {
                WriteLine($"Current frequency: {res}, change of: {item}, resulting frequency {res += item}");
                WriteLine($"Checking for previous frequency hits...");
                if (fqChanges.Any(x => x == res))
                {
                    dupl.Add(res);
                    WriteLine($"Found: {res}");
                    Assert.Equal(10, res);
                }
                else { WriteLine("Did not find any previous frequency hits"); fqChanges.Add(res); }
            }
        }
    }
}
