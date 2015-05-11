using System;
using System.Collections.Generic;
using System.Linq;

class Polygon
{
    List<Point> myPolygon = new List<Point>();
    public void AddToPolygon(Point point)
    {
        myPolygon.Add(point);
    }

    public void PrintPolygon()
    {
        myPolygon.ToList().ForEach(x => Console.WriteLine(x.x + " " + x.y));
        //foreach (var point in myPolygon)
        //{
        //    Console.WriteLine("x = {0}, y = {1}", point.x, point.y);
        //    //Console.Write("(" + point + "), ");
        //}
    }
}