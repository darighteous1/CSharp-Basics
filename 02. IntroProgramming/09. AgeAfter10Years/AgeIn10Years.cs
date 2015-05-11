using System;

class AgeIn10Years
{
    static void Main()
    {
        Console.WriteLine("Please, enter your date of birth");
        DateTime date = DateTime.Parse(Console.ReadLine()); // this will initialize a variable "date", that will hold the value of our input
        DateTime dateNow = DateTime.Now; // the variable dateNow holds the value of the current date
        TimeSpan age = dateNow - date; // This will substract the input date (your birth date) from the current date and returns a result in total days
        int ageInYears = age.Days / 365; // we divide the total days by 365 to get your age in years


        //now we can just print our age after 10 years by simply
        // Console.WriteLine(ageInYears + 10);
        
        //Or, we can do it a bit more elegant
        if (ageInYears < 1) //this checks if you are younger than 1 year and returns your age in months
        {
            int ageInMonths = age.Days / 12;
            Console.WriteLine("Today, you're approximately {0} months old.", ageInMonths);
            Console.WriteLine("After 10 years you'll be 10 years and {0} months old.", ageInMonths);
        }
        else // if you're 1 year old or older, the program returns your age in ten years
        {
            Console.WriteLine("Today, you're {0} years old.", ageInYears);
            Console.WriteLine("After 10 years you'll be {0} years old.", ageInYears + 10);
        }

    }
}