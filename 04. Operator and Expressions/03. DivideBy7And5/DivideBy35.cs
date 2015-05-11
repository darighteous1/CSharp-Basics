using System;

class DivideBy35
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 35 == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }    
    }
}