using System;

class MagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int difference = int.Parse(Console.ReadLine());
        int count = 0;
        
        for (int firstNum = 111; firstNum <= (777 - 2*difference); firstNum++)
        {
            int secondNum = firstNum + difference;
            int thirdNum = secondNum + difference;
            if (isValidNumber(firstNum) && isValidNumber(secondNum) && isValidNumber(thirdNum)
                && CalculateSumOfDigits(firstNum) + CalculateSumOfDigits(secondNum) + CalculateSumOfDigits(thirdNum) == sum) 
            {
                Console.WriteLine("{0}{1}{2}", firstNum, secondNum, thirdNum);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    static bool isValidNumber(int partOfNumber)
    {
        string digits = partOfNumber.ToString();
        foreach (var digit in digits)
        {
            if ((digit == '0' || digit == '8' || digit == '9'))
            {
                return false;
            }
        }
        return true;
    }

    static int CalculateSumOfDigits(int sumOfDigits)
    {
        int sum = 0;
        while (sumOfDigits > 0)
        {
            sum += sumOfDigits % 10;
            sumOfDigits = sumOfDigits / 10;
        }
        return sum;
    }
}