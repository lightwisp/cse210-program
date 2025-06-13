using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        // build a switch case for menu system to oporate through.
        List<Quest> goalData = Menu.LoadSave();
        bool gameOn = true;
        while (gameOn)
        {
            // code for start up gose here    
            UserProfile user = new UserProfile();
            // Load files gose here
            UserProfile.ProfileCard();
            int userAnswer = Menu.MainMenu();
            Console.Clear();
            //switch case for menu systems
            switch (userAnswer)
            {
                //create a new goal
                case 1:
                    Quest quest = Menu.GoalMenu();
                    goalData.Add(quest);
                    
                    break;
                //Show curent goals
                case 2:
                    Menu.ActiveGoals(goalData);
                    break;
                //User progress card display
                case 3:
                    Menu.UserMenu(goalData);
                    break;
                // add progress to quests
                case 4:
                    Menu.AddProgress(goalData);
                    Menu.SaveExit(goalData);
                    break;
                //Remove active goals
                case 5:
                    Menu.DeletQuest(goalData);
                    break;
                // save & quit program
                case 6:
                    Menu.PrintSlow("Saving New Data...", 50);
                    Menu.SaveExit(goalData);
                    Thread.Sleep(1000);
                    Menu.PrintSlow("Saved!");
                    Menu.PrintSlow("Good Bye...", 30);
                    Environment.Exit(0);
                    break;
                // catch for if uses typs somthing out of bounds
                default:
                    Menu.PrintSlow("Please chose an apropriat option.");
                    break;
            }
        }
    }
}