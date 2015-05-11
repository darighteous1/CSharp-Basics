using System;
using System.Collections.Generic;
using System.Linq;

class Count
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<string> names = new List<string>(input);
        //names.RemoveAll(entry => entry == ' ');
        names.Sort();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var name in names)
        {
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, 1);
            }
            else
            {
                dict[name]++;
            }
        }

        foreach (var entry in dict)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
        }
    }
}