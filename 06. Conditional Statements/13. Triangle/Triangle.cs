using System;

class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        double distanceAB = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
        double distanceBC = Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));
        double distanceAC = Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));

        bool checkOne = distanceAB + distanceBC <= distanceAC ;
        bool checkTwo = distanceBC + distanceAC <= distanceAB ;
        bool checkThree = distanceAB + distanceAC <= distanceBC;

        if (checkOne || checkTwo || checkThree)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}",distanceAB);
            return;
        }

        double p = (distanceAB + distanceAC + distanceBC) / 2;
        double area = Math.Sqrt(p*(p-distanceAB)*(p-distanceBC)*(p-distanceAC));
        Console.WriteLine("Yes");
        Console.WriteLine("{0:F2}", area);
    }

}