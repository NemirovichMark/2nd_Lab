using System;
using System.ComponentModel.DataAnnotations;

class Homew3lvl1
{
    static void Main()
    {
        #region Level1 task4
        Console.WriteLine("a ->");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("b ->");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("c ->");
        double c = Convert.ToDouble(Console.ReadLine());
        double min,max;
        if (a < b) min = a;
        else min = b;
        if (min > c) max = min;
        else max = c;
        Console.WriteLine($"z = max(min(a,b),c) = {max}");
        #endregion
        #region Level1 task10
        Console.WriteLine("введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;
        if (x <= -1) y = 1;
        else if ((x > -1) && (x <= 1)) y = -x;
        else y = -1;
        Console.WriteLine($"y -> {y}");
        #endregion

    }
}
