using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Lvl_1
            { 
            #region Num_1
            double r = 2;
            if ((double.TryParse(Console.ReadLine(), out double x)) && (double.TryParse(Console.ReadLine(), out double y)))
            {
                if (Math.Abs(x * x + y * y - r * r) <= 0.001)
                {
                    Console.WriteLine("included");
                }
                else
                {
                    Console.WriteLine("not included");
                }
            }
            else
            {
                Console.WriteLine("Ooops... Error");
            }
            #endregion
            }
            { 
            #region Num_3
            if ((double.TryParse(Console.ReadLine(), out double a)) && (double.TryParse(Console.ReadLine(), out double b)))
            {
                if (a > 0)
                {
                    Console.WriteLine($"c = {Math.Max(a, b)}");
                }
                else
                {
                    Console.WriteLine($"c = {Math.Min(a, b)}");
                }
            }
            #endregion
            }
            #endregion

            #region Lvl_2
            { 
            #region Num_1
            double s = 0;
            if ((Int32.TryParse(Console.ReadLine(), out int n)))
            {
                for (int i = 1; i <= n; ++i)
                {
                    if ((double.TryParse(Console.ReadLine(), out  double height)) && (height > 0))
                    {
                        s += height;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.WriteLine($"avg_height = {s / n}");
            }
            else
            {
                Console.WriteLine("Error, repeat again");
            }
            }
            #endregion

            { 
            #region Num_3
            double glass = 0.2;
            double liters = 0;
            if ((Int32.TryParse(Console.ReadLine(), out int n)))
            {
                for (int i = 1; i <= n; ++i)
                {
                    if ((double.TryParse(Console.ReadLine(), out double weight)) && (weight < 30))
                    {
                        liters += glass;
                    }
                    else
                    {
                        Console.WriteLine("Bez_Dobavki(");
                    }
                }
                Console.WriteLine($"need liters = {Math.Round(liters, 2)}");
            }
            #endregion
            }
            #endregion
            
            #region Lvl_3

            #region Num_4
            double rad1, rad2;
            double x, y;
            int included = 0;
            Console.WriteLine("enter inner ring");
            if(!double.TryParse(Console.ReadLine(), out rad1))
            {
                Console.WriteLine("wrong value");
                return;
            }
            Console.WriteLine("enter outer ring");
            if(!double.TryParse(Console.ReadLine(), out rad2))
            {
                Console.WriteLine("wrong value");
                return;
            }
                if ((rad1 < 0 || rad2 < 0) || (rad1 > rad2))
                {
                    Console.WriteLine("incorrect value");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("enter 9999 to end");
                        Console.WriteLine("enter x");
                        if(!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("wrong value");
                        return;
                    }
                        if (x == 9999) break;
                        Console.WriteLine("enter y");
                        if(!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("wrong value");
                        return;
                    }
                        if (x*x + y*y > rad1*rad1 || x*x + y*y < rad2 * rad2)
                        {
                            ++included;
                        }
                    }
                }
                Console.WriteLine($"inxluded = {included}");
            #endregion
            
            #region Num_11
            int n = 0;
            int sum_strong_dudes = 0;
            int weak_dudes = 0;
            int first_ex, second_ex, third_ex, fourth_ex;
            Console.WriteLine("enter -1 to end");
            while (true)
            {
                Console.WriteLine("enter rez 1st_ex");
                if(!int.TryParse(Console.ReadLine(), out first_ex))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                if (first_ex == -1) break;
                Console.WriteLine("enter rez 2nd_ex");
                if(!int.TryParse(Console.ReadLine(), out second_ex))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                if (second_ex == -1) break;
                Console.WriteLine("enter rez 3rd_ex");
                if(!int.TryParse(Console.ReadLine(), out third_ex))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                if (third_ex == -1) break;
                Console.WriteLine("enter rez 4th_ex");
                if(!int.TryParse(Console.ReadLine(), out fourth_ex))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                if (fourth_ex == -1) break;
                if ((first_ex < 2 && first_ex > 5) || (second_ex < 2 && second_ex > 5) || (third_ex < 2 && third_ex > 5) || (fourth_ex < 2 && fourth_ex > 5))
                { 
                    Console.WriteLine("wrong rez exam");
                }
                else
                {
                    if (first_ex > 2 && second_ex > 2 && third_ex > 2 && fourth_ex > 2)
                    {
                        ++n;
                        sum_strong_dudes += first_ex + second_ex + third_ex + fourth_ex;
                    }
                    else
                    {
                        ++weak_dudes;
                    }
                }
            }
            Console.WriteLine($"losers = {weak_dudes}, avg_rez = {(double)sum_strong_dudes / (n * 4)}");
                
            #endregion
           
            #region Num_12
            double r;
            int selection;
            Console.WriteLine("enter stop to end");
            while (true)
            {
                Console.WriteLine("enter r");
                if(!double.TryParse(Console.ReadLine(), out r))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                bool comeback = false;
                while (!comeback)
                {
                Console.WriteLine("enter 1 for calculated square area");
                Console.WriteLine("enter 2 for calculated square circle");
                Console.WriteLine("enter 3 for calculated square triangle");
                if(!int.TryParse(Console.ReadLine(), out selection))
                    {
                        Console.WriteLine("wrong value");
                    }
                    comeback = true;
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"square area = {r*r}");
                            break;
                        case 2:
                            Console.WriteLine($"square circle = {Math.PI * (r*r)}");
                            break;
                        case 3:
                            Console.WriteLine($"square triangle = {(Math.Sqrt(3) * (r*r)) / 4}");
                            break;
                        default:
                            Console.WriteLine("enter only 1,2,3 pls");
                            break;
                    }
                }
            }
            #endregion
            #region Num_13
            double a, b;
            int selection;
            Console.WriteLine("enter stop to end");
            while (true)
            {
                Console.WriteLine("enter a");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                Console.WriteLine("enter b");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("wrong value");
                    return;
                }
                if (a < 0 || b < 0) break;
                bool repeat = false;
                while (!repeat)
                {
                    Console.WriteLine("enter 1 for calculated rectangle area");
                    Console.WriteLine("enter 2 for calculated ring area");
                    Console.WriteLine("enter 3 for calculated square triangle");
                    if (!int.TryParse(Console.ReadLine(), out selection))
                    {
                        Console.WriteLine("wrong value");
                    }
                    repeat = true;
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"rectangle area = {a * b}");
                            break;
                        case 2:
                            Console.WriteLine($"ring area = {Math.Abs((Math.PI * a * a) - (Math.PI * b * b))}");
                            break;
                        case 3:
                            Console.WriteLine($"square triangle = {a * Math.Sqrt(Math.Abs((b * b - a * a) / 4)) / 2}");
                            break;
                        default:
                            Console.WriteLine("enter only 1,2,3 pls");
                            break;
                    }
                }
            }
            #endregion
            #endregion
        }
    }
}
