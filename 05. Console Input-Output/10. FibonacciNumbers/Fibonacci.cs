using System;

class Fibonacci
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine()); // use ulong, because int type is overflowed at 48th member
        ulong a = 0;
        ulong b = 1;
        Console.Write("{0}, {1}, ", a, b);
        for (ulong i = 0; i < (n - 2); i++)
        {
            ulong c = a + b;
            Console.Write("{0}, ", c);
            a = b;
            b = c;
        }
    }
}