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
            double r, x, y;
            double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), out  y);

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
            double a;
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("введите b");
            double b;
            double.TryParse(Console.ReadLine(), out b);


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
                double.TryParse(Console.ReadLine(), out rm);
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
                double.TryParse(Console.ReadLine(), out f);
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
            double r1, r2, x1, y2, k = 0;
            int nx;
            Console.WriteLine("Введите внутренний радиус");
            double.TryParse(Console.ReadLine(), out r1);
            Console.WriteLine("Введите внешний радиус");
            double.TryParse(Console.ReadLine(), out r2);
            Console.WriteLine("Введите количество точек");
            int.TryParse(Console.ReadLine(),out nx);
            if (r2 > r1 && r2 > 0)
            {
                for (int i = 0; i < nx; i++)
                {
                    Console.WriteLine("Введите координаты точек");
                    double.TryParse(Console.ReadLine(), out x1);
                    double.TryParse(Console.ReadLine(), out y2);
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
            double.TryParse(Console.ReadLine(), out nz);
            for (int i = 0; i < nz; i++)
            {
                Console.WriteLine("Введите оценки ученика");
                int.TryParse(Console.ReadLine(), out z1);
                int.TryParse(Console.ReadLine(), out z2);
                int.TryParse(Console.ReadLine(), out z3);
                int.TryParse(Console.ReadLine(), out z4);
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
            nz = nz - k3;
            srz = sumz / nz;
            Console.WriteLine($"Среднийй бал: {srz}");
            Console.WriteLine($"Количество неуспевающих: {k3}");
            #endregion
            #region lvl3-12
            Console.WriteLine("LVL3-12");
            double rc;
            int kc;
            Console.WriteLine("Ввидите r");
            double.TryParse(Console.ReadLine(), out rc);
            if (rc > 0)
            {
                    Console.WriteLine("Если вы хотите вычислить площадь: для квадрата введите 1, для круга введите 2, для треугольника введите 3");
                    int.TryParse(Console.ReadLine(), out kc);
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
            double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Введите значение B");
            double.TryParse(Console.ReadLine(), out B);
            Console.WriteLine("для площади прямоугольника введите 1,для площади кольца 2,для площади равнобедренного треугольника 3");
            int v;
            int.TryParse(Console.ReadLine(), out v);
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
                        if (B < pl)
                        {
                            Console.WriteLine("ОШИБКА");
                        }
                        else
                        {
                            double sd = Math.Sqrt(B * B - pl * pl);
                            S = (A * sd) / 2;
                            Console.WriteLine($"Площадь Равнобедренного треугольника равна {S}");
                            
                        }
                        break;
                }
            }
            #endregion







        }
    }
}
