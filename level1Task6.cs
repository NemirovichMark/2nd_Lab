using System;
using System.Globalization;

class Program
{
    static int Main()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double s = Convert.ToDouble(Console.ReadLine());
        if (r < 0) {Console.WriteLine("r must not be less than zero"); return 0; }
        if (s < 0) {Console.WriteLine("s must not be less than zero"); return 0; }
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
        return 0;
    }
}
