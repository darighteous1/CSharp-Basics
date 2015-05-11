using System;

class InCircleOutsideRect
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool insideCircleOutsideRectangle = isInCircle(x, y) && isOutsideRectangle(x, y);
        if (insideCircleOutsideRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
    static bool isInCircle(double x, double y)
    {
        bool isInCircle = ((x-1)* (x-1) + (y-1) * (y-1)) <= Math.Pow(1.5, 2);
        if (isInCircle)
        {
            return true;
        }
        return false;
    }
    static bool isOutsideRectangle(double x, double y)
    {
        if (x<-1 || x > 5 || y > 1 || y < -1)
        {
            return true;
        }
        return false;
    }
}