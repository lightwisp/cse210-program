
public class EternalQuest : Quest
{
    public EternalQuest(string name, string description, int points) : base(name, points, description)
    {

    }

    public override void RecordEvent()
    {
        UserProfile.AddPoints(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string goalData = $"EternalQuest*{_name}*{_description}*{_points}";
        return goalData;
    }
    public override string PrintQuestDetails()
    {
        string goalData = GetDetailsString();
        return goalData;
    }
}