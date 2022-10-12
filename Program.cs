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
                if (!double.TryParse(Console.ReadLine(), out double x1))
                {
                    Console.WriteLine("2.5 Incorrect data, try again");
                    i--;
                }
                else
                {
                    if (x1 <= norm)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"2.5 Answer: {count}");
            #endregion
            #region Task_3.4

            double r1, r2;
            count = 0;

            Console.WriteLine("3.4 Enter r1");
            if (!double.TryParse(Console.ReadLine(), out r1))
            {
                Console.WriteLine("3.4 It`s not a number.");
                return;
            }

            Console.WriteLine("Enter r2");
            if (!double.TryParse(Console.ReadLine(), out r2))
            {
                Console.WriteLine("3.4 It`s not a number.");
                return;
            }

            Console.WriteLine("3.4 Еnter a coordinate with a space, example: 10 13");
            string s;
            double x, y;

            while (true)
            {
                s = Console.ReadLine();

                if (s == "")
                {
                    break;
                }

                string[] nums = s.Split();

                if (nums.Length != 2)
                {
                    Console.WriteLine("3.4 Wrong input. Let`s try again.");
                    continue;
                }

                if (!double.TryParse(nums[0], out x))
                {
                    Console.WriteLine("3.4 x is not a number. Let`s try again.");
                    continue;
                }
                if (!double.TryParse(nums[1], out y))
                {
                    Console.WriteLine("3.4 y is not a number. Let`s try again.");
                    continue;
                }

                if ((r1 * r1 <= x * x + y * y) && (r2 * r2 >= x * x + y * y))
                {
                    count++;
                }
            }

            Console.WriteLine($"Task 3.4 answer {count}");

            #endregion
            #region Task_3.11

            Console.WriteLine("3.11 Еnter all 4 marks with a space between, example: 4 5 3 3");


            string[] marks;

            int failingStudents = 0;
            int sumOfMarks = 0;
            int numberOfStudents = 0;

            while (true)
            {
                s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }

                marks = s.Split();
                if (marks.Length != 4)
                {
                    Console.WriteLine("3.11 Wrong input. Let`s try again.");
                    continue;
                }

                int[] intMarks = { 0, 0, 0, 0 };
                bool isFailng = false;
                bool wrongInput = false;

                for (int i = 0; i < 4; i++)
                {
                    if (!int.TryParse(marks[i], out intMarks[i]))
                    {
                        wrongInput = true;
                    }
                }

                if (wrongInput)
                {
                    Console.WriteLine("3.11 One of the marks isn`t integer. Let`s try again.");
                    continue;
                }

                foreach (int mark in intMarks)
                {
                    if (mark <= 2)
                    {
                        isFailng = true;
                    }
                    sumOfMarks += mark;
                }

                if (isFailng)
                {
                    failingStudents += 1;
                }

                numberOfStudents += 1;
            }

            Console.WriteLine($" 3.11 Answer: Failing students: {failingStudents} Average mark: {sumOfMarks / 4.0 / numberOfStudents}");
            #endregion
            #region Task_3.12

            double r;
            string cmd;

            while (true)
            {
                Console.WriteLine("3.12 Enter r: ");

                s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }

                if (!double.TryParse(s, out r))
                {
                    Console.WriteLine("It`s not a number. Let`s try again.");
                    continue;
                }

                if (r < 0)
                {
                    Console.WriteLine("Wrong input (r < 0). Let`s try again.");
                    continue;
                }

                Console.WriteLine("Number commands\n1. rectangle area\n2. ring area\n3. triange area\nEnter command");
                cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        Console.WriteLine($"Area of the square: {r * r}");
                        break;
                    case "2":
                        Console.WriteLine($"Area of the cirle: {r * r * Math.PI}");
                        break;
                    case "3":
                        Console.WriteLine($"Area of the triangle: {(Math.Sqrt(3) / 4) * r * r}");
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }


            #endregion
            #region Task_3.13
            Console.WriteLine("3.12 Еnter a and b with a space between, example: 10 13");


            double a1, b1;


            while (true)
            {
                Console.WriteLine("3.12 Enter a and b");
                s = Console.ReadLine();

                if (s == "")
                {
                    break;
                }

                string[] nums = s.Split();

                if (nums.Length != 2)
                {
                    Console.WriteLine("Wrong input. Let`s try again.");
                    continue;
                }

                if (!double.TryParse(nums[0], out a1))
                {
                    Console.WriteLine("a is not a number. Let`s try again.");
                    continue;
                }
                if (!double.TryParse(nums[1], out b1))
                {
                    Console.WriteLine("b is not a number. Let`s try again.");
                    continue;
                }

                if (a1 < 0 || b1 < 0)
                {
                    Console.WriteLine("Wrong input: a < 0 or b < 0. Let`s try again.");
                    continue;
                }

                Console.WriteLine("Number commands\n1. square area\n2. circle area\n3. triange area\nEnter command");
                cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        Console.WriteLine($"Area of the square: {a1 * b1}");
                        break;
                    case "2":
                        Console.WriteLine($"Area of the cirle: {Math.Abs(a1 * a1 * Math.PI - b1 * b1 * Math.PI)}");
                        break;
                    case "3":
                        if (Math.Max(a1, b1) > (a1 + b1 + b1) - Math.Max(a1, b1))
                        {
                            Console.WriteLine("There is no triangle with such sides");
                            break;
                        }
                        Console.WriteLine($"Area of the triangle: {Math.Sqrt(b1 * b1 - Math.Pow((a1 / 2.0), 2)) * a1 / 2.0}");
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
            #endregion
        }

    }
}