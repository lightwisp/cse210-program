using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcom to your DOOOOOOOOOOOMMMm!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your full name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorit number?");
        string fave_number = Console.ReadLine();
        int number = int.Parse(fave_number);
        return number;
    }

    static int SquareNumber(int number)
    {
        int sqrd_num = number * number;
        
        return sqrd_num;
        
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the suuare of your number is {square}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name,square);
    }
}