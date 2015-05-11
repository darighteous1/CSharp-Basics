using System;
using System.Collections.Generic;
using System.Linq;

class EqualElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }
        foreach (var word in words)
        {
            if (!dict.ContainsKey(word))
            {
                dict.Add(word, 1);
            }
            else
            {
                dict[word]++;
            }
        }
    
        int count = dict.Values.Max();
        string output = null;
        
        Console.WriteLine();

        foreach (var key in dict)
        {
            if (key.Value == count)
            {
                output = key.Key;
                break;
            }
            
        }
        
        Console.WriteLine(count);
        
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(output);
        }
    }
}