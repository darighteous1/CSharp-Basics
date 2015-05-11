using System;
using System.Collections.Generic;
using System.Linq;

class LongestWord
{
    static void Main()
    {
        char[] chars = new char[] { ' ', '.', ',', ';', '!', '?', '"', '\'' };
        string[] input = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>(input.ToList());

        int length = 0;
        string longestWord = null;
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Length > length)
            {
                longestWord = input[i];
                length = longestWord.Length;
            }
        }
        Console.WriteLine(longestWord);
    }
}