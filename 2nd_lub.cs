#region lvl1_task1 
int rad = 2;
Console.WriteLine("Введите координаты X и Y :");
string[] x_y = Console.ReadLine().Split(' ');
int x = int.Parse(x_y[0]);
int y = int.Parse(x_y[1]);

if (Math.Abs(x * x + y * y - rad * rad) < 0.001)
    Console.WriteLine("Точка лежит на окружности");
else
    Console.WriteLine("Точка не лежит на прямой");
#endregion

#region lvl1_task3 
Console.WriteLine("Введите a и b:");
string[] x__y = Console.ReadLine().Split(' ');
int a = int.Parse(x__y[0]);
int b = int.Parse(x__y[1]);

if (a > 0)
    Console.WriteLine(Math.Max(a, b));
else
    Console.WriteLine(Math.Min(a, b));
#endregion
#region lvl1_task4
Console.WriteLine("Введите a, b, c:");
string[] x___y = Console.ReadLine().Split(' ');
int aaa = int.Parse(x___y[0]);
int bbb = int.Parse(x___y[1]);
int c = int.Parse(x___y[2]);

Console.WriteLine(Math.Max(Math.Min(aaa, bbb), c));
#endregion

#region lvl2_task1
Console.WriteLine("Введите кол-во учеников:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост и пол ученика через пробел:");
int m_count = 0, w_count = 0, m_sum = 0, w_sum = 0, m_avg = 0, w_agv = 0;
for (int i = 0; i < n; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    if (str[1] == "м" || str[1] == "М" && str[1] != null)
    {
        m_count++;
        m_sum += int.Parse(str[0]);
    }
    else if (str[1] == "д" || str[1] == "Д" && str[1] != null)
    {
        w_count++;
        w_sum += int.Parse(str[0]);
    }
}
if (m_count <= 0 && w_count<= 0)
    Console.WriteLine("Пережмакивай");
else
    m_avg = m_sum / m_count;
w_agv = w_sum / w_count;
Console.WriteLine("Средний рост мальчиков " + m_avg + ", а девочек " + w_agv);
#endregion

#region lvl2_task5
int[] array = new int[30];
int norm = 10;
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > norm)
    {
        count++;
    }
}
Console.WriteLine(count + " спортсменов выполнило норматив");
#endregion
#region lvl3_task4 
int sum = 0;
Console.WriteLine("Вот так пиши: N: [x] [y]");
int ii = 0;
try
{
    Console.Write("r1: ");
    double r1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("r2: ");
    double r2 = Convert.ToDouble(Console.ReadLine());
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
}
catch
{
    Console.WriteLine("Не то жмакаешь, как в примере делай пж");
}
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
try
{
    Console.WriteLine("(Input example) N: [r] [Type]");
    Console.WriteLine("(Input example) Type 1 - Square");
    Console.WriteLine("(Input example) Type 2 - Circle");
    Console.WriteLine("(Input example) Type 3 - Equilateral triangle");
    while (true)
    {
        Console.Write((ii + 1) + ": ");
        string input = Console.ReadLine();
        if (input == "")
        {
            break;
        }
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
}
catch
{
    Console.WriteLine("Ну ек макарёк, как в примере делай и не беси");
}
#endregion
#region lvl3_task13 
ii = 0;
try
{
    Console.WriteLine("(Input example) N: [a] [b] [Type]");
    Console.WriteLine("(Input example) Type 1 - Rectangle");
    Console.WriteLine("(Input example) Type 2 - Ring");
    Console.WriteLine("(Input example) Type 3 - Isosceles");
    while (true)
    {
        Console.Write((ii + 1) + ": ");
        string input = Console.ReadLine();
        if (input == "")
        {
            break;
        }
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
}
catch
{
    Console.WriteLine("Опять не как в примере");
}
#endregion
