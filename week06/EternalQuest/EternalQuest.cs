
public class EternalQuest : Quest
{
    public EternalQuest(string name, int points, string description) : base(name, points, description)
    {

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