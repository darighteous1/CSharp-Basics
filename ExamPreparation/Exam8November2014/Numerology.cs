using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string[] date = input[0].Split('.');
        int day = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[2]);
        string username = input[1];

        ulong calcDate = (ulong)day * (ulong)month * (ulong)year;
        if (month % 2 != 0)
        {
            calcDate *= calcDate;
        }
        int sumOfLetters = 0;

        for (int i = 0; i < username.Length; i++)
        {
            if (username[i] >= '0' && username[i] <= '9')
            {
                sumOfLetters += username[i] - 48;
            }
            else if (username[i] >= 'a' && username[i] <= 'z')
            {
                sumOfLetters += username[i] - 96;
            }
            else
            {
                sumOfLetters += (username[i] - 64) * 2;
            }
        }

        ulong digitsPlusLetters = (ulong)sumOfLetters + calcDate;
        int celestialNumber = 0;

        while (digitsPlusLetters > 0)
        {
            celestialNumber += (int)(digitsPlusLetters % 10);
            digitsPlusLetters /= 10;
        }
        int output = celestialNumber;
        if (celestialNumber > 13)
        {
            output = 0;
            while (celestialNumber > 0)
            {
                output += (celestialNumber % 10);
                celestialNumber /= 10;
            }
        }
        Console.WriteLine(output);
    }
}