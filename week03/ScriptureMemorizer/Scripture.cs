
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> _wordPosition;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _wordPosition = new List<int>();
        Word word;
        string[] splitText = text.Split(' ');
        int i = 0;
        foreach (string w in splitText)
        {
            _words.Add(word = new Word(w));
            _wordPosition.Add(i);
            i++;
        }
        
    }
    public void DisplayAll()
    {
        Console.WriteLine(_reference.GetDisplayText());

        string result = "";
        foreach (var word in _words)
        {
            string display = word.GetDisplayText();

            if (char.IsDigit(display[0]))
            {
                result += "\n" + display + " ";
            }
            else
            {
                result += display + " ";
            }
        }

        Console.WriteLine(result.Trim());
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hidden = 0;
        while (hidden < numberToHide)
        {
            int number = random.Next(_wordPosition.Count());
            int index = _wordPosition[number];
            Word word = _words[index];

            if (word.IsHidden() == false)
            {
                word.Hide();
                string blankWord = word.GetDisplayText();
                _words[index] = new Word(blankWord);
                _wordPosition.RemoveAt(number);
                hidden++;
            }

            if (numberToHide > _wordPosition.Count())
            {
                hidden++;
            }
        }
    }



}