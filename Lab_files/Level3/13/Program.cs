using System;

namespace LaboratoryL3N13
{
    class Program
    {
        static void rectangle(double a, double b)
        {
            Console.WriteLine($"Rectangle area: {a*b}");
        }

        static void ring(double a, double b)
        {
            double first, second;
            first = Math.PI * Math.Pow(a, 2);
            second = Math.PI * Math.Pow(b, 2);
            Console.WriteLine($"Ring area: {Math.Abs(first - second)}");
        }

        static void triangle(double a, double b)
        {
            double root = (1 / 2);
            double p = a+b+b;
            double heron = (p * (p - a) * (p - b) * (p - b));
            Console.WriteLine($"Triangle area: {Math.Pow(heron, root)}");
        }

        static int Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Program number: ");
                string input_n = Console.ReadLine();
                bool result_n = int.TryParse(input_n, out var n);
                if (result_n == false)
                {
                    Console.WriteLine("Incorrect data");
                    return 1;
                }

                Console.WriteLine("Input a: ");
                string input_a = Console.ReadLine();
                bool result_a = double.TryParse(input_a, out var a);
                if (!result_a)
                {
                    Console.WriteLine("Incorrect data");
                    return 1;
                }
                
                Console.WriteLine("Input b: ");
                string input_b = Console.ReadLine();
                bool result_b = int.TryParse(input_b, out var b);
                if (result_b == false)
                {
                    Console.WriteLine("Incorrect data");
                    return 1;
                }
                
                switch (n)
                {
                    case 1:
                        rectangle(a, b);
                        break;
                    case 2:
                        ring(a, b);
                        break;
                    case 3:
                        triangle(a, b);
                        break;
                    default:
                        Console.WriteLine("Usage: n should be an integer from 1 to 3");
                        return 1;
                }
            }
        }
    }
}