using System;
using System.Net;

// added the process of finding any scripture you want
// by giving the user links the all of the churches doctorin books
//also added menu systems for navagation
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Menu menu = new Menu();
        Reference reference;
        bool singleOrMulti = menu.SingleOrMulti();
        menu.BookSetLink(menu.BookSetGet());
        ScriptureInfo info = menu.GetInfo(singleOrMulti);
        // ScriptureInfo info = new ScriptureInfo();
        // info.Book = "Mormon";
        // info.Chapter = 25;
        // info.Verse = 14;
        // info.Text = "hello this is very awesom and i can to so many difrent things in hear, why dont we try them all out.";
        if (singleOrMulti)
        {
            reference = new Reference(info.Book, info.Chapter, info.StartVerse, info.EndVerse);
        }
        else
        {
            reference = new Reference(info.Book, info.Chapter, info.Verse);
        }

        int amountToHide = menu.Difuculty();
        Scripture scripture = new Scripture(reference, info.Text);
        string input = "";
        while (input != "Quit")
        {
            Console.Clear();
            scripture.HideRandomWords(amountToHide);
            scripture.DisplayAll();
            Console.WriteLine("Press 'Enter' for more hidden words.\nType 'Quit' to exit.");
            input = Console.ReadLine();
        }

    }
}