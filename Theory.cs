using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            //#region 2lvl, 1
            //int r = 2;
            //double x, y;
            //Console.WriteLine("Введите x");
            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите y");
            //y = double.Parse(Console.ReadLine());
            //if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
            //{
            //    Console.WriteLine("Внутри");
            //}
            //else
            //{
            //    Console.WriteLine("Снаружи");
            //}
            //#endregion

            //#region 1lvl, 2
            //double x, y;
            //Console.WriteLine("Введите x");
            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите y");
            //y = double.Parse(Console.ReadLine());
            //if (y + Math.Abs(x) <= 1 && (y >= 0))
            //{
            //    Console.WriteLine("Внутри");
            //}
            //else
            //{
            //    Console.WriteLine("Снаружи");
            //}
            //#endregion

            //#region 1lvl,3
            //double a, b;
            //Console.WriteLine("Введите а");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите b");
            //b = double.Parse(Console.ReadLine());
            //if (a > 0)
            //{
            //    Console.WriteLine("c= " + Math.Max(a, b));
            //}
            //else
            //{
            //    Console.WriteLine("c= " + Math.Min(a, b));
            //}
            //#endregion


            //#region 2lvl, 1

            //int n = 10;
            //double sr, r, s = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите рост ученика");
            //    r = double.Parse(Console.ReadLine());
            //    s += r;
            //}
            //sr = s / n;
            //Console.WriteLine("Средний рост всех учеников=" + sr);
            //#endregion

            //#region 2lvl,5
            //int n = 30;
            //int normativ = 10;
            //double s = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите результат спортсмена");
            //    double resultat = double.Parse(Console.ReadLine());
            //    if (resultat <= normativ)
            //    {
            //        s++;
            //        Console.WriteLine("Выполнил");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не выполнил");
            //    }
            //}
            //Console.WriteLine("всего выполнили " + s + " спортсменов");
            //#endregion

            //#region 3lvl, 4
            //double s = 0;
            //Console.WriteLine("Введите количество точек");
            //double k = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите координаты центра окружности");
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите радиус внутреннего кольца");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите радиус внешнего кольца");
            //double R = double.Parse(Console.ReadLine());
            //for (int i = 1; i <= k; i++)
            //{
            //    Console.WriteLine("Введите координаты по оси x");
            //    double x = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите координаты по оси y");
            //    double y = double.Parse(Console.ReadLine());

            //    double q = Math.Sqrt((Math.Pow((x - a), 2) + Math.Pow((y - b), 2)));
            //    if (q >= r && q <= R)
            //    {
            //        s++;
            //        Console.WriteLine("точка лежит в кольце");
            //    }
            //}
            //Console.WriteLine(s + " точек лежит в кольце");
            //#endregion


            //#region 3lvl,11
            //Console.WriteLine("Введите количество студентов");
            //double st = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите количество экзаменов");
            //double k = double.Parse(Console.ReadLine());
            //double sr = 0;
            //int schetchik = 0;
            //for (int i = 1; i <= st; i++)
            //{
            //    Console.WriteLine("Введите оценки студента " + i);
            //    bool b = true;
            //    for (int n = 1; n <= k; n++)
            //    {
            //        Console.WriteLine("Введите оценку за экзамен " + n);
            //        double q = double.Parse(Console.ReadLine());
            //        sr += q;
            //        if (q < 3)
            //        {
            //            b = false;
            //        }
            //    }
            //    if (b == false)
            //    {
            //        schetchik++;
            //    }
            //}
            //Console.WriteLine("Средний балл = " + sr / (st * k) + " Количество неуспевающих студентов = " + schetchik);
            //#endregion

            //#region 3lvl,12
            //Console.WriteLine("Введите количество значений");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите значение r");
            //    double r = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Это квадрат? y/n");
            //    string c1 = Console.ReadLine();
            //    Console.WriteLine("Это круг? y/n");
            //    string c2 = Console.ReadLine();
            //    Console.WriteLine("Это треугольник? y/n");
            //    string c3 = Console.ReadLine();
            //    if (c1 == "y")
            //    {
            //        Console.WriteLine("Площадь квадрата =" + r * r);
            //    }
            //    if (c2 == "y")
            //    {
            //        Console.WriteLine("Площадь круга =" + Math.PI * r * r);
            //    }
            //    if (c3 == "y")
            //    {
            //        Console.WriteLine("Площадь треугольника =" + r * r * Math.Sqrt(3) / 4);
            //    }
            //}
            //#endregion

            #region 3, lvl 13
            Console.WriteLine("Введите количество пар значений");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите значение A");
                double A = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B");
                double B = double.Parse(Console.ReadLine());
                Console.WriteLine("Это прямоугольник? y/n");
                string c1 = Console.ReadLine();
                Console.WriteLine("Это кольцо? y/n");
                string c2 = Console.ReadLine();
                Console.WriteLine("Это треугольник? y/n");
                string c3 = Console.ReadLine();
                if (c1 == "y")
                {
                    Console.WriteLine("Площадь прямоугольника =" + A * B);
                }
                if (c2 == "y")
                {
                    Console.WriteLine("Площадь кольца =" + ((Math.PI * A * A) - (Math.PI * B * B)));
                }
                if (c3 == "y")
                {
                    Console.WriteLine("Площадь треугольника =" + Math.Sqrt(4 * A * A - B * B) * B / 4);
                }
            }
            #endregion
        }
    }
}
