// menu system for the questing program

public class Menu()
{
    public static int MainMenu()
    {
        //this will be the base menu for user decisions
        PrintSlow("Menu Options:\n  1: Creat new Goal\n  2: Show Curent Goals\n  3: User Progress Card\n  4: Remove Goal\n  5: Quit");
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);
        return userAnswer;
    }
    public static Quest GoalMenu()
    {
        //menu for creating a new goal that lets user decide what goal they want
        return null;
    }
    public static void UserMenu()
    {
        //gets user states for compleated quests levle, progress, name card
        //this might need more function for the idea to work
    }
    public static void AddProgress()
    {
        //menu to add progress to curent goals and add points to the user
    }
    public static void ActiveGoals()
    {
        //menu to show progress on active goals
    }
    public static void LevelMenu()
    {
        //menu for when the user levels up
    }
    public static void SaveData()
    {
        //Save progress of user
        //want this to auto save on aplication close.
    }
    public static void LoadSave()
    {
        //Gets user info
        //want to auto load on aplication start up.
    }
    //makes text use typwriter feel
    public static void PrintSlow(string text, int delay = 10)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
    //used for user input in menu system to see if it is int
    private static int CheckStringToInt(string userInput)
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
}