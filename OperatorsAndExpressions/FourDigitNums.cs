using System;

class FourDigitNums
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int firstDigit = num / 1000 % 10;
        int secondDigit = num / 100 % 10;
        int thirdDigit = num / 10 % 10;
        int fourthDigit = num % 10;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}