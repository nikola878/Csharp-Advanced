using System;
using System.Linq;

namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            FillMatrix(matrix);
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = matrix[row, col];

                    if (row == col)
                    {
                        sum += number;
                    }
                }
            }
            Console.WriteLine(sum);
        }

        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
