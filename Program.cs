﻿using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            FillMatrix(n, matrix);
            int primaryDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonal += matrix[row, col];
                    }
                }
            }
            int secondaryDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (n - 1 - row == col)
                    {
                        secondaryDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(secondaryDiagonal - primaryDiagonal));
        }

        private static void FillMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }
    }
}
