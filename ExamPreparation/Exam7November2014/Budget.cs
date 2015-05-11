using System;

class Budget
{
    static void Main()
    {
        ulong money = ulong.Parse(Console.ReadLine());
        ulong weekdays = ulong.Parse(Console.ReadLine());
        ulong hometown = ulong.Parse(Console.ReadLine());
        ulong rent = 150;

        ulong normalWeekends = (4 - hometown) * 2 * 20;
        ulong normalDays = (22 - weekdays) * 10;
        ulong extraSpendings = money * 3 / 100;
        ulong goingOut = (10 + extraSpendings) * weekdays;

        ulong spendings = (ulong)(rent + normalWeekends + normalDays + goingOut);
        long difference = (long)(money - spendings);

        if (difference == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (difference < 0)
        {
            Console.WriteLine("No, not enough {0}.", -difference);
        }
        else
        {
            Console.WriteLine("Yes, leftover {0}.", difference);
        }
    }
}