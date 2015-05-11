using System;

class Triangle
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double distanceAB = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
        double distanceBC = Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));
        double distanceAC = Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));

        bool canFormTriangle = (distanceAB + distanceBC > distanceAC) && (distanceBC + distanceAC > distanceAB) && (distanceAC + distanceAB > distanceBC);
        if (!canFormTriangle)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", distanceAB);
            return;
        }

        double p = (distanceAB + distanceAC + distanceBC) / 2;
        double area = Math.Sqrt(p * (p - distanceAB) * (p - distanceBC) * (p - distanceAC));
        Console.WriteLine("Yes");
        Console.WriteLine("{0:F2}", area);
    }
}