using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double s = Convert.ToDouble(Console.ReadLine()); 
        double diametr = Math.Sqrt(r / Math.PI);
        double diagonal = Math.Sqrt(s * 2);
        if (diametr <= diagonal)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}