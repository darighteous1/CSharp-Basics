using System;

class PaintBall
{
    static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = 1023;
        }

        string command = Console.ReadLine();
        bool isBlack = true;

        do
        {
            string[] shotParameters = command.Split();
            int row = int.Parse(shotParameters[0]);
            int column = int.Parse(shotParameters[1]);
            int radius = int.Parse(shotParameters[2]);
            int startNum = (row - radius) >= 0 ? row - radius : 0;
            int endNum = (row + radius) < numbers.Length ? row + radius : numbers.Length - 1;
            int startBit = (column - radius) >= 0 ? column - radius : 0;
            int endBit = (column + radius) < 10 ? column + radius : 9;
            int mask = (1 << ((endBit - startBit) + 1)) - 1;

            for (int i = startNum; i <= endNum; i++)
            {
                if (isBlack)
                {
                    numbers[i] = numbers[i] & ~(mask << startBit);
                }
                else
                {
                    numbers[i] = numbers[i] | (mask << startBit);
                }
            }
            isBlack = !isBlack;
            command = Console.ReadLine();
        } while (command != "End");

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}