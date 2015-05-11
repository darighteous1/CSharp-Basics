using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Wrong input!");
            System.Environment.Exit(0);
        }
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("|{0,-10:X}", a);
        Console.Write("|{0}", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.WriteLine("|{0, 10:F2}|{1,-10:F3}|", b, c);
    }
}