using System;

class Program
{
    static void Main()
    {
        double dataToDownload = double.Parse(Console.ReadLine());
        double priceOfMovie = double.Parse(Console.ReadLine());
        double wifeSpending = double.Parse(Console.ReadLine());
        double downloadSpeed = 2.0;

        double downloadTime = dataToDownload / downloadSpeed / 3600;
        double priceForDownload = downloadTime * wifeSpending;
        double numberOfMovies = dataToDownload / 1500.0;
        double cinemaPrice = numberOfMovies * priceOfMovie;

        if (priceForDownload > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
        }
    }
}