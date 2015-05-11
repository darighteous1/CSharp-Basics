using System;
using System.Numerics;

class CalculateCatalan
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine(catalanNumber);
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}