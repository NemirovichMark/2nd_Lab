using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task#1.1
            double x, y;
            double r = 2.0;
            bool l = false;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Введите x:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = double.Parse(Console.ReadLine());
                if ((x * x + y * y - r * r) <= Math.Pow(10, -3)) l = !l;
                Console.WriteLine(l);
            }
            #endregion
            #region Task#1.4
            double z, a, b, c, mn = 0, mx = 0;
            Console.WriteLine("Введите a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c:");
            c = double.Parse(Console.ReadLine());
            if (a > b) mn = b;
            else mn = a;
            if (mn > c) mx = mn;
            else mx = c;
            z = mx;
            Console.WriteLine(z);
            #endregion
            #region Task#2.1
            double srg, srb, rg, rb, gs = 0, bs = 0;
            int k = 0, k1 = 0, n;
            do
            {
                Console.WriteLine("1-девочка, 2-мальчик, 0-для окончания");
                n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                if (n == 1)
                {
                    Console.WriteLine("Введите рост девочки в метрах");
                    rg = double.Parse(Console.ReadLine());
                    gs += rg;
                    k += 1;
                }
                if (n == 2)
                {
                    Console.WriteLine("Введите рост мальчика в метрах");
                    rb = double.Parse(Console.ReadLine());
                    bs += rb;
                    k1 += 1;
                }

            }
            while ((gs > 0) || (bs > 0));
            srg = gs / k; srb = bs / k1;
            Console.WriteLine("Средний рост днвочек {0:f2}, средний рост мальчика {1:f2}", srg, srb);
            #endregion
            #region Task#2.5
            double norm, rezl;
            int k5 = 0;
            Console.WriteLine("Введите норматив");
            norm = double.Parse(Console.ReadLine());
            for (int sp = 1; sp <= 30; sp ++)
            {
                Console.WriteLine("Введите результат по бегу:");
                rezl = double.Parse(Console.ReadLine());
                if (rezl >= norm) k5 += 1;
            }
            Console.WriteLine("{0} спортсменов выполнили норматив", k5);
            #endregion
            #region Task#3.4
            double r1, r2, n4, x4, y4;
            int ch = 0;
            Console.WriteLine("Введите количество точек:");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите внутрений радиус:");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите внешний радиус:");
            r2 = double.Parse(Console.ReadLine());
            for (int j = 1; j <= n4; j++)
            {
                Console.WriteLine("Введите x:");
                x4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y4 = double.Parse(Console.ReadLine());
                if ((x4 * x4 + y4 * y4 >= r1 * r1) && (x4 * x4 + y4 * y4 <= r2 * r2)) ch += 1;
            }
            Console.WriteLine("{0} точек попадет в кольцо с внутреним и внешним радиусом", ch);
            #endregion
            #region Task#3.11
            double sb, n11, alsb = 0.0; //средний бал 
            int count = 0;
            int math, phys, comp, chem;
            Console.WriteLine("Введите количество студентов:");
            n11 = double.Parse(Console.ReadLine());
            for (int g = 1; g <= n11; g++)
            {
                Console.WriteLine("Введите оценку за экзамен по математике: ");
                math = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку за экзамен по физике: ");
                phys = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку за экзамен по информатике: ");
                comp = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку за экзамен по химии: ");
                chem = int.Parse(Console.ReadLine());
                sb = (math + phys + comp + chem) / 4;
                if (sb < 3) count += 1; //если средний бал ниже 3 то неуспевающий 
                else alsb += sb
            }
            Console.WriteLine("Колчество неуспевающих студентов: {0}, средний балл группы: {1}", count, alsb / n11);
            #endregion
            #region Task#3.12
            double r12, rez12;
            const double PI = 3.14;
            int n12, k12;
            Console.WriteLine("Введите количество r");
            n12 = int.Parse(Console.ReadLine());
            for (int q = 1; q <= n12; q++)
            {
                Console.WriteLine("Введите значение r:");
                r12 = double.Parse(Console.ReadLine());
                Console.WriteLine("1-площадь квадрата со стороной r; 2-площадь круга радусом r; 3-площадь равностороннего треугольника со стороной r");
                Console.Write("Введите 1, 2 и 3");
                k12 = int.Parse(Console.ReadLine());
                switch (k12)
                {
                    case 1:
                        rez12 = Math.Pow(r12, 2);
                        Console.WriteLine("Площадь квадрата: {0}", rez12);
                        Console.ReadKey();
                        break;
                    case 2:
                        rez12 = Math.Pow(r12, 2) * PI;
                        Console.WriteLine("Площадь круга: {0}", rez12);
                        Console.ReadKey();
                        break;
                    case 3:
                        rez12 = (Math.Pow(r12, 2) * Math.Sqrt(3)) / 4;
                        Console.WriteLine("Площадь равностороннего треугольника: {0}", rez12);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Выберите 1, 2 или 3:");
                        Console.ReadKey();
                        break;
                }
            }
            #endregion
            #region Task#3.13
            int n13, k13;
            const double Pi = 3.14;
            double A, B, rez13;
            Console.WriteLine("Введите количество пар");
            n13 = int.Parse(Console.ReadLine());
            for (int w = 1; w <= n13; w++)
            {
                Console.WriteLine("Введите значение A:");
                A = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B:");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine("1-площадь прямоугольника, 2-площадь кольца, 3-площадь равнобедренного треугольника");
                Console.Write("Введите признак 1, 2 или 3:");
                k13 = int.Parse(Console.ReadLine());
                switch (k13)
                {
                    case 1:
                        rez13 = A * B;
                        Console.WriteLine("Площадь прямоугольника: {0}", rez13);
                        Console.ReadKey();
                        break;
                    case 2:
                        rez13 = Pi * (Math.Abs(A * A - B * B));
                        Console.WriteLine("Площадь кольца: {0}", rez13);
                        Console.ReadKey();
                        break;
                    case 3:
                        rez13 = 0.5 * B * Math.Sqrt((A + 0.5 * B) * (A - 0.5 * B));
                        Console.WriteLine("Площадь равнобедренного треугольника: {0}", rez13);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Выберите 1, 2 или 3:");
                        Console.ReadKey();
                        break;
                }
            }
            #endregion
        }
    }
}
