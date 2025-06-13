// parent for quest types

public abstract class Quest
{
    protected string _name;
    protected int _points;
    protected string _description;

    protected Quest(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public abstract string PrintQuestDetails();
    public string GetDetailsString()
    {
        return $"[{XCompleate()}] {_name} ({_description})";
    }
    public string XCompleate()
    {
        if (IsComplete() == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    
}