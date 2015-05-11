using System;

class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long number = input;
        string output = "";
        while (number != 0)
        {
            output += number%2;
            number = number / 2;
        }
        for (int i = (output.Length - 1); i >= 0; i--)
        {
            Console.Write(output[i]);
        }
        Console.WriteLine();
    }
}