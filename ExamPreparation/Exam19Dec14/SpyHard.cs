using System;

class SpyHard
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int totalValue = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                totalValue += input[i] - 64;
            }
            else if (input[i] >= 'a' && input[i] <= 'z')
            {
                totalValue += input[i] - 96;
            }
            else
            {
                totalValue += input[i];
            }
        }
        string convertedValue = "";
        while (totalValue != 0)
        {
            convertedValue = (totalValue % numeralSystem) + convertedValue;
            totalValue /= numeralSystem;
        }
        Console.Write(numeralSystem.ToString() + input.Length.ToString() + convertedValue);
    }
}