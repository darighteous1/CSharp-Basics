using System;

class SumOfN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double currentNum = double.Parse(Console.ReadLine());
            sum += currentNum;
        }
        Console.WriteLine(sum);
    }
}