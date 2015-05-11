using System;

class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        ulong mask = (1 << 3) - 1;
        for (int i = 61; i >= 0; i--)
        {
            bool zeroCheck = ((num >> i) & mask) == 0;
            bool oneCheck = ((num >> i) & mask) == 7;
            if (zeroCheck | oneCheck)
            {
                num = num ^ (mask << i);
                i -= 2;
            }
        }
        Console.WriteLine(num);
    }
}