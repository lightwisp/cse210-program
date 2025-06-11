
public class MultiQuest : Quest
{
    private int _numToCompleat;
    public MultiQuest(string name, int points, int numToCompleat) : base(name, points)
    {
        _numToCompleat = numToCompleat;
    }
    public override string DisplayQuest()
    {
        return null;
    }
}