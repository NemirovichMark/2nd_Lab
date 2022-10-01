using System;

namespace LaboratoryL2N1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Input n: ");
            string input_n = Console.ReadLine();
            bool result_n = int.TryParse(input_n, out var n);
            if (result_n == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }
            if (n == 0)
            {
                Console.WriteLine("No way");
                return 1;
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Height {i+1}: ");
                string input_height = Console.ReadLine();
                bool result_height = double.TryParse(input_height, out var h);
                if (result_height == false)
                {
                    Console.WriteLine("Incorrect data");
                    Console.WriteLine($"Average height to this moment is: {sum / (i)}");
                    return 1;
                }
                sum += h;
            }
            Console.WriteLine($"Average height is: {sum / n}");
            return 0;
        }
    }
}