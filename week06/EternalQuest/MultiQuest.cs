
public class MultiQuest : Quest
{
    private int _target;
    private int _bonusPoints;
    private int _amountCompleted;
    public MultiQuest(int target, int bonusPoints, int amountCompleted, string name, int points, string description) : base(name, points, description)
    {
        _target = target;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
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