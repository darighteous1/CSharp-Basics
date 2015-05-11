using System;

class Sieve
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            num = num & ~sieve;
        }

        int count = 0;
        for (int bitCount = 63; bitCount >= 0; bitCount--)
        {
            ulong currentBit = (num >> bitCount) & 1;
            if (currentBit == 1)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}