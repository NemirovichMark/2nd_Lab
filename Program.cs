using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace LB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1lvl
            
            #region ex1
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

            #region ex3
            Console.WriteLine("введите а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите b");
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a > 0)
            {
                c = Math.Max(a, b);
                Console.Write("максимальное из 2: ");
            }
            else
            {
                c = Math.Min(a, b);
                Console.Write("минимальное из 2: ");
            }
            Console.WriteLine(c);
            #endregion


            #endregion

            #region 2lvl

            #region 1ex
            Console.WriteLine("введите количество учеников");
            int n = int.Parse(Console.ReadLine());
            b = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"введите рост {i} ученика");
                a = double.Parse(Console.ReadLine());
                b += a;
            }
            Console.Write("средний рост учеников: ");
            Console.WriteLine(b / n);
            #endregion

            #region ex2
            
            Console.WriteLine("Введите кол-во точек");
            n = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите x координату центра");
            x = double.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите y координату центра");
            y = double.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите радиус ");
            r = double.Parse(Console.ReadLine());
                
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите x {i} точки");
                double x1 = double.Parse(Console.ReadLine());

                Console.WriteLine($"Введите y {i} точки");
                double y1 = double.Parse(Console.ReadLine());
                    
                if (((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y)) <= r * r)
                {
                   k++;
                }
            }
            
            Console.WriteLine(k);
            #endregion



            #endregion

            #region 3lvl

            #region 4ex
            Console.WriteLine("Введите x координату центра окружности");
            x = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите y координату центра окружности");
            y = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите радиус внутреннего круга");
            double r1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите радиус внешней окружности");
            double r2 = double.Parse(Console.ReadLine());
            
            k = 0;
            
            for (;;)
            {
                Console.WriteLine("Введите x точки  или entr что бы закончить");
                string a11 = Console.ReadLine();
                if (a11 == "")
                {
                   break;
                }
                double a1 = double.Parse(a11);
                Console.WriteLine("Введите y точки ");
                double b1 = double.Parse(Console.ReadLine());
                if ((((a1 - x) * (a1 - x) + (b1 - y) * (b1 - y)) >= r1 * r1) && (((a1 - x) * (a1 - x) + (b1 - y) * (b1 - y)) <= r2 * r2))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
            #endregion

            #region ex11
            k = 0;
            double bal1 = 0;
            double bal2 = 0;
            double bal3 = 0;
            double bal4 = 0;
            n = 0;

            for (;;)
            {
                Console.WriteLine("Введите оценку за 1 предмет или нажмите enter что бы закончить");
                string OC = Console.ReadLine();
                
                if (OC == "")
                {
                    break;
                }

                double OC1 = double.Parse(OC);
                
                Console.WriteLine("Введите оценку за 2 предмет");
                double OC2 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите оценку за 3 предмет");
                double OC3 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите оценку за 4 предмет");
                double OC4 = double.Parse(Console.ReadLine());
                
                if (OC1 < 2 || OC1 > 5 || OC2 < 2 || OC2 > 5 || OC3 < 2 || OC3 > 5 || OC4 < 2 || OC4 > 5)
                {
                    Console.WriteLine("Таких оценок не бывает");
                    bal1 = 0;
                    bal2 = 0;
                    bal3 = 0;
                    bal4 = 0;
                    n++;
                    break;
                }
                if (OC1 == 2 | OC2 == 2 | OC3 == 2 | OC4 == 2)
                {
                    k++;
                }
                bal1 += OC1;
                bal2 += OC2;
                bal3 += OC3;
                bal4 += OC4;
                n++;
            }

            Console.Write("Средний бал за 1 предмет ");
            Console.WriteLine(bal1 / n);

            Console.Write("Средний бал за 2 предмет ");
            Console.WriteLine(bal2 / n);
            
            Console.Write("Средний бал за 3 предмет ");
            Console.WriteLine(bal3 / n);
            
            Console.Write("Средний бал за 4 предмет ");
            Console.WriteLine(bal4 / n);
            
            Console.Write("Неуспевающих учеников: ");
            Console.WriteLine(k);
            #endregion
            
            #region ex12
                        
            for (;;)
            {
                Console.WriteLine("Введите r или нажмите enter что бы закончить");
                string rr1 = Console.ReadLine();
                if (rr1 == "")
                {
                    break;
                }
                r = double.Parse(rr1);
                Console.WriteLine("Введите: 0 что бы вычислить пощадь квадрата, 1 - круга, 2 - треугольника");
                int fig = int.Parse(Console.ReadLine());

                if (fig == 0)
                {
                    Console.WriteLine(r * r);
                }
                else if (fig == 1)
                {
                    Console.WriteLine(Math.PI * r * r);
                }
                else if (fig == 2)
                {
                    Console.WriteLine(r * r * Math.Sqrt(3) / 4);
                }
            }

            #endregion
            
            #region ex13

            for (;;)
            {
                Console.WriteLine("Введите A или нажмите enter что бы закончить");
                string A1 = Console.ReadLine();
                if (A1 == "")
                {
                    break;
                }
                double A = double.Parse(A1);
                Console.WriteLine("Введите B  ");
                double B = double.Parse(Console.ReadLine());
                if (A <= 0 || B <= 0)
                {
                    Console.WriteLine("Это не длина");
                    break;
                }

                Console.WriteLine("Введите: 0 что бы вычислить пощадь прямоугольника, 1 - кольца, 2 - треугольника");
                int fig = int.Parse(Console.ReadLine());
                
                if (fig == 0)
                {
                    Console.WriteLine(A * B);
                }
                else if (fig == 1)
                {
                    if (A > B)
                    {
                        Console.WriteLine(Math.PI * A * A - Math.PI * B * B);
                    }
                    else
                    {
                        Console.WriteLine(Math.PI * B * B - Math.PI * A * A);
                    }
                }
                else if (fig == 2)
                {
                    a = A / 2;
                    double h = B * B - a * a;
                    Console.WriteLine(0.5 * A * Math.Sqrt(h));
                }
            }
            




            #endregion

            #endregion
        }
    }
}
