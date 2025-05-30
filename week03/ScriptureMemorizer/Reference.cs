
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _verse = start;
        _endVerse = end;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse} - {_endVerse}";
        }
    }

    
}