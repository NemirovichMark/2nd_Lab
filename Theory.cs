using System;

namespace _2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1_3
            double a, b, c;
            Console.Write("Enter a:");
            string vvod_a = Console.ReadLine();
            double.TryParse(vvod_a, out a);
            Console.Write("Enter b:");
            string vvod_b = Console.ReadLine();
            double.TryParse(vvod_b, out b);
            if (a > 0)
            {
                if (a > b)
                {
                    c = a;
                }
                else
                {
                    c = b;
                }
            }
            else
            {
                if (a < b)
                {
                    c = a;
                }
                else
                {
                    c = b;
                }
            }
            Console.WriteLine(c);
            #endregion

            #region Task 1_4
            double a, b, c, z;
            Console.Write("Enter a:");
            string vvod_a = Console.ReadLine();
            double.TryParse(vvod_a, out a);
            Console.Write("Enter b:");
            string vvod_b = Console.ReadLine();
            double.TryParse(vvod_b, out b);
            Console.Write("Enter c:");
            string vvod_c = Console.ReadLine();
            double.TryParse(vvod_c, out c);
            if (a > b)
            {
                if (b > c)
                {
                    z = b;
                }
                else
                {
                    z = c;
                }
            }
            else
            {
                if (a > c)
                {
                    z = a;
                }
                else
                {
                    z = c;
                }
            }
            Console.WriteLine(z);
            #endregion

            #region Task 1_5
            double r1 = 70, s1 = 36.74, r2 = 0.86, s2 = 0.74;
            double diagonal_1, radius_1, diagonal_2, radius_2;
            diagonal_1 = Math.Sqrt(s1) * Math.Pow(2, 0.5);
            radius_1 = Math.Pow(r1 / Math.PI, 0.5);
            if (diagonal_1 <= 2 * radius_1)
            {
                Console.WriteLine("1) The square will fit into the circle");
            }
            else
            {
                Console.WriteLine("1) The square won't fit in a circle");
            }

            diagonal_2 = Math.Sqrt(s2) * Math.Pow(2, 0.5);
            radius_2 = Math.Pow(r2 / Math.PI, 0.5);
            if (diagonal_2 <= 2 * radius_2)
            {
                Console.WriteLine("2) The square will fit into the circle");
            }
            else
            {
                Console.WriteLine("2) The square won't fit in a circle");
            }
            #endregion

            #region Task 2_1
            int n = 6, sum_girls, k = 0;
            double height, med_girls = 0, sum = 0, med_boys = 0;
            Console.Write("How many girls?");
            string vvod = Console.ReadLine();
            if (int.TryParse(vvod, out sum_girls))
            {
                int.TryParse(vvod, out sum_girls);
            }
            else
            {
                Console.WriteLine("Enter an integer");
            }
            if (sum_girls < 0)
            {
                Console.WriteLine("Error");
            }
            if (sum_girls > 0)
            {
                Console.Write("Enter the height of the girls in one measurement system");
                for (int i = 1; i <= sum_girls; i++)
                {
                    string height_vvod = Console.ReadLine();
                    double.TryParse(height_vvod, out height);
                    if (height > 0)
                    {
                        sum += height;
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                }
                med_girls = sum / k;
                k = 0;
                sum = 0;
                height = 0;
                Console.Write("Enter the height of the boys in one measurement system");
                for (int i = 1; i <= n - sum_girls; i++)
                {
                    string height_vvod = Console.ReadLine();
                    double.TryParse(height_vvod, out height);
                    if (height > 0)
                    {
                        sum += height;
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                }
                med_boys = sum / k;
                Console.WriteLine($"Average height of girls: {med_girls}", med_girls);
                Console.WriteLine($"Average height of boys: {med_boys}", med_boys);
            }
            if (sum_girls == 0)
            {
                Console.Write("Enter the height of the boys in one measurement system");
                for (int i = 1; i <= n; i++)
                {
                    string height_vvod = Console.ReadLine();
                    double.TryParse(height_vvod, out height);
                    if (height > 0)
                    {
                        sum += height;
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                }
                med_boys = sum / k;
                Console.WriteLine($"Average height of boys: {med_boys}", med_boys);
            }
            #endregion

            #region Task 2_5
            double min, result;
            int k = 0;
            Console.Write("Enter the minimum number of the standart:");
            string vvod_min = Console.ReadLine();
            double.TryParse(vvod_min, out min);
            if (min <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Enter the participant's result:");
                string vvod_result = Console.ReadLine();
                double.TryParse(vvod_result, out result);
                if (result < 0)
                {
                    Console.WriteLine("Error");
                    return;
                }
                if (result >= min)
                {
                    k += 1;
                }
            }
            Console.WriteLine(k);
            #endregion

            #region Task 3_4
            double R, r, x, y;
            int sum = 0;
            Console.Write("Enter a larger radius: ");
            string vvod_R = Console.ReadLine();
            double.TryParse(vvod_R, out R);
            Console.Write("Enter a smaller radius: ");
            string vvod_r = Console.ReadLine();
            double.TryParse(vvod_r, out r);
            if (r <= 0 || R <= 0 || R <= r)
            {
                Console.WriteLine("Error");
                return;
            }
            do
            {
                for (int i = 1; ; i++)
                {
                    Console.Write("Enter 1000 < x < 1000, (to end, enter '1000'): ");
                    string vvod_x = Console.ReadLine();
                    double.TryParse(vvod_x, out x);
                    if (x == 1000)
                    {
                        break;
                    }
                    Console.Write("Enter y: ");
                    string vvod_y = Console.ReadLine();
                    double.TryParse(vvod_y, out y);
                    if ((x * x + y * y <= R * R) && (x * x + y * y >= r * r)) ;
                    {
                        sum++;
                    }
                }
            } while (x < 1000);
            Console.WriteLine(sum);
            #endregion

            #region Task 3_11
            int mark, ch_mark = 0, bad = 0, bad_st = 0, k = 0, ch = 0;
            double middle, sum = 0;
            do
            {
                ch += 1;
                Console.Write($"Enter mark {ch} of student {k + 1}(to end, enter '6'): ");
                string vvod_mark = Console.ReadLine();
                int.TryParse(vvod_mark, out mark);
                if (mark < 2 || mark > 6)
                {
                    Console.Write("Error");
                    return;
                }
                if (mark == 2)
                {
                    bad++;
                }
                ch_mark += mark;
                if (ch == 4)
                {
                    if (bad == 0)
                    {
                        k += 1;
                        sum += ch_mark;
                    }
                    if (bad > 0)
                    {
                        bad_st++;
                        bad = 0;
                    }
                    ch_mark = 0;
                    ch = 0;
                }
            } while (mark < 6);
            middle = sum / (k * 4);
            Console.WriteLine($"Average score for the group: {middle}");
            Console.WriteLine($"Number of underachieving students: {bad_st}");
            #endregion

            #region Task 3_12
            int k;
            double r;
            Console.Write("Enter a number: ");
            string vvod_r = Console.ReadLine();
            double.TryParse(vvod_r, out r);
            if (r <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Command options: 1 - square area, 2 - area of the circle, 3 - area of an equilateral triangle");
            Console.Write("Enter command 1, 2 or 3: ");
            string vvod_k = Console.ReadLine();
            int.TryParse(vvod_k, out k);
            switch (k)
            {
                case 1:
                    r = r * r;
                    Console.WriteLine($"Square area: {r}");
                    Console.ReadKey();
                    return;
                case 2:
                    r = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"Area of the circle: {r}");
                    Console.ReadKey();
                    return;
                case 3:
                    r = (Math.Pow(r, 2) * Math.Sqrt(3)) / 4;
                    Console.WriteLine($"Area of an equilateral triangle: {r}");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    return;
            }
            #endregion

            #region Task 3_13
            int k;
            double a, b, s;
            Console.Write("Enter a first number: ");
            string vvod_a = Console.ReadLine();
            double.TryParse(vvod_a, out a);
            Console.Write("Enter a second number: ");
            string vvod_b = Console.ReadLine();
            double.TryParse(vvod_b, out b);
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Command options: 1 - rectangle area, 2 - ring area, 3 - area of an isosceles triangle");
            Console.Write("Enter command 1, 2 or 3: ");
            string vvod_k = Console.ReadLine();
            int.TryParse(vvod_k, out k);
            switch (k)
            {
                case 1:
                    s = a * b;
                    Console.WriteLine($"Rectangle area: {s}");
                    Console.ReadKey();
                    return;
                case 2:
                    s = Math.Abs(Math.PI * a * a - Math.PI * b * b);
                    Console.WriteLine($"Ring area: {s}");
                    Console.ReadKey();
                    return;
                case 3:
                    if ((4 * b * b - a * a) <= 0)
                    {
                        Console.WriteLine("The triangle doesn't exist");
                        return;
                    }
                    s = (a * Math.Sqrt(4 * b * b - a * a)) / 4;
                    Console.WriteLine($"Area of an isosceles triangle: {s}");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    return;
            }
            #endregion
        }

    }
}
