using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (matrixSize[0], matrixSize[1]);

            int[,] matrix = new int[rows, cols];

            MatrixReading(matrix, rows, cols);

            long maxSum = long.MinValue;
            string bestMatrix = "";

            for (int row = 0; row < rows -1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    long sum =
                        matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestMatrix = matrix[row, col] + " " + matrix[row, col + 1] + "\r\n" +
                        matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(bestMatrix);
            Console.WriteLine(maxSum);
        }

        private static void MatrixReading(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
