using System;

class BitSwapper
{
    static void Main()
    {
        uint[] numbers = new uint[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        string[] command = Console.ReadLine().Split();

        uint mask = (1 << 4) - 1;
        while (command[0] != "End")
        {
            string[] command2 = Console.ReadLine().Split();

            uint x = uint.Parse(command[0]);
            int posX = int.Parse(command[1]) * 4;
            uint y = uint.Parse(command2[0]);
            int posY = int.Parse(command2[1]) * 4;

            uint firstByteToSwap = (numbers[x] >> posX) & mask;
            uint secondByteToSwap = (numbers[y] >> posY) & mask;

            numbers[x] = numbers[x] & ~(mask << posX);
            numbers[y] = numbers[y] & ~(mask << posY);

            numbers[x] = numbers[x] | (secondByteToSwap << posX);
            numbers[y] = numbers[y] | (firstByteToSwap << posY);

            command = Console.ReadLine().Split();
        }
        foreach (uint number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}