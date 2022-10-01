using System;

namespace LaboratoryL1N1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dots = {0,2, 1.5,0.7, 1,1, 3,0};
            for (int i = 0; i < dots.Length; i = i + 2)
            {
                    double x = dots[i];
                    double y = dots[i+1];
                    if (((x*x) + (y*y) - 4) <= (1/1000))
                    {
                        Console.WriteLine($"({x} , {y}) on the circle");
                    }
                    else
                    {
                        Console.WriteLine($"({x} , {y}) outside the circle");
                    }
            }
        }
    }
}