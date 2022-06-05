using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ');
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                Add(cities, continent, country, city);
            }

            Print(cities);
        }

        static void Add(Dictionary<string, Dictionary<string, List<string>>> cities, string continent, string country, string city)
        {
            if (!cities.ContainsKey(continent))
                cities.Add(continent, new Dictionary<string, List<string>>());

            Dictionary<string, List<string>> countries = cities[continent];
            if (!countries.ContainsKey(country))
                countries.Add(country, new List<string>());
            countries[country].Add(city);
        }

        static void Print(Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            foreach (string continent in cities.Keys)
            {
                Console.WriteLine(continent + ":");
                foreach (var country in cities[continent].Keys)
                {
                    Console.Write("  " + country + " -> ");
                    List<string> allCities = cities[continent][country];
                    Console.WriteLine(string.Join(", ", allCities));
                }
            }
        }
    }
}
