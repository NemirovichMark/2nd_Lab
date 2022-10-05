using System;

namespace LaboratoryL3N11
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 0;
            double avg = 0;
            int losers = 0;
            bool flag = true;
            while (true)
            { 
                int f_s = 0;
                double sum = 0;
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"{i} exam: ");
                    string input = Console.ReadLine();
                    bool result = int.TryParse(input, out var a);
                    if (((result == false) || ((a < 2) || (a > 5))) == true)
                    {
                        Console.WriteLine($"Incorrect data");
                        if (n == 0)
                        {
                            Console.WriteLine($"Average grade to this moment: 0");
                        }
                        else
                        {
                            Console.WriteLine($"Average grade to this moment: {avg = (avg / n)}");
                        }
                        return 1;
                    }
                    if (a == 2)
                    {
                        f_s += 1;
                    }
                    sum += a;
                }
                if (f_s > 0)
                {
                    losers += 1;
                    continue;
                }
                avg += (sum / 4);
                n += 1;
            }
        }
    }
}