using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Level I
            Console.WriteLine("--- Level I ----------------------\n");

            #region Task 3
            Console.WriteLine("Task 3 \n");

            double a, b;

            Console.Write("Enter a: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            Console.Write("Enter b: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            if (a > 0)
            {
                if (a >= b)
                    Console.WriteLine($"Max is a: {a}");
                else
                    Console.WriteLine($"Max is b: {b}");
            }
            else
            {
                if (a < b)
                    Console.WriteLine($"Min is a: {a}");
                else
                    Console.WriteLine($"Min is b: {b}");
            }
            #endregion

            #region Task 4
            Console.WriteLine("\nTask 4 \n");

            double c;
            double min;

            Console.Write("Enter c: ");
            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            if (a < b)
                min = a;
            else
                min = b;

            if (c >= min)
                Console.WriteLine($"Max is: {c}");
            else
                Console.WriteLine($"Max is : {min}");

            #endregion

            #region Task 7
            Console.WriteLine("\nTask 7 \n");

            double x;
            double xAbs;

            Console.Write("Enter x: ");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Value has an incorrect value!");
                return;
            }

            xAbs = Math.Abs(x);

            if (xAbs > 1)
                Console.WriteLine($"y = {1}");
            else
                Console.WriteLine($"y = {xAbs}");
            #endregion

            #endregion

            #region Level II
            Console.WriteLine("\n--- Level II ----------------------\n");

            int n = 5;

            #region Task 1
            Console.WriteLine("Task 1\n");

            double heightSum = 0;
            double height;
            double avgHeight;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter height of {i} student: ");

                if (!double.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Value has incorrect format!");
                    return;
                }
                if (height <= 0)
                {
                    Console.WriteLine("Height must be greater than 0!");
                    return;
                }

                heightSum += height;
            }

            avgHeight = heightSum / n;

            Console.WriteLine($"Average height is: {Math.Round(avgHeight, 2)}");
            #endregion

            #region Task 9
            Console.WriteLine("\nTask 9\n");

            double result;
            double bestResult = -1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter {i} result: ");

                if (!double.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Value has incorrect format!");
                    return;
                }
                if (result <= 0)
                {
                    Console.WriteLine("Result must be greater than 0!");
                    return;
                }

                if (result < bestResult || bestResult == -1)
                    bestResult = result;
            }

            Console.WriteLine($"Best result is {Math.Round(bestResult, 3)}");
            #endregion

            #endregion

            #region Level III
            Console.WriteLine("\n--- Level III ----------------------\n");

            #region Task 4
            Console.WriteLine("Task 4\n");
            // circle formula x^2 + y^2 = r^2
            double y = 0;
            double r1, r2;
            double point;

            string input;

            x = 0;
            n = 1;
            int belongingCount = 0;

            Console.Write("Enter r1: ");
            if (!double.TryParse(Console.ReadLine(), out r1))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            Console.Write("Enter r2: ");
            if (!double.TryParse(Console.ReadLine(), out r2))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            if (r2 < r1)
            {
                Console.WriteLine("Outer radius can not be less than inner!");
                return;
            }

            Console.WriteLine("\nWrite $ to stop.");

            for (; ; n++)
            {
                Console.WriteLine($"\nEnter coordinates №{n}:");

                Console.Write("   x: ");
                input = Console.ReadLine();
                if (input == "$")
                    break;

                if (!double.TryParse(input, out x))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                Console.Write("   y: ");
                input = Console.ReadLine();
                if (input == "$")
                    break;

                if (!double.TryParse(input, out x))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                point = (x * x) + (y * y);

                if (point <= r2 * r2 && point >= r1 * r1)
                    belongingCount++;
            }

            Console.WriteLine($"\nPoints belonging to circle: {belongingCount}");
            #endregion

            #region Task 11
            Console.WriteLine("\nTask 11\n");

            int mark;
            double marksSum = 0;
            double avgMarksSum = 0;
            double groupAverageMark;
            int badStudentsCount = 0;
            bool continueInput = true;
            bool hasBadGrade = false;

            n = 0;

            Console.WriteLine("Write $ to stop.");

            for (; continueInput; n++)
            {
                Console.WriteLine($"\nEnter {n + 1} student marks:");

                marksSum = 0;

                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"   Mark #{i}: ");
                    input = Console.ReadLine();

                    if (input == "$")
                    {
                        continueInput = false;
                        break;
                    }

                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("Value has an incorrect format!");
                        return;
                    }

                    if (mark < 2 || mark > 5)
                    {
                        Console.WriteLine("Mark value must be between 2 and 5");
                        return;
                    }

                    if (mark == 2)
                        hasBadGrade = true;

                    marksSum += mark;
                }

                if (!continueInput)
                    break;

                if (hasBadGrade)
                    badStudentsCount++;

                avgMarksSum += marksSum / 4;
            }

            if (n == 0)
                groupAverageMark = 0;
            else
                groupAverageMark = avgMarksSum / n;

            Console.WriteLine($"\nBad students count: {badStudentsCount}");
            Console.WriteLine($"Group average mark: {Math.Round(groupAverageMark, 3)}");
            #endregion

            #region Task 12
            Console.WriteLine("\nTask 12");

            double r;
            double area = 0;
            double rootOf3 = Math.Sqrt(3);
            int choice;

            while (true)
            {
                Console.WriteLine("\nWhich area I should calculate?:");
                Console.WriteLine("[1] - Square, [2] - Circle, [3] - Triangle\n");
                Console.Write("Your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("You can choose olny 1, 2 or 3!");
                    return;
                }

                Console.Write("\nEnter r (must be positive): ");
                if (!double.TryParse(Console.ReadLine(), out r))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                if (r < 0)
                {
                    Console.WriteLine("Value of r must be positive!");
                    return;
                }

                switch (choice)
                {
                    case 1:
                        area = r * r;
                        break;
                    case 2:
                        area = Math.PI * r * r;
                        break;
                    case 3:
                        area = r * r * rootOf3 / 4;
                        break;
                }

                Console.WriteLine($"Area is: {Math.Round(area, 3)}\n");
                Console.Write("Do this again? [y/n]: ");

                input = Console.ReadLine().ToLower();
                if (input == "n")
                    break;
                else if (input != "y")
                {
                    Console.WriteLine("You need to enter y or n!");
                    return;
                }
            }
            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:");

            while (true)
            {
                Console.WriteLine("\nWhich area I should calculate?:");
                Console.WriteLine("[1] - Rectangle, [2] - Ring, [3] - Isosceles triangle\n");
                Console.Write("Your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("You can choose olny 1, 2 or 3!");
                    return;
                }

                Console.Write("   Enter a (must be positive): ");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                if (a < 0)
                {
                    Console.WriteLine("Value of a must be positive!");
                    return;
                }

                Console.Write("   Enter b (must be positive): ");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Value has an incorrect format!");
                    return;
                }

                if (b < 0)
                {
                    Console.WriteLine("Value of a must be positive!");
                    return;
                }

                switch (choice)
                {
                    case 1:
                        area = a * b;
                        break;
                    case 2:
                        if (a >= b)
                            area = Math.PI * (a * a - b * b);
                        else
                            area = Math.PI * (b * b - a * a);
                        break;
                    case 3:
                        double h = Math.Sqrt((b * b) - 0.25 * a * a);
                        area = 0.5 * a * h;
                        break;
                }

                Console.WriteLine($"\nArea is: {Math.Round(area, 3)}\n");
                Console.Write("Do this again? [y/n]: ");

                input = Console.ReadLine().ToLower();
                if (input == "n")
                    break;
                else if (input != "y")
                {
                    Console.WriteLine("You need to enter y or n!");
                    return;
                }
            }
            #endregion

            #endregion
        }
    }
}
