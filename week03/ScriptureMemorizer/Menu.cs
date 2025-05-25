

using System.Formats.Asn1;

public class Menu
{
    private string _bookSet;

    public int Difuculty()
    {
        bool on = true;
        int answer = 0;
        while (on)
        {
            Console.WriteLine("What difuculty level would your like?\n1: Easy\n2: Medium\n3: Hard");
            answer = int.Parse(Console.ReadLine());
            if (answer < 1 || answer > 3)
            {
                answer = 0;
                Console.Clear();
                Console.WriteLine("Select a valid option.");
            }
            else
            {
                on = false;
                Console.WriteLine("im here");
            }

        }
        return answer;
    }
    public bool SingleOrMulti()
    {
        bool oneOrMore = false;
        int answer = 0;
        while (answer != 1 || answer != 2)
        {
            Console.WriteLine("Do you want to memorize more than one verse at a time?\n1: Yes\n2: No");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.Clear();
                oneOrMore = true;
                break;
            }
            else if (answer < 1 || answer > 2)
            {
                Console.Clear();
                Console.WriteLine("Select a valid option.");
            }
            else
            {
                Console.Clear();
                oneOrMore = false;
                break;
            }
        }
        return oneOrMore;
    }

    public void BookSetLink(int soulution)
    {
        switch (soulution)
        {
            case 1:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/ot";
                break;
            case 2:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/nt";
                break;
            case 3:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/bofm";
                break;
            case 4:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/dc-testament";
                break;
            case 5:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/pgp";
                break;
        }
        Console.Clear();
        Console.WriteLine("Go ahead and find your scripture on the churches website.\nThis is so you can copy and past the verse into the program.\n");
        Console.WriteLine("Hold 'Ctrl' and click on the link.");
        Console.WriteLine(_bookSet);
    }
    public int BookSetGet()
    {
        int soulution = 0;
        while (soulution < 1 || soulution > 5)
        {
            Console.WriteLine("What Colection is your scripter in?");
            Console.WriteLine("1: Old Testament\n2: New Testament\n3: Book of Mormon\n4: Doctrine and Covenants\n5: Pearl of Great Price");
            string answer = Console.ReadLine();
            soulution = int.Parse(answer);
            if (soulution < 1 || soulution > 5)
            {
                Console.Clear();
                Console.WriteLine("Select a valid option.");
            }

        }
        return soulution;
    }

    public ScriptureInfo GetInfo(bool singleOrMulti)
    {
        ScriptureInfo info = new ScriptureInfo();
        if (singleOrMulti)
        {
            info.IsMultiVerse = singleOrMulti;
            Console.WriteLine("What is the Book's name?");
            info.Book = Console.ReadLine();
            Console.WriteLine("What is the chapter number?");
            info.Chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your starting verse number?");
            info.StartVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the last verse number?");
            info.EndVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Copy the scripture from the church's web site with 'Ctrl + C'\nThen past it into the console with'Ctrl + Shift + V'\n");
            info.Text = Console.ReadLine();

        }
        else
        {
            info.IsMultiVerse = singleOrMulti;
            Console.WriteLine("What is the Book name?");
            info.Book = Console.ReadLine();
            Console.WriteLine("What is the chapter number?");
            info.Chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the verse number?");
            info.Verse = int.Parse(Console.ReadLine());
            Console.WriteLine("Copy the scripture from the church's web site with 'Ctrl + C'\nThen past it into the console with'Ctrl + Shift + V'\n");
            Console.WriteLine();
            Console.WriteLine("What is the entier content of the verse?");
            info.Text = Console.ReadLine();
            
        }
        return info;
    }
}