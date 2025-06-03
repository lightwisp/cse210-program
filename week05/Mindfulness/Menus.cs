

public class Menus()
{
    // creat a menu system to navagate between 3 options
    // breathing, reflection, and lisening activitys
    // these are all children on mindfullness
    private bool on = true;
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
                    description = "This activity will help you relax by walking you " +
                                    "through breathing in and out slowly." +
                                    "\n\nClear your mind and focus on your breathing.\n";
                    Console.Clear();
                    Breathing breathing = new Breathing(activityName, description, GetActivityDuration(activityName));
                    breathing.ActivityMessage();
                    breathing.DisplayBreathing();
                    breathing.PositiveEndMessage();
                    break;
                // do Reflection activity
                case 2:
                    activityName = "Reflection";
                    description = "This activity will help you reflect on times in your " +
                                  "life when you have shown strength and resilience." +
                                  "\nThis will help you recognize the power you have and " +
                                  "how you can use it in other aspects of your life.";
                    Console.Clear();
                    Reflection reflection = new Reflection(activityName, description, GetActivityDuration(activityName));
                    reflection.ActivityMessage();
                    reflection.DisplayQuestions();
                    reflection.PositiveEndMessage();
                    break;
                // do Listing activity
                case 3:
                    activityName = "Listing";
                    description = "This activity will help you reflect on the good things in your life by having you" +
                    " list as many things as you can in a certain area.";
                    Console.Clear();
                    Listing listing = new Listing(activityName, description, GetActivityDuration(activityName));
                    listing.ActivityMessage();
                    
                    listing.PositiveEndMessage();
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
    public static void PrintSlow(string text, int delay = 20)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
    public static void WaitingAnimation(int length = 5)
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
            Thread.Sleep(100);

            i++;
            if (i >= _animations.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }
}