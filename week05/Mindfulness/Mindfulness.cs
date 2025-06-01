
public class Mindfulness
{
    private int _activityLength;
    private string _activityName;
    private string _activityDescription;
    // create a list of messages for this to draw from for end of activitys
    private List<string> _positveMessages;

    public Mindfulness(string name, string description)
    {
        // add _positiveMessage here when it is ready 
        _activityName = name;
        _activityDescription = description;
        _activityLength = GetActivityDuration(name);
    }

    public int GetActivityDuration(string name)
    {
        Console.WriteLine($"How long of a {name} sesion would you like ? (seconds)");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }
}