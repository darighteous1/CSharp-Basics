using System;

class CalculateCircleAreaPerimeter
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2* radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine("Perimeter = {0:F2}", perimeter);
        Console.WriteLine("Area = {0:F2}", area);
    }
}