using System;

namespace Project
{
    class Programm
    {
        static void Main(string[] args)
        {
            #region Task_1.3
            while (true)
            {
                Console.WriteLine("1.3 Input a: ");
                string input1 = Console.ReadLine();
                bool result1 = float.TryParse(input1, out var a);
                if (!result1)
                {
                    Console.WriteLine("1.3 Incorrect a, try again");
                    continue;
                }
                Console.WriteLine("1.3 Input b: ");
                string input2 = Console.ReadLine();
                bool result2 = float.TryParse(input2, out var b);
                if (!result2)
                {
                    Console.WriteLine("1.3 Incorrect b, try again");
                    continue;
                }
                if (result1 && result2)
                {
                    if (a > 0)
                    {
                        Console.WriteLine($"1.3 Answer: {Math.Max(a, b)}");
                    }
                    else
                    {
                        Console.WriteLine($"1.3 Answer: {Math.Min(a, b)}");
                    }
                    break;
                }
            }
            #endregion
            #region Task_1.4
            while (true)
            {
                Console.WriteLine("1.4 Input a: ");
                string input1 = Console.ReadLine();
                bool result1 = float.TryParse(input1, out var a);
                if (!result1)
                {
                    Console.WriteLine("1.4 Incorrect a, try again");
                    continue;
                }
                Console.WriteLine("1.4 Input b: ");
                string input2 = Console.ReadLine();
                bool result2 = float.TryParse(input2, out var b);
                if (!result2)
                {
                    Console.WriteLine("1.4 Incorrect b, try again");
                    continue;
                }
                Console.WriteLine("1.4 Input c: ");
                string input3 = Console.ReadLine();
                bool result3 = float.TryParse(input3, out var c);
                if (!result3)
                {
                    Console.WriteLine("1.4 Incorrect c, try again");
                    continue;
                }
                if (result1 && result2 && result3)
                {
                    Console.WriteLine($"1.4 Answer: {Math.Max(Math.Min(a, b), c)}");
                    break;
                }
            }
            #endregion
            #region Task_2.1
            while (true)
            {
                int n;
                Console.WriteLine("2.1 Input n: ");
                string input1 = Console.ReadLine();
                bool result1 = int.TryParse(input1, out n);
                if (!result1 || n <= 0)
                {
                    Console.WriteLine("2.1 Incorrect n, try again");
                    continue;
                }
                else
                {
                    double sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("2.1 Input height");
                        string input4 = Console.ReadLine();
                        bool result4 = float.TryParse(input4, out var h);
                        if (!result4 || h <= 0)
                        {
                            Console.WriteLine("2.1 Incorrect height, try again");
                            i -= 1;
                            continue;
                        }
                        sum += h;

                    }
                    Console.WriteLine($"2.1 Answer: {sum / n}");
                    break;
                }
            }
            #endregion
            #region Task_2.5
            Console.WriteLine("2.5 Input: ");
            if (!double.TryParse(Console.ReadLine(), out double norm))
            {
                Console.WriteLine("2.5 Incorrect data, try again");
                return;
            }
            int count = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("2.5 Incorrect data, try again");
                    i--;
                }
                else
                {
                    if (x <= norm)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"2.5 Answer: {count}");
            #endregion
        }
    }    
}
