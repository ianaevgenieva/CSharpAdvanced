using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int index1 = 1;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix1[col, row] = index1;
                index1++;
            }
        }
        int leftColumn = 0;
        int upperRow = 0;
        int bottomRow = n - 1;
        int count = 1;
        int index2 = 1;
        do
        {
            for (int i = upperRow; i <= bottomRow; i++)
            {
                matrix2[i, leftColumn] = index2;
                count++;
                index2++;
            }
            leftColumn++;
            for (int i = bottomRow; i >= upperRow; i--)
            {
                matrix2[i, leftColumn] = index2;
                count++;
                index2++;
            }
            leftColumn++;
            ;
            for (int i = upperRow; i <= bottomRow; i++)
            {
                matrix2[i, leftColumn] = index2;
                count++;
                index2++;
            }
            leftColumn++;
            for (int i = bottomRow; i >= upperRow; i--)
            {
                matrix2[i, leftColumn] = index2;
                count++;
                index2++;
            }
            leftColumn++;
            ;
        } while (count <= n*n);  
        PrintMatrix(matrix1);
        PrintMatrix(matrix2);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}