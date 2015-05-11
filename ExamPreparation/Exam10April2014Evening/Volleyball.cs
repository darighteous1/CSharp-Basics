using System;

class Volleyball
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        double holidayPlays = holidays * 2 / 3.0;
        int normalWeekends = 48 - hometownWeekends;
        double normalWeekendPlays = normalWeekends * 3 / 4.0;

        double plays = hometownWeekends + normalWeekendPlays + holidayPlays;
        if (year == "leap")
        {
            plays *= 1.15;
        }

        Console.WriteLine(Math.Floor(plays));
    }
}