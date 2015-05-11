using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upperCount = 1;
        //first row
        string FirstLastRow = new string('.', n / 2);
        Console.WriteLine("{0}{1}{0}", FirstLastRow, '*');
        //upper part
        for (int i = 1; i < (n / 2); i++)
        {
            string outline = new string('.', n / 2 - i);
            string inside = new string('.', (n - 2 - (n / 2 - upperCount) - (n / 2 - upperCount)));
            Console.WriteLine("{0}{1}{2}{1}{0}", outline, '*', inside);
            upperCount++;
        }
        //bottom of roof
        string bottomRoof = new string('*', n);
        Console.WriteLine(bottomRoof);
        //bottom part of house
        string houseOutside = new string('.', (n / 4));
        string houseInside = new string('.', (n - 2 - n / 4 - n / 4));
        for (int i = 0; i < n / 2; i++)
        {
            if (i == n / 2 - 1)
            {
                string lastRow = new string('*', (n - n / 4 - n / 4));
                Console.WriteLine("{0}{1}{0}", houseOutside, lastRow);
                break;
            }
            Console.WriteLine("{0}*{1}*{0}", houseOutside, houseInside);

        }
    }
}