using System;
using System.Diagnostics;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double proverka = 0;
        double S = 0;
        double A;
        double B;
        string strf;
        double t = 1;
        Console.WriteLine("To finish the input, write 'END' instead of any of the number of figure.");
        while (proverka == 0)
        {
            Console.WriteLine("The Figure number: " + t);
            Console.WriteLine("The area of which figure do you want to know?");
            Console.WriteLine("1)Rectangle.");
            Console.WriteLine("2)Ring.");
            Console.WriteLine("3)Isosceles triangle.");
            Console.WriteLine("Enter the number:");
            strf = Console.ReadLine();
            if (strf == "END") break;
            else
            {
                if (strf == "1")
                {
                    Console.WriteLine("Enter the first side of the rectangle:");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second side of the rectangle:");
                    B = Convert.ToDouble(Console.ReadLine());
                    S = A * B;
                }
                if (strf == "2")
                {
                    Console.WriteLine("Enter the radius of a smaller circle:");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the radius of a larger circle:");
                    B = Convert.ToDouble(Console.ReadLine());
                    S = B * B * Math.PI - A * A * Math.PI;
                }
                if (strf == "3")
                {
                    Console.WriteLine("Enter the first side of the isosceles triangle:");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second side of the isosceles triangle:");
                    B = Convert.ToDouble(Console.ReadLine());
                    S = A * Math.Sqrt(4 * B * B - A * A)/4;
                }
                Console.WriteLine("The area of figure number " + t + ": " + S);
                Console.WriteLine();
            }
            t++;
        } 
        return 0;
    }
}