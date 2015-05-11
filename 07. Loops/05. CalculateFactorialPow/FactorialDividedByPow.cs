using System;
using System.Numerics;

class FactorialDividedByPow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());


        double result = 0;
        for (int i = 1; i <= n; i++)
        {
            double factorial = Factorial(i);
            double power = Math.Pow(x, i);
            result += factorial/power;
        }
        result += 1;
        Console.WriteLine("{0:F5}", result);
    }

    private static double Factorial(int n)
    {
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
