using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int numbersFound = 0;
        for (int i = 555; i <= 999; i++)
        {
            int firstNum = i;
            if (IsValid(firstNum))
            {
                int secondNum = firstNum + diff;
                int thirdNum = secondNum + diff;
                int currentSum = SumOfDigits(firstNum) + SumOfDigits(secondNum) + SumOfDigits(thirdNum);

                if (IsValid(secondNum) && IsValid(thirdNum) && currentSum == sum)
                {
                    numbersFound++;
                    Console.WriteLine("{0}{1}{2}", firstNum, secondNum, thirdNum);
                }
            }
        }
        if (numbersFound == 0)
        {
            Console.WriteLine("No");
        }
    }
    static bool IsValid(int num)
    {
        while (num > 0)
        {
            int digit = num % 10;
            if (digit == 0 || digit == 1 || digit == 2 || digit == 3 || digit == 4)
            {
                return false;
            }
            num /= 10;
        }
        return true;
    }
    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (num % 10);
            num /= 10;
        }
        return sum;
    }
}