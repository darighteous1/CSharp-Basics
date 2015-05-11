using System;

class GCD
{
    static void Main()
    {
        int firstInput = int.Parse(Console.ReadLine());
        int secondInput = int.Parse(Console.ReadLine());

        uint a = (uint)Math.Abs(firstInput);
        uint b = (uint)Math.Abs(secondInput);

        uint result = calculateGCD(a, b);
        Console.WriteLine(result);
    }
    static uint calculateGCD(uint u, uint v)
    {
        // simple cases (termination)
        if (u == v)
            return u;

        if (u == 0)
            return v;

        if (v == 0)
            return u;

        // look for factors of 2
        if ((~u & 1) == 1) // u is even
        {
            if ((v & 1) == 1) // v is odd
                return calculateGCD(u >> 1, v);
            else // both u and v are even
                return calculateGCD(u >> 1, v >> 1) << 1;
        }

        if ((~v & 1) == 1) // u is odd, v is even
            return calculateGCD(u, v >> 1);

        // reduce larger argument
        if (u > v)
            return calculateGCD((u - v) >> 1, v);

        return calculateGCD((v - u) >> 1, u);
    }
}
