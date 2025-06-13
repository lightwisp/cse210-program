
public class UserProfile
{
    private static int _totalPoints;
    private static int _xp;
    private static int _xpToLvl = 100;
    private static int _lvl;
    // if quest is completed apend to completed quests
    static string fileName = Menu.GetFilePath();
    public UserProfile()
    {

        using (StreamReader reader = new StreamReader(fileName))
        {
            string[] line = reader.ReadLine().Split("*");
            _totalPoints = int.Parse(line[0]);
            _xp = int.Parse(line[1]);
            _lvl = int.Parse(line[2]);
        }
    }
    public static void ShowProfileCard(List<Quest> goalData)
    {
        Menu.PrintSlow("Complead Quests:");
        ShowCompleted(goalData);
        Console.WriteLine();
        ProfileCard();

    }
    public static void ShowCompleted(List<Quest> goalData)
    {
        Menu.CompletedGoals(goalData);
    }
    public static void ProfileCard()
    {
        List<string> card = new List<string>();
        card.AddRange(new[]
        {
            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
            $" Total Points: {_totalPoints}    ",
            $" Curent Level: {_lvl}            ",
            $" Xp: {_xp} / {_xpToLvl}          ",
            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
        });
        foreach (string item in card)
        {
            Menu.PrintSlow(item, 2);
        }
    }
    public static void ShowPoints()
    {
        Menu.PrintSlow($"{_totalPoints}");
    }
    public static void AddPoints(int points)
    {
        _totalPoints += points;
        _xp += 10;
        while (_xp >= _xpToLvl)
        {
            _xp = _xp - _xpToLvl;
            _lvl += 1;
        }

        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length > 0)
        {
            lines[0] = $"{_totalPoints}*{_xp}*{_lvl}";
            File.WriteAllLines(fileName, lines);
        }
    }
    public static string GetStringRepresentation()
    {
        string userData = $"{_totalPoints}*{_xp}*{_lvl}";
        return userData;
    }
}