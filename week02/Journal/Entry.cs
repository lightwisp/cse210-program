
public class Entry
{   static DateTime now = DateTime.Now;
    public string _curentDate;
    public string _passage;
    public string _prompt;

    public string SetDate()
    {
        string date = now.ToShortDateString();
        return date;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_curentDate}\nPrompt: {_prompt}\n{_passage}");
    }
}