using System;

namespace BitLock
{
    class BitLock
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[8];
            string command = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            command = Console.ReadLine();

            do
            {
                if (command.Contains("check"))
                {
                    int count = 0;
                    int position = int.Parse(command.Substring(6));
                    foreach (var number in numbers)
                    {
                        int bit = (number >> position) & 1;
                        count++;
                    }
                    Console.WriteLine(count);

                }
                else if (command.Contains("right") || command.Contains("left"))
                {
                    if (command.Contains("right"))
                    {
                        int rowPosition = int.Parse(command[0].ToString());
                        int rotationsCount = int.Parse(command.Substring(8));

                        for (int i = 0; i < rotationsCount; i++)
                        {
                            int bitToLose = numbers[rowPosition] & 1;
                            numbers[rowPosition] >>= 1;
                            numbers[rowPosition] |= bitToLose << 11;
                        }    
                    }
                    else
                    {
                        int rowPosition = int.Parse(command[0].ToString());
                        int rotationsCount = int.Parse(command.Substring(7));

                        for (int i = 0; i < rotationsCount; i++)
                        {
                            int bitToLose = (numbers[rowPosition] >> 11) & 1;
                            numbers[rowPosition] &= ~(1 << 11);
                            numbers[rowPosition] <<= 1;
                            numbers[rowPosition] |= bitToLose;
                        }
                    }

                }
                command = Console.ReadLine();

            } while (command != "end");

        }
    }
}
