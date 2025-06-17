using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> list = new List<Activity>();
        Running running = new Running(5, 1.2);
        Cycling cycling = new Cycling(15.3, 6);
        Swimming swimming = new Swimming(3, 4);

        list.AddRange([running, cycling, swimming]);

        foreach (Activity item in list)
        {
            Console.WriteLine(item.DisplayActivity());
        }
    }
}