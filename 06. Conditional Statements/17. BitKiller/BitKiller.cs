using System;
using System.Collections.Generic;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string stringResult = "";
        List<string> result = new List<string>();
        int index = 0;
        int stringCount = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((index == 1) || (step == 1 && index != 0) || (index % step == 1))
                {
                    index++;
                    continue;
                }
                string currentBit = Convert.ToString((num >> bit) & 1);
                stringResult += currentBit;
                stringCount++;

                if (stringCount % 8 == 0)
                {
                    result.Add(stringResult);
                    stringCount = 0;
                    stringResult = "";
                }
                index++;
            }
        }
        foreach (var number in result)
        {
            Console.WriteLine(Convert.ToInt32(number, 2));
        }

        if (stringResult.Length % 8 == 0)
        {
            return;
        }

        stringResult = stringResult.PadRight(8, '0');

        Console.WriteLine(Convert.ToInt32(stringResult, 2));
    }
}
