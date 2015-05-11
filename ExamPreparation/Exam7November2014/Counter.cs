using System;

class Counter
{
    static void Main()
    {
        int sets = int.Parse(Console.ReadLine());
        int numbersInSet = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        bool isOdd = true;
        if (str == "even")
        {
            isOdd = false;
        }

        int[,] matrix = new int[sets, numbersInSet];
        long? max = null;
        int maxSet = 0;
        int numbersFound = 0;

        for (int i = 0; i < sets; i++)
        {
            numbersFound = 0;
            for (int j = 0; j < numbersInSet; j++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if ((currentNum % 2 == 0) != isOdd)
                {
                    numbersFound++;
                }
            }
            if (max == null || numbersFound > max)
            {
                max = numbersFound;
                maxSet = i;
            }
        }

        if (max == 0)
        {
            Console.WriteLine("No");
            return;
        }

        string[] setName = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        Console.WriteLine("{0} set has the most {1} numbers: {2}", setName[maxSet], str, max);
    }
}