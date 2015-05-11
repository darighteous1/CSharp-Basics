using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        List<string> first = new List<string>(Console.ReadLine().Split());
        List<string> second = new List<string>(Console.ReadLine().Split());

        first.AddRange(second);
        List<string> result = first.Distinct().ToList();
        result.Sort();

        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}