
public class Assingment
{
    private string _studentName;
    private string _topic;

    public Assingment()
    {
        _studentName = "Unknown";
        _topic = "Blank";
    }
    public Assingment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Name: {_studentName}\nSubject: {_topic}";
    }
}