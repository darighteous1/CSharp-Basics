using System;

class OddOrEven
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool isOdd = true;
        if (num%2 != 0)
        {
            Console.WriteLine(isOdd);
        }
        else
        {
            Console.WriteLine(!isOdd);
        }
    }
}