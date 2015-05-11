using System;
using System.Collections.Generic;

class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', '\t', '\n');
        List<int> pairSums = new List<int>();



        for (int i = 0; i < input.Length; i += 2)
        {
            int sum = int.Parse(input[i]) + int.Parse(input[i + 1]);
            pairSums.Add(sum);
        }

        if (pairSums.Capacity == 1)
        {
            Console.WriteLine("Yes, value={0}", pairSums[0]);
            return;
        }

        int checkSum = pairSums[0];
        bool allSumsAreEqual = true;

        foreach (var sum in pairSums)
        {
            if (sum != checkSum)
            {
                allSumsAreEqual = false;
                break;
            }
        }

        if (allSumsAreEqual == false)
        {
            int maxDiff = 0;
            int counter = input.Length / 2 - 1; // with 6 integers as input, pairSums.Capacity shows 3, but counter=pairSums.Capacity sets the value to 4 ?!?
            for (int index = 0; index <= counter; index++)
            {
                if (index == (counter))
                {
                    break;
                }
                int diff = Math.Abs(pairSums[index] - pairSums[index + 1]);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
        else
        {
            Console.WriteLine("Yes, value={0}", checkSum);
        }
    }
}