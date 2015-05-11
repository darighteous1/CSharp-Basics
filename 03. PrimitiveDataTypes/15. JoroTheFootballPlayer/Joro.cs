using System;

class Joro
{
    static void Main()
    {
        string year = Console.ReadLine();
        int hollydays = int.Parse(Console.ReadLine());
        int homeWeekends = int.Parse(Console.ReadLine());

        int numberOfPlays = hollydays/2 + (52 - homeWeekends)*2/3 + homeWeekends;

        if (year == "t")
        {
            numberOfPlays = numberOfPlays + 3;
        }
    
        Console.WriteLine(numberOfPlays);
    }
}