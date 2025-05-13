using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
         string letter = "";
        
        Console.WriteLine("What is your grad percent?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        if (grade >= 90)
        {
            letter = "A";   
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you have passed");
        }
        else
        {
            Console.WriteLine("Faild. Try again.");
        }
    }
}