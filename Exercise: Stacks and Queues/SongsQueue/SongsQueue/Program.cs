using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Queue<string> queueOfSongs = new Queue<string>(listOfSongs);
            string cmd = Console.ReadLine();
            while (queueOfSongs.Count != 0)
            {
                if (cmd == "Play")
                {
                    queueOfSongs.Dequeue();
                }
                else if (cmd.Contains("Add"))
                {
                    string song = cmd.Substring(4);
                    if (queueOfSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queueOfSongs.Enqueue(song);
                    }
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueOfSongs));
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
