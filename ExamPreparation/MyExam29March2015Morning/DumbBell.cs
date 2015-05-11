﻿using System;

class DumbBell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string(' ', n / 2),
            new string('&', n / 2 + 1),
            new string(' ', n));

        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                    new string(' ', n / 2 - 1 - i),
                    new string('*', n / 2 + i),
                    new string(' ', n));
        }

        Console.WriteLine("&{0}&{1}&{0}&",
            new string('*', n - 2),
            new string('=', n));

        for (int i = (n / 2-2); i >= 0; i--)
        {

            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
            new string(' ', n / 2 -1-i),
            new string('*', n / 2 + i),
            new string(' ', n));
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string(' ', n / 2),
            new string('&', n / 2 + 1),
            new string(' ', n));
    }
}