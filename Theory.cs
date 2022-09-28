using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab1s
{
    internal class Program
    {
        static void Main()
        {
            #region task 1_1
            Console.WriteLine("task 1_1");
            double r = 2;
            double point1x = 0, point1y = 2;
            if (Math.Abs(point1x * point1x + point1y * point1y - r * r) <= 0.001)
            {
                Console.WriteLine("first Point is in circle");
            }
            else
            {
                Console.WriteLine("first Point is not in circle");
            }
            double point2x = 1.5, point2y = 0.7;
            if (Math.Abs(point2x * point2x + point2y * point2y - r * r) <= 0.001)
            {
                Console.WriteLine("second Point is in circle");
            }
            else
            {
                Console.WriteLine("second Point is not in circle");
            }
            double point3x = 1, point3y = 1;
            if (Math.Abs(point3x * point3x + point3y * point3y - r * r) <= 0.001)
            {
                Console.WriteLine("third Point is in circle");
            }
            else
            {
                Console.WriteLine("third Point is not in circle");
            }
            double point4x = 3, point4y = 0;
            if (Math.Abs(point4x * point4x + point4y * point4y - r * r) <= 0.001)
            {
                Console.WriteLine("fourth Point is in circle");
            }
            else
            {
                Console.WriteLine("fourth Point is not in circle");
            }

            #endregion
            #region task 1_2
            Console.WriteLine("task 1_2");
            Console.WriteLine("Enter point coordinates");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (y >= -0 && y + Math.Abs(x) <= 1)
            {
                Console.WriteLine("the point is in circle");
            }
            else
            {
                Console.WriteLine("the point is not in circle");
            }
            #endregion
            #region task 2_1
            Console.WriteLine("Task 2_1");
            Console.WriteLine("Enter amount of boys in class");
            double i;
            double s = 0;
            double n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) Console.WriteLine("Enter normal number");
            else
            {
                i = n;
                Console.WriteLine("Enter Boys height");
                while (i > 0)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x <= 0) Console.WriteLine("Enter normal number");
                    else
                    {
                        s += x;
                        i = i - 1;
                    }
                }
                Console.WriteLine($"Boys average height - {s / n} ");
            }
            s = 0;
            Console.WriteLine("Enter amount of girls in class");
            double g = Convert.ToInt32(Console.ReadLine());
            if (g <= 0) Console.WriteLine("Enter normal number");
            else
            {
                i = g;
                Console.WriteLine("Enter girls height");
                while (i > 0)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x <= 0) Console.WriteLine("enter normal number");
                    else
                    {
                        s += x;
                        i = i - 1;
                    }
                }
                Console.WriteLine($"Girls average height - {s / g}");
            }
            #endregion
            #region task 2_2
            Console.WriteLine("Task 2_2");
            double a1, b1;
            n = 0;
            Console.WriteLine("Write amount of points");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("write r of circle");
            r = 0;
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("write centre coordinates of circle");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            i = n;
            int kol = 0;
            while (i > 0)
            {
                Console.WriteLine("Write point coordinates");
                a1 = double.Parse(Console.ReadLine());
                b1 = double.Parse(Console.ReadLine());
                if ((a1 - a) * (a1 - a) + (b1 - b) * (b1 - b) <= r * r)
                {
                    kol++;
                }
                i--;
            }
            Console.WriteLine($"amount of points in circle - {kol}");
            #endregion
            #region task 3_4
            double swap;
            Console.WriteLine("Task 3_4");
            Console.WriteLine("Write abscissa of centre ring");
            double x0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write ordinate of centre ring");
            double y0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write r1");
            double r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write r2");
            double r2 = double.Parse(Console.ReadLine());
            if (r1 > r2)
            {
                swap = r2;
                r2 = r1;
                r1 = swap;
            }
            n = 0;
            double flag = 0;
            double x3 = 0;
            double y3 = 0;
            kol = 0;
            do
            {
                Console.WriteLine("Write abscissa of point or if you want to end prog write - 0.123");
                x3 = double.Parse(Console.ReadLine());
                if (x3 == 0.123) break;
                Console.WriteLine("Write ordinate of point");
                y3 = double.Parse(Console.ReadLine());
                if ((x3 - x0) * (x3 - x0) + (y3 - y0) * (y3 - y0) >= r1 * r1 && (x3 - x0) * (x3 - x0) + (y3 - y0) * (y3 - y0) <= r2 * r2)
                {
                    kol++;
                }
            } while (flag != 1);
            Console.WriteLine($"amount of points in ring - {kol}");
            #endregion
            #region task 3_11
            Console.WriteLine("Task 3_11");
            n = 0;
            double dva = 0;
            s = 0;
            kol = 0;
            double neyt = 0;
            flag = 0;
            double proverka = 0;
            do
            {
                dva = 0;
                proverka = 0;
                Console.WriteLine("Write max of student, if you want to end programm write 0");
                for (i = 1; i <= 4; i++)
                {
                    n = double.Parse(Console.ReadLine());
                    if (n == 0) break;
                    if (n == 2) dva++;
                    proverka += n;
                }
                if (n == 0) break;
                kol += 1;
                s += proverka;
                if (dva != 0)
                {
                    neyt++;
                    s = s - proverka;
                }
            } while (flag != 1);
            if (kol == 0)
            { Console.WriteLine("No students"); }
            else
            {
                double gda = s / ((kol - neyt) * 4);
                Console.WriteLine($"amount of losers - {neyt}, grade point avarage - {gda}");
            }
            #endregion
            #region task 3_12
            int area;
            flag = 0;
            r = 0;
            s = 0;
            Console.WriteLine("Task 3_12");
            do
            {
                Console.WriteLine("Which shape you want to calculate area of - square(write 1), triangle(write 2), circle (write 3). If you want to stop prog write - 0");
                area = int.Parse(Console.ReadLine());
                if (area == 0) break;
                switch (area)
                {
                    case 1:
                        Console.WriteLine("Write side length");
                        r = double.Parse(Console.ReadLine());
                        if (r == 0)
                        {
                            Console.WriteLine("Write correct length");
                        }
                        else
                        {
                            s = r * r;
                            Console.WriteLine($"square area - {s}");
                        }
                        break;
                    case 2:

                        Console.WriteLine("Write side of length");
                        r = double.Parse(Console.ReadLine());
                        if (r == 0)
                        {
                            Console.WriteLine("Write correct length");
                        }
                        else
                        {
                            s = Math.Sqrt(3) / 4 * r * r;
                            Console.WriteLine("triangle area - {0:f4}", s);
                        }
                        break;
                    case 3:

                        Console.WriteLine("Write side of length");
                        r = double.Parse(Console.ReadLine());
                        if (r == 0)
                        {
                            Console.WriteLine("Write correct length");
                        }
                        else
                        {
                            s = Math.PI * r * r;
                            Console.WriteLine("circle area - {0:f4}", s);
                        }
                        break;
                }
            } while (flag != 1);
            #endregion
            #region task 3_13
            a = 0;
            b = 0;
            s = 0;
            flag = 0;
            Console.WriteLine("Task 3_13");
            do
            {
                Console.WriteLine("Which shape you want to calculate area of rectangle (Write 1), triangle (Write 2), ring (Write 3). If you want to end prog write - 0");
                area = int.Parse(Console.ReadLine());
                if (area == 0)
                {
                    break;
                }
                switch (area)
                {
                    case 1:
                        
                            Console.WriteLine("Write side lengths a and b");
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            if (a == 0 || b == 0) Console.WriteLine("Write correct length");
                            else
                            {
                                s = a * b;
                                Console.WriteLine($"rectangle area - {s}");
                            }
                        break;
                    case 2:
                       
                            Console.WriteLine("Write side lengths a and b");
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            if (a == 0 || b == 0) Console.WriteLine("Write correct length");
                            else
                            {
                                s = b / 4 * (Math.Sqrt(4 * a * a - b * b));
                                Console.WriteLine("triangle area - {0:f4}", s);
                            }
                        break;
                    case 3:
                        
                            Console.WriteLine("Write two radius a and b");
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            if (a == 0 || b == 0) Console.WriteLine("write correct lenght");
                            else
                            {
                                if (a > b) s = Math.PI * (a - b);
                                else s = Math.PI * (b - a);
                                Console.WriteLine("ring area - {0:f4}", s);
                            }
                        break;
                }
            } while (flag != 1);
            #endregion
        }
    }
}
