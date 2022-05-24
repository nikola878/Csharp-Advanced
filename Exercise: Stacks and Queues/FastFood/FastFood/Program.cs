using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            List<int> listOrders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Queue<int> queueOrders = new Queue<int>(listOrders);

            Console.WriteLine(queueOrders.Max());

            int count = queueOrders.Count;

            for (int order = 1 ; order <= count; order++)
            {
                if (foodQuantity >= queueOrders.Peek())
                {
                    foodQuantity -= queueOrders.Peek();
                    queueOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queueOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOrders)}");
            }
        }
    }
}
