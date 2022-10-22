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
            try
            {
                Console.WriteLine("введите количество учеников");
                int n1 = int.Parse(Console.ReadLine());
                b = 0;

                for (int i = 1; i <= n1; i++)
                {
                    Console.WriteLine($"введите рост {i} ученика");
                    a = double.Parse(Console.ReadLine());
                    if (a > 0)
                    {
                        b += a;
                    }
                    else
                    {
                        Console.WriteLine("рост не может быть отрицательным");
                        break;
                    }
                }
                Console.Write("средний рост учеников: ");
                Console.WriteLine(b / n1);
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }

            #endregion

            #region ex2

            try
            {
                Console.WriteLine("Введите кол-во точек");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите x координату центра");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите y координату центра");
                y = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите радиус ");
                r = double.Parse(Console.ReadLine());

                int k1 = 0;
                for (int i = 1; i <= n2; i++)
                {
                    Console.WriteLine($"Введите x {i} точки");
                    double x1 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Введите y {i} точки");
                    double y1 = double.Parse(Console.ReadLine());

                    if (((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y)) <= r * r)
                    {
                        k1++;
                    }
                }

                Console.WriteLine(k1);
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }
            #endregion



            #endregion

            #region 3lvl

            #region 4ex
            try
            {
                Console.WriteLine("Введите x координату центра окружности");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите y координату центра окружности");
                y = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите радиус внутреннего круга");
                double r1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите радиус внешней окружности");
                double r2 = double.Parse(Console.ReadLine());

                int k2 = 0;

                for (; ; )
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
                        k2++;
                    }
                }
                Console.WriteLine(k2);
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }
            #endregion

            #region ex11
            
            try
            {
                int k3 = 0;
                double bal1 = 0;
                double bal2 = 0;
                double bal3 = 0;
                double bal4 = 0;
                int n3 = 0;
                for (;;)
                {
                    Console.Write("Введите оценку за 1 предмет или нажмите enter что бы закончить");
                    string OC11 = Console.ReadLine();
                    if (OC11 == "")
                    {
                        break;
                    }

                    double OC1 = double.Parse(OC11);
                    Console.Write("Введите оценку за 2 предмет");
                    double OC2 = double.Parse(Console.ReadLine());
                    Console.Write("Введите оценку за 3 предмет");
                    double OC3 = double.Parse(Console.ReadLine());
                    Console.Write("Введите оценку за 4 предмет");
                    double OC4 = double.Parse(Console.ReadLine());
                    if (OC1 < 2 || OC1 > 5 || OC2 < 2 || OC2 > 5 || OC3 < 2 || OC3 > 5 || OC4 < 2 || OC4 > 5)
                    {
                        Console.Write("Таких оценок не бывает");
                        bal1 = 0;
                        bal2 = 0;
                        bal3 = 0;
                        bal4 = 0;
                        n3++;
                        break;
                    }
                    if (OC1 == 2 | OC2 == 2 | OC3 == 2 | OC4 == 2)
                    {
                        k3++;
                    }
                    bal1 += OC1;
                    bal2 += OC2;
                    bal3 += OC3;
                    bal4 += OC4;
                    n3++;
                }


                Console.Write("Средний бал за 1 предмет ");
                Console.WriteLine(bal1 / n3);
                Console.Write("Средний бал за 2 предмет ");
                Console.WriteLine(bal2 / n3);
                Console.Write("Средний бал за 3 предмет ");
                Console.WriteLine(bal3 / n3);
                Console.Write("Средний бал за 4 предмет ");
                Console.WriteLine(bal4 / n3);
                Console.Write("Неуспевающих учеников: ");
                Console.WriteLine(k3);
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }

            #endregion

            #region ex12

            try
            {
                for (;;)
                {
                    Console.Write("Введите r или нажмите enter что бы закончить  ");
                    string rr1 = Console.ReadLine();
                    if (rr1 == "")
                    {
                        break;
                    }
                    double rr = double.Parse(rr1);
                    Console.Write("Введите: 0 что бы вычислить пощадь квадрата, 1 - круга, 2 - треугольника  ");
                    int fig = int.Parse(Console.ReadLine());
                    switch (fig)
                    {
                        case 0:
                            Console.WriteLine(rr * rr);
                            break;
                        case 1:
                            Console.WriteLine(Math.PI * rr * rr);
                            break;
                        case 2:
                            Console.WriteLine(rr * rr * Math.Sqrt(3) / 4);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }



            #endregion

            #region ex13

            try
            {
                for (; ; )
                {
                    Console.Write("Введите A или нажмите enter что бы закончить  ");
                    string AA1 = Console.ReadLine();
                    if (AA1 == "")
                    {
                        break;
                    }
                    double AA = double.Parse(AA1);
                    Console.Write("Введите B  ");
                    double BB = double.Parse(Console.ReadLine());
                    if (AA <= 0 || BB <= 0)
                    {
                        Console.Write("Это не длина");
                        break;
                    }

                    Console.Write("Введите: 0 что бы вычислить пощадь прямоугольника, 1 - кольца, 2 - треугольника  ");
                    int fig = int.Parse(Console.ReadLine());
                    switch (fig)
                    {
                        case 0:
                            Console.WriteLine(AA * BB);
                            break;
                        case 1:
                            if (AA > BB)
                            {
                                Console.WriteLine(Math.PI * AA * AA - Math.PI * BB * BB);
                            }
                            else
                            {
                                Console.WriteLine(Math.PI * BB * BB - Math.PI * AA * AA);
                            }
                            break;
                        case 2:
                            double aaa = AA / 2;
                            double HH = BB * BB - aaa * aaa;
                            Console.WriteLine(0.5 * AA * Math.Sqrt(HH));
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }


            #endregion

            #endregion
        }
    }
}
