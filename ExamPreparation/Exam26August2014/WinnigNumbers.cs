using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int letSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            letSum += (input[i] - 'a' + 1);
        }
        bool foundNumbers = false;
        for (int i = 111; i <= 999; i++)
        {
            if (ProductOfDigits(i) == letSum)
            {
                int leftPart = i;
                for (int j = 111; j <= 999; j++)
                {
                    if (ProductOfDigits(j) == letSum)
                    {
                        foundNumbers = true;
                        int rightPart = j;
                        Console.WriteLine("{0}-{1}", leftPart, rightPart);
                    }
                }
            }
        }
        if (foundNumbers == false)
        {
            Console.WriteLine("No");
        }
    }

    static int ProductOfDigits(int number)
    {
        int product = 1;
        while (number > 0)
        {
            product *= (number % 10);
            number /= 10;
        }
        return product;
    }
}