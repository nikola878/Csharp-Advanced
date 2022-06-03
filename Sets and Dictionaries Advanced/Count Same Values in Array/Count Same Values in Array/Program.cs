using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> keyValuePairs = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (keyValuePairs.ContainsKey(num))
                {
                    keyValuePairs[num]++;
                }
                else
                {
                    keyValuePairs[num] = 1;
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
