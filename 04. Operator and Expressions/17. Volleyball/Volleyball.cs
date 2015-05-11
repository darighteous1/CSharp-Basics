using System;


class Volleyball
{
    static void Main()
    {
        string isLeap = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double numberOfPlays = (p * 2 / 3) + (48 - h) * 3 / 4 + h;
        if (isLeap == "leap")
        {
            numberOfPlays = numberOfPlays * 1.15;
        }
        int result = (int)numberOfPlays;
        Console.WriteLine(result);
    }
}