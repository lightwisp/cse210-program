

public class Menus()
{
    // creat a menu system to navagate between 3 options
    // breathing, reflection, and lisening activitys
    // these are all children on mindfullness
    bool on = true;

    public void MenuRun()
    {
        string activityName;
        string description;
        while (on)
        {
            int userAnswer = MainMenu();

            switch (userAnswer)
            {
                // do breathing activity
                case 1:
                    activityName = "Breathing";
                    description = @"This activity will help you relax by walking you " +
                                    "through breathing in and out slowly." +
                                    "\n\nClear your mind and focus on your breathing.\n";
                    int length = GetActivityDuration(activityName);
                    Console.Clear();
                    Breathing breathing = new Breathing(activityName, description, length);
                    breathing.ActivityMessage();
                    breathing.DisplayBreathing();
                    breathing.PositiveEndMessage();
                    break;
                // do Reflection activity
                case 2:
                    break;
                // do Listing activity
                case 3:
                    break;
                // quit the program    
                case 4:
                    PrintSlow("Good Bye");
                    Environment.Exit(0);
                    break;
                // if user puts in anything other than the 4 options    
                default:
                    PrintSlow("Chose an apropriat number. 1,2,3,4");
                    break;
            }
        }
    }

    private int MainMenu()
    {
        PrintSlow("What activity would you like?\n");
        PrintSlow("1. Breathing Activity\n2. Reflection\n3. List off Gratitude\n4. Quit\n", 10);
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);
        return userAnswer;
    }
    private int GetActivityDuration(string name)
    {
        PrintSlow($"How long of a {name} sesion would you like in seconds?\n");
        string stringAnswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAnswer);
        return userAnswer;
    }
    private int CheckStringToInt(string userInput)
    {
        bool success = int.TryParse(userInput, out int selection);
        if (success)
        {
            return selection;
        }
        else
        {
            return 0;
        }
    }
    private void PrintSlow(string text, int delay = 20)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }


    
}