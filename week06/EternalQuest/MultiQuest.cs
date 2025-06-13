
public class MultiQuest : Quest
{
    private int _target;
    private int _bonusPoints;
    private int _amountCompleted;
    public MultiQuest(string name, string description, int points, int target, int amountCompleted, int bonusPoints) : base(name, points, description)
    {
        _target = target;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete())
        {
            _points = _points + _bonusPoints;
        }
        UserProfile.AddPoints(_points);
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string goalData = $"MultiQuest*{_name}*{_description}*{_points}*{_target}*{_amountCompleted}*{_bonusPoints}";
        return goalData;
    }
    public override string PrintQuestDetails()
    {
        string goalData =$"[{XCompleate()}] GetDetailsString() --Curently Completed: {_amountCompleted}/{_target}";
        return goalData;
    }
}