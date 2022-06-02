using System;
using System.Linq;

namespace Sum_Matrix_Columns
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

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

        }

        private static void MatrixReading(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
