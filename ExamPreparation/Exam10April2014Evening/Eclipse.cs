using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == (n - 1))
            {
                Console.WriteLine(" {0} {1} {0} ", new string('*', 2 * n - 2), new string(' ',n-1));
            }
            else if (i == n / 2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2*n-2), new string('-',n-1));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n-1));
            }
        }
    }
}