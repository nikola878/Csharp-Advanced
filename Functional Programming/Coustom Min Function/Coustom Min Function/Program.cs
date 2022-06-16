using System;
using System.Linq;

namespace Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[], int> func = numbers => numbers.Min();
            Console.WriteLine(func(nums));
        }
    }
}
