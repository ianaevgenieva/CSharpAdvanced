using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> names = new List<string>(input.Split(new char[] { ' ' }));
        string inputSecond = Console.ReadLine();
        List<string> equalsNames = new List<string>(inputSecond.Split(new char[] { ' ' }));
        for (int i = 0; i < equalsNames.Count; i++)
        {
            for (int j = 0; j < names.Count; j++)
            {
                if (equalsNames[i] == names[j])
                {
                    names.Remove(names[j]);
                }
            }
        }
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }
    }
}
