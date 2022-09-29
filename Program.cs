using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Transactions;
using static System.Math;
{
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


    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    if (a>0)
        Console.WriteLine($"N1.3 c = {Max(a,b)}");
    else
        Console.WriteLine($"N1.3 c = {Min(a, b)}");
    Console.WriteLine("");


    double n = Convert.ToDouble(Console.ReadLine());
    double s = 0;
    for(int i = 0; i < n; i++)
    {
        double r = Convert.ToDouble(Console.ReadLine());
        s += r;
    }
    s = s / n;
    Console.WriteLine($"N2.1 Средний рост {Round(s, 2)}");
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
    string[] gh = Console.ReadLine().Split();
    int f = 0;
    double kolv = 0;
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


    Console.WriteLine($"N3.11:");
    Console.WriteLine("Введите результаты всех студентов в одну строку");
    string[] gg = Console.ReadLine().Split();
    double srs = 0;
    double sro = 0;
    double kolvo = 0;
    while (f < gg.Length)
    {
        double ex1 = Convert.ToDouble(gg[f]);
        double ex2 = Convert.ToDouble(gg[f + 1]);
        double ex3 = Convert.ToDouble(gg[f + 2]);
        double ex4 = Convert.ToDouble(gg[f + 3]);
        f += 4;
        srs = (ex1 + ex2 + ex3 + ex4) / 4;
        srs = Round(srs, 2);
        sro += srs;
        if (ex1 <3 | ex2 <3 | ex3 <3 | ex4 <3 )
        {
            kolvo += 1;
        }
    }
    sro = sro / (gg.Length / 4);
    Console.WriteLine($"Количество неуспевающих учеников {kolvo}");
    Console.WriteLine($"Средний балл класса {sro}");
    Console.WriteLine("");


    Console.WriteLine("Введите r и площадь чего хотите узнать(квадрат - кв ; круг - кг ; треугольник - т) через пробел в строку");
    string[] hh = Console.ReadLine().Split();
    int w = 0;
    double plk = 0;
    double q = 1;
    Console.WriteLine($"N3.12:");
    while (w < hh.Length)
    {
        double r = Convert.ToDouble(hh[w]);
        if (hh[w + 1] == "кв")
        {
            plk = r * r;
            plk = Round(plk, 2);
            Console.WriteLine($"Площадь квадрата со стороной {r} равна {plk}");
        }
        if (hh[w + 1] == "кг")
        {
            plk = PI * Pow(r, 2);
            plk = Round(plk, 2);
            Console.WriteLine($"Площадь круга с радиусом {r} равна {plk}");
        }
        if (hh[w + 1] == "т")
        {
            plk = Pow(3, (0.5)) * r / 4;
            plk = Round(plk, 2);
            Console.WriteLine($"Площадь правильного треугольника со стороной {r} равна {plk}");
        }
        w += 2;
        q++;

    }
    Console.WriteLine("");



    Console.WriteLine("Введите a b и площадь чего хотите узнать(прямоугольник - п ; кольцо - к ; треугольник - т) через пробел в строку");
    string[] er = Console.ReadLine().Split();
    int z = 0;
    double pl = 0;
    double x = 1;
    Console.WriteLine($"N3.13:");
    while (z < er.Length)
    {
        double a = Convert.ToDouble(er[z]);
        double b = Convert.ToDouble(er[z+1]);
        if (er[z + 2] == "п")
        {
            pl = a*b;
            pl = Round(pl, 2);
            Console.WriteLine($"Площадь прямоугольника со сторонами {a} , {b} равна {pl}");
        }
        if (er[z + 2] == "к")
        {
            pl = Abs((PI * a * a) - (PI * b * b));
            pl = Round(pl, 2);
            Console.WriteLine($"Площадь кольца с радиусами {a} , {b} равна {pl}");
        }
        if (er[z + 2] == "т")
        {
            pl = Sqrt(Pow(b, 2) - Pow(a / 2, 2)) * (a / 2);
            pl = Round(pl, 2);
            Console.WriteLine($"Площадь треугольника со сторонами {a} , {b} , {b} равна {pl}");
        }
        z += 3;
        x++;
       
    }
    Console.WriteLine("");
}
