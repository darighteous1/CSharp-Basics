using System;

class BitValue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mask = 1;
        int bitValue = (n >> 3) & mask;
        Console.WriteLine(bitValue);
    }
}