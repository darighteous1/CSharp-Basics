using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(startYear, 01, 01);
        DateTime endDate = new DateTime(endYear, 12, 31);

        bool magicDateFound = false;
        for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
        {
            string dateAsString = i.ToString("ddMMyyyy"); //important!!!
            int currentMagicSum = 0;

            for (int j = 0; j < dateAsString.Length-1; j++) //iterate through string
            {
                int startDigit = int.Parse(dateAsString[j].ToString()); //convert current char to string so we can parse it to int
                for (int k = j+1; k < dateAsString.Length; k++)
                {
                    int currentDigit = int.Parse(dateAsString[k].ToString());
                    currentMagicSum += (startDigit * currentDigit);
                }
            }
            if (currentMagicSum == magicWeight)
            {
                magicDateFound = true;
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
            }
        }
        if (!magicDateFound)
        {
            Console.WriteLine("No");
        }

    }
}