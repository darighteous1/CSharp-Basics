using System;

class GameOfBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        string currentCommand = Console.ReadLine();

        while (currentCommand != "Game Over!")
        {
            int oddEven = 0;

            switch (currentCommand)
            {
                case "Odd":
                    oddEven = 0;
                    break;
                case "Even":
                    oddEven = 1;
                    break;
            }
            uint numberNew = 0;
            int currentIndex = 0;
            for (; oddEven <= 31; oddEven += 2, currentIndex++)
            {

                uint currentBit = ((num >> oddEven) & 1) << currentIndex;
                numberNew = numberNew | currentBit;
            }
            num = numberNew;
            currentCommand = Console.ReadLine();
        }

        int oneBits = 0;
        for (int i = 0; i < 32; i++)
        {
            uint currentBit = (num >> i) & 1;
            if (currentBit == 1)
            {
                oneBits++;
            }
        }

        Console.WriteLine("{0} -> {1}", num, oneBits);
    }
}