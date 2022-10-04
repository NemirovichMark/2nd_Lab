using System;

namespace LaboratoryL3N11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double avg = 0;
            int losers = 0;
            while (true)
            { 
                int f_s = 0;
                double sum = 0;
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"{i} exam: ");
                    string input = Console.ReadLine();
                    bool result = int.TryParse(input, out var a);
                    if (result == false)
                    {
                        Console.WriteLine($"Incorrect data");
                        goto end;
                    }
                    if (a == 2)
                    {
                        f_s += 1;
                    }
                    sum += a;
                }
                avg += (sum / 4);
                n += 1;
                if (f_s > 0)
                {
                    losers += 1;
                }
            }
            
            end:
            avg = (avg / n);
            Console.WriteLine($"Average grade in the group: {avg}\nUnderachievers: {losers}, {n}");
        }
    }
}