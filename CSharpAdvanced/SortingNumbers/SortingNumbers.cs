using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert number of sequences: ");
        int number = int.Parse(Console.ReadLine());
        List<int> sequences = new List<int>();
        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sequences.Add(num);
        }
        Console.WriteLine();
        sequences.Sort();
        foreach (var integer in sequences)
        {
            Console.WriteLine(integer);
        }
    }
}