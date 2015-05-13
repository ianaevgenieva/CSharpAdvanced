﻿using System;

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert rows: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert columns: ");
        int width = int.Parse(Console.ReadLine());
        string[,] matrix = new string[height, width];
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] =
                "" + (char)('a' + row) + (char)('a' + col);
            }
        }
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}