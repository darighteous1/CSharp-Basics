﻿class Point
{
    public double x, y;
    
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return this.x + ", " + this.y;
    }
}