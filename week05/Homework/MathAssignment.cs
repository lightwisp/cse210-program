
public class MathAssignment : Assingment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment()
    {
        _textbookSection = "None";
        _problems = "None";
    }

    public MathAssignment(string textBook, string problem, string name, string topic = "Math") : base(name, topic)
    {
        _textbookSection = textBook;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"{base.GetSummary()}\nText Book: {_textbookSection}\nPrblems:\n{_problems}";
    }
}