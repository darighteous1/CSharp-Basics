using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int xbitsFound = 0;
        int mask = (1 << 3) - 1;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 29; j++)
            {
                if (((numbers[i] >> j) & mask) == 5) //5 in binary is 101
                {
                    if (((numbers[i+1] >> j) & mask) == 2 && ((numbers[i+2] >> j) & mask) == 5) //2 in binary is 010
                    {
                        xbitsFound++;
                    }
                }
            }
        }
        Console.WriteLine(xbitsFound);
    }
}