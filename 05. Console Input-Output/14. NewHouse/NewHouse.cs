using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upperCount = 1;
        int innerCount = upperCount + 2;
        //roof top
        string firstRow = new string('-', n / 2);
        Console.WriteLine("{0}{1}{0}", firstRow, '*');
        //roof
        for (int i = 1; i < (n / 2 + 1); i++)
        {
            string outline = new string('-', n / 2 - i);
            string inside = new string('*', innerCount);
            Console.WriteLine("{0}{1}{0}", outline, inside);
            upperCount++;
            innerCount += 2;
        }
        //house
        string wall = new string('*', (n - 2));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", '|', wall);
        }
        
    }
}