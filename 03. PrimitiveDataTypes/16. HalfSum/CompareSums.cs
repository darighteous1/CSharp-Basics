using System;

class CompareSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int sum1 = new int();
        
        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            sum1 += num1;
        }
        
        int sum2 = new int();
        
        for (int k = 0; k < n; k++)
        {
            int num2 = int.Parse(Console.ReadLine());
            sum2 += num2;
        }
        
        bool isEqual = sum1 == sum2;
        
        if (isEqual == true)
        {
            Console.WriteLine("Yes, sum=" + sum1);
        }
        else
        {
            int difference = Math.Abs(sum1 - sum2);
            Console.WriteLine("No, diff=" + difference);
        }
    }
}