using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> firstList = new List<string>(input.Split(new char[] { ' ' }));
        string input2 = Console.ReadLine();
        List<string> secondList = new List<string>(input2.Split(new char[] { ' ' }));
        List<int> resultList = new List<int>();
        List<int> joinList = new List<int>();
        for (int i = 0; i < firstList.Count; i++)
        {
            joinList.Add(int.Parse(firstList[i]));
        }
        for (int i = 0; i < secondList.Count; i++)
        {
            joinList.Add(int.Parse(secondList[i]));
        }
        joinList.Sort();
        resultList = joinList.Distinct().ToList();
        firstList.Sort();
        foreach (var result in resultList)
        {
            Console.Write(result + " ");
        }
    }
}
