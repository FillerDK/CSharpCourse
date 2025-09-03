using System.Drawing;

namespace L03_Objektorientering.Opg3._0;

public class Circle : Shape
{
    private double radius;

    public Circle() : this(0, 0, 0)
    {
    }
    
    public Circle(double x, double y, double radius) : base(x, y)
    {
        this.radius = radius;
    }

    public double Radius
    {
        get  { return radius; }
        set { radius = value; }
    }

    public Point getCenter()
    {
        return new Point((int)(X+radius), (int)(Y+radius));
    }

    public override double Area()
    {
        return Math.PI*radius*radius;
    }
}