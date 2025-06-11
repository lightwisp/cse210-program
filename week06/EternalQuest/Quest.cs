// parent for quest types

public abstract class Quest
{
    private string _name;
    private int _points;
    private string _description;

    protected Quest(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public string GetDetailsString()
    {
        return null;
    }
}