using System;

class HeadPhones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string('*', n + 2));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('-', n));
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', ((n - 1) / 2) - count),
                new string('*', 1 + 2 * count),
                new string('-', n - 2 * count));
            if (i < n / 2)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
    }
}