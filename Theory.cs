using System.Security.Cryptography;

double x1 = 0, y1 = 2, x2 = 1.5, y2 = 0.7, x3 = 1, y3 = 1, x4 = 3, y4 = 0;

Console.WriteLine("1 задача");
if (Math.Abs(x1 * x1 + y1 * y1 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x1},{y1}): да");
}
else
{
    Console.WriteLine($"Для ({x1},{y1}): нет");
}
if (Math.Abs(x2 * x2 + y2 * y2 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x2},{y2}): да");
}
else
{
    Console.WriteLine($"Для ({x2},{y2}): нет");
}
if (Math.Abs(x3 * x3 + y3 * y3 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x3},{y3}): да");
}
else
{
    Console.WriteLine($"Для ({x3},{y3}): нет");
}
if (Math.Abs(x4 * x4 + y4 * y4 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x4},{y4}): да");
}
else
{
    Console.WriteLine($"Для ({x4},{y4}): нет");
}

x1 = -1;
y1 = 0;
x2 = 1;
y2 = 0;
x3 = 0;
y3 = 1;

Console.WriteLine("\n2 задача");

if (y1 >= 0 && (y1 + Math.Abs(x1) <= 1))
{
    Console.WriteLine($"Для ({x1},{y1}): да");
}
else
{
    Console.WriteLine($"Для ({x1},{y1}): нет");
}
if (y2 >= 0 && (y2 + Math.Abs(x2) <= 1))
{
    Console.WriteLine($"Для ({x2},{y2}): да");
}
else
{
    Console.WriteLine($"Для ({x2},{y2}): нет");
}
if (y3 >= 0 && (y3 + Math.Abs(x3) <= 1))
{
    Console.WriteLine($"Для ({x3},{y3}): да");
}
else
{
    Console.WriteLine($"Для ({x3},{y3}): нет");
}

double s = 0, n = 0, inp = 5;


// сделал задачу с вводом n-значений

Console.WriteLine("Задача 2.1 Введите количество девочек:");

if (double.TryParse((Console.ReadLine()), out inp))
{
    n = inp;
}

Console.WriteLine("Введите рост девочек:");

for (int i = 0; i < n; i++)
{
    if (double.TryParse((Console.ReadLine()), out inp))
    {
        s += inp;
    }
}

Console.WriteLine($"Средний рост девочек: {s / n}");

s = 0;

Console.WriteLine("Задача 2.1 Введите количество мальчиков:");

if (double.TryParse((Console.ReadLine()), out inp))
{
    n = inp;
}

Console.WriteLine("Введите рост мальчиков:");

for (int i = 0; i < n; i++)
{
    if (double.TryParse((Console.ReadLine()), out inp))
    {
        s += inp;
    }
}

Console.WriteLine($"Средний рост мальчиков: {s / n}");


Console.WriteLine($"2.3 введите вес учеников (5):");
s = 0;
n = 5;

for (int i = 0; i < n; i++)
{
    if (double.TryParse((Console.ReadLine()), out inp) && inp > 30)
    {
        s += 0.2;
    }
}

Console.WriteLine($"{s} л");

double r1 = 1, r2 = 2;


Console.WriteLine("3.4 введите r1:");

double.TryParse((Console.ReadLine()), out r1);

Console.WriteLine("введите r2:");

double.TryParse((Console.ReadLine()), out r2);

bool trigger = true;

double x, y, length;

s = 0;

while (trigger)
{
    Console.WriteLine("Для ввода x и y точек нажмите клавишу enter, для остановки ввода напишите \"стоп\"");
    if (Console.ReadLine() ==  "стоп")
    {
        trigger = false;
        break;
    }

    Console.WriteLine("x:");

    double.TryParse((Console.ReadLine()), out x);

    Console.WriteLine("y:");

    double.TryParse((Console.ReadLine()), out y);

    length = x * x + y * y;

    if(length<=r2*r2 && length>=r1*r1)
    {
        s += 1;
    }
}

Console.WriteLine($"Количество точек: {s}");

Console.WriteLine("3.11");

trigger = true;

double sb = 0;

int e1, e2, e3, e4, dv = 0;

s = 0;

while (trigger)
{
    Console.WriteLine("Для ввода информации по студенту нажмите клавишу enter, для остановки ввода напишите \"стоп\"");
    if (Console.ReadLine() == "стоп")
    {
        trigger = false;
        break;
    }

    Console.WriteLine("e1:");

    Int32.TryParse((Console.ReadLine()), out e1);

    Console.WriteLine("e2:");

    Int32.TryParse((Console.ReadLine()), out e2);

    Console.WriteLine("e3:");

    Int32.TryParse((Console.ReadLine()), out e3);

    Console.WriteLine("e4:");

    Int32.TryParse((Console.ReadLine()), out e4);

    sb += (e1 + e2 + e3 + e4) / 4;

    if(e1 == 2 || e2 == 2 || e3 == 2 || e4 == 2)
    {
        dv += 1;
    }

    s++;
}

if (s > 0)
{
    Console.WriteLine($"Число неуспевающих: {dv}, ср. балл группы: {sb / s}");
} else
{
    Console.WriteLine("Не было введено ни одного ученика");
}

trigger = true;

double r;

int v;


while (trigger)
{
    Console.WriteLine("Для ввода r нажмите enter, для остановки ввода напишите \"стоп\"");
    if (Console.ReadLine() == "стоп")
    {
        trigger = false;
        break;
    }

    Console.WriteLine("R = ");
    double.TryParse((Console.ReadLine()), out r);

    Console.WriteLine("Введите 1 для получения площади квадрата, 2 для площади круга, 3 площади равностороннего треугольника");

    Int32.TryParse(Console.ReadLine(), out v);

    switch(v)
    {
        case 1:
            Console.WriteLine(r * r);
            break;
        case 2:
            Console.WriteLine(Math.PI * r * r);
            break;
        case 3:
            Console.WriteLine((r * r) / 2);
            break;
    }
}

trigger = true;

double a = 1, b = 1, h = 1;

while(trigger)
{
    Console.WriteLine("Для ввода a,b нажмите enter, для остановки ввода напишите \"стоп\"");
    if (Console.ReadLine() == "стоп")
    {
        trigger = false;
        break;
    }

    Console.WriteLine("a:");

    double.TryParse((Console.ReadLine()), out a);

    Console.WriteLine("b:");

    double.TryParse((Console.ReadLine()), out b);

    Console.WriteLine("Введите 1 для площади прямоугольника, 2 для площади кольца, 3 для равнобедренного треугольник");

    Int32.TryParse(Console.ReadLine(), out v);

    switch (v)
    {
        case 1:
            Console.WriteLine(a * b);
            break;
        case 2:
            if (a > b)
            {
                Console.WriteLine(Math.PI * a * a - Math.PI * b * b);
            } else Console.WriteLine(Math.PI * b * b - Math.PI * a * a);
            break;
        case 3:
            h = Math.Sqrt(b * b - (a * a / 4));
            Console.WriteLine(0.5 * a * h);
            break;
    }
}
