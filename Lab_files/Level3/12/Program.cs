using System;

namespace LaboratoryL3N12
{
    class Program
    {
        static void triangle(double r)
        {
            double s;
            double root = (1 / 2);
            s = ((Math.Pow(3, root) * Math.Pow(r, 2)) / 4);
            Console.WriteLine($"Triangle area: {s}");
        }

        static void circle(double r)
        {
            double s;
            s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Circle area: {s}");
        }

        static void square(double r)
        {
            Console.WriteLine($"Square area: {Math.Pow(r, 2)}");
        }

        static int Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input r: ");
                string input_r = Console.ReadLine();
                bool result_r = double.TryParse(input_r, out var r);
                if (!result_r)
                {
                    Console.WriteLine("Incorrect data");
                    return 1;
                }
                
                Console.WriteLine("Program number: ");
                string input_n = Console.ReadLine();
                bool result_n = int.TryParse(input_n, out var n);
                if (result_n == false)
                {
                    Console.WriteLine("Incorrect data");
                    return 1;
                }
                
                switch (n)
                {
                    case 1:
                        square(r);
                        break;
                    case 2:
                        circle(r);
                        break;
                    case 3:
                        triangle(r);
                        break;
                    default:
                        Console.WriteLine("Usage: n should be an integer from 1 to 3");
                        return 1;
                }
            }
        }
    }
}