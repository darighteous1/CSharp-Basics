using System;

class ThirdDigit7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num/100%10==7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);        
        }


    }
}