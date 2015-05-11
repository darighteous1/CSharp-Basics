using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upperCount = 1;
        //first row
        string FirstLastRow = new string('-', n/2);
        Console.WriteLine("{0}{1}{0}", FirstLastRow, '*');
        //upper part
        for (int i = 1; i < (n/2 + 1); i++)
        {
            string outline = new string('-', n / 2 - i);
            string inside = new string('-', (n - 2 - (n / 2 - upperCount) - (n / 2 - upperCount)));
            Console.WriteLine("{0}{1}{2}{1}{0}", outline, '*', inside);
            upperCount++;
        }
        //bottom part
        upperCount -= 2;
        int bottomCount = 1;
        for (int i = n / 2; i > 1; i--)
        {
            string outline = new string('-', bottomCount);
            string inside = new string('-', (n - 2 - (n / 2 - upperCount) - (n / 2 - upperCount)));
            Console.WriteLine("{0}{1}{2}{1}{0}", outline, '*', inside);
            upperCount--;
            bottomCount++;
        }
        Console.WriteLine("{0}{1}{0}", FirstLastRow, '*');
    }
}