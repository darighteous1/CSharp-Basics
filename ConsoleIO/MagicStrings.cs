using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int difference = int.Parse(Console.ReadLine());
        int count = 0;
        List<string> numbers = new List<string>();
        
        for (int firstPart = 1111; firstPart <= 5555; firstPart++)
        {
            if (isValidNumber(firstPart))
            {
                for (int secondPart = 1111; secondPart <= 5555; secondPart++)
                {
                    int diff = Math.Abs(CalculateSumOfDigits(firstPart) - CalculateSumOfDigits(secondPart));
                    if (isValidNumber(secondPart) && diff == difference)
                    {
                        string output = Convert.ToString(firstPart) + Convert.ToString(secondPart);
                        output = output.Replace('1', 'k').Replace('3', 's').Replace('4', 'n').Replace('5', 'p');
                        numbers.Add(output);
                        count++;
                    }
                }
                
            }
        }
        
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
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
            if (digit != '1' && digit != '3' && digit != '4' && digit != '5')
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