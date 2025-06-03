
public class Mindfulness
{
    protected int _activityLength;
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
        PrintSlow(_activityDescription);
    }
    public void PositiveEndMessage()
    {
        PrintSlow("You have done well. Good Job.");
    }

    public void PrintSlow(string text, int delay = 20)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }
    public void WaitingAnimation(int length = 5)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(length);

        // this is my text animations while the user is waiting.
        List<string> _animations = new List<string>();
        _animations.Add("_________");
        _animations.Add("-________");
        _animations.Add("^-_______");
        _animations.Add("-^-______");
        _animations.Add("_-^-_____");
        _animations.Add("__-^-____");
        _animations.Add("___-^-___");
        _animations.Add("____-^-__");
        _animations.Add("_____-^-_");
        _animations.Add("______-^-");
        _animations.Add("_______-^");
        _animations.Add("________-");
        _animations.Add("_________");

        int i = 0;
        while (DateTime.Now < end)
        {
            string l = _animations[i];
            Console.Write("\r" + l);
            Thread.Sleep(110);

            i++;
            if (i >= _animations.Count)
            {
                i = 0;
            }
        }

    }
}