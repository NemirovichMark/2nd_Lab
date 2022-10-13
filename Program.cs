using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;

namespace Lab_2
{
    class Theo
    {
        static void Main(string[] args)
        {
            #region Lvl1
            Console.WriteLine($"Level 1");
            #region Task 1
            Console.WriteLine($"Task 1");
            double rad, x, y;
            for (; ; )
            {
                try
                {
                    Console.WriteLine($"Enter radius");
                    rad = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter x");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter y");
                    y = double.Parse(Console.ReadLine());

                    if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(rad, 2))
                    {
                        Console.WriteLine($"Our point is in the circle");
                        break;

                    }
                    else
                    {
                        Console.WriteLine($"Our point is out of the circle");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Not correct input");
                    break;
                }
            }
            #endregion
            #region Task 4
            Console.WriteLine($"Task 4");
            double a, b, c, z, min, max = 0;
            Console.WriteLine($"Enter a");
            bool result = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine($"Enter b");
            bool result1 = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine($"Enter c");
            bool result2 = double.TryParse(Console.ReadLine(), out c);

            if (result && result1 && result2)
            {
                if (a < b) min = a;
                else min = b;
                if (min > c) max = min;
                else max = c;
                z = max;
                Console.WriteLine($"The answer is {z}");
            }
            else Console.WriteLine($"Error");
            #endregion
            Console.WriteLine($"---------------------------------------------");
            #endregion
            #region Lvl2
            Console.WriteLine($"Level 2");
            #region Task 1
            Console.WriteLine($"Task 1");
            int n = 0;
            double summ = 0;
            double avg = 0;
            for (; ; )
            {
                try
                {
                    double height;

                    Console.WriteLine($"If you want to add boy you need to type B, for girl you need to type G. Otherwise, enter E to exit.");
                    char gen = char.Parse(Console.ReadLine());

                    if (gen == 'B')
                    {
                        Console.Write("Enter height");
                        bool ok_height = double.TryParse(Console.ReadLine(), out height);

                        if ((!ok_height) || (height <= 0))
                        {
                            Console.WriteLine($"Height should be positive");
                            break;
                        }
                        else
                        {
                            summ += height;
                            n++;
                        }

                    }
                    else if (gen == 'G')
                    {
                        Console.WriteLine("Enter height");
                        bool ok_height = double.TryParse(Console.ReadLine(), out height);

                        if ((!ok_height) || (height <= 0))
                        {
                            Console.WriteLine($"Height should be positive");
                            break;
                        }
                        else
                        {
                            summ += height;
                            n++;
                        }

                    }
                    else if (gen == 'E')
                    {
                        avg = summ / n;
                        avg = Math.Round(avg, 2);
                        Console.WriteLine($"The average height in the class is {avg}");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Wrong, try again");
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine($"Not correct input..");
                }
            }


            #endregion
            #region Task 5
            Console.WriteLine($"Task 5");
            double m = 30;
            int complete = 0;
            double norm;
            Console.WriteLine($"Enter standart");
            bool normal = double.TryParse(Console.ReadLine(), out norm);
            if ((!normal) || (norm < 0))
            {
                Console.WriteLine($"Not correct input");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Enter results of {m} athletes");
            bool res;
            double resul;
            for (int i = 1; i <= m; i++)
            {
                res = double.TryParse(Console.ReadLine(), out resul);
                if ((!res) || (resul < 0))
                {
                    Console.WriteLine($"Not correct input");
                    Console.ReadLine();
                    return;
                }
                if (resul >= norm)
                {
                    complete++;
                }
            }
            Console.WriteLine($"{complete} athletes completed the specified standard");
            #endregion
            #endregion
            #region Lvl3
            Console.WriteLine($"Level 3");
            #region Task 4
            Console.WriteLine($"Task 4");
            double rad_1, rad_2, x_1, y_1;
            bool radi;
            double x_dot, y_dot;
            int counter = 0;

            Console.WriteLine($"Enter inner radius");
            radi = double.TryParse(Console.ReadLine(), out rad_1);
            if ((!radi) || (rad_1 < 0))
            {
                Console.WriteLine($"Not correct input");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Enter outer radius");
            radi = double.TryParse(Console.ReadLine(), out rad_2);
            if ((!radi) || (rad_2 < 0))
            {
                Console.WriteLine($"Not correct input");
                Console.ReadLine();
                return;
            }
            if (rad_1 >= rad_2)
            {
                Console.WriteLine($"The inner radius couldn`t be greater than or equal to outer");
            }
            rad_1 = rad_1 * rad_1;
            rad_2 = rad_2 * rad_2;
            Console.WriteLine($"Now ellipse x and y...");
            Console.WriteLine($"Enter x");
            bool x_good = double.TryParse(Console.ReadLine(), out x_1);
            if (x_good)
            {
                Console.WriteLine($"Enter y");
                bool y_good = double.TryParse(Console.ReadLine(), out y_1);
                if (y_good)
                {
                    do
                    {
                        Console.WriteLine($"Point dots, by the way, to exit -> enter 1005 for x");
                        Console.WriteLine($"Enter x");
                        double.TryParse(Console.ReadLine(), out x_dot);
                        if (x_dot == 1005) break;
                        Console.WriteLine($"Enter y");
                        double.TryParse(Console.ReadLine(), out y_dot);
                        if ((((x_dot - x_1) * (x_dot - x_1) + (y_dot - y_1) * (y_dot - y_1) > rad_1)) && (((x_dot - x_1) * (x_dot - x_1) + (y_dot - y_1) * (y_dot - y_1) < rad_2))) ;
                        {
                            counter++;
                        }
                    } while (x_dot != 1005);
                }
            }
            Console.WriteLine($"The amount of dots is {counter}");

            #endregion
            #region Task 11
            Console.WriteLine($"Task 11");
            double avgsu = 0, total = 0;
            double j;
            int ex1, ex2, ex3, ex4;
            double good = 0, bad = 0;
            Console.WriteLine($"Enter the amount of students");
            double.TryParse(Console.ReadLine(), out j);
            for (int h = 1; h <= j; h++)
            {
                Console.WriteLine($"Enter mark for the 1-st exam");
                int.TryParse(Console.ReadLine(), out ex1);
                Console.WriteLine($"Enter mark for the 2-nd exam");
                int.TryParse(Console.ReadLine(), out ex2);
                Console.WriteLine($"Enter mark for the 3-rd exam");
                int.TryParse(Console.ReadLine(), out ex3);
                Console.WriteLine($"Enter mark for the 4-th exam");
                int.TryParse(Console.ReadLine(), out ex4);

                if ((ex1 >= 2 && ex1 <= 5) && (ex2 >= 2 && ex2 <= 5) && (ex3 >= 2 && ex3 <= 5) && (ex4 >= 2 && ex4 <= 5))
                {
                    if (ex1 == 2 || ex2 == 2 || ex3 == 2 || ex4 == 2)
                    {
                        bad++;
                    }
                    else
                    {
                        good++;
                        avgsu = (ex1 + ex2 + ex3 + ex4) / 4;
                        total += avgsu;


                    }
                }
            }
            Console.WriteLine($"Amount of failed students is {bad}, avg. mark for group is {total / good} ");
            #endregion
            #region Task 12
            Console.WriteLine($"Task 12");
            double rr, result_12;
            int n_12;
            int choose;
            Console.WriteLine($"Enter n");
            n_12 = int.Parse(Console.ReadLine());
            for (int p = 1; p <= n_12; p++)
            {
                Console.WriteLine($"Enter r");
                rr = double.Parse(Console.ReadLine());
                Console.WriteLine($"For S of square type 0, for circle type 1, for triangle type 2 ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        result_12 = Math.Pow(rr, 2);
                        Console.WriteLine($"S of the square is {result_12}");
                        Console.ReadKey();
                        break;

                    case 1:
                        result_12 = Math.Pow(rr, 2) * Math.PI;
                        Console.WriteLine($"S of the circle is {result_12}");
                        Console.ReadKey();
                        break;

                    case 2:
                        result_12 = (Math.Pow(rr, 2) * Math.Sqrt(3)) / 4;
                        Console.WriteLine($"S of equilateral triangle is {result_12}");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        Console.ReadKey();
                        break;
                }
            } 
       
            #endregion
            #region Task 13
            Console.WriteLine($"Task 13");
            int n_13, choose_13;
            double A, B, result_13;
            Console.WriteLine($"Enter amount of pairs");
            n_13 = int.Parse(Console.ReadLine());
            for (int v = 1; v <= n_13; v++)
            {
                Console.WriteLine($"Enter A (it should be more than 0)");
                    A = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter B (it should be more than 0)");
                    B = double.Parse(Console.ReadLine());
                    Console.WriteLine($"For rectangle type 0, for annulus type 1, for isosceles triangle type 2 ");
                    choose_13 = int.Parse(Console.ReadLine());
                switch (choose_13)
                {
                    case 0:
                        result_13 = A * B;
                            Console.WriteLine($"S of the rectangle is {result_13}");
                            Console.ReadKey();
                            break;
                        
                    case 1:
                        result_13 = Math.PI * (Math.Abs(A * A - B * B));
                        Console.WriteLine($"S of the annulus is {result_13}");
                        Console.ReadKey();
                        break;

                    case 2:
                        result_13 = 0.5 * B * Math.Sqrt((A + 0.5 * B) * (A - 0.5 * B));
                        Console.WriteLine($"S of the isosceles triangle is {result_13}");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        Console.ReadKey();
                        break;
                }
            }

                #endregion
            #endregion




            
        }
    }
}
        

        
        

          
  















































