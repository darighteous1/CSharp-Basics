using System;
using System.Collections.Generic;
using System.Linq;

class JumpingSums
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int jumps = int.Parse(Console.ReadLine());

        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        List<int> sums = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int nextIndex = i;
            int sum = numbers[i];
            for (int j = 0; j < jumps; j++)
            {
                nextIndex = (nextIndex + numbers[nextIndex]) % numbers.Length;
             
                sum += numbers[nextIndex];
            }
            sums.Add(sum);
        }

        Console.WriteLine("max sum = {0}", sums.Max());
    }
}