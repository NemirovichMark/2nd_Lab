using System;


namespace _2nd_lab
{
    internal class Program
    {
        static void Main()
        {
            #region 1.7
            double x, y;
            Console.WriteLine("enter x");
            double.TryParse(Console.ReadLine(), out x);
            if (Math.Abs(x) > 1)
            {
                y = 1;
            }
            else
            {
                y = Math.Abs(x);
            }
            Console.WriteLine(y);
            #endregion

            #region 1.8
            y = 0;
            x = 0;
            Console.WriteLine("enter x");
            double.TryParse(Console.ReadLine(), out x);
            if (Math.Abs(x) >= 1)
            {
                y = 0;
            }
            else
            {
                y = Math.Pow(x, 2) - 1;
            }
            Console.WriteLine(y);
            #endregion

            #region 1.9
            y = 0;
            x = 0;
            Console.WriteLine("enter x");
            double.TryParse(Console.ReadLine(), out x);
            if (x <= -1)
            {
                y = 0;
            }
            else
                if ((x > -1) && (x <= 0)) ;
            {
                y = 1 + x;
            }
            Console.WriteLine(y);
            #endregion

            #region 2.1
            double count, count_g, count_m, sd = 0, sm = 0;
            Console.WriteLine("enter count");
            double.TryParse(Console.ReadLine(), out count);
            Random rnd = new Random();
            Console.WriteLine("enter count of girls");
            double.TryParse(Console.ReadLine(), out count_g);
            Console.WriteLine("enter count of boys");
            double.TryParse(Console.ReadLine(), out count_m);
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
            double.TryParse(Console.ReadLine(), out n1);
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
            double r1, r2, n, ct = 0, len = 0;
            x = 0;
            y = 0;
            Console.WriteLine("input  count of dots");
            double.TryParse(Console.ReadLine(), out n);
            Random rnd2 = new Random();
            Console.WriteLine("enter r1");
            double.TryParse(Console.ReadLine(), out r1);
            Console.WriteLine("enter r2");
            double.TryParse(Console.ReadLine(), out r2);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter coordinate х");
                double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("enter coordinate y");
                double.TryParse(Console.ReadLine(), out y);
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
                Console.WriteLine("to continue enter +, to leave enter -  (3.11)");
                key = Console.ReadLine();
                if (key == "-")
                {
                    trigger = false;
                }
                if (key == "+")
                {
                    Console.WriteLine("enter marks for 4 exams");
                    double.TryParse(Console.ReadLine(), out ex1);
                    double.TryParse(Console.ReadLine(), out ex2);
                    double.TryParse(Console.ReadLine(), out ex3);
                    double.TryParse(Console.ReadLine(), out ex4);
                    if ((ex1 >= 2) && (ex1 <= 5) && (ex2 >= 2) && (ex2 <= 5) && (ex3 >= 2) && (ex3 <= 5) && (ex4 >= 2) && (ex4 <= 5))
                    {
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
                    else
                    {
                        Console.WriteLine("MARKS ONLY FROM 1 TO 5");
                    }
                }
                #endregion

                #region 3.12
                double R, g;
                string c;
                bool trigger1 = true;
                while (trigger1)
                {
                    Console.WriteLine("to continue +, to leave - (3.12)");
                    c = Console.ReadLine();
                    if (c == "-")
                    {
                        trigger1 = false;
                    }
                    if (c == "+")
                    {
                        Console.WriteLine("enter r");
                        double.TryParse(Console.ReadLine(), out R);
                        Console.WriteLine("to get a square of a square enter 1\t to get a square of circle enter 2\t to get a square of triangle enter 3");
                        double.TryParse(Console.ReadLine(), out g);
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
                    Console.WriteLine("to continue +, to leave - (3.13)");
                    f = Console.ReadLine();
                    if (f == "-")
                    {
                        trigger_nigger = false;
                    }
                    if (f == "+")
                    {
                        Console.WriteLine("enter A");
                        double.TryParse(Console.ReadLine(), out A);
                        Console.WriteLine("enter B");
                        double.TryParse(Console.ReadLine(), out B);
                        Console.WriteLine("to get a square of a rectangle press 1\t to get a square of a ring press 2\t to get a square of a triangle press 3");
                        double.TryParse(Console.ReadLine(), out g1);
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
}
