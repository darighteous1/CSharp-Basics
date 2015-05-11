using System;

class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int centerX = n / 2;
        int centerY = n / 2;
        int diskRadius = r;

        char[,] matrix = new char[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int pointX = i - centerX;
                int pointY = j - centerY;
                if (Math.Sqrt(pointX * pointX + pointY * pointY) <= diskRadius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

    }
}