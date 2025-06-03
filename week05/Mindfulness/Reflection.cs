
public class Reflection : Mindfulness
{
    // creat variables that represent reflecting
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>
    {

    };
    public Reflection(string name, string description, int length) : base(name, description, length)
    {
        _prompts.AddRange(new List<string> {"Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." });

        _questions.AddRange(new List<string> {"Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" });
    }

    private string GetPromt(List<string> strings)
    {
        int numberPicker = GetRandArrayNumber(strings);
        string promt = strings[numberPicker];
        strings.RemoveAt(numberPicker);
        return promt;
    }
    private int GetRandArrayNumber(List<string> strings)
    {
        Random random = new Random();
        return random.Next(strings.Count());
    }
    public void DisplayString(List<string> strings)
    {
        Menus.PrintSlow(GetPromt(strings));
    }
    public void DisplayQuestions()
    {
        ReadyMessage();
        DisplayString(_prompts);
        Menus.WaitingAnimation(10);
        for (int i = GetLoop(10); i > 0; i--)
        {
            DisplayString(_questions);
            Menus.WaitingAnimation(10);
        }
    }
}