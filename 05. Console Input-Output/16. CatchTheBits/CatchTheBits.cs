using System;
using System.Collections.Generic;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        
        int count = 0;
        List<string> result = new List<string>();
        string stringResult = "";
        int stringCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((step == 1 && count > 0) || (count % step == 1)) //count > 0 because in this case we start at position 1 (bit 6) otherwise we get
                {                                                    // wrong result if step is 1
                    string currentBit = Convert.ToString((num >> bit) & 1);
                    stringResult += currentBit;
                    stringCount++;
                    
                    if (stringCount % 8 == 0)
                    {
                        result.Add(stringResult);
                        stringCount = 0;
                        stringResult = "";
                    }
                }
                count++;
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
