using System;

class Sign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        if (a < 0)
        {
            if ((b < 0 && c < 0) || (c > 0 && b > 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        if (a > 0)
        {
            if ((b < 0 && c < 0) || (c > 0 && b > 0))
            { Console.WriteLine("+"); }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}