
public class SimpleQuest : Quest
{
    private bool _isComplete;
    public SimpleQuest(string name, string description, int points, bool compleated) : base(name, points, description)
    {
        _isComplete = compleated;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        UserProfile.AddPoints(_points);
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string goalData = $"SimpleQuest*{_name}*{_description}*{_points}*{IsComplete()}";
        return goalData;
    }
    public override string PrintQuestDetails()
    {
        string goalData = GetDetailsString();
        return goalData;
    }
}