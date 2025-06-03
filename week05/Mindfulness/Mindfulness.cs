
public class Mindfulness
{
    private int _activityLength;
    private string _activityName;
    private string _activityDescription;

    public Mindfulness(string name, string description, int activityLength)
    {
        // add _positiveMessage here when it is ready
        _activityName = name;
        _activityDescription = description;
        _activityLength = activityLength;
    }

    public void ActivityMessage()
    {
        Console.Clear();
        Menus.PrintSlow(_activityDescription);
    }
    public void PositiveEndMessage()
    {
        Menus.PrintSlow("You have done well. Good Job.");
        Thread.Sleep(1500);
        Console.Clear();
    }
    public void ReadyMessage()
    {
        Menus.PrintSlow("Ready...", 300);

        Menus.PrintSlow("Begin...");
        Thread.Sleep(500);
        Console.Clear();
    }
    protected int GetLoop(int numberOfSeconds)
    {
        // if length of 60, there is 6 loops of breath in and 6 breath out
        // divided by 5 for 5 second in and out
        int maxLoop = _activityLength / numberOfSeconds;
        return maxLoop;
    }
}