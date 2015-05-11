using System;

class ExtractURL
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        char[] chars = { '.', ',', ';', '!', '?', ':' };
        Console.WriteLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].StartsWith("http") || input[i].StartsWith("www"))
            {
                for (int j = 0; j < chars.Length; j++)
                {
                        input[i] = input[i].Trim(chars[j]);
                }    
                Console.WriteLine(input[i]);
            }
        }
    }
}