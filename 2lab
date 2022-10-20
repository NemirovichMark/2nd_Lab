#region task2
double x, y;
bool q = false;
Console.WriteLine("x=");
x = double.Parse(Console.ReadLine());
Console.WriteLine("y=");
y = double.Parse(Console.ReadLine());
if (y >= 0 && (y + Math.Abs(x)) <= 1) q = !q;
Console.WriteLine($"{q}");
#endregion

#region task3
double a;
double b;
double c;
c = 0;
Console.WriteLine("A=");
a = double.Parse(Console.ReadLine());
Console.WriteLine("B=");
b = double.Parse(Console.ReadLine());
if (a > 0)
{
    if (a > b) c = a;
    else c = b;
}
else if(a <= 0);
{
    if (a > b) c = b;
    else c = a;
}
Console.WriteLine($"c={c}");
#endregion

#region 2task1
double grls, boys, grlsh, boysh,i,l=0,s=0;
Console.WriteLine("Количество мальчиков=: ");
boys = double.Parse(Console.ReadLine());
for (i = 0; i < boys; i++)
{
    Console.WriteLine("рост мальчиков");
    boysh = double.Parse(Console.ReadLine());
    s += boysh;
}

Console.WriteLine("Количество девочек=: ");
grls = double.Parse(Console.ReadLine());
for (i = 0; i < grls; i++)
{
    Console.WriteLine("рост девочек");
    grlsh = double.Parse(Console.ReadLine());
    l += grlsh;
}

Console.WriteLine($"cредний рост= {(s + l) / (grls + boys)}");
#endregion

#region 2task3
double summa, number, weight;
summa = 0;
int j;
Console.WriteLine("Количество учеников ");
number = double.Parse(Console.ReadLine());
for (j = 0; j < number; j++)
{
    Console.WriteLine("Вес ученика= ");
    weight = double.Parse(Console.ReadLine());
    if (weight < 30) summa += 0.2;
}
Console.WriteLine($" {summa}");
#endregion

#region 3task4
int tochki = 0;
double r1, r2, x1, y1;
Console.WriteLine("Введите r1");
r1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите r2");
r2 = double.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Введите х");
    x1 = double.Parse(Console.ReadLine());
    if (x1 >= 20000) break;
    Console.WriteLine("Введите y");
    y1 = double.Parse(Console.ReadLine());
    if ((x1 * x1) + (y1 * y1) <= r1 * r1 && (x1 * x1) + (y1 * y1) <= r2 * r2) 
    {
        tochki++;
    }
}
while (x1 >20000);
Console.WriteLine($"{tochki}");
#endregion

#region 11task3
double students = 0;
int allpoints = 0, loxi = 0, u = 0;
for (int ii = 1; ; ii++)
{
    int m = 0;
    Console.WriteLine("Оценки за экзамен ");
    for (int k2 = 1; k2 <= 4; k2++)
    {
        int point = int.Parse(Console.ReadLine());
        if (point <= 3)
            m = m + 1;

        if (point > 5)
        {
            u = 1;
            break;
        }
        allpoints = allpoints + point;
    }
    if (m > 0)
        loxi++;
    students++;
    if (u == 1)
        break;
}
Console.WriteLine($"Число неуспевающих студентов = {loxi}");
Console.WriteLine($"Средний балл группы = {(allpoints / 4 / (students - 1))}");
#endregion


#region 3task12
double ploschad;
Console.WriteLine("r=");
double r = double.Parse(Console.ReadLine());
Console.WriteLine("1-квадрат 2-круг 3-треугольник?");
int f = int.Parse(Console.ReadLine());
while (r > 0)
{
    switch (f)
    {
        case 1:
            ploschad = r * r;
            Console.WriteLine($"площадь квадрата = {ploschad}");
            break;
        case 2:
            ploschad = 3.14 * r * r;
            Console.WriteLine($"площадь круга = {ploschad}");
            break;
        case 3:
            ploschad = Math.Sqrt(3) * r * r / 4;
            Console.WriteLine($"площадь треугольника = {ploschad}");
            break;
    }
    r = double.Parse(Console.ReadLine());
    break;
}

#endregion

#region 3task13
double s1;
Console.WriteLine("a=");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("b=");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("1-прямоугольник, 2-кольца, 3-треугольник");
int k = 0;
k = int.Parse(Console.ReadLine());
while ((a1 > 0) && (b1 > 0))
{
    switch (k)
    {
        case 1:
            s1 = a1 * b1;
            Console.WriteLine($"площадь прямоугольника = {s1}");
            break;
        case 2:
            s1 = Math.Abs(3.14 * a1 * a1 - 3.14 * b1 * b1);
            Console.WriteLine($"площадь колец = {s1}");
            break;
        case 3:
            s1 = a1 * Math.Sqrt(4 * b1 * b1 - a1 * a1) / 4;
            Console.WriteLine($"площадь равнобедренного треугольника = {s1}");
            break;
    }
    a1 = double.Parse(Console.ReadLine());
    if (a1 == 0)
        break;
    b1 = double.Parse(Console.ReadLine());
    break;
}

#endregion
