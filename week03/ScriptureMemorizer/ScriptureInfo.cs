
public class ScriptureInfo
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int StartVerse { get; set; }  // For multi-verse
    public int EndVerse { get; set; }    // For multi-verse
    public int Verse { get; set; }       // For single verse
    public string Text { get; set; }
    public bool IsMultiVerse { get; set; }
}