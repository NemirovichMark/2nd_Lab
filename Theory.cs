#region lvl.1 ex.1
Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double r = 2;
if (Math.Abs(x * x + y * y - r * r) <= 0.001)
{
    Console.WriteLine("Лежит на окружности");
}
else if (x*x+y*y<r*r)
{
    Console.WriteLine("Лежит в пределах окружности");
}
else
{
    Console.WriteLine("Точка находится вне окружности");
}
#endregion
#region ex.2
Console.WriteLine("Введите x:\t");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:\t");
double y  = double.Parse(Console.ReadLine());
if (y>=0 & y+ Math.Abs(x)<=1)
{
    Console.WriteLine("Точка находится в треугольнике");
}
else
{
    Console.WriteLine("Точка не в треугольнике");
}
#endregion
#region #region lvl.2 ex.1
Console.WriteLine("Введите количество учеников в классе:");
int n = int.Parse(Console.ReadLine()), i = 0;
double h, sum = 0;
do
{
    i++;
    Console.WriteLine($"Введите рост {i} ребенка:");
    h = double.Parse(Console.ReadLine());
    if (h <= 0)
    {
        Console.WriteLine("Рост должен быть больше нуля.");
        h = double.Parse(Console.ReadLine());
    }
    sum += h;
} while (i < n);
Console.WriteLine($"Средний рост {i} детей равен {sum/i}");
#endregion
#region ex.2
Console.WriteLine("Введите количество точек:");
int n = int.Parse(Console.ReadLine());
int a = 3, b = 2, r = 3;
double x = 0, y = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите x{i}:");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine($"Введите y{i}:");
    y = double.Parse(Console.ReadLine());
    x -= a; y -= b;
    if (Math.Sqrt(x * x + y * y) <= r)
    {
        Console.WriteLine("точка лежит в окружности");
    }
    else
    {
        Console.WriteLine("Точка находится вне окружности");
    }
}
#endregion
#region lvl.3 ex.4
Console.WriteLine("Введите количество точек:");
int n = int.Parse (Console.ReadLine());
Console.WriteLine("Введите внутренний радиус:");
double r1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите внешний радиус:");
double r2 = double.Parse(Console.ReadLine());
double x, y;
int s = 0, d = 0;
if (r2 <= r1)
{
    Console.WriteLine("Внешний радиус должен быть больше");
    Environment.Exit(0);
}
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Введите х{i}:");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine($"Введите y{i}:");
    y = double.Parse(Console.ReadLine());
    if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
    {
        s += 1;
    }
    else
    {
        d += 1;
    }
}
Console.WriteLine($"{s} точек попали в кольцо");
Console.WriteLine($"{d} точек не попали в кольцо");
#endregion
#region ex.11
Console.WriteLine("Введите количество студентов:");
int n = int.Parse(Console.ReadLine());
int b, k = 0;
double s = 0;
int[] a = new int[4];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"Введите {j} оценку {i} ученика");
        b = int.Parse(Console.ReadLine());
        if (b > 6)
        {
            Console.WriteLine("У нас максимальная оценка - 5");
        }
        a[j] = b;
    }
    if (a.Min() == 1 || a.Min() == 2 || a.Min() == 3)
    {
        k++;
    }
    else
    {
        s += a.Sum();
    }
}
Console.WriteLine($"Успешно сдали {n-k} студентов, средний балл группы равен {s/((n-k)*4)}");
#endregion
#region ex.12
double r;
do
{
    Console.WriteLine("Введите значение r, для окончания введите 0:");
    r = double.Parse(Console.ReadLine());
    if (r <= 0)
    {
        Console.WriteLine("Программа завершена.");
        Environment.Exit(0);
    }
    Console.WriteLine("Если хотите вычислить площадь квадрата - нажмите 1, площадь круга - 2 площать равностороннего треугольника - 3");

    string a = Console.ReadLine();
    switch (a)
    {
        case "1":
            Console.WriteLine($"Площадь квалрата равна {r * r}");
            break;
        case "2":
            Console.WriteLine($"Площадь круга равна {Math.PI * r * r}");
            break;
        case "3":
            Console.WriteLine($"{r * r * Math.Sqrt(3) / 4}");
            break;
        default:
            Console.WriteLine("Вы ввели или больше 3, или меньше 1");
            break;
    }
} while (r > 0);
#endregion
#region ex.13
double a;
int i = 0;
do
{
    double p = 0;
    Console.WriteLine("Введите значение А, для завершения программы введите 0 или отрицательное число:");
    a = double.Parse(Console.ReadLine());
    if (a <= 0)
    {
        Console.WriteLine($"Программа завершена, цикл выполнен {i} раз") ;
        break;
    }
    Console.WriteLine("Введите значение B:");
    double b = double.Parse(Console.ReadLine());
    if (b <= 0)
    {
        Console.WriteLine("Введите число болше нуля");
        while (b <= 0)
        {
            Console.WriteLine("Введите значение B больше нуля:");
        }
    }
    Console.WriteLine("Для вычисления площади прямоугольника нажмите 1, для кольца - 2, для равнобедренного треугольника - 3:");
    string c = Console.ReadLine();
    switch (c)
    {
        case "1":
            Console.WriteLine($"Площадь прямоугольника равна {a * b}");
            break;
        case "2":
            if (a < b)
            {
                Console.WriteLine($"Площадь кольца равна {Math.PI * b * b - Math.PI * a * a}");
            }
            Console.WriteLine($"Площадь кольца равна {Math.PI * a * a - Math.PI * b * b}");
            break;
        case "3":
            p = a + b * 2;
            Console.WriteLine($"{Math.Sqrt(p * (p - a) * (p - b) * (p - b))}");
            break;
        default:
            Console.WriteLine("Вы ввели или больше 3, или меньше 1");
            break;
    }
    i++;
} while (a > 0);
#endregion
