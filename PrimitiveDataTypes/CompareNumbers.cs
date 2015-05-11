using System;

class CompareNumbers
{
    static void Main()
    {
        double a = -4.999999;
        double b = -4.999998;
        const double Eps = 0.000001;
        double compare = Math.Abs(a - b);
        bool areEqual = compare < Eps;
        Console.WriteLine(areEqual);
    }
}
