
public abstract class Shape
{
    private string _color;
    private string _name;
    public Shape(string color, string name)
    {
        SetColor(color);
        _name = name;
    }
    public string GetColor()
    {
        return _color;
    }
    public string GetName()
    {
        return _name;
    }
    private void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}