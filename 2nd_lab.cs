using System;


namespace _2nd_lab
{
    internal class Program
    {
        static void Main()
        {
            #region 1.7
            double x_1_7, y_1_7;
            Console.WriteLine("enter x");
            x_1_7 = double.Parse(Console.ReadLine());
            if (Math.Abs(x_1_7) > 1)
            {
                y_1_7 = 1;
            }
            else
            {
                y_1_7 = Math.Abs(x_1_7); 
            }
            Console.WriteLine(y_1_7);
            #endregion

            #region 1.8
            double y_1_8, x_1_8;
            Console.WriteLine("enter x");
            x_1_8 = double.Parse(Console.ReadLine());
            if (Math.Abs(x_1_8) >= 1)
            {
                y_1_8 = 0;
            }
            else
            {
                y_1_8 = Math.Pow(x_1_8, 2) - 1;
            }
            Console.WriteLine(y_1_8);
            #endregion

            #region 1.9
            double y_1_9, x_1_9;
            Console.WriteLine("enter x");
            x_1_9 = double.Parse(Console.ReadLine());
            if (x_1_9 <= -1)
            {
                y_1_9 = 0;
            }
            else 
                if((x_1_9 > -1) && (x_1_9 <= 0));
            {
                y_1_9 = 1 + x_1_9;
            }
            Console.WriteLine(y_1_9);
            #endregion

            #region 2.1
            double count, count_g, count_m, sd = 0, sm = 0;
            Console.WriteLine("enter count");
            count = double.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine("enter count of girls");
            count_g = double.Parse(Console.ReadLine());
            Console.WriteLine("enter count of boys");
            count_m = double.Parse(Console.ReadLine());
            if ((count_m + count_g <= count) && (count_m > 0) && (count_g > 0))
            {
                for (int i = 1; i <= count_g; i++)
                {
                    int rost = rnd.Next(100, 180);
                    sd = sd + rost;
                }
                for (int i1 = 1; i1 <= count_m; i1++)
                {
                    int rost1 = rnd.Next(130, 220);
                    sm = sm + rost1;
                }
            }
            else Console.WriteLine("count of boys and girls > count or 0");
            Console.WriteLine($"average boys height = {Math.Round(sm / count_m, 1)} cm \t average girls height = {Math.Round(sd / count_g),1} cm");
            #endregion

            #region 2.9
            double n1, max_dist = 200, res;
            Console.WriteLine("enter count of swimmers ");
            n1 = double.Parse(Console.ReadLine());
            Random rnd1 = new Random();
            for (int i = 1; i <= n1; i++)
            {
                res = rnd1.Next(123, 199);
                if (res < max_dist)
                {
                    max_dist = res;
                }
            }
            Console.WriteLine($"best time {max_dist} s");
            #endregion

            #region 3.4
            double r1, r2, n, x, y, ct = 0, len = 0;
            Console.WriteLine("input  count of dots");
            n = double.Parse(Console.ReadLine());
            Random rnd2 = new Random();
            Console.WriteLine("enter r1");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter r2");
            r2 = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter coordinate х");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("enter coordinate y");
                y = double.Parse(Console.ReadLine());
                len = x * x + y * y;
                if ((len >= r1 * r1) && (len <= r2 * r2))
                {
                    ct = ct + 1;
                }
            }
            Console.WriteLine($"count of dots ={ct}");
            #endregion

            #region 3.11
            double sum, summa = 0, cnt_bad = 0, cnt_good = 0;
            string key;
            double ex1, ex2, ex3, ex4;
            Random rnd3 = new Random();
            bool trigger = true;
            while (trigger)
            {
                Console.WriteLine("to continue enter +, to leave enter - ");
                key = Console.ReadLine();
                if (key == "-")
                {
                    trigger = false;
                }
                if (key == "+")
                {
                    Console.WriteLine("enter marks for 4 exams");
                    ex1 = double.Parse(Console.ReadLine());
                    ex2 = double.Parse(Console.ReadLine());
                    ex3 = double.Parse(Console.ReadLine());
                    ex4 = double.Parse(Console.ReadLine());
                    if ((ex1 != 2) && (ex2 != 2) && (ex3 != 2) && (ex4 != 2))
                    {
                        cnt_good = cnt_good + 1;
                        sum = (ex1 + ex2 + ex3 + ex4) / 4;
                        summa = summa + sum;
                    }
                    if ((ex1 <= 2) || (ex2 <= 2) || (ex3 <= 2) || (ex4 <= 2))
                    {
                        cnt_bad = cnt_bad + 1;
                    }
                    Console.WriteLine($"count of failed = {cnt_bad}\t avg of good marks = {summa / cnt_good}");
                }
            }
            #endregion

            #region 3.12
            double R, g;
            string c;
            bool trigger1 = true;
            while (trigger1)
            {
                Console.WriteLine("to continue +, to leave - ");
                c = Console.ReadLine();
                if (c == "-")
                {
                    trigger1 = false;
                }
                if (c == "+")
                {
                    Console.WriteLine("enter r");
                    R = double.Parse(Console.ReadLine());
                    Console.WriteLine("to get a square of a square enter 1\t to get a square of circle enter 2\t to get a square of triangle enter 3");
                    g = double.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 1:
                            Console.WriteLine($"square of a square = {R * R}");
                            break;
                        case 2:
                            Console.WriteLine($"square of a circle = {Math.PI * R * R}");
                            break;
                        case 3:
                            Console.WriteLine($"square of a triangle = {Math.Sqrt(3) * R * R / 4}");
                            break;
                    }
                }
            }
            Console.WriteLine();
            #endregion

            #region 3.13
            double A, g1, B, h;
            string f;
            bool trigger_nigger = true;
            while (trigger_nigger)
            {
                Console.WriteLine("to continue +, to leave - ");
                f = Console.ReadLine();
                if (f == "-")
                {
                    trigger_nigger = false;
                }
                if (f == "+")
                {
                    Console.WriteLine("enter A");
                    A = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter B");
                    B = double.Parse(Console.ReadLine());
                    Console.WriteLine("to get a square of a rectangle press 1\t to get a square of a ring press 2\t to get a square of a triangle press 3");
                    g1 =
                    double.Parse(Console.ReadLine());
                    switch (g1)
                    {
                        case 1:
                            Console.WriteLine($" square of a rectangle = {A * B}");
                            break;
                        case 2:
                            if (A > B)
                            {
                                Console.WriteLine($"square of a ring = {Math.PI * A * A - Math.PI * B * B}");
                            }
                            else Console.WriteLine($"square of a ring = {Math.PI * B * B - Math.PI * A * A}");
                            break;
                        case 3:
                            h = Math.Sqrt(B * B - (A * A / 4));
                            Console.WriteLine($"square of a triangle = {0.5 * A * h}");
                            break;
                    }
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
