using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //top row - constant
        Console.WriteLine("{0}*{0}",
            new string ('.', n));
        
        //top part
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', n-1-i),
                new string('.', 1+2*i));
        }
        
        //middle row - constant
        Console.WriteLine("{0}{1}{0}",
            new string('*', n/2+1),
            new string('.', 2*n+1 - 2*(n/2 +1)));

        //middle part
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string ('.', 1+i),
                new string ('.', 2*n+1 -2 - 2*(1+i)));
        }

        //waist - constant
        Console.WriteLine("{0}*{1}*{1}*{0}",
            new string ('.', n/2),
            new string ('.', n/2 - 1));

        //legs
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", 
                new string ('.', n/2-1 - i),
                new string ('.', n/2-1),
                new string ('.', 1+2*i));
        }

        //feet - constant (same as middle row)
        Console.WriteLine("{0}{1}{0}",
            new string('*', n / 2 + 1),
            new string('.', 2 * n + 1 - 2 * (n / 2 + 1)));
    }
}