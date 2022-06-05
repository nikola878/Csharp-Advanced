using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = ints[0];
            int m = ints[1];
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            if (n >= m)
            {
                foreach (var item in set2)
                {
                    if (set1.Contains(item))
                    {
                        list.Add(item);
                    }
                }
            }
            else if (n < m)
            {
                foreach (var item in set1)
                {
                    if (set2.Contains(item))
                    {
                        list.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
