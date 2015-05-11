using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //first row - constant
        Console.WriteLine(new string('.', 3 * n / 2) + '*' +
                            new string('.', 3 * n / 2));

        //plane nose narrow
        for (int i = 0; i <= n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', (3 * n - 3 - 2 * i) / 2),
                new string('.', 1 + 2 * i));
        }

        //plane nose wide
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', n - 4 - 2 * i),
                new string('.', 3 * n - 2 - 2 * (n - 4 - 2 * i)));
        }

        //middle row - constant
        Console.WriteLine("*{0}*{1}*{0}*",
                new string('.', n - 2),
                new string('.', n));

        //wings
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                new string('.', n - 4 - 2 * i),
                new string('.', 1 + 2 * i),
                new string('.', n));
        }

        //tail
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', n - 1 - i),
                new string('.', n+2*i));
        }

        //last row - constant
        Console.WriteLine(new string('*', 3 * n));
    }
}
