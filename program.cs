#region_1_4
Console.WriteLine("Enter value 'a'");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter value 'b'");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter value 'c'");
double c = Convert.ToDouble(Console.ReadLine());
double z;
if (a < b)
{
    if (a > c)
    {
        z = a;
    }
    else
    {
        z = c;
    }
}
else
{
    if (b > c)
    {
        z = b;
    }
    else
    {
        z = c;
    }
}
Console.WriteLine("z = " + z);
#endregion

#region_1_5
double Sc1 = 70;
double Ss1 = 36.74;
double Sc2 = 0.86;
double Ss2 = 0.74;
Console.WriteLine("Which option would you like to consider? (1 or 2)");
double N = Convert.ToDouble(Console.ReadLine());
if (N == 1)
{
    if (Math.Sqrt(2 * Ss1) <= (2 * Math.Sqrt(Sc1 / Math.PI)))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    if (Math.Sqrt(2 * Ss2) <= (2 * Math.Sqrt(Sc2 / Math.PI)))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
#endregion

#region_2_1
Console.WriteLine("Введите число детей в классе:");
double c = Convert.ToDouble(Console.ReadLine());
double x;
double s = 0;
double p = 0;
if (c > 0)
{
    for (x = 1; x <= c; x += 1)
    {
        Console.WriteLine("Введите рост ребенка:");
        double h = Convert.ToDouble(Console.ReadLine());
        if (h > 0)
        {
            s = s + h;
            p += 1;
        }
        else
        {
            Console.WriteLine("Проверьте введенные данные.");
            break;
        }
    }
    Console.WriteLine("Средний рост детей в классе: " + s / p);
}
else
{
    Console.WriteLine("Проверьте введенные данные.");
}
#endregion

#region_2_5
double z = 0;
double a = 0;
Console.WriteLine("Введите количество участников:");
double c = Convert.ToDouble(Console.ReadLine());
if (c > 0)
{
    Console.WriteLine("Введите заданный норматив:");
    double n = Convert.ToDouble(Console.ReadLine());
    if (n > 0)
    {
        Console.WriteLine("Поочереди введите результаты спортсменов:");
        while (z < c)
        {

            double r = Convert.ToDouble(Console.ReadLine());
            if (r > 0)
            {
                z += 1;
                if (r >= n)
                {
                    a += 1;
                }
            }
            else
            {
                Console.WriteLine("Проверьте введенные данные");
            }
        }
        Console.WriteLine("Количество учеников выполнивших норматив: " + a);
    }
    else
    {
        Console.WriteLine("Проверьте введенные данные");
    }
}
else
{
    Console.WriteLine("Проверьте введенные данные");
}
#endregion

#region_3_4
Console.WriteLine("Введите значение 'r1':");
double r1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение 'r2':");
double r2 = Convert.ToDouble(Console.ReadLine());
double g;
Console.WriteLine("Введите координату 'x':");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату 'y':");
double y = Convert.ToDouble(Console.ReadLine());
g = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
if ((g >= r1 & g <= r2) | (g >= r2 & g <= r1))
{
    Console.WriteLine("Точка с координатами (" + x + ";" + y + ") лежит в кольце.");
}
else
{
    Console.WriteLine("Точка с координатами (" + x + ";" + y + ") НЕ лежит в кольце.");
}
ConsoleKeyInfo k;
do
{
    Console.WriteLine("Если вы хотите продолжить нажмите любую клавишу, иначе нажмите 'Enter'.");
    k = Console.ReadKey();
    if (k.Key != ConsoleKey.Enter)
    {
        Console.WriteLine("\nВведите координату 'x':");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату 'y':");
        double y1 = Convert.ToDouble(Console.ReadLine());
        g = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        if ((g >= r1 & g <= r2) | (g >= r2 & g <= r1))
        {
            Console.WriteLine("Точка с координатами (" + x1 + ";" + y1 + ") лежит в кольце.");
        }
        else
        {
            Console.WriteLine("Точка с координатами (" + x1 + ";" + y1 + ") НЕ лежит в кольце.");
        }
    }
    else
    {
        Console.WriteLine("Конец.");
    }
} while (k.Key != ConsoleKey.Enter);
#endregion

#region_3_11
ConsoleKeyInfo n;
double q2 = 0;
double c = 0;
do
{
    Console.WriteLine("Вы хотите продолжить? Если да, нажмите любую клавишу. Если хотите выйти, нажмите Enter.");
    n = Console.ReadKey();
    if (n.Key != ConsoleKey.Enter)
    {
        c += 1;
        double s;
        Console.WriteLine("\nВведите оценки учеников:");
        double m1 = Convert.ToDouble(Console.ReadLine());
        double m2 = Convert.ToDouble(Console.ReadLine());
        double m3 = Convert.ToDouble(Console.ReadLine());
        double m4 = Convert.ToDouble(Console.ReadLine());
        s = (m1 + m2 + m3 + m4) / 4;
        q2 += s;
        if (s < 3)
        {
            Console.WriteLine("Оценка 'Неудовлетворительно'");
        }
        else
        {
            Console.WriteLine("Оценка 'Удовлетворительно'");
        }
    }
    else
    {
        Console.WriteLine("Конец.");
    }
} while (n.Key != ConsoleKey.Enter);
Console.WriteLine("Средний балл группы: " + q2 / c);
#endregion

#region_3_12
ConsoleKeyInfo n;
Console.WriteLine("Введите значение 'r':");
double r = Convert.ToDouble(Console.ReadLine());
do
{
    Console.WriteLine("Нажмите, чтобы найти:\nS - Площадь квадрата\nC - Площадь круга\nT - Площадь треугольника\nEnter - Конец программы\n\n\n");
    n = Console.ReadKey();
    if (n.Key == ConsoleKey.S)
    {
        Console.WriteLine("\nПлощадь квадрата: " + (r * r) + "\n");
    }
    if (n.Key == ConsoleKey.C)
    {
        Console.WriteLine("\nПлощадь круга: " + (3.14 * r * r) + "\n");
    }
    if (n.Key == ConsoleKey.T)
    {
        Console.WriteLine("\nПлощадь тругольника: " + (0.4 * r * r) + "\n");
    }
    if (n.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("Конец.");
    }
} while (n.Key != ConsoleKey.Enter);
#endregion

#region_3_13
ConsoleKeyInfo n;
Console.WriteLine("Введите значение 'A':");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение 'B':");
double b = Convert.ToDouble(Console.ReadLine());
do
{
    Console.WriteLine("Нажмите, чтобы найти:\nS - Площадь прямоугольника\nC - Площадь кольца\nT - Площадь треугольника\nEnter - Конец программы\n\n\n");
    n = Console.ReadKey();
    if (n.Key == ConsoleKey.S)
    {
        Console.WriteLine("\nПлощадь прямоугольника: " + (a * b) + "\n");
    }
    if (n.Key == ConsoleKey.C)
    {
        Console.WriteLine("\nПлощадь кольца: " + Math.Round(Math.Abs((3.14 * a * a) - (3.14 * b * b)), 2) + "\n");
    }
    if (n.Key == ConsoleKey.T)
    {
        Console.WriteLine("\nПлощадь тругольника: " + Math.Round(((Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a / 2, 2)) / 2) * a), 2) + "\n");
    }
    if (n.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("Конец.");
    }
} while (n.Key != ConsoleKey.Enter);
#endregion
