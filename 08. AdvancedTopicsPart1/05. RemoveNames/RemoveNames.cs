using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> first = new List<string>(Console.ReadLine().Split());
        List<string> second = new List<string>(Console.ReadLine().Split());

        for (int i = 0; i < first.Count; i++)
        {
            for (int j = 0; j < second.Count; j++)
            {
                if (second[j] == first[i])
                {
                    first.RemoveAll(entry => entry == second[j]);
                }
            }
        }

        foreach (var name in first)
        {
            Console.Write("{0} ", name);
        }
        
        Console.WriteLine();
    }
}