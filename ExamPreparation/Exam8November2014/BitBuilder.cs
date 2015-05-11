using System;

class BitBuilder
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        long number = num;
        int pos;
        bool posCheck = int.TryParse(Console.ReadLine(), out pos);
        if (!posCheck)
        {
            Console.WriteLine(number);
            return;
        }
        string command = Console.ReadLine();

        while (command != "quit")
        {
            string currentCommand = command;
            switch (currentCommand)
            {
                case "flip":
                    number = FlipBit(number, pos);
                    break;
                case "remove":
                    number = RemoveBit(number, pos);
                    break;
                case "insert":
                    number = InsertBit(number, pos);
                    break;
                default:
                    break;
            }
            bool check = int.TryParse(Console.ReadLine(), out pos);
            if (!check)
            {
                break;
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(number);
    }

    private static long InsertBit(long number, int pos)
    {
        long rightPart = number & (((long)1 << pos) - 1);
        long leftPart = number >> pos;
        return (leftPart << (pos + 1)) | ((long)1 << pos) | rightPart;
    }

    private static long RemoveBit(long number, int pos)
    {
        long rightPart = number & (((long)1 << pos) - 1);
        long leftPart = number >> (pos + 1);
        long newNum = (leftPart << pos) | rightPart;
        return newNum;
    }

    private static long FlipBit(long number, int pos)
    {
        number = number ^ ((long)1 << pos);
        return number;
    }
}