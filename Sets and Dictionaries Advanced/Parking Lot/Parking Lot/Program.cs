using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> numbers = new HashSet<string>();
            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string cmd = tokens[0];
                string carNumber = tokens[1];

                if (cmd == "IN")
                {
                    numbers.Add(carNumber);
                }
                else if (cmd == "OUT")
                {
                    numbers.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
