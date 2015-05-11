using System;

//v.1 with array
//using System.Linq;
//
//        int[] myArr = new int[3] {1, 2, 3};
//        Console.WriteLine(myArr.Max());


class Sort
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double min = a;
        double mid = b;
        double max = c;

        if (a >= b && a >= c)
        {
            max = a;

            if (b >= c)
            {
                mid = b;
                min = c;
            }
            else
            {
                mid = c;
                min = b;
            }
        }
        else if (b >= a && b >= c)
        {
            max = b;

            if (a >= c)
            {
                mid = a;
                min = c;
            }
            else
            {
                mid = c;
                min = a;
            }
        }
        else if (c >= b && c >= a)
        {
            max = c;
            if (a >= b)
            {
                mid = a;
                min = b;

            }
            else
            {
                mid = b;
                min = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", max, mid, min);
    }
}