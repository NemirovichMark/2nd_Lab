using System;

namespace Lab2
{
    class Theory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1/3");
            #region 1/3
            try
            {
                double a, b;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                if (a > 0) 
                {
                    Console.WriteLine("c = " + Math.Max(a,b));
                }
                else 
                {
                    Console.WriteLine("c = " + Math.Min(a,b));
                }
            }
            catch 
            {
                Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion
            Console.WriteLine("1/4");
            #region 1/4
            try 
            {
                double a, b, c;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("z = " + Math.Max(Math.Min(a, b), c));
            }
            catch
            {
                Console.WriteLine("Программа поддерживает только числа");
            }

            #endregion
            Console.WriteLine("1/2");
            #region 1/2
            try 
            {
                int n = 3;
                double r, mid;
                double s = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите рост ученика");
                    r = double.Parse(Console.ReadLine());
                    while (r <= 0) 
                    {
                        Console.WriteLine("Рост должен быть > 0");
                        r = double.Parse(Console.ReadLine());
                    }
                    s += r;
                }
                mid = s / n;
                Console.WriteLine("Средний рост всех учеников =" + mid);
            }
            catch 
            {
                Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion
            Console.WriteLine("5/2");
            #region 5/2
            
            try 
            {
                double  c = 0;
                double n = 30;
                double norm, res;
                norm = double.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите результат спортсмена " + i);
                    res = double.Parse(Console.ReadLine());
                    while (res <= 0)
                    {
                        Console.WriteLine("Результат не может быть отрицательным");
                        res = double.Parse(Console.ReadLine());
                    }
                    if (res < norm)
                    {
                        c += 1;
                    }
                }
                Console.WriteLine("Норматив выполнили " + c + "спортсменов");
            }
            catch
            {
                Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion
            Console.WriteLine("4/3");
            #region 4/3 
            try 
            {
            double s = 0;
            Console.WriteLine("Введите количество точек");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности по Х и У соответсвенно");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус внутреннего кольца");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус внешнего кольца");
            double R = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите координаты по оси x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты по оси y");
                double y = double.Parse(Console.ReadLine());

                double q = Math.Sqrt((Math.Pow((x - a), 2) + Math.Pow((y - b), 2)));
                if (q >= r && q <= R)
                {
                    s++;
                }
            }
            Console.WriteLine(s + " точек лежит в кольце");
            }
            catch
            {
            Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion 
            Console.WriteLine("11/3");
            #region 11/3
            try 
            {
                
                Console.WriteLine("Введите кол-во студентов, сдающих экзамен");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во экзаменов");
                double ex = double.Parse(Console.ReadLine());
                double o, ne = 0, s = 0, c = 0, sum = 0, sumo = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Студент " + i);
                    for (int j = 1; j <= ex; j++)
                    {
                        Console.WriteLine("Введите оценку за экзамен " + j);
                        o = double.Parse(Console.ReadLine()); 
                        if (o > 3)
                        {
                            sum += o;
                            c += 1;
                        }
                    }
                    if (c == ex)
                    {
                        s += 1;
                        sumo += sum;
                    }
                    else 
                    {
                        ne += 1;
                    }
                    sum = 0;
                    c = 0;
                }
                Console.WriteLine("Средний балл студентов = " + (sumo / ex) / n);
                Console.WriteLine("Экзамен не сдало " + ne + " студентов");
            }
            catch
            {
                Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion
            Console.WriteLine("12/3");
            #region 12/3
            try 
            {
                Console.WriteLine("Введите количество значений");
                double n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите значение r");
                    double r = Convert.ToDouble(Console.ReadLine());
                    while (r <= 0)
                    {
                        Console.WriteLine("r <= 0? Вероятно, вы не правы");
                        r = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("Какая еще фигура?");
                    string figure = Console.ReadLine();
                    if (figure == "Квадрат")
                    {   
                        Console.WriteLine("Площадь квадрата =" + r * r);
                    }
                    if (figure == "Круг")
                    {
                        Console.WriteLine("Площадь круга =" + Math.PI * r * r);
                    }
                    if (figure == "Треугольник")
                    {
                        Console.WriteLine("Площадь треугольника =" + r * r * Math.Sqrt(3) / 4);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Программа поддерживает только числа");
            }
            #endregion 
            Console.WriteLine("13/3");
            #region 13/3

            try 
            {
            Console.WriteLine("Введите количество пар значений");
            double n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите значение для А");
                double a = Convert.ToDouble(Console.ReadLine());
                while (a <= 0)
                {
                    Console.WriteLine("a > 0 нужно");
                }
                Console.WriteLine("Введите значение для B");
                double b = Convert.ToDouble(Console.ReadLine());
                while (b < 0)
                {
                    Console.WriteLine("b > 0 нужно");
                }
                Console.WriteLine("Какая еще фигура?");
                string figure = Console.ReadLine();
                if (figure == "Прямоугольник")
                {
                    Console.WriteLine("Площадь прямоугольника = " + a * b);
                }
                if (figure == "Кольцо")
                {
                    Console.WriteLine("Площадь кольца = " + (Math.PI * (a * a - b * b)));
                }
                if (figure == "Треугольник")
                {
                    try 
                    {
                        Console.WriteLine("Площадь треугольника = " + (Math.Sqrt(4 * a * a - b * b) * b / 4));
                    }
                    catch
                    {
                        Console.WriteLine("Треугольникa с такими сторонами не существует");
                    }
                }
            }
            }
            catch
            {
                Console.WriteLine("Программа поддерживает только числа");
            }

            #endregion
        } 
    }
}