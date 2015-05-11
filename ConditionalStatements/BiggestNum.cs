using System;

class BiggestNum
{
    static void Main()
    {
        double? biggestNum = null;
        for (int i = 0; i < 3; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (biggestNum == null || num > biggestNum)
            {
                biggestNum = num;
            }
        }
        Console.WriteLine(biggestNum);
    }
}