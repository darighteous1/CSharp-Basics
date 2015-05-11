using System;

class Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int index = i;
            for (int j = 1; j <= n; j++)
            {
                Console.Write(index + " ");
                index++;
            }
            Console.WriteLine();
        }

    }
}