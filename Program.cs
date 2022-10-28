using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
        #region 1/3

        double a, b;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        if (a > 0) 
        {
            Console.WriteLine(Math.Max(a,b));
        }
        else 
        {
            Console.WriteLine(Math.Min(a,b));
        }

        #endregion 1/3
        #region 4/1
        double x;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        x = Math.Min(a,b);
        Console.WriteLine(Math.Max(x,c));

        #endregion 4/1

        #region 1/2
        int n = 3;
        double sr, r, s = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите рост ученика");
            r = Convert.ToDouble(Console.ReadLine());
            s += r;
        }
        sr = s / n;
        Console.WriteLine("Средний рост = " + sr);
        #endregion 1/2

        #region 5/2 

        n = 30;
        c = 0;
        double norma;
        Console.WriteLine("Введите норматив");
        norma = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i <= n; i++) 
        {
            Console.WriteLine("Введите результат участника");
            if (Convert.ToDouble(Console.ReadLine()) >= norma)
            {
                Console.WriteLine("Норматив сдан");
                c++;
            }
            else 
            {
                Console.WriteLine("Норматив не сдан");
            }
        }
        Console.WriteLine($"{c}");
        #endregion 5/2
        
        #region 4/3

        s = 0;
        Console.WriteLine("Введите количество точек");
        double k = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты центра окружности");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите радиус внутреннего кольца");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус внешнего кольца");
            double r2 = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("Введите координаты по оси x");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координаты по оси y");
                double y = Convert.ToDouble(Console.ReadLine());

                double q = Math.Sqrt((Math.Pow((x - a), 2) + Math.Pow((y - b), 2)));
                if (q >= r && q <= r2)
                {
                    s++;
                    Console.WriteLine("Точка принадлежит кольцу");
                }
            }
            Console.WriteLine($"{s}");

        #endregion 4/3

        #region 11/3

        Console.WriteLine("Введите кол-во студентов");
        double m = 0;
        c = 0;
        k = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите кол-во экзаменов");
        double e = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i < k; i++)
        {
            bool flag = true;
            for (int j = 1; j < e; j++)
            {
                Console.WriteLine("Введите оценку за экзамен");
                double z = Convert.ToDouble(Console.ReadLine());
                m += z;
                if (z < 3)
                {
                    flag = false;
                }
            if (flag == false)
                {
                    c++;
                }

            }
        }
        Console.WriteLine("Средний балл = " + m / (k*e));
        Console.WriteLine("Кол-во незачетов = " + c);
        
        #endregion 11/3

        #region 12/3
            Console.WriteLine("Введите количество значений");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите значение r");
                r = Convert.ToDouble(Console.ReadLine());
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

            #endregion 12/3

            #region 12/4
            Console.WriteLine("Введите количество пар значений");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите значение для А");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение для B");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Какая еще фигура?");
                string figure = Console.ReadLine();
                if (figure == "Прямоугольник")
                {
                    Console.WriteLine("Площадь прямоугольника =" + a * b);
                }
                if (figure == "Кольцо")
                {
                    Console.WriteLine("Площадь кольца = " + (Math.PI * (a * a - b * b)));
                }
                if (figure == "Треугольник")
                {
                    Console.WriteLine("Площадь треугольника = " + (Math.Sqrt(4 * a * a - b * b) * b / 4));
                }
            }

            #endregion 12/4
        }
    }
}