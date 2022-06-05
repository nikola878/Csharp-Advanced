using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string line = Console.ReadLine();
            while (line != "Revision")
            {
                string[] strings = line.Split(", ");
                string shop = strings[0];
                string product = strings[1];
                double price = double.Parse(strings[2]);
                AddProduct(shops, shop, product, price);

                line = Console.ReadLine();
            }
            PrintPrices(shops);
        }

        

        private static void AddProduct(Dictionary<string, Dictionary<string, double>> shops, string shop, string product, double price)
        {
            if (!shops.ContainsKey(shop))
                shops.Add(shop, new Dictionary<string, double>());
            shops[shop][product] = price;
            
        }

        private static void PrintPrices(Dictionary<string, Dictionary<string, double>> shops)
        {
            foreach (var item in shops.OrderBy(s => s.Key))
            {
                string shopName = item.Key;
                Console.WriteLine($"{shopName}->");
                var products = item.Value;
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
