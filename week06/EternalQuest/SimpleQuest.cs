
public class SimpleQuest : Quest
{
    private bool _isComplete;
    public SimpleQuest(string name, int points, string description) : base(name, points, description)
    {
        _isComplete = false;
    }
   
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}