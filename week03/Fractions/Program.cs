using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction01 = new Fraction();
        Fraction fraction02 = new Fraction(6);
        Fraction fraction03 = new Fraction(5, 2);

        fraction01.SetTop(1);
        fraction01.SetBottom(1);
        Console.WriteLine(fraction01.GetFractionString());
        Console.WriteLine(fraction01.GetDecimalValue());

        fraction01.SetTop(5);
        fraction01.SetBottom(1);
        Console.WriteLine(fraction01.GetFractionString());
        Console.WriteLine(fraction01.GetDecimalValue());

        fraction01.SetTop(3);
        fraction01.SetBottom(4);
        Console.WriteLine(fraction01.GetFractionString());
        Console.WriteLine(fraction01.GetDecimalValue());

        fraction01.SetTop(1);
        fraction01.SetBottom(3);
        Console.WriteLine(fraction01.GetFractionString());
        Console.WriteLine(fraction01.GetDecimalValue());
    }
}