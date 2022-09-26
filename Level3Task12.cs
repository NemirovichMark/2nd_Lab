using System;
using System.Diagnostics;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double proverka = 0;
        double S = 0;
        double r;
        string strf;
        double t = 1;
        Console.WriteLine("To finish the input, write 'END' instead of any of the number of figure.");
        while (proverka == 0)
        {
            Console.WriteLine("The Figure number: " + t);
            Console.WriteLine("The area of which figure do you want to know?");
            Console.WriteLine("1)Square.");
            Console.WriteLine("2)Circle.");
            Console.WriteLine("3)Equilateral triangl.");
            Console.WriteLine("Enter the number:");
            strf = Console.ReadLine();
            if (strf == "END") break;
            else
            {
                if (strf == "1")
                {
                    Console.WriteLine("Enter the side of the square:");
                    r = Convert.ToDouble(Console.ReadLine());
                    S = r * r;
                }
                if (strf == "2")
                {
                    Console.WriteLine("Enter the radius of the circle:");
                    r = Convert.ToDouble(Console.ReadLine());
                    S = r * r * Math.PI;
                }
                if (strf == "3")
                {
                    Console.WriteLine("Enter the side of the equilateral triangle:");
                    r = Convert.ToDouble(Console.ReadLine());
                    S = r * r * Math.Sqrt(3) / 4;
                }
                Console.WriteLine("The area of figure number " + t + ": " + S);
                Console.WriteLine();
            }
            t++;
        } 
        return 0;
    }
}