
public class WritingAssignment : Assingment
{
    private string _title;

    public WritingAssignment(string title, string name, string topic = "Writing") : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{base.GetSummary()}\n{_title}";
    }
}