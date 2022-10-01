using System;

namespace _2nd_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1.1
            Console.WriteLine("Level 1 Task 1");

            double x, y;
            int r = 2;
            while (true)
            {
                Console.WriteLine("    Please enter x:");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("    Wrong x, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter y:");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("    Wrong y, please try again");
                    continue;
                }
                break;
            }
            double e = 0.001;
            if (Math.Abs(x * x + y * y - r * r) <= e)
            {
                Console.WriteLine("    The point lies on the circle");
            }
            else
            {
                Console.WriteLine("    The point doesn't lie on the circle");
            }
            #endregion
            #region task 1.2
            Console.WriteLine("Level 1 Task 2");

            double x, y;
            while (true)
            {
                Console.WriteLine("    Please enter x:");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("    Wrong x, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter y:");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("    Wrong y, please try again");
                    continue;
                }
                break;
            }
            if (y >= 0 && y + Math.Abs(x) <= 1)
            {
                Console.WriteLine("    The point is inside of the triangle");
            }
            else
            {
                Console.WriteLine("    The point is outside of the triangle");
            }
            #endregion
            #region task 1.3
            Console.WriteLine("Level 1 Task 3");

            double a, b;
            while (true)
            {
                Console.WriteLine("    Please enter a:");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong a, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter b:");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("    Wrong y, please try again");
                    continue;
                }
                break;
            }
            if (a > 0)
            {
                Console.WriteLine($"    Maximum value = {Math.Max(a, b)}");
            }
            else
            {
                Console.WriteLine($"    Minimum value = {Math.Min(a, b)}");
            }
            #endregion
            #region task 2.1
            Console.WriteLine("Level 2 Task 1");

            double n, height;
            double s = 0;
            while (true)
            {
                Console.WriteLine("    Please enter n:");
                if (!double.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }
            for (int i = 1; i <= n; i++)
            {
                while (true)
                {
                    Console.WriteLine($"    Please enter the height of the {i} pupil in centimeteres.");
                    if (!double.TryParse(Console.ReadLine(), out height))
                    {
                        Console.WriteLine("    Wrong height, please try again");
                        continue;
                    }

                    if (height <= 0)
                    {
                        Console.WriteLine($"    Height must be > 0.");
                        continue;
                    }
                    break;
                }
                s += height;
            }
            Console.WriteLine($"    Average height in the class is {s / n}");
            #endregion
            #region task 2.9
            Console.WriteLine("Level 2 Task 9");

            double n, result;
            double best = double.PositiveInfinity;
            while (true)
            {
                Console.WriteLine("    Please enter n:");
                if (!double.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }
            for (int i = 1; i <= n; i++)
            {
                while (true)
                {
                    Console.WriteLine($"    Please enter the result of the {i} sportsman.");
                    if (!double.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("    Wrong result, please try again");
                        continue;
                    }
                    if (result <= 0)
                    {
                        Console.WriteLine($"    result must be > 0.");
                        continue;
                    }
                    break;
                }
                if (result < best) best = result;
            }
            Console.WriteLine($"    The best result is {best}");
            #endregion
            #region task 3.4
            Console.WriteLine("Level 3 Task 4");

            double r1, r2, r, x, y;
            int n = 0;
            while (true)
            {
                Console.WriteLine("    Please enter r1:");
                if (!double.TryParse(Console.ReadLine(), out r1))
                {
                    Console.WriteLine("    Wrong r1, please try again");
                    continue;
                }
                if (r1 <= 0)
                {
                    Console.WriteLine("    r1 must be > 0");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("    Please enter r2:");
                if (!double.TryParse(Console.ReadLine(), out r2))
                {
                    Console.WriteLine("    Wrong r2, please try again");
                    continue;
                }
                if (r2 < r1)
                {
                    Console.WriteLine("    r2 must be >= r1");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("    Please enter x or 3.1415 if data is over");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("    Wrong x, please try again");
                    continue;
                }
                if (x == 3.1415)
                {
                    break;
                }

                Console.WriteLine("    Please enter y");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("    Wrong y, please try again");
                    continue;
                }
                r = x * x + y * y;
                if (r >= r1 * r1 && r <= r2 * r2)
                {
                    n++;
                }
            }
            Console.WriteLine($"    Points in [r1, r2]: {n}");
            #endregion
            #region task 3.11
            Console.WriteLine("Level 3 Task 11");

            int s = 0;
            double average = 0;
            int mark;
            bool bad_trigger = false;
            bool stop = false;
            int bad = 0;
            int n = 0;

            Console.WriteLine($"    if all data is entered, please write '-1'");
            while (true)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"    Please enter {i} grade of {n + 1} student");
                    if (!int.TryParse(Console.ReadLine(), out mark))
                    {
                        Console.WriteLine("    Wrong mark, please try again");
                        return;
                    }
                    if (mark == -1)
                    {
                        stop = true;
                        break;
                    }
                    if (mark < 2 || mark > 5)
                    {
                        Console.WriteLine($"    Mark must be in range from 2 to 5");
                        return;
                    }
                    if (mark == 2)
                    {
                        bad_trigger = true; ;
                    }
                    s += mark;
                }
                if (stop)
                {
                    break;
                }
                if (bad_trigger)
                {
                    bad++;
                }
                else
                {
                    average += s;
                }
                bad_trigger = false;
                s = 0;
                n++;
            }
            Console.WriteLine($"    Bad students: {bad}, Average mark: {average / ((n - bad) * 4)}");
            #endregion
            #region task 3.12
            Console.WriteLine("Level 3 Task 12");

            double r, r2;
            int key;

            Console.WriteLine($"    if all data is entered, please write '-1'");
            while (true)
            {
                Console.WriteLine($"    Please enter r");
                if (!double.TryParse(Console.ReadLine(), out r))
                {
                    Console.WriteLine("    Wrong r, please try again");
                    continue;
                }
                if (r == -1)
                {
                    break;
                }
                if (r < 0)
                {
                    Console.WriteLine("    Wrong r, please try again");
                    continue;
                }

                r2 = r * r;

                Console.WriteLine("1 = square area, 2 = circle area, 3 = triangle area");
                while (true)
                {
                    Console.WriteLine($"    Choose what to calculate(1, 2, 3):");
                    if (!int.TryParse(Console.ReadLine(), out key))
                    {
                        Console.WriteLine($"    incorrect format, try again");
                        continue;
                    }
                    if (key < 1 || key > 3)
                    {
                        Console.WriteLine($"    key must be in [1, 3]");
                        continue;
                    }
                    break;
                }
                switch (key)
                {
                    case 1:
                        Console.WriteLine($"square area: {r2}");
                        break;

                    case 2:
                        Console.WriteLine($"circle area: {Math.PI * r2}");
                        break;

                    case 3:
                        Console.WriteLine($"triangle area: {Math.Sqrt(3) * r2 / 4}");
                        break;
                }
            }
            #endregion
            #region task 3.13
            Console.WriteLine("Level 3 Task 13");

            double a, b;
            int key;

            Console.WriteLine($"    if all data is entered, please write '-1'");
            while (true)
            {
                Console.WriteLine("    Please enter a");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong a, please try again");
                    continue;
                }
                if (a == -1)
                {
                    break;
                }
                if (a <= 0)
                {
                    Console.WriteLine("    a must be > 0");
                    continue;
                }

                Console.WriteLine("    Please enter b");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("    Wrong b, please try again");
                    continue;
                }
                if (b <= 0)
                {
                    Console.WriteLine("    b must be > 0");
                    continue;
                }

                Console.WriteLine("1 = rectangle area, 2 = ring area, 3 = triangle area");
                while (true)
                {
                    Console.WriteLine($"    Choose what to calculate(1, 2, 3):");
                    if (!int.TryParse(Console.ReadLine(), out key))
                    {
                        Console.WriteLine($"    incorrect format, try again");
                        continue;
                    }
                    if (key < 1 || key > 3)
                    {
                        Console.WriteLine($"    key must be in [1, 3]");
                        continue;
                    }
                    break;
                }
                switch (key)
                {
                    case 1:
                        Console.WriteLine($"rectangle area: {a * b}");
                        break;

                    case 2:
                        Console.WriteLine($"ring area: {Math.Abs(Math.PI * (a * a - b * b))}");
                        break;

                    case 3:
                        Console.WriteLine($"triangle area: {a / 4 * Math.Sqrt(4 * b * b - a * a)}");
                        break;
                }
            }
            #endregion
        }
    }
}
