using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double proverka = 0;
        Console.WriteLine("Enter a small radius:");
        double rad1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a larger radius:");
        double rad2 = Convert.ToDouble(Console.ReadLine());
        double count = 0;
        double x = 0;
        double y = 0;
        string strx;
        string stry;
        double gipotinusa = 0;
        Console.WriteLine("To finish the input, write 'END' instead of any of the coordinates.");
        while (proverka == 0)
        {
            Console.WriteLine("Enter the coordinate 'X': ");
            strx = Console.ReadLine();
            if (strx == "END") break;
            else
            {
                x = Convert.ToDouble(strx);
            }
            Console.WriteLine("Enter the coordinate 'Y': ");
            stry = Console.ReadLine();
            if (stry == "END") break;
            else
            {
                y = Convert.ToDouble(stry);
            }
            gipotinusa = Math.Sqrt(x * x + y * y);
            if (gipotinusa >= rad1 && gipotinusa <= rad2) count++;

        }
        Console.WriteLine("Number of points in the ring: " + count);
        return 0;
    }
}