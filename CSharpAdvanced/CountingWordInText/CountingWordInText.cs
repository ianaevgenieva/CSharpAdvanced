using System;
using System.Collections.Generic;

class CountingWordInText
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        List<string> input = new List<string>(text.Split(new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' }, StringSplitOptions.None));
        int count = 0;
        for (int i = 0; i < input.Count; i++)
        {
            if (string.Equals(input[i], word, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
    