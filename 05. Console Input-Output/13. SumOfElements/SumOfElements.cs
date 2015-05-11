using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ', '\n', '\t');
        double sum = 0;

        foreach (var num in numbers)
        {
            sum += int.Parse(num);
        }
        double diff = Math.Abs(sum);

        foreach (var num in numbers)
        {
            bool check = double.Parse(num) == (sum - double.Parse(num));
            if (check)
            {
                Console.WriteLine("Yes, sum={0}", sum / 2);
                return;
            }
            
            double tempDiff = Math.Abs(sum - 2*double.Parse(num));
            
            if (tempDiff < diff)
            {
                diff = tempDiff;
            }
        }
        Console.WriteLine("No, diff={0}", diff);
    }
}