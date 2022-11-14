using System;
using System.Diagnostics.Metrics;
// Nizamiev, Laboratorka N2
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ////L2, LVL1, TSK1
            //double r = Convert.ToDouble(Console.ReadLine());
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());

            //if (a * a + b * b < r * r)
            //{
            //    Console.WriteLine("Inside the circle");
            //}
            //else if (a * a + b * b == r * r)
            //{
            //    Console.WriteLine("On the circle");
            //}
            //else
            //{
            //    Console.WriteLine("Not on the circle");
            //}

            ////L2, LVL1, TSK3
            //Console.WriteLine("Enter a, b");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c;
            //if (a > 0)
            //{
            //    c = Math.Max(a, b);
            //}
            //else
            //{
            //    c = Math.Min(a, b);
            //}
            //Console.WriteLine("Answer: " + c);
            //Console.ReadLine();

            ////L2, LVL1, TSK4
            //Console.WriteLine("Enter a, b, c");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double z = Math.Max(Math.Min(a, b), c);
            //Console.WriteLine(z);
            //Console.ReadLine();



            ////L2, LVL2, TSK1
            //Console.WriteLine("Enter count of students");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num < 1)
            //{
            //    Console.WriteLine("Enter correct count of students");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}
            //double sum = 0;
            //int[] nums = new int[100];
            //for (int n = num; n > 0; n -= 1)
            //{
            //    Console.WriteLine($"Enter height of {n} student");
            //    nums[n] = Convert.ToInt32(Console.ReadLine());
            //    if (nums[n] < 1)
            //    {
            //        Console.WriteLine("Enter correct height");
            //        nums[n] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int n = num; n > 0; n -= 1)
            //{
            //    sum += nums[n];
            //}
            //Console.WriteLine("Answer:");
            //Console.WriteLine(sum / num);

            ////L2, LVL2, TSK2
            //Console.WriteLine("Enter count of students");
            //int num = Convert.ToInt32(Console.ReadLine());
            //double[] array = new double[num + 1];
            //double sum = 0;
            //for (int n = num; n > 0; n -= 1)
            //{
            //    Console.WriteLine("Enter weight of " + n + " student");
            //    array[n] = Convert.ToDouble(Console.ReadLine());
            //    if (array[n] < 30)
            //    {
            //        sum += 200;
            //    }
            //}
            //Console.WriteLine("Answer: " + sum / 1000 + " Litres");



            ////L2, LVL3, TSK4
            //Console.WriteLine($"Enter R1 (outer)");
            //double R1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Enter R2 (inner)");
            //double R2 = Convert.ToDouble(Console.ReadLine());
            //int n = 0, k = 0;
            //double x = 0, y;
            //do
            //{
            //    if (R1 > R2 & R2 > 0)
            //    {
            //        Console.WriteLine("Enter x, if you want to stop, enter '434343' ");
            //        x = Convert.ToDouble(Console.ReadLine());
            //        if (x == 434343)
            //        {
            //            break;
            //        }
            //        Console.WriteLine("Enter y");
            //        y = Convert.ToDouble(Console.ReadLine());
            //        n += 1;
            //        if (x * x + y * y <= R1 * R1 && x * x + y * y <= R2 * R2)
            //        {
            //            k += 1;
            //        }
            //    }

            //} while (x != 434343);
            //Console.WriteLine("Count of points: " + n + " ,count of points in ring: " + k);

            ////L2, LVL3, TSK11
            //int s1, s2, s3, s4;
            //Console.WriteLine("Enter count of students");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum, ans, sum2 = 0, k = 0, cnt = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter grades");
            //    s1 = Convert.ToInt32(Console.ReadLine());
            //    s2 = Convert.ToInt32(Console.ReadLine());
            //    s3 = Convert.ToInt32(Console.ReadLine());
            //    s4 = Convert.ToInt32(Console.ReadLine());
            //    if ((s1 < 2) | (s2 < 2) | (s3 < 2) | (s4 < 2) | (s1 > 5) | (s2 > 5) | (s3 > 5) | (s4 > 5))
            //    {
            //        Console.WriteLine("Enter correct grades");
            //        s1 = Convert.ToInt32(Console.ReadLine());
            //        s2 = Convert.ToInt32(Console.ReadLine());
            //        s3 = Convert.ToInt32(Console.ReadLine());
            //        s4 = Convert.ToInt32(Console.ReadLine());
            //    }
            //    if ((s1 <= 5) && (s2 <= 5) && (s3 <= 5) && (s4 <= 5))
            //    {
            //        if ((s1 != 2) && (s2 != 2) && (s3 != 2) && (s4 != 2))
            //        {
            //            sum = (s1 + s2 + s3 + s4) / 4;
            //            cnt += 1;
            //            sum2 += sum;
            //        }

            //        if ((s1 <= 2) || (s2 <= 2) || (s3 <= 2) || (s4 <= 2))
            //        {
            //            k += 1;
            //        }
            //    }
            //}
            //ans = sum2 / cnt;
            //Console.WriteLine("Count of losers: " + k + ", group average: " + ans);

            ////L2, LVL3, TSK12, квадрат, круг, р/с треуг

            //Console.WriteLine("Enter count of r");
            //int n = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter r");
            //    double r = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("if you want calculate square, write '1', circle, write '2', triangle, write '3'");
            //    double dly = Convert.ToDouble(Console.ReadLine());
            //    switch (dly)
            //    {
            //        case 1:
            //            Console.WriteLine($"Squere area: {r * r}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"Circle area: {Math.PI * r * r}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"Triangle area: {Math.Sqrt(3) * r * r}");
            //            break;
            //        default:
            //            break;
            //    }
            //}

            ////L2, LVL3, TSK13
            //Console.WriteLine("Enter count of A and B");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double c;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter A");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    if (a < 1)
            //    {
            //        Console.WriteLine("Enter Correct A");
            //        a = Convert.ToDouble(Console.ReadLine());
            //    }
            //    Console.WriteLine("Enter B");
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    if (b < 1)
            //    {
            //        Console.WriteLine("Enter Correct B");
            //        b = Convert.ToDouble(Console.ReadLine());
            //    }
            //    Console.WriteLine("if you want calculate area of rectangle, write '1', ring, write '2', triangle, write '3'");
            //    double dly = Convert.ToDouble(Console.ReadLine());
            //    switch (dly)
            //    {
            //        case 1:
            //            Console.WriteLine($"Area of rectangle: {a * b}");
            //            break;
            //        case 2:
            //            if (a > b)
            //            {
            //                Console.WriteLine($"Area of ring: {Math.PI * a * a - Math.PI * b * b}");
            //            }
            //            else
            //                Console.WriteLine($"Area of ring: {Math.PI * b * b - Math.PI * a * a}");
            //            break;
            //        case 3:
            //            c = Math.Sqrt(b * b - (a * a / 4));
            //            Console.WriteLine($"Area of triangle: {0.5 * a * c}");
            //            break;
            //        default:
            //            break;

            //    }
            //}
        }
    }
}
