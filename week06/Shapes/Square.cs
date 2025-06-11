
public class Square : Shape
{
    private double _side;

    public Square(string color, double side,string name="Square") : base(color, name)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}