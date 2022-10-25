using System.Drawing;

Console.WriteLine("Hello, World!");


#region task2
double x, y;
bool q = false;
Console.Write("x=");
while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("x=");
}
Console.Write("y=");
while (!double.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("y=");
}
if (y >= 0 && (y + Math.Abs(x)) <= 1)
    q = !q;
Console.WriteLine($"{q}");
#endregion

#region task3
double a;
double b;
double c;
c = 0;
Console.Write("A=");
while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("А=");
}
Console.Write("B=");
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("В=");
}
if (a > 0)
{
    if (a > b)
        c = a;
    else 
        c = b;
}
else if(a <= 0)
{
    if (a > b)
        c = b;
    else 
        c = a;
}
Console.WriteLine($"c={c}");
#endregion

#region 2task1
int grls, boys;
double grlsh, boysh,i,l=0,s=0;

do
{
    Console.WriteLine("Количество мальчиков=: ");
    while (!int.TryParse(Console.ReadLine(), out boys))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("количество мальчиков=");
    }
    if (boys < 0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (boys<0);
for (i = 0; i < boys; i++)
{
    do {
        Console.Write("рост мальчиков");
        while (!double.TryParse(Console.ReadLine(), out boysh))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("рост мальчиков=");
        }
        if (boysh < 0)
            Console.WriteLine("Вы ввели неверные входные данные!;(");
        //boysh=Convert.ToDouble(Console.ReadLine());
    } while(boysh <= 0);
    s += boysh;
}
do
{
    Console.WriteLine("Количество девочек=: ");
    while (!int.TryParse(Console.ReadLine(), out grls))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("количество девочек=");
    }
    if (grls < 0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (grls < 0);
for (i = 0; i < grls; i++)
{
    do
    {
        Console.Write("рост девочек:");
        while (!double.TryParse(Console.ReadLine(), out grlsh))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("рост девочек=");
        }
        if (grlsh <= 0)
            Console.WriteLine("Вы ввели неверные входные данные!;(");
    } while (grlsh <= 0);
    l += grlsh;
}

Console.WriteLine($"cредний рост= {(s + l) / (grls + boys)}");
#endregion

#region 2task3
double summa, weight;
summa = 0;
int j, number;
Console.WriteLine("Количество учеников ");
do
{
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("количество учеников=");
    }
    if (number < 0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (number<0);
for (j = 0; j < number;j++)
{
    do
    {
        Console.Write("Вес ученика= ");
        while (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("вес ученика=");
        }
        if (weight < 0)
            Console.WriteLine("Вы ввели неверные входные данные!;(");
    } while (weight<0);
    if (weight < 30)
    {
        summa += 0.2;
    }
}
Console.WriteLine($" {summa}");
#endregion

#region 3task4
int tochki = 0;
double r1, r2, x1, y1;
do {
    Console.WriteLine("Введите r1");
    while (!double.TryParse(Console.ReadLine(), out r1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("r1=");
    }
    if (r1<=0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (r1 <= 0) ;
do {
    Console.WriteLine("Введите r2");
    while (!double.TryParse(Console.ReadLine(), out r2))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("r2=");
    }
    if (r1 <= 0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (r2<=0) ;
do
{
    Console.WriteLine("Введите х");
    while (!double.TryParse(Console.ReadLine(), out x1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("x=");
    }
    if (x1 >= 20000) break;
    Console.WriteLine("Введите y");
    while (!double.TryParse(Console.ReadLine(), out y1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("y=");
    }
    if ((x1 * x1) + (y1 * y1) <= r1 * r1 && (x1 * x1) + (y1 * y1) <= r2 * r2) 
    {
        tochki++;
    }
}
while (x1 >20000);
Console.WriteLine($"{tochki}");
#endregion

#region 11task3
int students,j3 = 0;
int allpoints = 0, loxi = 0, u = 0,dop_point=0;
int point;
bool flag3;
do
{
    Console.Write("Введите количество студентов:");
    while (!int.TryParse(Console.ReadLine(), out students))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите количество студентов=");
    }
    if (students <= 0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (students<=0);
for (int ii = 0;ii<students; ii++)
{
    Console.WriteLine($"Студент {ii+1}");
    flag3 = true;
    j3 = 0;
    dop_point = 0;
    while (flag3 && (j3 <= 3))
    {
        do
        {
            Console.WriteLine("Оценки за экзамен ");
            while (!int.TryParse(Console.ReadLine(), out point))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write("оценки за экзамен=");
            }
            if (point <= 1 || point > 5)
                Console.WriteLine("Вы ввели неверные входные данные!;(");
        } while (point <= 1 || point > 5);
        dop_point += point;
        if (point == 2)
        {
            flag3 = false;
            dop_point =0;
            loxi++;
        }
        j3++;
    }
    allpoints += dop_point;
}
Console.WriteLine($"Число неуспевающих студентов = {loxi}");
if (loxi != students)
    Console.WriteLine($"Средний балл группы = {(allpoints / 4 / (students - loxi))}");
else Console.WriteLine("Средний балл группы =2");
#endregion


#region 3task12
double ploschad;
double r;
do {
    Console.WriteLine("r=");
    while (!double.TryParse(Console.ReadLine(), out r))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("r=");
    }
    if (r<=0)
        Console.WriteLine("Вы ввели неверные входные данные!;(");
} while (r<=0);
Console.WriteLine("1-квадрат\n2-круг\n3-треугольник\n4-выход");
int f;
while (!int.TryParse(Console.ReadLine(), out f))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("1-квадрат 2-круг 3-треугольник 4-выход");
}
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
        case 4:
            break;
        default:
            Console.WriteLine("Нет такой команды!");
            break;

    }

#endregion

#region 3task13
double s1;
double a1;
double b1;
do {
    Console.WriteLine("a=");
    while (!double.TryParse(Console.ReadLine(), out a1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("a=");
    }
    if (a1 <= 0)
        Console.WriteLine("Неверные входные данные:");
} while (a1<=0);
do
{
    Console.WriteLine("b=");
    while (!double.TryParse(Console.ReadLine(), out b1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("b=");
    }
    if (b1 <= 0)
        Console.WriteLine("Неверные входные данные:");
} while (b1 <= 0);

Console.WriteLine("1-прямоугольник \n2-кольца \n3-треугольник\n4-выход");
int k = 0;
do
{
    Console.WriteLine("k=");
    while (!int.TryParse(Console.ReadLine(), out k))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("k=");
    }
    if (k <= 0)
        Console.WriteLine("Неверные входные данные:");
} while (k <= 0);
switch (k) {
    case 1:
    s1 = a1 * b1;
    Console.WriteLine($"площадь прямоугольника = {s1}");
    break;
case 2:
    s1 = Math.Abs(3.14 * a1 * a1 - 3.14 * b1 * b1);
    Console.WriteLine($"площадь колец = {s1}");
    break;
case 3:
    if (a1 * a1 / 4 > b1 * b1)
        Console.WriteLine("Треугольника с такими сторонами не существует");
    else
    {
        s1 = a1 * Math.Sqrt(b1 * b1 - a1 * a1 / 4) / 2;
        Console.WriteLine($"площадь равнобедренного треугольника = {s1}");
    }
    break;
#endregion
}

