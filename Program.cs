using System;
using System.Diagnostics.Metrics;
using System.Threading;

namespace _1stLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 3
            Console.WriteLine($"_LEVEL_1_ \n");

            int a, b, c;

            Console.Write("Enter the value of variable a: \t");
            Int32.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter the value of variable b: \t");
            Int32.TryParse(Console.ReadLine(), out b);

            if (a > 0)
            {
                if (a > b)
                {
                    c = a;
                }
                else c = b;
            }
            else
            {
                if (a > b)
                {
                    c = b;
                }
                else c = a;
            }
            Console.WriteLine($"Task 3: c = {c} \n");
            #endregion

            #region Task 4

            int z, temporary;

            Console.Write("Enter the value of variable a: \t");
            Int32.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter the value of variable b: \t");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter the value of variable c: \t");
            Int32.TryParse(Console.ReadLine(), out c);

            if (a > b)
            {
                temporary = b;
            }
            else temporary = a;

            if (temporary > c)
            {
                z = temporary;
            }
            else z = c;

            Console.WriteLine($"Task 4: z = {z} \n");

            #endregion

            #region Task 9

            double x, y;
            y = 0;

            Console.Write("Enter the value of variable x ( x <= -1  or  -1 < x <= 0 ): \t");
            double.TryParse(Console.ReadLine(), out x);

            if (x <= -1)
            {
                y = 0;

                Console.WriteLine($"Task 9: y = {y} \n");
            }

            if (x <= 0 && x > -1)
            {
                y = 1 + x;

                Console.WriteLine($"Task 9: y = {y} \n");
            }

            #endregion

            #region Level 2 Task 1

            Console.WriteLine("_LEVEL_2_ \n");

            int n;
            double height, weight, average_weight, average_height, all_height, all_weight;

            all_height = 0;
            all_weight = 0;

            Console.Write("Enter the number of students in the class: \t");
            Int32.TryParse(Console.ReadLine(), out n);
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Enter the height of {i} student: \t");
                    double.TryParse(Console.ReadLine(), out height);

                    Console.Write($"Enter the weight of {i} student: \t");
                    double.TryParse(Console.ReadLine(), out weight);

                    all_height += height;
                    all_weight += weight;
                }

                average_height = all_height / n;
                average_weight = all_weight / n;

                Console.WriteLine($"Task 1: average height = {average_height} and average weight = {average_weight} \n");
            }
            #endregion

            #region Task 10

            int count, all_count;

            count = 0;
            all_count = 0;

            Console.Write("Enter the number of students in the group: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                int[] Marks = new int[4];

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter {j + 1} mark of {i} student:");
                    Marks[j] = Int32.Parse(Console.ReadLine());

                }

                foreach (int str in Marks)
                {
                    if (str == 2 || str == 3)
                    {
                        Console.WriteLine("Do your best");
                    }
                    else count += 1;
                }

                if (count == 4)
                {
                    all_count += 1;
                }

                count = 0;
            }

            Console.WriteLine($"There are {all_count} good students in the group \n");

            #endregion

            #region Level 3 Task 4

            Console.WriteLine("_LEVEL_3_ \n");

            double r1, r2, k;

            k = 0;

            Console.Write("Enter inner radius: \t");
            double.TryParse(Console.ReadLine(), out r1);

            Console.Write("Enter outer radius: \t");
            double.TryParse(Console.ReadLine(), out r2);

            if (r2 > r1 && r2 > 0 && r1 > 0)
            {
                do
                {
                    Console.Write("Enter x (enter 1000 to finish) : \t");
                    double.TryParse(Console.ReadLine(), out x);

                    if (x >= 1000) break;

                    Console.Write("Enter y: \t");
                    double.TryParse(Console.ReadLine(), out y);

                    if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2)) k += 1;

                } while (x < 1000);

                Console.WriteLine($"Task 4: There are {k} points in such a ring \n");
            }
            #endregion

            #region Task 11

            double bad_students, summa, average_summa;

            n = 0;
            count = 0;
            bad_students = 0;
            summa = 0;
            average_summa = 0;

            do
            {
                int[] Exams = new int[4];

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter {j + 1} mark of student (2 to 5; write 1 to finish): \t");
                    Exams[j] = Int32.Parse(Console.ReadLine());
                }

                if (Exams.Contains(1))
                {
                    break;
                }

                else
                {
                    if (Exams.Contains(2) || Exams.Contains(3))
                    {
                        count += 1;
                    }

                    if (count != 0)
                    {
                        bad_students += 1;
                    }
                    else
                    {
                        for (int g = 0; g < Exams.Length; g++)
                        {
                            summa += Exams[g];
                        }

                        n += 1;
                    }

                    count = 0;
                }


            } while (true);

            if (n > 0)
            {
                average_summa = summa / (4 * n);

                Console.WriteLine($"There are {bad_students} bad students in the group and average mark is {average_summa}\n");
            }

            else Console.WriteLine("There must be more than 0 people in the group");

            #endregion

            #region Task 12

            int choice;
            string output;
            double r, result;
            double sqrt3;

            sqrt3 = Math.Sqrt(3);
            result = 0;

            do
            {
                Console.WriteLine("What i need to calculate?");
                Console.WriteLine("Enter [1] for Square, [2] for Circle and [3] for Triangle");

                Console.Write("Your choice is: \t");
                Int32.TryParse(Console.ReadLine(), out choice);
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    Console.Write("Enter r: \t");
                    double.TryParse(Console.ReadLine(), out r);

                    if (r > 0)
                    {
                        switch (choice)
                        {
                            case 1:
                                result = r * r;
                                break;

                            case 2:
                                result = Math.PI * r * r;
                                break;

                            case 3:
                                result = r * r * sqrt3 / 4;
                                break;
                        }

                        Console.WriteLine($"The result is {result}");
                        Console.Write("Wanna do it again, bro? [yes/no] - \t");
                        output = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (output == "no")
                        {
                            break;
                        }
                    }
                }

            } while (true);

            #endregion

            #region Task 13

            double A, B;

            do
            {
                Console.WriteLine("What i need to calculate?");
                Console.WriteLine("Enter [1] for Rectangle, [2] for Ring and [3] for Triangle");

                Console.Write("Your choice is: \t");
                Int32.TryParse(Console.ReadLine(), out choice);
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    Console.Write("Enter A: \t");
                    double.TryParse(Console.ReadLine(), out A);

                    Console.Write("Enter B: \t");
                    double.TryParse(Console.ReadLine(), out B);

                    if (A > 0 && B > 0)
                    {
                        switch (choice)
                        {
                            case 1:
                                result = A * B;
                                break;

                            case 2:
                                if (A > B)
                                {
                                    result = Math.PI * (A * A - B * B);
                                }

                                else result = Math.PI * (B * B - A * A);
                                break;

                            case 3:
                                double h = Math.Sqrt((B * B) - 0.25 * A * A);
                                result = A * h * 0.5;
                                break;
                        }

                        Console.WriteLine($"The result is {result}");
                        Console.Write("Wanna do it again, bro? [yes/no] - \t");
                        output = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (output == "no")
                        {
                            break;
                        }
                    }
                }

            } while (true);

            #endregion
        }
    }
}
