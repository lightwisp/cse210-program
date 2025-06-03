
public class Breathing : Mindfulness
{
    public Breathing(string name, string description, int length) : base(name, description, length)
    {
        
    }

    public void DisplayBreathing()
    {
        ReadyMessage();
        bool inOut = true;
        for (int i = GetLoop(5); i > 0; i--)
        {
            if (inOut)
            {
                Menus.PrintSlow("Breath in...");
                Menus.WaitingAnimation();
                Console.Clear();
                inOut = false;
            }
            else
            {
                Menus.PrintSlow("Breath out...");
                Menus.WaitingAnimation();
                Console.Clear();
                inOut = true;
            }
        }
    }
}