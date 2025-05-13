using System;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string answer= "";
        int int_answer = 0;

        Random random = new Random();
        int randNum =random.Next(1, 100);

        Console.WriteLine("Try and guess my magic number.");

        int repCounter = 0;
        while (int_answer != randNum)
        {
            repCounter++;

            Console.Write("What is your guess? ");
            answer = Console.ReadLine();
            int_answer = int.Parse(answer);
            if (int_answer > randNum)
            {
                Console.WriteLine("Lower");
            }
            else if (int_answer < randNum)
            {
                Console.WriteLine("Higher");
            }
            else if (int_answer == randNum)
            {
                Console.WriteLine("You have guessed the magic number!");
                Console.WriteLine($"You guessed {repCounter} times.");
            }
        }

    }
}