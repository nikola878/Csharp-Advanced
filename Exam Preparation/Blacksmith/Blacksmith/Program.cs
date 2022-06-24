using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] steel = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] carbon = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueSteel = new Queue<int>();
            for (int i = 0; i < steel.Length; i++)
            {
                queueSteel.Enqueue(steel[i]);
            }
            Stack<int> stackCarbon = new Stack<int>();
            for (int i = 0; i < carbon.Length; i++)
            {
                stackCarbon.Push(carbon[i]);
            }
            SortedDictionary<string, int> swords = new SortedDictionary<string, int>()
            {
                { "Gladius", 0 },
                { "Shamshir", 0 },
                { "Katana", 0 },
                { "Sabre", 0 },
                { "Broadsword", 0 }
            };

            int totalSwords = 0;

            while (queueSteel.Count > 0 && stackCarbon.Count > 0)
            {
                int currentSteel = queueSteel.Peek();
                int currentCarbon = stackCarbon.Peek();
                int sum = currentCarbon + currentSteel;

                if (sum == 70)
                {
                    swords["Gladius"]++;
                    totalSwords++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                }
                else if (sum == 80)
                {
                    swords["Shamshir"]++;
                    totalSwords++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                }
                else if (sum == 90)
                {
                    swords["Katana"]++;
                    totalSwords++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                }
                else if (sum == 110)
                {
                    swords["Sabre"]++;
                    totalSwords++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                }
                else if (sum == 150)
                {
                    swords["Broadsword"]++;
                    totalSwords++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                }
                else
                {
                    queueSteel.Dequeue();
                    currentCarbon += 5;
                    stackCarbon.Pop();
                    stackCarbon.Push(currentCarbon);
                }
            }

            if (totalSwords >= 1)
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }

            if (queueSteel.Count >= 1)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", queueSteel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (stackCarbon.Count >= 1)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", stackCarbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            foreach (var item in swords)
            {
                if (item.Value >= 1)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
