using System;

class CalculateArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = (width + height) * 2;
        Console.WriteLine("area = " + area);
        Console.WriteLine("perimeter = " + perimeter);
    }
}