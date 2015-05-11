using System;


class FibonacciNumbers
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }

    private static uint Fibonacci(ulong n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        uint a = 1;
        uint b = 1;
        uint c = 0;

        for (uint i = 2; i <= n; i++)
        {
            c = b + a;
            a = b;
            b = c;
        }
        return c;
    }
}