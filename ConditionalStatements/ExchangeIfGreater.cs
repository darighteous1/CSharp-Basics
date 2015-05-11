using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = b;
            b = a;
            a = c;
            Console.WriteLine("{0} {1}", a, b);
            return;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}