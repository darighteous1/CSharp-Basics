using System;

class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        //int n = int.Parse(Console.ReadLine());
        int[] pairs = new int[input.Length / 2];
        int inputIndex = 0;
        for (int i = 0; i < pairs.Length; i++)
        {
            pairs[i] = int.Parse(input[inputIndex]) + int.Parse(input[inputIndex+1]);
            inputIndex += 2;
        }
        
        

        bool equalSums = true;
        int pairCheck = pairs[0];
        foreach (int pair in pairs)
        {
            if (pair != pairCheck)
            {
                equalSums = false;
            }
        }

        if (equalSums)
        {
            Console.WriteLine("Yes, value={0}", pairCheck);
            return;
        }
        int maxDiff = 0;
        for (int i = 0; i < pairs.Length-1; i++)
        {
            int currentDiff = Math.Abs(pairs[i] - pairs[i + 1]);
            if (currentDiff > maxDiff)
            {
                maxDiff = currentDiff;
            }
        }
        Console.WriteLine("No, maxdiff={0}", maxDiff);
    }
}