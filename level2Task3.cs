using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the number of students: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double countJirnii = 0;
        Console.WriteLine("Enter Weight of Students: ");
        for (int i=0; i<n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= 30) {countJirnii++;}
        }
        if (countJirnii == 0)
        {
            Console.WriteLine("No milk needed");
        }
        else
        {
            Console.WriteLine("You need " + countJirnii*0.2 + " liters of milk.");
        }
        return 0;
    }
}