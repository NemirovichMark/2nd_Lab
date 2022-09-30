using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine(Math.Max(Math.Min(a, b), c));
    }
}