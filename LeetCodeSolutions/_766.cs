﻿namespace LeetCodeSolutions
{
    public class _766
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[0].Length - 1; j++)
                {
                    if (matrix[i][j] != matrix[i + 1][j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}