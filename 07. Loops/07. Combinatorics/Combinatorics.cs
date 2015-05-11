using System;
using System.Numerics;

class Combinatorics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger topResult = 1;

        for (int i = (k + 1); i <= n; i++)
        {
            topResult *= i;
        }
        BigInteger bottomResult = 1;
        for (int j = 1; j <= (n-k); j++)
        {
            bottomResult *= j;
        }
        BigInteger finalResult = topResult / bottomResult;
        Console.WriteLine(finalResult);
    }
}