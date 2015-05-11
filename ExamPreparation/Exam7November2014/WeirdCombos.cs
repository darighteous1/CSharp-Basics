using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class WeirdCombos
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        int n = int.Parse(Console.ReadLine());
        List<string> combinations = new List<string>();
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            string result = "" + input[i]+ input[j]+ input[k]+ input[l]+ input[m];
                            combinations.Add(result);
                        }
                    }
                }
            }
        }
        if (n >= combinations.Count)
        {
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine(combinations[n]);
    }
}