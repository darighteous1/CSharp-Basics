using System;

class DiffBetweenDates
{
    static void Main()
    {
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        TimeSpan diff = endDate - startDate;
        Console.WriteLine(diff.Days);
    }
}