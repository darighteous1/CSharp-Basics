using System;

class BinToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        int index = 0;
        for (int i = (input.Length-1); i >=0; i--)
        {
            if (input[i] == '1')
            {
                number += (int)Math.Pow(2, index);
            }
            index++;
        }
        Console.WriteLine(number);
    }
}