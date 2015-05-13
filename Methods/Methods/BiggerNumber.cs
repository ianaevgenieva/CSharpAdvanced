using System;

namespace Methods
{
    class BiggerNumber
    {
        static int GetMax(int a, int b)
        {
            int c = Math.Max(a, b);
            return c;
        }
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int max = GetMax(first, second);
            Console.WriteLine(max);
        }
    }
}
