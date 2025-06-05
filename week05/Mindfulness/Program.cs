using System;

class Program
{
    // the etra stuf i added outside of requierments. i added a text animation for all descriptions.
    // like a type writer afect.
    // i added a Menu class that holds all of the functiuons needed for animations, genarice text diolog,
    // and checks to see if the user typs in the corect switch case.
    // probably could have writen this in Program but i think it looks cleaner.
    // also added a uique waiting animations that uses "\r" + List to clear the line and then write over it.
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menus menus = new Menus();
        menus.MenuRun();
    }
}