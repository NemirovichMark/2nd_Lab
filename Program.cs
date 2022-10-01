using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Transactions;
using static System.Math;
{
    /*
    string[] g = Console.ReadLine().Split();
    double x1 = Convert.ToDouble(g[0]);
    double y1 = Convert.ToDouble(g[1]);
    if (y1>=0 & y1+Abs(x1)<=1)
    {
        Console.WriteLine($"N1.2 Точка ({ x1 };{ y1 }) принадлежит треугольнику");
    }
    else
    {
        Console.WriteLine($"N1.2 Точка ({ x1 };{ y1 }) не принадлежит треугольнику");
    }
    Console.WriteLine("");


    double[] xs = new double[4] { 0, 1.5, 1, 3 };
    double[] ys = new double[4] { 2, 0.7, 1, 0 };
    Console.WriteLine("N1.1:");
    for (int i = 0; i <xs.Length; i++)
    {
        if (Abs(Pow(xs[i], 2) + Pow(ys[i], 2) - 4) <= Pow(10, -3))
        {
            Console.WriteLine($"Точка ({xs[i]};{ys[i]} ) принадлежит окружности");
        } 
        else
        {
            Console.WriteLine($"Точка ({xs[i]};{ys[i]} ) не принадлежит окружности");
        }
    }
    Console.WriteLine("");


    double aa = Convert.ToDouble(Console.ReadLine());
    double bb = Convert.ToDouble(Console.ReadLine());
    if (aa>0)
        Console.WriteLine($"N1.3 c = {Max(aa,bb)}");
    else
        Console.WriteLine($"N1.3 c = {Min(aa, bb)}");
    Console.WriteLine("");


    double n = Convert.ToDouble(Console.ReadLine());
    double s = 0;
    for(int i = 0; i < n; i++)
    {
        double r = Convert.ToDouble(Console.ReadLine());
        s += r;
    }
    if (s > 0 & n > 0)
    {
        s = s / n;
        Console.WriteLine($"N2.1 Средний рост {Round(s, 2)}");
    }
    else
    {
        Console.WriteLine($"N2.1 Неправильный ввод данных");
    }
    Console.WriteLine("");

    
    double norm = Convert.ToDouble(Console.ReadLine());
    double count = 0;
    for (int i = 0; i < 5; i++)
    {
        double range = Convert.ToDouble(Console.ReadLine());
        if (range>norm)
        {
            count++;
        }
    }
    Console.WriteLine($"N2.5 {count} выполнили норматив");
    Console.WriteLine("");

    Console.WriteLine("Введите r1 и r2 где r1<r2");
    double r1 = Convert.ToDouble(Console.ReadLine());
    double r2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты точек в одну строку через пробел");
    string[] gh = Console.ReadLine().Split();
    int f = 0;
    double kolv = 0;
    if (gh.Length % 2 == 0)
    {
        while (f < gh.Length)
        {
            double xx = Convert.ToDouble(gh[f]);
            double yy = Convert.ToDouble(gh[f + 1]);
            f += 2;
            if (Abs(Pow(xx, 2) + Pow(yy, 2)) >= r1 * r1 & Abs(Pow(xx, 2) + Pow(yy, 2)) <= r2 * r2)
            {
                kolv += 1;
            }
        }
        f = 0;
        Console.WriteLine($"N3.4 {kolv} точек лежат в заданном кольце");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"N3.4 Неправильный ввод координат точек");
        Console.WriteLine("");
    }


    Console.WriteLine($"N3.11:");
    Console.WriteLine("Введите результаты всех студентов в одну строку");
    string[] gg = Console.ReadLine().Split();
    double srs = 0;
    double sro = 0;
    double kolvo = 0;
    int v = 0;
    double ee = 0;
    for (int i = 0; i < gg.Length; i++)
    {
        double pr = Convert.ToDouble(gg[i]);
        if (pr < 2 | pr > 5)
        {
            ee++;
        }
    }
    if (gg.Length % 4 == 0 & ee==0)
    {
        while (v < gg.Length)
        {
            double ex1 = Convert.ToDouble(gg[v]);
            double ex2 = Convert.ToDouble(gg[v + 1]);
            double ex3 = Convert.ToDouble(gg[v + 2]);
            double ex4 = Convert.ToDouble(gg[v + 3]);
            v += 4;
            if (ex1 < 3 | ex2 < 3 | ex3 < 3 | ex4 < 3)
            {
                kolvo += 1;
            }
            else
            {
                srs = (ex1 + ex2 + ex3 + ex4) / 4;
                srs = Round(srs, 2);
                sro += srs;
            }
        }
        sro = sro / (gg.Length / 4);
        Console.WriteLine($"Количество неуспевающих учеников {kolvo}");
        Console.WriteLine($"Средний балл класса {sro}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"Неправильный вввод данных результатов экзаменов студентов");
        Console.WriteLine("");
    }


    Console.WriteLine("Введите r и площадь чего хотите узнать(квадрат - 1 ; круг - 2 ; треугольник - 3) через пробел в строку");
    string[] hh = Console.ReadLine().Split();
    int w = 0;
    double plk = 0;
    double hf = 0;
    for (int i = 1; i < hh.Length; i=i+2)
    {
        double sss = Convert.ToDouble(hh[i]);
        if (sss <1 | sss>3)
        {
            hf++;
        }
    }
    if (hh.Length % 2 == 0 & hf==0 )
    {
        Console.WriteLine($"N3.12:");
        while (w < hh.Length)
        {
            double r = Convert.ToDouble(hh[w]);
            double dd = Convert.ToDouble(hh[w + 1]);
            r=abs(r);
            switch (dd)
            {
                case 1:
                    plk = r * r;
                    plk = Round(plk, 2);
                    Console.WriteLine($"Площадь квадрата со стороной {r} равна {plk}");
                    break;
                case 2:
                    plk = PI*Pow(r,2);
                    plk = Round(plk, 2);
                    Console.WriteLine($"Площадь круга с радиусом {r} равна {plk}");
                    break;
                case 3:
                    plk = Sqrt(3)*r/4;
                    plk = Round(plk, 2);
                    Console.WriteLine($"Площадь правильного треугольника со стороной {r} равна {plk}");
                    break;
                default: 
                    Console.WriteLine("Неправильный ввод данных");
                    break;
            }
            w += 2;
        }
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("N3.12 Неправильный ввод данных");
        Console.WriteLine("");
    }


    */
    Console.WriteLine("Введите a b и площадь чего хотите узнать(прямоугольник - 1 ; кольцо - 2 ; треугольник - 3) через пробел в строку");
    string[] er = Console.ReadLine().Split();
    int z = 0;
    double pl = 0;
    double sh = 0;
    for (int i = 2; i < er.Length; i+=3)
    { 
      double ffg= Convert.ToDouble(er[i]);
        if (ffg < 1 | ffg > 3)
        {
            sh++;
        }
    }
    if (er.Length % 3 == 0 & sh==0)
    {
        Console.WriteLine($"N3.13:");
        while (z < er.Length)
        {
            double a = Convert.ToDouble(er[z]);
            double b = Convert.ToDouble(er[z + 1]);
            double uu = Convert.ToDouble(er[z + 2]);
            a = abs(a);
            b = abs(b);
            switch (uu)
            {
                case 1:
                    pl = a * b;
                    pl = Round(pl, 2);
                    Console.WriteLine($"Площадь прямоугольника со сторонами {a}, {b} равна {pl}");
                    break;
                case 2:
                    pl = Abs((PI*a*a)-(PI*b*b));
                    pl = Round(pl, 2);
                    Console.WriteLine($"Площадь кольца с радиусами {a},{b} равна {pl}");
                    break;
                case 3:
                    pl = Sqrt(Pow(b, 2) - Pow(a / 2, 2)) * (a / 2);
                    pl = Round(pl, 2);
                    Console.WriteLine($"Площадь равнобедренного треугольника со сторонами {a},{b},{b} равна {pl}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод данных");
                    break;
            }
            z += 3;
        }
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("N3.13 Неправильный ввод данных");
        Console.WriteLine("");
    }
}
