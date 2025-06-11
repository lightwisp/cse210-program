
public class Circle : Shape
{
    private double _radius;

    public Circle(string color,double radius ,string name="Circle") : base(color, name)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}