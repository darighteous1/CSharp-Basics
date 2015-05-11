using System;

class LeliaVanche
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double productivity = p / 100.0;

        double daysOfWork = days * 0.9;
        int hoursOfWork = (int)(daysOfWork * 12 * productivity);
        int difference = hoursOfWork - hours;

        Console.WriteLine((difference >= 0) ? ("Yes\n" + difference) : ("No\n" + difference));
    }
}