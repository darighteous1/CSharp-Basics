using System;

class DecimalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string result = "";
        long number = input;
        while (number != 0)
        {
            long digit = number % 16;

            switch (digit)
            {
                case 10:
                    result += "A";
                    break;
                case 11:
                    result += "B";
                    break;
                case 12:
                    result += "C";
                    break;
                case 13:
                    result += "D";
                    break;
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;
                default:
                    result += digit;
                    break;
            }
            number /= 16;
        }
        for (int i = (result.Length - 1); i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}