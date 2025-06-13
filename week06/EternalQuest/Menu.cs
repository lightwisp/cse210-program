// menu system for the questing program
using System.Formats.Asn1;
using System.Reflection;
public class Menu()
{
    static string oldFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    static string  filePath = oldFolderPath.Replace(@"\bin\Debug\net8.0", "");
    private string[] files = Directory.GetFiles(filePath, "*.csv");
    private static string fileName = filePath + @"\" + "SaveData.txt";
    public static int MainMenu()
    {
        //this will be the base menu for user decisions
        PrintSlow("Menu Options:\n  1: Creat new Goal\n  2: Show Curent Goals\n  3: User Progress Card\n  4: Add Progress\n  5: Remove Goal\n  6: Save & Quit");
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);
        return userAnswer;
    }
    // menu for selecting goal creation
    public static Quest GoalMenu()
    {
        //menu for creating a new goal that lets user decide what goal they want
        PrintSlow("What Goal would you like to make?\n 1: Simple Goal\n 2: Eternal Goal\n 3: Multi Goal\n 4: Go Back", 2);
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);

        switch (userAnswer)
        {
            // make a simple quest
            case 1:
                PrintSlow("What is the name if your goal?",2);
                string name = Console.ReadLine();
                PrintSlow("What is your description of the goal?",2);
                string description = Console.ReadLine();
                PrintSlow("How Many Points is this worth?",2);
                int points = int.Parse(Console.ReadLine());
                SimpleQuest s = new SimpleQuest(name, description, points, false);
                return s;
            // make an eternal quest
            case 2:
                PrintSlow("What is the name if your goal?");
                name = Console.ReadLine();
                PrintSlow("What is your description of the goal?");
                description = Console.ReadLine();
                PrintSlow("How Many Points is this worth?");
                points = int.Parse(Console.ReadLine());
                EternalQuest e = new EternalQuest(name, description, points);
                return e;
            //make multi quest
            case 3:
                PrintSlow("What is the name if your goal?");
                name = Console.ReadLine();
                PrintSlow("What is your description of the goal?");
                description = Console.ReadLine();
                PrintSlow("How Many Points is this worth?");
                points = int.Parse(Console.ReadLine());
                PrintSlow("How many times would you like to do this?");
                int target = int.Parse(Console.ReadLine());
                PrintSlow("How many bonus points for compleating this chalange?");
                int bPoints = int.Parse(Console.ReadLine());
                MultiQuest m = new MultiQuest(name, description, points, target, 0, bPoints);
                return m;
            // returns user to Main Menu
            case 4:
                return null;
            default:
                PrintSlow("Chose a proper number. 1, 2, 3.");
                return null;
        }

    }
    public static void UserMenu(List<Quest> goalData)
    {
        //gets user states for compleated quests levle, progress, name card
        //this might need more function for the idea to work
        UserProfile.ShowProfileCard(goalData);
    }
    public static void AddProgress(List<Quest> goalData)
    {
        //menu to add progress to curent goals and add points to the user
        List<Quest> notDone = ActiveGoals(goalData);
        PrintSlow("What goal have you made progress on?");
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);
        if (userAnswer == 0)
        {
            return;
        }
        else
        {
            Quest name = notDone[userAnswer - 1];
            int loop = 0;
            foreach (Quest goal in goalData)
            {
                if (goal == name)
                {
                    goalData[loop].RecordEvent();
                }
                loop++;
            }
        }
    }
    public static void CompletedGoals(List<Quest> goalData)
    {
        int loop = 1;
        foreach (Quest goal in goalData)
        {
            if (goal.IsComplete())
            {
                PrintSlow($"{loop}. " + goal.PrintQuestDetails());
                loop++;
            }
        }
    }
    public static List<Quest> ActiveGoals(List<Quest> goalData)
    {
        //menu to show progress on active goals
        List<Quest> notFinished = new List<Quest>();
        int loop = 1;
        foreach (Quest goal in goalData)
        {
            if (!goal.IsComplete())
            {
                notFinished.Add(goal);
                PrintSlow($"{loop}. " + goal.PrintQuestDetails());
                loop++;
            }
        }
        return notFinished;
    }
    public static void DeletQuest(List<Quest> goalData)
    {
        List<Quest> notDone = ActiveGoals(goalData);
        PrintSlow("What goal would you like to remove?");
        string stringAswer = Console.ReadLine();
        int userAnswer = CheckStringToInt(stringAswer);

        if (userAnswer == 0 || userAnswer > notDone.Count)
        {
            return;
        }

        Quest name = notDone[userAnswer - 1];

        for (int i = 0; i < goalData.Count; i++)
        {
            if (goalData[i] == name)
            {
                goalData.RemoveAt(i);
                break;  // Only remove the first match, then exit
            }
        }
    }

    public static void SaveNewQuest(Quest quest)
    {
        //Save progress of user
        //want this to auto save on aplication close.

        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            outputFile.WriteLine(quest.GetStringRepresentation());
        }
    }
    public static void SaveExit(List<Quest> goalData)
    {
        List<string> newLines = new List<string>();

        // Add updated first line
        newLines.Add(UserProfile.GetStringRepresentation());

        // Add updated goal lines
        foreach (Quest goal in goalData)
        {
            newLines.Add(goal.GetStringRepresentation());
        }

        // Overwrite entire file at once
        File.WriteAllLines(fileName, newLines);
    }

    public static List<Quest> LoadSave()
    {
        //Gets user info
        //want to auto load on aplication start up.
        string[] lines = System.IO.File.ReadAllLines(fileName);

        List<Quest> goalData = new List<Quest>();

        //call function to set user data points.
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("*");
            string questName = parts[0];
            if (questName == "SimpleQuest")
            {
                SimpleQuest s = new SimpleQuest(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goalData.Add(s);
            }
            else if (questName == "EternalQuest")
            {
                //name, description
                EternalQuest e = new EternalQuest(parts[1], parts[2], int.Parse(parts[3]));
                goalData.Add(e);
            }
            else if (questName == "MultiQuest")
            {
                //name, description, points, target amount, amount compleated, bonus points
                MultiQuest m = new MultiQuest(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                goalData.Add(m);
            }
        }
        return goalData;
    }
    public static string GetFilePath()
    {
        string fileName = filePath + @"\" + "SaveData.txt";
        return fileName;
    }
    //makes text use typwriter feel
    public static void PrintSlow(string text, int delay = 2)
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