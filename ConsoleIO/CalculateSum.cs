using System;

class CalculateSum
{
    static void Main()
    {
        double sum = 0;
        string input = Console.ReadLine();
        
        string[] numbers = input.Split(' ', '\n', '\t');
        foreach (var num in numbers)
        {
            sum += double.Parse(num);
        }
        
        Console.WriteLine("{0:#.##}",sum);
    }
}