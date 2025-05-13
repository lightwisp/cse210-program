using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<float> numbers;
        numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int inpute = -1;
        while (inpute != 0)
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            inpute = int.Parse(answer);

            if (inpute == 0)
            {
                break;
            }
            else
            {
                numbers.Add(inpute);
            }
        }

        float total = 0;
        float larg_num = 0;
        foreach (float num in numbers)
        {
            total = total + num;
            if (larg_num < num)
            {
                larg_num = num;
            }
        }

        float avrage = total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avrage.ToString("F4")}");
        Console.WriteLine($"The largest number is: {larg_num}");

    }
}