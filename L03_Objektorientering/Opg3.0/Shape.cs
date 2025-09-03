namespace L03_Objektorientering.Opg3._0;

public abstract class Shape
{
    private double x, y;

    public Shape(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Shape() : this(1, 1)
    {
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public  double Y
    {
        get { return y; }
        set { y = value; }
    }
    
    public abstract double Area();
}