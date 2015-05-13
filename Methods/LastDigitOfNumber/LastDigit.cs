using System;

class LastDigit
{
    static string[] number = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};

    static void PrintNumber(int num)
    {
        int lastDigit = num % 10;
        Console.WriteLine(number[lastDigit]);
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        PrintNumber(a);
    }
}
