using System;
using System.Collections.Generic;
using System.Linq;

namespace Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                
                names.Add(name);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
