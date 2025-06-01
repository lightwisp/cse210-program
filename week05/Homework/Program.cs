using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assingment assingment = new Assingment("Dylan", "Math");
        Console.WriteLine();
        Console.WriteLine(assingment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Algibra", "2*X = X/2", "Sammy Brenard");
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("How the Wilobys roll", "Brandon Miles", "Biography");
        Console.WriteLine();
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}