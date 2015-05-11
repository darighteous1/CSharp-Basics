using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long output = 0;
        int power = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            long currentDigit;
            bool check = Int64.TryParse(Convert.ToString(input[i]), out currentDigit);
            long powerOf16 = (long)Math.Pow(16, power);


            if (check)
            {
                output += currentDigit * powerOf16;
            }
            else
            {
                switch (input[i])
                {
                    case 'A':
                        output += 10 * powerOf16;
                        break;
                    case 'B':
                        output += 11 * powerOf16;
                        break;
                    case 'C':
                        output += 12 * powerOf16;
                        break;
                    case 'D':
                        output += 13 * powerOf16;
                        break;
                    case 'E':
                        output += 14 * powerOf16;
                        break;
                    case 'F':
                        output += 15 * powerOf16;
                        break;
                }
            }
            power++;
        }


        Console.WriteLine(output);
    }
}