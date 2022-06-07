using System;
using System.Collections.Generic;

namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> digits = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!digits.ContainsKey(num))
                {
                    digits.Add(num, 1);
                }
                else
                {
                    digits[num]++;
                }
            }
            int theNum = 0;
            foreach (var num in digits)
            {
                if (num.Value % 2 == 0)
                {
                    theNum = num.Key;
                }
            }

            Console.WriteLine(theNum);
        }
    }
}
