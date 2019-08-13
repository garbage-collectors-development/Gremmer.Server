using System;
using System.IO;

namespace Server.Core
{
    class JuliansMatrix
    {

        public int[,] Subtract(int[,] firstArray, int[,] secondArray)
        {
            int rowsCount = firstArray.GetLength(0);
            int columnsCount = firstArray.GetLength(1);

            int[,] subtractedArray = new int[rowsCount,columnsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                for (int column = 0; column < columnsCount; column++)
                {
                    subtractedArray[row, column] = firstArray[row, column] - secondArray[row, column];
                }
            }

            return subtractedArray;
        }

    }

    class Matrix
    {
        const int MATRIX_ROW = 2, MATRIX_COLUMN = 3;
        static int[,] firstMatrix = {
            {5, 6,3},
            {7, 8,3}
        };
        static int[,] secondMatrix = {
            {1, 2,3},
            {3, 4,3}
        };
        int[,] subMatrix = new int[MATRIX_ROW, MATRIX_COLUMN];

        public static void Main(string[] args)
        {
            var julian = new JuliansMatrix();
            int[,] arr = julian.Subtract(firstMatrix, secondMatrix);
            Console.WriteLine();
        }

    }
}
