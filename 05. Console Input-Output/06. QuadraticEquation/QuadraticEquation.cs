using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        
        double firstRoot = (-b + Math.Sqrt(b*b-4*a*c))/(2*a);
        double secondRoot = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        if (firstRoot == secondRoot)
        {
            Console.WriteLine("X1 = X2 = {0:0.###}", firstRoot, secondRoot);
            return;
        }
        
        if (Double.IsNaN(firstRoot) && Double.IsNaN(secondRoot))
        {
            Console.WriteLine("no real roots");   // check with discriminant value - if <0 no real roots, if == 0 - 1 root, >0 2 roots.
        }
        else if (Double.IsNaN(firstRoot))
        {
            Console.WriteLine("Only one real root, X = {0:F3}", secondRoot);
        }
        else if (Double.IsNaN(secondRoot))
        {
            Console.WriteLine("Only one real root, X = {0:F3}", firstRoot);
        }
        else
        {
        Console.WriteLine("X1 = {0:0.###}", firstRoot);
        Console.WriteLine("X2 = {0:0.###}", secondRoot);
        }
    }
}