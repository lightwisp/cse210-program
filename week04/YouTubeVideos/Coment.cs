
public class Coment
{
    private string _name;
    private string _coment;

    public Coment(string name, string coment)
    {
        _name = name;
        _coment = coment;
    }

    public void displayAll()
    {
        Console.WriteLine($"{_name}\n{_coment}");
    }

}