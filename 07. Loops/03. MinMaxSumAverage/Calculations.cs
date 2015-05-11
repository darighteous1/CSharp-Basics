using System;

class Calculations
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int? min = null;
        int? max = null;
        for (int i = 0; i < number; i++)
        {
            int input = int.Parse(Console.ReadLine());
            sum += input;

            if (min == null || input < min)
            {
                min = input;
            }
            if (max == null || input > max)
            {
                max = input;
            }
        }
        
        double average = (double)sum / number;
       
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}