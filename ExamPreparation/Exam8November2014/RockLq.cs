using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', n) +
                            new string('*', n) +
                            new string('.', n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', n - 2 - 2 * i) +
                                '*' +
                                new string('.', 3 * n - 2 * (n - 2 - 2 * i) - 2) +
                                '*' +
                                new string('.', n - 2 - 2 * i));
        }

        Console.WriteLine('*' + new string('.', n - 2) +
                            '*' + new string('.', n) +
                            '*' + new string('.', n - 2) +
                                '*');

        for (int i = 0; i < (n / 2 - 1); i++)
        {
            Console.WriteLine('*' + new string('.', n - 4 - 2 * i) +
                '*' + new string('.', 1 + 2 * i) +
                '*' + new string('.', n) +
                '*' + new string('.', 1 + 2 * i) +
                '*' + new string('.', n - 4 - 2 * i) + '*');
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', n - 1 - i) + '*' +
                                new string('.', n + 2 * i) + '*' +
                                new string('.', n - 1 - i));
        }
        Console.WriteLine(new string('*', 3 * n));
    }
}
