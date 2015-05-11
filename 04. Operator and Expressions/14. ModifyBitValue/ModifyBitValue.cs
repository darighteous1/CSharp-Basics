using System;

class ModifyBitValue
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        if (value == 1)
        {
            int result = number | mask;
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(8,'0'));

        }
        else
        {
            int result = number & ~mask;
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(8, '0'));
        }

    }
}