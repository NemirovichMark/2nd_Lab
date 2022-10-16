using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace LABA_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  #region 1lvl, 1
            //  int r = 2;
            //  double x, y; 
            //  Console.WriteLine("Введите x");

            //while (  !double.TryParse(Console.ReadLine(),out x))
            //  {
            //  }
            //  Console.WriteLine("Введите y");
            // while ( !double.TryParse(Console.ReadLine(), out y))
            //  {
            //  }
            //  if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
            //  {
            //      Console.WriteLine("Внутри");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Снаружи");
            //  }
            //  #endregion

            // #region 1lvl, 2
            // double x, y;
            // Console.WriteLine("Введите x");
            //while (  !double.TryParse(Console.ReadLine(), out x))
            // {
            // }
            // Console.WriteLine("Введите y");
            // while (!double.TryParse(Console.ReadLine(), out y))
            // {
            // }
            // if (y + Math.Abs(x) <= 1 && (y >= 0))
            // {
            //     Console.WriteLine("Внутри");
            // }
            // else
            // {
            //     Console.WriteLine("Снаружи");
            // }
            // #endregion

            //#region 1lvl,3
            //double a, b;
            //Console.WriteLine("Введите а");
            //while ( !double.TryParse(Console.ReadLine(), out a))
            //{ }
            //Console.WriteLine("Введите b");
            //while ( !double.TryParse(Console.ReadLine(), out b))
            //{ }
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
            //    while (!double.TryParse(Console.ReadLine(), out r) || r<=0  ) 
            //    {
            //        Console.WriteLine("Рост должен быть положительным");
            //    }
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
            //double q;
            //int schetchik = 0;
            //for (int i = 1; i <= st; i++)
            //{
            //    Console.WriteLine("Введите оценки студента " + i);
            //    bool b = true;
            //    for (int n = 1; n <= k; n++)
            //    {
            //        Console.WriteLine("Введите оценку за экзамен " + n);
            //         while ( !double.TryParse(Console.ReadLine(), out q) || q<2 || q>5)
            //        {
            //            Console.WriteLine("Оценка должна быть от 2 до 5");
            //        }
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
            //double r;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите значение r");
            //    while ( !double.TryParse(Console.ReadLine(), out r) || r<0)
            //    { }
            //    Console.WriteLine("Это квадрат(1), круг(2) или треугольник(3)?");
            //    string c1 = Console.ReadLine();
            //    switch (c1)
            //    {
            //        case "1":
            //            Console.WriteLine("Площадь квадрата =" + r * r);
            //            break;
            //        case "2":
            //            Console.WriteLine("Площадь круга = " + Math.PI * r * r);
            //            break;
            //        case "3":
            //            Console.WriteLine("Площадь треугольника =" + r * r * Math.Sqrt(3) / 4);
            //            break;
            //        default:Console.WriteLine("Введите 1 или 2 или 3");
            //            break;
            //    }

            //    }
            //#endregion

            //#region 3, lvl 13
            //Console.WriteLine("Введите количество пар значений");
            //int n = int.Parse(Console.ReadLine());
            //double A,B;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите значение A");
            //while  (   !double.TryParse(Console.ReadLine(), out A) || A<=0)
            //    {
            //        Console.WriteLine("A должна быть положительной");
            //    }
            //    Console.WriteLine("Введите значение B");
            //while (!double.TryParse(Console.ReadLine(), out B) || B<=0)
            //    {
            //        Console.WriteLine("B должна быть положительной");
            //    }
            //    Console.WriteLine("Это прямоугольник(1), кольцо(2) или треугольник(3)?");
            //    string c1 = Console.ReadLine();
            //    switch(c1)
            //    {
            //        case "1":
            //            Console.WriteLine("Площадь прямоугольника =" + A * B);
            //            break;
            //            case "2":
            //            Console.WriteLine("Площадь кольца =" + ((Math.PI * A * A) - (Math.PI * B * B)));
            //            break;
            //        case "3":
            //            Console.WriteLine("Площадь треугольника =" + (Math.Sqrt(Math.Abs(4 * A * A - B * B))) * B / 4);
            //            break;
            //        default: Console.WriteLine("Введите 1 или 2 или 3");
            //            break;
            //    }
            //}
            //#endregion
        }
    }
}
