using System;

class CountWord
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        char[] chars = { ' ', '.', ',', ';', '!', '?', ':', '(', ')', '+', '/', '\\', '"', '@' };
        string input = Console.ReadLine();
        int count = 0;

        while (input != string.Empty)
        {
            string[] words = input.ToLower().Split(chars, StringSplitOptions.RemoveEmptyEntries);

            foreach (string entry in words)
            {
                if (entry == word)
                {
                    count++;
                }
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(count);
    }
}