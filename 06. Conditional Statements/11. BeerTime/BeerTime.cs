using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("enter time: ");
        DateTime beerTime;
        bool validTime = DateTime.TryParse(Console.ReadLine(), out beerTime);

        if (validTime == false)
        {
            Console.WriteLine("invalid time");
            return;
        }

        DateTime early = Convert.ToDateTime("1:00PM");
        DateTime late = Convert.ToDateTime("3:00AM");
        int checkOne = DateTime.Compare(beerTime, late);
        int checkTwo = DateTime.Compare(beerTime, early);
        if (checkOne >= 0 && checkTwo <=0)
        {
            Console.WriteLine("non-beer time :(");
        }
        else
        {
            Console.WriteLine("BEER TIME!");
        }


    }
}