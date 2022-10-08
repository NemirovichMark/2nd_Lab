using System;

namespace LaboratoryL3N4
{
    class Program
    {
        static bool inside(double x, double y, double r_1, double r_2)
        {
            return (((x * x) + (y * y) >= r_1) && ((x * x) + (y * y) <= r_2));  
        }
        static int Main(string[] args)
        {
            Console.Write("Input r_1: ");
            string input_r1 = Console.ReadLine();
            bool result_1 = double.TryParse(input_r1, out var r_1);
            if (result_1 == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }

            Console.Write("Input r_2: ");
            string input_r2 = Console.ReadLine();
            bool result_2 = double.TryParse(input_r2, out var r_2);
            if (result_2 == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }

            int ans = 0;

            while (true)
            {
                Console.Write("Input x: ");
                string input_x = Console.ReadLine();
                bool result_x = double.TryParse(input_x, out var x);
                if (result_x == false)
                {
                    Console.WriteLine($"Incorrect data");
                    goto end;
                }

                Console.Write("Input y: ");
                string input_y = Console.ReadLine();
                bool result_y = double.TryParse(input_y, out var y);
                if (result_y == false) //I do not like those huge inputs ._. 
                {
                    Console.WriteLine($"Incorrect data");
                    goto end;
                }
                
                if (inside(x,y,r_1,r_2) == true)
                {
                    ans += 1;
                }
            }
            
            end:
            Console.WriteLine($"{ans} dots inside the ring");
            return 0;
        }
    }
}