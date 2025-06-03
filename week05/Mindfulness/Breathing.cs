
public class Breathing : Mindfulness
{
    //create variables that suport breathing techneaks
    private int _loopsOfBreathing;
    public Breathing(string name, string description, int length) : base(name, description, length)
    {
        _loopsOfBreathing = GetBreathingLoop();
    }

    private int GetBreathingLoop()
    {
        // if length of 60, there is 6 loops of breath in and 6 breath out
        // divided by 5 for 5 second in and out
        int maxLoop = _activityLength / 5;
        return maxLoop;
    }
    public void DisplayBreathing()
    {
        ReadyMessage();
        bool inOut = true;
        Thread.Sleep(500);
        Console.Clear();
        for (int i = _loopsOfBreathing; i > 0; i--)
        {
            if (inOut)
            {
                PrintSlow("Breath in...\n");
                WaitingAnimation();

                inOut = false;
            }
            else
            {
                PrintSlow("\nBreath out...\n");
                WaitingAnimation();

                Console.Clear();
                inOut = true;
            }

        }
    }
    public void ReadyMessage()
    {
        PrintSlow("Ready...\n", 300);

        PrintSlow("Begin.\n");
    }
}