#region lvl1_task1 

using System;

int rad = 4;
int y = 0;
int x = 0;
try
{
    Console.Write("Введите координаты X: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y: ");
    y = int.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Wrong Input");
}

bool onCircle = Math.Abs(x * x + y * y) == rad * rad;
if (onCircle)
{
    Console.WriteLine("Точка лежит на окружности");
}
else
{
    Console.WriteLine("Точка не лежит на окружности");
}
#endregion

    #region lvl1_task3 
Console.WriteLine("Введите a и b:");
string[] x__y = Console.ReadLine().Split(' ');
int a = 0;
int b = 0;
try
{
    Console.Write("Введите a: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    b = int.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Wrong Input");
}
if (a > 0)
    Console.WriteLine(Math.Max(a, b));
else
    Console.WriteLine(Math.Min(a, b));
#endregion
#region lvl1_task4
Console.WriteLine("Введите a, b, c:");
string[] x___y = Console.ReadLine().Split(' ');
int aaa = 0;
int bbb = 0;
int c = 0;
try
{
    Console.Write("Введите a");
    aaa = int.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    bbb = int.Parse(Console.ReadLine());
    Console.Write("Введите c: ");
    c = int.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Wrong Input");
}
Console.WriteLine(Math.Max(Math.Min(aaa, bbb), c));
#endregion

#region lvl2_task1
Console.WriteLine("Введите кол-во учеников:");
bool canN = int.TryParse(Console.ReadLine(), out int n);

if (!canN)
{
    Console.WriteLine("Неверные данные");
}

if (canN)
{
    Console.WriteLine("Введите рост и пол ученика через пробел:");
    int manCount = 0, wCount = 0, mSum = 0, wSum = 0;

    for (int i = 0; i < n; i++)
    {
        // 180 м 190 ж 300 м
        string[] input = Console.ReadLine()?.Split(' ') ?? new string[] { };
        if (input.Length != 0 && input.Length % 2 == 0)
        {
            try
            {
                if (input[1].ToLower() == "м")
                {
                    mSum += int.Parse(input[0]);
                    manCount++;
                }

                if (input[1].ToLower() == "ж")
                {
                    wSum += int.Parse(input[0]);
                    wCount++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверные данные");
            }
        }
    }

    if (manCount <= 0 && wCount <= 0)
    {
        Console.WriteLine("Нет данных");
    }
    else
    {
        double mAvg = (double)mSum / manCount;
        double wAgv = (double)wSum / wCount;
        Console.WriteLine($"Средний рост мальчиков: {mAvg}\nСредний рост девочек: {wAgv}");
    }
}


#endregion

#region lvl2_task5
int[] array = new int[30];
int norm = 10;
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    try
    {
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] > norm)
        {
            count++;
        }
    }
    catch
    {
        Console.WriteLine("err");
    }
}
Console.WriteLine(count + " спортсменов выполнило норматив");
#endregion
#region lvl3_task4 
int sum = 0;
Console.WriteLine("Вот так пиши: N: [x] [y]");
int ii = 0;
double r1 = 0;
double r2 = 0;
try
{
    Console.Write("r1: ");
    r1 = double.Parse(Console.ReadLine());
    Console.Write("r2: ");
    r2 = double.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Wrong Input");
}
while (true)
    {
        Console.Write((ii + 1) + ": ");
        string input = Console.ReadLine();
        if (input == "")
        {
            break;
        }
        string[] coords = input.Split(' ');
        double xx = double.Parse(coords[0]);
        double yy = double.Parse(coords[1]);
        double line = Math.Sqrt(Math.Pow(xx, 2) + Math.Pow(yy, 2));
        if (line > r1 && line < r2)
        {
            sum++;
        }
        ii += 1;
    }
    Console.WriteLine("Sum: " + sum);
#endregion

#region 3.11
Console.WriteLine("Введите число учеников");
double q = Convert.ToDouble(Console.ReadLine());
double aaaa, bbbb, cccc, d, s = 0, sum1 = 0;
double qwerty = 0;
for (int i = 1; i <= q; i++)
{
    Console.WriteLine($"Студент №{i}");
    Console.WriteLine("Оценка №1:");
    aaaa = Convert.ToDouble((Console.ReadLine()));
    Console.WriteLine("Оценка №2:");
    bbbb = Convert.ToDouble((Console.ReadLine()));
    Console.WriteLine("Оценка №3:");
    cccc = Convert.ToDouble((Console.ReadLine()));
    Console.WriteLine("Оценка №4:");
    d = Convert.ToDouble((Console.ReadLine()));
    if (aaaa < 6 || bbbb < 6 || cccc < 6 || d < 6 || aaaa > 1 || bbbb > 1 || cccc > 1 || d > 1)
    {


        if (aaaa < 3 || bbbb < 3 || cccc < 3 || d < 3)
        {
            s++;
        }
        if (aaaa > 2 & bbbb > 2 & cccc > 2 & d > 2)
        {
            qwerty++;
            sum1 += aaaa + bbbb + cccc + d;
        }
    }
    else
    {
        Console.WriteLine("Оценки должны быть от 2 до 5");
        return;
    }
}
Console.WriteLine($"Неуспевающих студентов: {s} \nСредний балл группы: {sum * 1.0 / qwerty / 4:f2}");
#endregion


#region lvl3_task12  
ii = 0;
Console.WriteLine("(Input example) N: [r] [Type]");
Console.WriteLine("(Input example) Type 1 - Square");
Console.WriteLine("(Input example) Type 2 - Circle");
Console.WriteLine("(Input example) Type 3 - Equilateral triangle");
while (true)
{
    Console.Write((ii + 1) + ": ");
    string input = "";
    try
    {
        input = Console.ReadLine();
    }
    catch
    {
        Console.WriteLine("Ну ек макарёк, как в примере делай и не беси");
    }

    if (input == "") break;
    string[] line = input.Split(' ');
    double r = double.Parse(line[0]);
    int type = int.Parse(line[1]);
    double area = 0;
    switch (type)
    {
        case 1:
            area = Math.Pow(r, 2);
            break;
        case 2:
            area = Math.PI * Math.Pow(r, 2);
            break;
        case 3:
            area = (Math.Sqrt(3) * Math.Pow(r, 2)) / 4;
            break;
        default:
            Console.WriteLine("Там есть пример кста, может так же делать будешь?");
            return;
    }
    Console.WriteLine("Area: " + Math.Round(area, 3));
    ii++;
}


#endregion
#region lvl3_task13 

ii = 0;

Console.WriteLine("(Input example) N: [a] [b] [Type]");
Console.WriteLine("(Input example) Type 1 - Rectangle");
Console.WriteLine("(Input example) Type 2 - Ring");
Console.WriteLine("(Input example) Type 3 - Isosceles");

while (true)
{
    Console.Write((ii + 1) + ": ");
    string input = "";
    try
    {
        input = Console.ReadLine();
    }
    catch
    {
        Console.WriteLine("Ну ек макарёк, как в примере делай и не беси");
    }

    if (input == "") break;
    string[] line = input.Split(' ');
    double aa = double.Parse(line[0]);
    double bb = double.Parse(line[1]);
    if (aa <= 0 || bb <= 0)
    {
        Console.WriteLine("Там пример сверху написан кста ");
        return;
    }

    int type = int.Parse(line[2]);
    double area = 0;
    switch (type)
    {
        case 1:
            area = Math.Abs(aa * bb);
            break;
        case 2:
            area = Math.Abs((Math.PI * Math.Pow(aa, 2)) - (Math.PI * Math.Pow(bb, 2)));
            break;
        case 3:
            double p = (aa + bb + bb) / 2;
            area = Math.Sqrt(p * (p - aa) * (p - bb) * (p - bb));
            break;
        default:
            Console.WriteLine("Как в примере делай");
            return;
    }

    Console.WriteLine("Area: " + Math.Round(area, 3));
    ii++;
}
#endregion
