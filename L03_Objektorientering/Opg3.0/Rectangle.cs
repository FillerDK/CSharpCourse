namespace L03_Objektorientering.Opg3._0;

public class Rectangle: Shape
{
    private double width, height;

    public Rectangle():this(0,0,0,0)
    {
    }
    
    public Rectangle(double x, double y, double width, double height): base(x, y)
    {
        this.width = width;
        this.height = height;
    }

    private double Width
    {
        get { return width; }
        set { width = value; }
    }

    private double Height
    {
        get { return height; }
        set { height = value; }
    }

    public override double Area()
    {
        return width * height;
    }
}