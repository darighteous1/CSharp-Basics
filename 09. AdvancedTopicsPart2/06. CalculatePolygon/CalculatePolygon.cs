using System;

class CalculatePolygon
{
    static void Main(string[] args)
    {
        Polygon myPolygon = new Polygon();

        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            
            myPolygon.AddToPolygon(new Point(x, y));
        }
        Console.WriteLine();
        myPolygon.PrintPolygon();
    }
    static double GetArea()
    {
        return 1;
    }
    static double GetPerimeter()
    {
        return 1;
    }
    static double CalculatePolygonSides(Point a, Point b)
    {
        return 1;
    }
}