using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, r = 2;// 1.1
            Console.WriteLine($"Введите х");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите y");
            y=double.Parse(Console.ReadLine());
            if (Math.Abs(x*x+y*y-r*r)<=0.001)
            {
                Console.WriteLine($"Точка с координатами ({x}:{y}) лежит на окр-ти");
            }
            else Console.WriteLine($"Точка с координатами ({x}:{y}) не лежит на окр-ти");

            double x1, y1=0;// 1.9
            Console.WriteLine($"Введите х");
            x1 = double.Parse(Console.ReadLine());
            if (x1<=-1)
            {
                y1 = 0;
            }
            else if ((x1>-1)&&(x1<=0))
            {
                y1 = 1 + x1;
            }
            else if (x1>0)
            {
                y1 = 1;
            }
            Console.WriteLine(y1);


            double n,d,m,sd=0,sm=0;// 2.1
            Console.WriteLine($"Введите n");
            n=double.Parse(Console.ReadLine());
            Random rnd =new Random();
            Console.WriteLine($"Введите кол-во девочек");
            d=double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите кол-во мальчиков");
            m=double.Parse(Console.ReadLine());
            if ((m + d <= n)&&(m>0)&&(d>0))
            {
                for (int i = 1; i <= d; i++)
                {
                    int rost = rnd.Next(130, 200);
                    sd = sd + rost;
                }
                for (int i1 = 1; i1 <= m; i1++)
                {
                    int rost1 = rnd.Next(150, 210);
                    sm = sm + rost1;
                }

            }
            else Console.WriteLine($"Количество мальчиков и девочек > n, либо d(m)=0");
            Console.WriteLine($"Средний рост мальчиков = {Math.Round(sm / m,1)} см \t Средний рост девочек = {Math.Round(sd / d),1} см");


            double n1,max=200,rez;//2.9
            Console.WriteLine($"Введите n");
            n1= double.Parse(Console.ReadLine());
            Random rnd1 = new Random();
            for (int i = 1; i <= n1; i++) 
            {
                rez = rnd1.Next(110, 180);
                if (rez < max)
                {
                    max = rez;
                }
            }
            Console.WriteLine($"Лучший результат {max} сек");


            double r1, r2,n2,x2,y2,kol=0,length=0;//3.4
            Console.WriteLine($"Введите кол-во точек");
            n2 = double.Parse(Console.ReadLine());
            Random rnd2 = new Random();
            Console.WriteLine($"Введите r1");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите r2");
            r2 = double.Parse(Console.ReadLine());
            for(int i=1;i<=n2;i++)
            {
                Console.WriteLine($"Введите координату х");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Введите координату y");
                y2 = double.Parse(Console.ReadLine());
                length = x2 * x2 + y2 * y2;
                if ((length>=r1*r1)&&(length<=r2*r2))
                {
                    kol = kol + 1;
                }
            }
            Console.WriteLine($"Количество точек ={kol}");


            double sum,summa=0,kolvo=0,kolv=0;//3.11
            string v;
            double ekz1, ekz2, ekz3, ekz4;
            Random rnd3 = new Random();
            bool trigger = true;
            while (trigger)
            {
                Console.WriteLine("если хотите закончить введите #, если хотите продолжить введите $ (3.11)");
                v = Console.ReadLine();
                if (v=="#")
                {
                    trigger=false;
                }
                if (v=="$")
                {
                    Console.WriteLine("Введите оценки за 4 экзамена");
                    ekz1 = double.Parse(Console.ReadLine());
                    ekz2=double.Parse(Console.ReadLine());
                    ekz3=double.Parse(Console.ReadLine());
                    ekz4=double.Parse(Console.ReadLine());
                    if ((ekz1 != 2) && (ekz2 != 2) && (ekz3 != 2) && (ekz4 != 2))
                    {
                        kolv = kolv + 1;
                        sum = (ekz1 + ekz2 + ekz3 + ekz4) / 4;
                        summa = summa + sum;
                    }
                    if ((ekz1 <= 2) || (ekz2 <= 2) || (ekz3 <= 2) || (ekz4 <= 2))
                    {
                        kolvo = kolvo + 1;
                    }
                    Console.WriteLine($"Количество неуспевающих = {kolvo}\t Средний балл = {summa / kolv}");
                }
            }


            double R ,g;//3.12
            string c;
            bool trigger1 = true;
            while (trigger1)
            {
                Console.WriteLine("если хотите закончить введите #, если хотите продолжить введите $ (3.12)");
                c = Console.ReadLine();
                if (c == "#")
                {
                    trigger1 = false;
                }
                if (c == "$")
                {
                    Console.WriteLine("Введите r");
                    R = double.Parse(Console.ReadLine());
                    Console.WriteLine("Если хотите узнать площади квадрата - нажмите 1\t Если хотите узнать площадь круга нажмите 2\t Если хотите узнать площадь треугольника нажмите 3");
                    g = double.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 1:
                            Console.WriteLine($"Площадь квадрата = {R * R}");
                            break;
                        case 2:
                            Console.WriteLine($"Площадь круга = {Math.PI * R * R}");
                            break;
                        case 3:
                            Console.WriteLine($"Площадь треугольника = {Math.Sqrt(3) * R * R / 4}");
                            break;
                    }
                }
            }
            Console.WriteLine();


            double  A, g1,B,h;//3.13
            string f;
            bool trigger2=true;
            while (trigger2)
            {
                Console.WriteLine("если хотите закончить введите #, если хотите продолжить введите $ (3.13)");
                f = Console.ReadLine();
                if (f == "#")
                {
                    trigger2 = false;
                }
                if (f == "$")
                {
                    Console.WriteLine("Введите A");
                    A = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B");
                    B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Если хотите узнать площади прямоугольника - нажмите 1\t Если хотите узнать площадь кольца нажмите 2\t Если хотите узнать площадь треугольника нажмите 3");
                    g1 = double.Parse(Console.ReadLine());
                    switch (g1)
                    {
                        case 1:
                            Console.WriteLine($" Площадь прямоугольника = {A * B}");
                            break;
                        case 2:
                            if (A > B)
                            {
                                Console.WriteLine($"Площадь кольца = {Math.PI * A * A - Math.PI * B * B}");
                            }
                            else Console.WriteLine($"Площадь кольца = {Math.PI * B * B - Math.PI * A * A}");
                            break;
                        case 3:
                            h = Math.Sqrt(B * B - (A * A / 4));
                            Console.WriteLine($"Площадь треугольника = {0.5 * A * h}");
                            break;
                    }
                }
                Console.WriteLine();
            }

        }

    }
}