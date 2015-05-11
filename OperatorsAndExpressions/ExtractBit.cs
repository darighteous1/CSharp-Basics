using System;

class BitValue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        int bitValue = (n >> p) & mask;
        Console.WriteLine(bitValue);
    }
}