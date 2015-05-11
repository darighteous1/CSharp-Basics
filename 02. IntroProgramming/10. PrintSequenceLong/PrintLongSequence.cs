using System;

class SequenceShort
{
    static void Main()
    {
        // this is the same as the short sequence, we just count the first 1000 numbers, not the first 10
        for (int num = 2; num < 1002; num++)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
            else
            {
                Console.Write(-num + " ");
            }
        }
        Console.WriteLine();
    }
}