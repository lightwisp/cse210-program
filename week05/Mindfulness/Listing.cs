
public class Listing : Mindfulness
{
    private List<string> _prompts = new List<string>();
    public Listing(string name, string description, int length) : base(name, description, length)
    {
        _prompts.AddRange(new List<string> {"Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?" });
    }

    public void DisplayListing()
    {
        ReadyMessage();
        DisplayString(_prompts);
        Menus.WaitingAnimation(10);
        Menus.PrintSlow("Share your thoughts as quick as you can.");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetActivityDuration());
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.ReadLine();
            i++;
        }
        Menus.PrintSlow($"You made {i} enteries in {GetActivityDuration()}/seconds");
        Thread.Sleep(2000);
    }
}