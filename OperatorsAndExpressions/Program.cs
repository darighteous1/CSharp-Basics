using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
