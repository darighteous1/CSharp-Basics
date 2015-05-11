using System;

class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstClassInput = Console.ReadLine().Split();
        string[] businessClassInput = Console.ReadLine().Split();
        string[] economyClassInput = Console.ReadLine().Split();
        
        int[] firstClass = new int[3];
        int[] businessClass = new int[3];
        int[] economyClass = new int[3];

        for (int i = 0; i < 3; i++)
        {
            firstClass[i] = int.Parse(firstClassInput[i]);
            businessClass[i] = int.Parse(businessClassInput[i]);
            economyClass[i] = int.Parse(economyClassInput[i]);
        }

        int maxIncome = 233160;

        int firstClassIncome = (firstClass[0] - firstClass[1]) * 7000 + firstClass[1]*2100 + firstClass[2]*35;
        int businessClassIncome = (businessClass[0] - businessClass[1])* 3500 + businessClass[1] * 1050 + businessClass[2] * 175/10;
        int economyClassIncome = (economyClass[0] - economyClass[1])* 1000 + economyClass[1] *300 + economyClass[2] * 5;

        int totalIncome = firstClassIncome + businessClassIncome + economyClassIncome;
        int difference = maxIncome - totalIncome;

        Console.WriteLine(totalIncome);
        Console.WriteLine(difference);
    }
}