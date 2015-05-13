using System;
using System.Globalization;
         
class DifferenceBetweenDates
{
    static void Main()
    {
        IFormatProvider culture = new CultureInfo("bg-BG", true);
        Console.WriteLine("Insert first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine(), culture,
        DateTimeStyles.NoCurrentDateDefault);
        Console.WriteLine("Insert second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine(), culture,
        DateTimeStyles.NoCurrentDateDefault);
        TimeSpan span = secondDate - firstDate;
        Console.WriteLine("There're {0} days between {1:d} and {2:d} ",
        span.TotalDays, firstDate, secondDate);
    }
}