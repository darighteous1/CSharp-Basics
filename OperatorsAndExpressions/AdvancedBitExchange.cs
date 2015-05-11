using System;

class AdvancedBitExchange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //
        int step = int.Parse(Console.ReadLine());

        string input = "";
        string fullNumber = "";
        
        //console input
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            input = Convert.ToString(num, 2).PadLeft(8, '0');
            Console.WriteLine(input);
            fullNumber += input;
        }
        
        Console.WriteLine(fullNumber.PadLeft(8*n, '0'));
        for (int i = 1; i <= 8*n; i+=step)
        {
            foreach (var digit in fullNumber)
            {
                if (digit == '0')
                {
                    fullNumber.Replace(digit, '1');
                }
            }
        }
        Console.WriteLine(fullNumber);
        //ulong finalNumber = Convert.ToUInt64(fullNumber, 2);

    }
}