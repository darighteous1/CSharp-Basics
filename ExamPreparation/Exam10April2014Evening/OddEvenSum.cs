using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 1; i <= 2*n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i%2 !=0)
            {
                oddSum += num;
            }
            else
            {
                evenSum += num;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}