using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
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
            int s = ints[1];
            int x = ints[2];

            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(list[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
