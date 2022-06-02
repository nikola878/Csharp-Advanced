using System;
using System.Linq;

namespace Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (matrixSize[0], matrixSize[1]);

            char[,] matrix = new char[rows, cols];

            MatrixReading(matrix, rows, cols);

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col] 
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void MatrixReading(char[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
