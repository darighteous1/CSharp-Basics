using System;

class ByteParty
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        //check for 1 line input!!!

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        string input = Console.ReadLine();
        while (input != "party over")
        {

            string[] command = input.Split(' ');
            switch (command[0])
            {
                case "-1":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] ^= (1 << int.Parse(command[1]));
                    }
                    break;
                case "0":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] &= ~(1 << int.Parse(command[1]));
                    }
                    break;
                case "1":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] |= (1 << int.Parse(command[1]));
                    }
                    break;
            }

            input = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}