using System;
using System.Collections.Generic;
using System.Linq;

class Count
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> letters = new List<char>(input.ToList());
        letters.RemoveAll(entry => entry == ' ');
        letters.Sort();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (var letter in letters)
        {
            if (!dict.ContainsKey(letter))
            {
                dict.Add(letter, 1);
            }
            else
            {
                dict[letter]++;
            }
        }

        foreach (var entry in dict)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
        }
    }
}