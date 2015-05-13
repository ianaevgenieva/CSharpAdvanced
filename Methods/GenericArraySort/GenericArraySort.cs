using System;
using System.Collections.Generic;

    class GenericArraySort
    {      
        static void SortArray<T>(List<T> list) where T : IComparable
        {
            for (double a = 0; a < list.Count - 1; a++)
            {
                double minValue = a;
                for (double b = a + 1; b < list.Count; b++)
                {
                    if (list[minValue].CompareTo(list[b])>0)
                    {
                        minValue = b;
                    }
                }
                T temp = list[a];
                list[a] = list[minValue];
                list[minValue] = temp;
            }
            foreach (var l in list)
            {
                Console.Write(l+" ");
            }
        }
        static void Main()
        {
            List<int> number = new List<int> { 3, 2, 16, 24, 5, 1, 27, 80, 9 };
            List<string> words = new List<string> { "am", "em", "omo", "zaz", "cba", "baa" };
            List<DateTime> dates = new List<DateTime> { new DateTime(2012, 02, 01),
                                                        new DateTime(2015, 05, 06), new DateTime(1875, 03, 03) };
 
            SortArray(number);
            Console.WriteLine();
            SortArray(words);
            Console.WriteLine();
            SortArray(dates);
            Console.WriteLine();
        }
    }
}