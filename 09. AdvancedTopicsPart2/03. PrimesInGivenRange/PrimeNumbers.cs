using System;
using System.Collections.Generic;
class PrimeNumbers
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        List<int> primeNumbers = FindPrimesInRange(start, end);
        
        foreach (int prime in primeNumbers)
        {
            Console.Write(prime + " ");
        }
    }

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeNumbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primeNumbers.Add(i);
            }
        }
        return primeNumbers;
    }
    
    private static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }

        }

        return true;
    }
}