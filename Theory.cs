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
                else if (n < 0)
                {
                    Console.WriteLine("Отрицательное тоже не может быть :(");
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
                else if (n < 0)
                {
                    Console.WriteLine("Отрицательное тоже не может быть :(");
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

            bool flag = true;
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
                    } while (flag);

                    Console.WriteLine(count);
                }
                
            }


            #endregion
            
            
            #region 11Task

            count = 0;
            flag = true;
            double mark, marks = 0;
            double underachiever = 0;
            double underachievers = 0, allmarks = 0, Count = 0;
            do
            {
                Console.WriteLine("If you want to stop enter 0");
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Enter the mark of {i} exam");
                    if (double.TryParse(Console.ReadLine(), out mark))
                    {
                        if (mark == 2)
                        {
                            underachiever++;
                            count = 0;
                            marks = 0;
                        }
                        else if (mark == 0)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            count++;
                            marks += mark;
                        }
                    }
                }

                if (underachiever != 0)
                {
                    underachievers++;
                }
                else
                {
                    allmarks += marks;
                    Count += count;
                }
                underachiever = 0;
                marks = 0;
                count = 0;
            } while (flag);

            Console.WriteLine($"Count of underachiviers - {underachievers}, average mark - {allmarks / Count}");
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
                if (double.TryParse(Console.ReadLine(), out A) && double.TryParse(Console.ReadLine(), out B) &&
                    (A > 0 && B > 0))
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
