
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void DisplayEntrys()
    {
        foreach (Entry line in _entries)
        {
            line.DisplayEntry();
        }
    }

    public void ClearCash()
    {
        _entries.Clear();
    }

    
}