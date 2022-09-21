using System;

namespace _1st_Lesson
{

    class Program
    {
        const string EndString = "";
        static bool Read(out double x)
        {
            string s;
            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static bool Read(out int x)
        {
            string s;
            s = Console.ReadLine();

            if (!int.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static bool Read(out int x , out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!int.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }
        static bool Read(out double x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!double.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }

        static bool CheckRead(out double x , string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if(ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static bool CheckRead(out int x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static void exercise_1_3()
        {
            double a, b, c;
            Console.WriteLine("ведите a , b");
            if (!Read(out a) || !Read(out b))
            {
                Console.WriteLine("ошибка 1_3");
                return;
            }

            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }

            Console.WriteLine(c);
        }
        static void exercise_1_4()
        {
            double a, b, c, z;
            Console.WriteLine("ведите a , b , c");
            if (!Read(out a) || !Read(out b) || !Read(out c))
            {
                Console.WriteLine("ошибка 1_4");
                return;
            }

            z = Math.Max(Math.Min(a, b), c);

            Console.WriteLine(z);
        }
        static void exercise_1_9()
        {
            double x, y;
            Console.WriteLine("ведите x");
            if (!Read(out x))
            {
                Console.WriteLine("ошибка 1_9");
                return;
            }

            if (x <= -1)
            {
                y = 0;
            }
            else if (x <= 0) 
            {
                y = 1 + x;
            }
            else
            {
                y = 1;
            }

            Console.WriteLine(y);
        }
        static void exercise_2_4()
        {
            double n;
            double R, r;
            Console.WriteLine("ведите n , R , r");

            if (!Read(out n) || !Read(out R) || !Read(out r))
            {
                Console.WriteLine("ошибка 2_4");
                return;
            }

            Console.WriteLine($"ведите {n} - точек вида x y"); ;

            int ans = 0;
            for(int i = 0; i < n; i++)
            {

                double x = 0;
                double y = 0;
                if (!Read(out x) || !Read(out y))
                {
                    Console.WriteLine("ошибка 2_4");
                    return;
                }

                if ((x * x + y * y <= R * R) && (x * x + y * y >= r * r))
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
        static void exercise_2_1()
        {
            double n;
            Console.WriteLine("ведите n");
           
            if (!Read(out n))
            {
                Console.WriteLine("ошибка 2_1");
                return;
            }

            double kolg = 0, kolb = 0 , sumg = 0 , sumb =0;
            for (int i = 0; i < n; i++)
            {
                double x = 0;
                string s;
                s = Console.ReadLine();
                //Console.WriteLine(s);
                if (!Read(out x))
                {
                    Console.WriteLine("ошибка 2_1");
                    return;
                }
                if(s == "g")
                {
                    sumg += x;
                    kolg++;
                }
                else if(s == "b")
                {
                    sumb += x;
                    kolb++;
                }
                else
                {
                    Console.WriteLine("ошибка 2_1");
                }
            }
            Console.WriteLine($"{sumg/kolg} {sumb/kolb}");
        }
        static void exercise_3_4()
        {
            string erorr = "ошибка 3_4";
            double R, r;
            string s;
            bool fl;
            Console.WriteLine("ведите R , r");

            if(!CheckRead(out R, erorr) || !CheckRead(out r, erorr))
            {
                return;
            }


            Console.WriteLine($"ведите точки вида x y"); 

            int ans = 0;
            for (int i = 0; i == i; i++)
            {

                double x = 0;
                double y = 0;

                if (!CheckRead(out x, erorr, ans.ToString()) || !CheckRead(out y, erorr, ans.ToString())) 
                {
                    return;
                }

                if ((x * x + y * y <= R * R) && (x * x + y * y >= r * r))
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
            
        }

        static void exercise_3_11()
        {
            string erorr = "ошибка 3_11";
            bool fl;
            int ans2 = 0;
            double kol = 0, x, sum = 0, ans1 = 0;
            for (int i = 0; i == i; i++)
            {
                bool D = false;
                double arg = 0;
                Console.WriteLine($"ведите 4 оценки");
                for (int j = 0; j < 4; j++)
                {
                    if (!CheckRead(out x, erorr, ans1.ToString() + " " + ans2.ToString()))
                    {
                        return;
                    }

                    if (x < 3 && !D) 
                    {
                        D = true;
                        ans2 ++;
                    }

                    arg += x;
                }
                sum += arg;
                kol += 4;
                ans1 = sum / kol;
            }

        }
        static void exercise_3_12()
        {
            string erorr = "ошибка 3_12";

            for (int i = 0; i == i; i++)
            {

                double r = 0;
                double ans = 0;
                Console.WriteLine("ведите r");

                if (!CheckRead(out r, erorr))
                {
                    return;
                }

                if (r < 0)
                {
                    Console.WriteLine(erorr);
                }

                Console.WriteLine("ведите 1(квадрат) 2(круг) 3(треугольник)");
                int w = 0;

                if (!CheckRead(out w, erorr))
                {
                    return;
                }

                if (w != 1 && w != 2 && w != 3)
                {
                    Console.WriteLine(erorr);
                    return;
                }

                if (w == 1)
                {
                    ans = r * r;
                }
                if (w == 2)
                {
                    ans = r * r * Math.PI;
                }
                if(w == 3)
                {
                    ans = r * r * Math.Sqrt(3) / 4;
                }
                Console.WriteLine(ans);
            }
        }
        static void exercise_3_13()
        {
            string erorr = "ошибка 3_13";

            for (int i = 0; i == i; i++)
            {

                double a = 0, b = 0;
                double ans = 0;
                Console.WriteLine("ведите a и b");

                if (!CheckRead(out a, erorr) || !CheckRead(out b, erorr))
                {
                    return;
                }

                if(a < 0|| b < 0)
                {
                    Console.WriteLine(erorr);
                }

                Console.WriteLine("ведите 1(прямоугольник) 2(кольцо) 3(треугольник)");
                int w = 0;

                if (!CheckRead(out w, erorr))
                {
                    return;
                }

                if (w != 1 && w != 2 && w != 3)
                {
                    Console.WriteLine(erorr);
                    return;
                }

                if (w == 1)
                {
                    ans = a * b;
                }
                if (w == 2)
                {
                    if(a < b)
                    {
                        (a, b) = (b, a);
                    }

                    ans = (a * a  - b * b) * Math.PI;
                }
                if (w == 3)
                {
                    if(a > b + b)
                    {
                        Console.WriteLine("не возможный треугольник");
                        continue;
                    }

                    ans = a * Math.Sqrt(b * b - a * a / 4) / 2;
                }

                Console.WriteLine(ans);
            }
        }
        static void Main(string[] args)
        {
            #region exercise 1_3
            exercise_1_3();
            #endregion

            #region exercise 1_4
            exercise_1_4();
            #endregion

            #region exercise 1_9
            exercise_1_9();
            #endregion

            #region exercise 2_1
            exercise_2_1();
            #endregion

            #region exercise 2_4
            exercise_2_4();
            #endregion

            #region exercise 3_4
            exercise_3_4();
            #endregion

            #region exercise 3_11
            exercise_3_11();
            #endregion

            #region exercise 3_12
            exercise_3_12();
            #endregion

            #region exercise 3_13
            exercise_3_13();
            #endregion

        }
    }
}