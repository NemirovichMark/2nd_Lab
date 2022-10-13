using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ERROR = "Input isn't correct!";

            #region Task_1 _1
            Console.WriteLine("Task 1.1");
            double x, y, r;
            #region INPUT
            Console.Write("Write X: ");
            if ((!double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write Y: ");
            if ((!double.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write R: ");
            if ((!double.TryParse(Console.ReadLine(), out r)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            #endregion
            if (Math.Abs(x * x + y * y - r * r) <= 0.01)
            {
                Console.WriteLine("Dot on circle :)\n");
            }
            else
            {
                Console.WriteLine("Dot is not on circle :(\n");
            }
            #endregion

            #region Task_1_2
            Console.WriteLine("Task 1.2");
            #region INPUT
            Console.Write("Write X: ");
            if ((!double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write Y: ");
            if ((!double.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            #endregion
            if ((y >= 0) && (y + Math.Abs(x) <= 1))
            {
                Console.WriteLine("Dot IN\n");
            }
            else
            {
                Console.WriteLine("Dot OUT\n");
            }
            #endregion 

            #region Task_1_3
            Console.WriteLine("Task 1.3");
            double a, b, c;
            #region INPUT
            Console.Write("Write A: ");
            if ((!double.TryParse(Console.ReadLine(), out a)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write B: ");
            if ((!double.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine(ERROR);
                return;
            }
            #endregion
            if (a > 0)
            {
                if (a > b) c = a;
                else c = b;
            }
            else
            {
                if (a < b) c = a;
                else c = b;
            }
            Console.WriteLine(c + "\n");
        #endregion

            #region Task_2_1
            Console.WriteLine("Task 2.1");
            double sm = 0, sw = 0, km = 0, kw = 0, height;
            Console.Write("Write number of students: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Write the height the {i} student: ");
                if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write($"Write the gender the {i} student (Woman or Man): ");
                string gender = Console.ReadLine();
                if  (gender == "Man")
                {
                    sm += height;
                    km += 1;
                }
                else if (gender == "Woman")
                {
                    sw += height;
                    kw += 1;
                }
                else
                {
                    Console.WriteLine(ERROR);
                    return;
                }
            }
            sm = sm / km;
            sw = sw / kw;
            Console.WriteLine($"Average height of women: {sw}");
            Console.WriteLine($"Average height of men: {sm}\n");
            #endregion

            #region Task_2_2
            Console.WriteLine("Task 2.2");
            double k = 0;
            #region INPUT
            Console.Write("Write number of dots: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write radius of the circle: ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write a: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write b: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.WriteLine("\n");
            #endregion
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Write coordinates of {i} dot");
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write Y: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    k++;
                }
            }
            Console.WriteLine($"Number of dots in circle: {k}");
        #endregion

            #region Task_3_4
            Console.WriteLine("Task 3.4");
            k = 0;
            #region INPUT
            Console.Write("Write inner radius: ");
            if (!double.TryParse(Console.ReadLine(), out double r1) || r1 <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write outer radius: ");
            if (!double.TryParse(Console.ReadLine(), out double r2) || r1 >= r2 || r2 <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            #endregion
            Console.WriteLine("To end write X = 1000");
            do
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write Y: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                if ((x * x + y * y > r1 * r1) && (x * x + y * y < r2 * r2))
                {
                    k++;
                }
                Console.WriteLine("\n");
            } while (x != 1000);
            Console.WriteLine($"Number of dots in ring: {k}");
        #endregion

            #region Tasl_3_11
            Console.WriteLine("Task 3.11");
            Console.Write("Write the number of students: ");
            double avg = 0, avge = 0, d;
            k = 0;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Write the mark of the first exam (2 - 5): ");
                if (!double.TryParse(Console.ReadLine(), out a) || a < 2 || a > 5)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write the mark of the second exam (2 - 5): ");
                if (!double.TryParse(Console.ReadLine(), out b) || b < 2 || b > 5)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write the mark of the third exam (2 - 5): ");
                if (!double.TryParse(Console.ReadLine(), out c) || c < 2 || c > 5)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write the mark of the fourth exam (2 - 5): ");
                if (!double.TryParse(Console.ReadLine(), out d) || d < 2 || d > 5)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.WriteLine("\n");
                avge = (a + b + c + d) / 4;
                if (avge < 2.5)
                {
                    k += 1;
                }
                else
                {
                    avg += avge;
                }
            }
            avg = avg / (n-k);
            Console.WriteLine($"Number of underachieving students: {k}");
            Console.WriteLine($"Average mark of students in the group: {avg:f2}\n");
        #endregion

            #region Task_3_12
            Console.WriteLine("Task 3.12");
            Console.Write("Write number of values: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Write R: ");
                if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.WriteLine("1 - to calculate the area of a square with side R");
                Console.WriteLine("2 - to calculate the area of a circle with radius R");
                Console.WriteLine("3 - to calculate the area of an equilateral triangle with side R");
                Console.Write("Chose: ");
                if (!int.TryParse(Console.ReadLine(), out int chose))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                switch (chose)
                {
                    case 1:
                        Console.WriteLine($"Area of a square: {r * r}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Area of a circle: {(Math.PI * (r * r)):f2}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Area of an equilateral triangle: {((Math.Pow(3, 0.5) * (r * r)) / 4):f2}\n");
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }
            #endregion

            #region Task_3_13
            Console.WriteLine("Task 3.13");
            Console.Write("Write number of values: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Write A: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.Write("Write B: ");
                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                Console.WriteLine("1 - to calculate the area of a rectangle with sides A and B");
                Console.WriteLine("2 - to calculate the area of a ring enclosed between two circles with radii A and B");
                Console.WriteLine("3 - to calculate the area of an isosceles triangle with sides A, B, B");
                Console.Write("Chose: ");
                if (!int.TryParse(Console.ReadLine(), out int chose))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                switch (chose)
                {
                    case 1:
                        Console.WriteLine($"Area of a rectangle: {a * b}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Area of a ring: {(Math.PI * Math.Abs(a * a - b * b)):f2}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Area of an isosceles triangle: {((a / 4) * Math.Sqrt(4 * (b * b) - (a * a))):f2}\n");
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }
            #endregion
        }
    }
}
