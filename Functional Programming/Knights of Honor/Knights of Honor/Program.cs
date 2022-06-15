using System;

namespace Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                Action<string> namess = name => Console.WriteLine("Sir " + name);
                namess(names[i]);
            }
        }
    }
}
