using System;

namespace LaboratoryL1N3
{
    class Program
    {
        static void c_max(double a, double b)
        {
            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static void c_min(double a, double b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static int Main(string[] args)
        {
            #region inputs

            /*I'm wondering, can i make a function out of this lines? 
            with like any fancy self-written data structure or smth?
            */

            Console.Write("Input a: ");
            string input_1 = Console.ReadLine();
            bool result_1 = double.TryParse(input_1, out var a);
            if (result_1 == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }

            Console.Write("Input b: ");
            string input_2 = Console.ReadLine();
            bool result_2 = double.TryParse(input_2, out var b);
            if (result_2 == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }
            
            #endregion

            if (a > 0)
            {
                c_max(a,b);
            }
            else
            {
                c_min(a,b);
            }
            return 0;
        }
    }
}