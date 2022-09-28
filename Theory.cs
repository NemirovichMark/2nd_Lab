using System;
using System.Threading.Channels;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First level");

            #region 4Task

            double z, a, b, c;
            Console.WriteLine("Введите a, b, c:");
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) &&
                double.TryParse(Console.ReadLine(), out c))
            {
                z = Math.Max(Math.Min(a, b), c);
                Console.WriteLine("Z равно:");
                Console.WriteLine(z);
            }
            
            
            #endregion

            #region 5Task

            double r, s;
            r = 70;
            s = 36.74;
            if (r >= s * Math.PI / 2)
            {
                Console.WriteLine("Поместится");
            }
            else
            {
                Console.WriteLine("Не поместится");
            }
            r = 0.86;
            s = 0.74;
            if (r >= s * Math.PI / 2)
            {
                Console.WriteLine("Поместится");
            }
            else
            {
                Console.WriteLine("Не поместится");
            }
            #endregion

            s = 0;
            Console.WriteLine("Second level");
            
            #region 1Task

            Console.WriteLine("Введите количество учеников:");
            double n, height;
            if (double.TryParse(Console.ReadLine(), out n))
            {
                if (n == 0)
                {
                    Console.WriteLine("Невозможно посчитать рост 0 человек :(");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("Введите рост:");
                        double.TryParse(Console.ReadLine(), out height);
                        s += height;
                    }
                    Console.WriteLine($"Средний рост учеников: {s / n}");
                }
            }
            
            #endregion

            #region 9Task

            double result, bestresult = Math.Pow(10, 10);
            Console.WriteLine("Введите количество участников:");
            if (double.TryParse(Console.ReadLine(), out n))
            {
                if (n == 0)
                {
                    Console.WriteLine("Количество участников не может быть ноль");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("Введите результат:");
                        if (double.TryParse(Console.ReadLine(), out result))
                        {
                            bestresult = Math.Min(result, bestresult); 
                        }
                        
                    }
                
                }

                Console.WriteLine($"Лучший результат: {bestresult}");
            }
            

            #endregion

            Console.WriteLine("Third level");

            #region 4Task

            double Radius1, Radius2, x, y, XofE, YofE;
            int count = 0;
            Console.WriteLine("Введите радиус внутреннего кольца, радиус внешнего кольца, x и y центра этих колец");
            if (double.TryParse(Console.ReadLine(), out Radius1) && double.TryParse(Console.ReadLine(), out Radius2)
                && double.TryParse(Console.ReadLine(), out XofE) && double.TryParse(Console.ReadLine(), out YofE))
            {
                if (Radius1 <= 0 || Radius2 <= 0){
                    Console.WriteLine("This is bad :(");
                }
                else
                {
                    Radius1 = Radius1 * Radius1;
                    Radius2 = Radius2 * Radius2;
                    do
                    {
                        Console.WriteLine("Enter x and y of point:");
                        Console.WriteLine("If you want to stop, enter x = -100");
                        if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
                        {
                            if (x == -100)
                            {
                                break;
                            }
                            else
                            {
                                if ((x - XofE) * (x - XofE) + (y - YofE) * (y - YofE) < Radius1 &&
                                    (x - XofE) * (x - XofE) + (y - YofE) * (y - YofE) < Radius2) count++;

                            }
                        }
                        else break;
                    } while (x != -100);

                    Console.WriteLine(count);
                }
                
            }


            #endregion
            
            
            #region 11Task

            double mark1, mark2, mark3, mark4;
            double underachievers = 0, allmarks = 0, Count = 0;
            do
            {
                Console.WriteLine("Enter the mark of first exam:");
                Console.WriteLine("If you want to stop enter 0");
                if (double.TryParse(Console.ReadLine(), out mark1))
                {
                    if (mark1 == 1 || mark1 == 2) underachievers++;
                    else if (mark1 == 0) break;
                    else
                    {
                        allmarks += mark1;
                        Count++;
                    }
                    Console.WriteLine("Enter the mark of second exam:");
                    if (double.TryParse(Console.ReadLine(), out mark2))
                    {
                        if (mark2 == 1 || mark2 == 2) underachievers++;
                        else
                        {
                            allmarks += mark2;
                            Count++;
                        }
                        Console.WriteLine("Enter the mark of third exam:");
                        if (double.TryParse(Console.ReadLine(), out mark3))
                        {
                            if (mark3 == 1 || mark3 == 2) underachievers++;
                            else
                            {
                                allmarks += mark3;
                                Count++;
                            }
                            Console.WriteLine("Enter the mark of fourth exam:");
                            if (double.TryParse(Console.ReadLine(), out mark4))
                            {
                                if (mark4 == 1 || mark4 == 2) underachievers++;
                                else
                                {
                                    allmarks += mark4;
                                    Count++;
                                }
                            }
                        }
                    }
                    
                    
                }
            } while (mark1 != 0);

            Console.WriteLine($"Count of underachiviers - {underachievers}, average mark - {allmarks / count}");
            #endregion

            r = 0;
            s = 0;
            #region 12Task
            do
            {
                Console.WriteLine("If you want to stop enter 0");
                Console.WriteLine("Enter variable r:");
                if (double.TryParse(Console.ReadLine(), out r))
                {
                    if (r == 0) break;
                    Console.WriteLine("Enter square, circle or triangle according to what you want to find");
                    switch (Console.ReadLine())
                    {
                        case "square":
                            Console.WriteLine($"Square of square is - {r * r}");
                            break;
                        case "circle":
                            Console.WriteLine($"Square of circle is - {r * r * Math.PI}");
                            break;
                        case "triangle":
                            Console.WriteLine($"Square of triangle is - {r * r * Math.Sin(Math.PI / 3) / 2}");
                            break;
                    }
                }
            } while (r != 0);

            #endregion

            #region 13Task

            double A = 0, B = 0, perimeter;
            do
            {
                Console.WriteLine("Enter A or B. If you want to stop enter A = 0 or B = 0");
                if (double.TryParse(Console.ReadLine(), out A) && double.TryParse(Console.ReadLine(), out B))
                {
                    if (A == 0 || B == 0) break;
                    Console.WriteLine("Enter rectangle, circle or triangle according to what you want to find");
                    switch (Console.ReadLine())
                    {
                        case "rectangle":
                            Console.WriteLine($"Square of rectangle is - {A * B}");
                            break;
                        case "circle":
                            Console.WriteLine($"Square of circle is - {Math.Abs(Math.PI * A * A - Math.PI * B * B)}");
                            break;
                        case "triangle":
                            perimeter = (A + B + B) / 2;
                            s = Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - B));
                            Console.WriteLine($"Square of triangle is - {s}");
                            break;
                    }
                }
            } while (A != 0 || B != 0);



            #endregion
        }
    }
}
