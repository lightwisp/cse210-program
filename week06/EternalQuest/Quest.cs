// parent for quest types

public abstract class Quest
{
    private string _name;
    private int _points;
    private int _bonusPoints;
    
    protected Quest(string name, int points, int bonusPoints = 0)
    {
        _name = name;
        _points = points;
        _bonusPoints = bonusPoints;
    }

    public abstract string DisplayQuest();
}