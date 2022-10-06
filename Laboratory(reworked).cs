using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Reflection;
using System.Xml.Schema;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region First LVL
                {
                    #region Task 3
                    WriteLine("First lvl_Task 3");
                    double a = 0;
                    double b = 0;

                    WriteLine("Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    WriteLine("Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (a > 0)
                    {
                        double c = Math.Max(a, b);
                        WriteLine($"c = {c} ");
                    }
                    else
                    {
                        double c = Math.Min(a, b);
                        WriteLine($"c = {c} ");
                    }

                    #endregion
                }

                {
                    #region Task 4
                    WriteLine("First lvl_Task 4");
                    double a = 0;
                    double b = 0;
                    double c = 0;
                    double min, max;

                    WriteLine("Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    WriteLine("Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    WriteLine("Enter b: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    if (a > b)
                    {
                        min = b;
                    }
                    else
                    {
                        min = a;

                    }
                    if (c > min)
                    {
                        max = c;
                    }
                    else
                    {
                        max = min;
                    }

                    WriteLine($"z = {max} ");



                    #endregion
                }

                {
                    #region Task 5_1
                    WriteLine("First lvl_Task 5.1");

                    int r = 70;
                    double s = 36.74;

                    if ((Math.Sqrt(r / Math.PI) * 2) >= (Math.Sqrt(s) * Math.Sqrt(2))) //Диагонали круга и квадрата
                    {
                        WriteLine("Yes, placed");
                    }
                    else
                    {
                        WriteLine("No, not placed");
                    }

                    #endregion

                }

                {
                    #region Task 5_2
                    WriteLine("First lvl_Task 5.2");

                    double r = 0.86;
                    double s = 0.74;

                    if ((Math.Sqrt(r / Math.PI) * 2) >= (Math.Sqrt(s) * Math.Sqrt(2))) //Диагонали круга и квадрата
                    {
                        WriteLine("Yes, placed");
                    }
                    else
                    {
                        WriteLine("No, not placed");
                    }

                    #endregion
                }
                #endregion
            }

            {
                #region Second LVL
                {
                    #region Task 1
                    WriteLine("Second lvl_Task 1");

                    WriteLine("Enter n : ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Random rnd = new Random();
                    int[] array = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rnd.Next(140, 200);
                    }

                    WriteLine("Average height: ");
                    WriteLine(array.Sum() / array.Length);

                    #endregion
                }

                {
                    #region Task 5
                    WriteLine("Second lvl_Task 5");

                    WriteLine("Enter normative: ");
                    double normative = Convert.ToDouble(Console.ReadLine());
                    double result = 0;
                    double completed = 0;
                    double notcomplited = 0;

                    if (normative > 0)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            WriteLine("Enter the result; ");
                            result = Convert.ToDouble(Console.ReadLine());
                            if (result > 0)
                            {
                                if (result >= normative)
                                {
                                    completed += 1;
                                }
                                else
                                {
                                    notcomplited += 1;
                                }
                            }
                            else
                            {
                                break;
                            }


                        }
                    }
                    else
                    {
                        WriteLine("Enter correct values");
                    }

                    WriteLine($"Completed normatives: {completed}");
                    WriteLine($"Didnt complete normatives: {notcomplited}");

                    #endregion
                }

                #endregion
            }

            {
                #region Third LVL
                {
                    #region Task 4


                    double x = 0, y, r1, r2;
                    double amount = 0;

                    WriteLine("Enter r1: ");
                    double.TryParse(ReadLine(), out r1);

                    WriteLine("Enter r2: ");
                    double.TryParse(ReadLine(), out r2);

                    do
                    {
                        if (r2 > r1 && r2 > 0)
                        {
                            WriteLine("Enter x:  (enter 1000 for end)");
                            double.TryParse(ReadLine(), out x);

                            if (x >= 1000)
                            {
                                break;
                            }

                            WriteLine("Enter y: ");
                            double.TryParse(ReadLine(), out y);

                            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                            {
                                amount += 1;
                            }

                        }

                    } while (x < 1000);

                    WriteLine($"Amount = {amount}");

                    #endregion
                }

                {
                    #region Task 11

                    double losers = 0;
                    double sum = 0;
                    double amount = 0;
                    double total = 0;
                    double exam1, exam2, exam3, exam4;

                    WriteLine("Enter number of students; ");
                    int n = Convert.ToInt32(ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        WriteLine("Enter the grade for 1 exam: ");
                        exam1 = double.Parse(ReadLine());

                        WriteLine("Enter the grade for 2 exam: ");
                        exam2 = double.Parse(ReadLine());

                        WriteLine("Enter the grade for 3 exam: ");
                        exam3 = double.Parse(ReadLine());

                        WriteLine("Enter the grade for 4 exam: ");
                        exam4 = double.Parse(ReadLine());

                        if ((exam1 <= 5) && (exam2 <= 5) && (exam3 <= 5) && (exam4 <= 5))
                        {
                            if ((exam1 > 2) && (exam2 > 2) && (exam3 > 2) && (exam4 > 2))
                            {
                                amount += 1;
                                sum = (exam1 + exam2 + exam3 + exam4) / 4;
                                total = total + sum;

                            }
                            else
                            {
                                losers += 1;
                            }
                        }

                    }
                    WriteLine($"Number of losers = {losers} , AVG grade = {total / amount}");

                    #endregion
                }

                {
                    #region Task 12

                    double r;
                    double choice;

                    WriteLine("Enter r: ");
                    r = double.Parse(ReadLine());

                    if (r > 0)
                    {
                        WriteLine("Enter 1 for square's area, enter 2 for for circle's area, enter 3 for triangle's area");
                        choice = Convert.ToDouble(ReadLine());

                        switch (choice)
                        {
                            case 1:
                                WriteLine($"Square's area = {Math.Pow(r, 2)}");
                                break;
                            case 2:
                                WriteLine(($"Circle's area = {Math.Pow(r, 2) * Math.PI}"));
                                break;
                            case 3:
                                WriteLine($"Triangle's area = {Math.Pow(r, 2) * Math.Sqrt(3) * 0.25}");
                                break;

                        }

                    }

                    #endregion
                }

                {
                    #region Task 13

                    double a = 0;
                    WriteLine("Enter a: ");
                    double.TryParse(ReadLine(), out a);

                    double b = 0;
                    WriteLine("Enter b: ");
                    double.TryParse(ReadLine(), out b);

                    double choice;
                    WriteLine("Enter 1 for rectangle's area, enter 2 for for ring's area, enter 3 for triangle's area");
                    double.TryParse(ReadLine(), out choice);

                    double s = 0;
                    double h;

                    switch (choice)
                    {
                        case 1:
                            s = a * b;
                            WriteLine($"Rectangle's area = {s}");
                            break;
                        case 2:
                            if (a > b)
                            {
                                s = Math.Pow(a, 2) * Math.PI - Math.Pow(b, 2) * Math.PI;
                                WriteLine($"Ring's area = {s}");
                            }
                            else
                            {
                                s = Math.Pow(b, 2) * Math.PI - Math.Pow(a, 2) * Math.PI;
                                WriteLine($"Ring's area = {s}");

                            }
                            break;
                        case 3:
                            h = Math.Sqrt(b * b - (a * a / 4)); //Формулу просто скопировал(так как через Герона выводил "не число" :D
                            if (h >= 0)
                            {
                                WriteLine($"Triangle's area = {0.5 * a * h}");
                            }
                            else
                            {
                                WriteLine("Wrong data");//отрицательное подкоренное
                                break;
                            }
                            break;

                    }

                    #endregion
                }

                #endregion
            }
        }
    }
}
