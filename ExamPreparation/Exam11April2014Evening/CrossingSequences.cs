using System;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int firstSpiralNum = int.Parse(Console.ReadLine());
        int spiralStep = int.Parse(Console.ReadLine());
        int originalStep = spiralStep;


        List<int> tribonacciNumbers = new List<int>();
        tribonacciNumbers.Add(a);
        tribonacciNumbers.Add(b);
        tribonacciNumbers.Add(c);

        int tribonacci = a + b + c;

        while (tribonacci <= 1000000)
        {
            tribonacciNumbers.Add(tribonacci);
            a = b;
            b = c;
            c = tribonacci;
            tribonacci = a + b + c;
        }

        int spiralNumber = firstSpiralNum;
        int spiralNumberCount = 1;

        while (spiralNumber <= tribonacciNumbers[tribonacciNumbers.Count - 1])
        {
            for (int i = 0; i < tribonacciNumbers.Count; i++)
            {
                if (spiralNumber == tribonacciNumbers[i])
                {
                    Console.WriteLine(spiralNumber);
                    return;
                }
            }

            spiralNumber += spiralStep;
            spiralNumberCount++;
            if (spiralNumberCount % originalStep == 1)
            {
                spiralStep += originalStep;
            }
        }
        Console.WriteLine("No");
    }
}