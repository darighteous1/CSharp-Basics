using System;

class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        int vowelCount = 0;
        int vowelSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A':
                    vowelSum += 'A';
                    vowelCount++;
                    break;
                case 'E':
                    vowelSum += 'E';
                    vowelCount++;
                    break;
                case 'I':
                    vowelSum += 'I';
                    vowelCount++;
                    break;
                case 'O':
                    vowelSum += 'O';
                    vowelCount++;
                    break;
                case 'U':
                    vowelSum += 'U';
                    vowelCount++;
                    break;
            }
        }
        Console.WriteLine(vowelCount);
        Console.WriteLine(vowelSum);
    }
}