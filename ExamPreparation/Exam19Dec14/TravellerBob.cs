using System;

class TravellerBob
{
    static void Main(string[] args)
    {
        string isLeap = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        double travels = c * 12 + f * 4 + ((12 - c - f) * 12) * 3 / 5.0;
        if (isLeap == "leap")
        {
            travels *= 1.05;
        }
        Console.WriteLine(Math.Floor(travels));
    }
}