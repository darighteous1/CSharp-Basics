﻿using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <=2*n; i++)
        {
            if (i % 2 != 0)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
            else
            {
                evenSum += int.Parse(Console.ReadLine());
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            int diff = Math.Abs(evenSum-oddSum);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}