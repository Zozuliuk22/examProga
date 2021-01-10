using System;

namespace MyMatrix
{
    public class Matrix
    {
        public static void CreateMatrix(ref int n, ref int m, out double[,] matrix, ref int max, ref int min)
        {
            Random rand = new Random();
            matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Math.Round((rand.NextDouble() * (max - min) + min), 6);
                }
            }
        }

        public static void PrintMatrix(ref double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(String.Format("{0, 10} ", String.Format("{0:0.000}", matrix[i, j])));
                Console.WriteLine("\n");
            }
        }

        public static void DeleteRow(ref double[,] matrix, int row)
        {
            double[,] matrix0 = new double[matrix.GetLength(0) - 1, matrix.GetLength(1)];

            for (int i = 0, i2 = 0; i2 < matrix.GetLength(0); i++, i2++)
            {
                if (i != row)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix0[i, j] = matrix[i2, j];
                    }
                }
                else
                {
                    i -= 1;
                }
            }
            matrix = matrix0;
        }

        public static void DeleteCol(ref double[,] matrix, int col)
        {
            double[,] matrix0 = new double[matrix.GetLength(0), matrix.GetLength(1) - 1];

            for (int j = 0, j2 = 0; j2 < matrix.GetLength(1); j++, j2++)
            {
                if (j != col)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix0[i, j] = matrix[i, j2];
                    }
                }
                else
                {
                    j -= 1;
                }
            }
            matrix = matrix0;
        }        
    }
}
