using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            
            #region lvl1-1
            Console.WriteLine("LVL1-1");
            Console.WriteLine("Введите r");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());

            if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
            {
                Console.WriteLine("лежит внутри окружности");
            }
            else
            {
                Console.WriteLine("не лежит внутри окружности");
            }
            #endregion
            #region lvl1-3
            Console.WriteLine("LVL1-3");
            Console.WriteLine("введите а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите b");
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a > 0)
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(a);
                }
                
            }
            #endregion
            #region lvl2-1
            Console.WriteLine("LVL2-1");
            double sr, rm, s = 0;
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите рост ученика");
                rm = double.Parse(Console.ReadLine());
                s += rm;

            }
            sr = s/ n;
            Console.WriteLine(sr);
            #endregion
            #region lvl2-9
            Console.WriteLine("LVL2-9");
            double mx = 0, f;
            int l = 5;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("спортсмен проплыл: ");
                f = double.Parse(Console.ReadLine());
                if (f > 200)
                {
                    Console.WriteLine("Ошибка максимально допустимое значение 200");
                    return;
                    
                }
                
                else
                {
                    if (f > mx)
                    {
                        mx = f;
                    }
                }
              
            }
            Console.WriteLine($"Лучший результат: {mx}");
            #endregion
            #region lvl3-4
            Console.WriteLine("LVL3-4");
            double r1, r2, x1, y2, nx, k = 0;
            Console.WriteLine("Введите внутренний радиус");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите внешний радиус");
            r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество точек");
            nx = int.Parse(Console.ReadLine());
            if (r2 > r1 && r2 > 0)
            {
                for (int i = 0; i < nx; i++)
                {
                    Console.WriteLine("Введите координаты точек");
                    x1 = double.Parse(Console.ReadLine());
                    y2 = double.Parse(Console.ReadLine());
                    if (x1 * x1 + y2 * y2 <= r1 * r1 || x1 * x1 + y2 * y2 <= r2 * r2)
                    {
                        k++;
                    }

                }
                Console.WriteLine($"количество точек:{k}");
            }
            else
            {
                Console.WriteLine("Внешний радиус должен быть больше внутреннего");
                
            }
            #endregion
            #region lvl3-11
            Console.WriteLine("LVL3-11");
            int z1, z2, z3, z4, k3 = 0;
            double srz, nz, sumz = 0;

            Console.WriteLine("Введите количесвто студентов");
            nz = double.Parse(Console.ReadLine());
            for (int i = 0; i < nz; i++)
            {
                Console.WriteLine("Введите оценки ученика");
                z1 = int.Parse(Console.ReadLine());
                z2 = int.Parse(Console.ReadLine());
                z3 = int.Parse(Console.ReadLine());
                z4 = int.Parse(Console.ReadLine());
                if (z1 == 2 | z2 == 2 | z3 == 2 | z4 == 2)
                {
                    k3++;
                }
                else
                {
                    if (z1 <= 5 | z2 <= 5 | z4 <= 5 | z4 <= 5 | z1 > 2 | z2 > 2 | z3 > 2 | z4 > 2)
                    {
                        sumz =  sumz + z1 + z2 + z3 + z4;
                    }
                }
                
                
            }
            srz = sumz / nz;
            Console.WriteLine($"Среднийй бал: {srz}");
            Console.WriteLine($"Количество неуспевающих: {k3}");
            #endregion
            #region lvl3-12
            Console.WriteLine("LVL3-12");
            double rc;
            int kc;
            Console.WriteLine("Ввидите r");
            rc = double.Parse(Console.ReadLine());
            if (rc > 0)
            {
                    Console.WriteLine("Если вы хотите вычислить площадь: для квадрата введите 1, для круга введите 2, для треугольника введите 3");
                    kc = int.Parse(Console.ReadLine());
                    switch (kc)
                    {
                        case 1:
                            rc *= rc;
                            Console.WriteLine($"Площадь квадрата = {rc}");
                            break;
                        case 2:
                            rc = Math.PI * Math.Pow(rc, 2);
                            Console.WriteLine($"Площадь круга = {rc}");
                            break;
                        case 3:
                            rc = (Math.Pow(rc, 2) * Math.Sqrt(3)) / 4;
                            Console.WriteLine($"Площадь треугольника = {rc}");
                            break;
                    }
            }

            #endregion
            #region lvl3-13
            Console.WriteLine("LVL3-13");
            double A, B, S;
            Console.WriteLine("Введите значение А");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("для площади прямоугольника введите 1,для площади кольца 2,для площади равнобедренного треугольника 3");
            int v;
            v = int.Parse(Console.ReadLine());
            if (A > 0 && B > 0)
            {
                switch (v)
                {
                    case 1:
                        S = A * B;
                        Console.WriteLine($"Площадь прямоугольника = {S}");
                        break;
                    case 2:
                        S = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                        Console.WriteLine($"Площадь кольца равна{S}");
                        break;
                    case 3:
                        double pl = A / 2;
                        double sd = Math.Sqrt(B * B - pl * pl);
                        S = (A * sd) / 2;
                        Console.WriteLine($"Площадь Равнобедренного треугольника равна {S}");
                        break;
                }
            }
            #endregion







        }
    }
}
