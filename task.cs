#region lvl1Task3
Console.WriteLine("Enter value a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter value b");
double b = Convert.ToDouble(Console.ReadLine());
double c;

if (a > 0)
{
    c = Math.Max(a, b);
}
else
{
    c = Math.Min(a, b);
}
Console.WriteLine($"c = {c}");
#endregion

#region lvl1Task4
Console.WriteLine("Enter value a");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter value b");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter value c");
double c1 = Convert.ToDouble(Console.ReadLine());

double z1 = Math.Max(Math.Min(a1, b1), c1);

Console.WriteLine($"z = {z1}");

#endregion

#region lvl1Task10

double y10 = 0;
double x10 = Convert.ToDouble(Console.ReadLine());
if (x10 <= -1)
{
    y10 = 1;
}
if (1 < x10 & x10 <= 1)
{
    y10 = -1 * x10;
}
if (x10 > 1)
{
    y10 = -1;
}
Console.WriteLine($"y = {y10}");
#endregion

#region lvl2Task4
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    // Не знаю, какой минимальный/максимальный рост может быть, поэтому навскидку ставлю диапазон 100-210
    array[i] = rnd.Next(100,210);
}
Console.WriteLine(array.Sum()/array.Length);
#endregion

#region lvl2Task9
int n9 = Convert.ToInt32(Console.ReadLine());
Random rnd9 = new Random();
int[] array9 = new int[n9];
for (int i = 0; i < n; i++)
{
    // 10-40 условный диапазон скорости преодоления дистанции
    array9[i] = rnd.Next(10, 40);
}
Console.WriteLine(array9.Max());
#endregion

#region lvl3Task11
double m1, m2, m3, m4;
double[] marks = new double[4];
double student_count = 0;
double count_of_unnormal_student = 0;
Console.WriteLine("Enter student count:");
student_count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < student_count; i++)
{
    Console.WriteLine($"Enter marks for student {i + 1}");
    m1 = Convert.ToInt32(Console.ReadLine());
    m2 = Convert.ToInt32(Console.ReadLine());
    m3 = Convert.ToInt32(Console.ReadLine());
    m4 = Convert.ToInt32(Console.ReadLine());
    if (m1 > 2 & m2 > 2 & m3 > 2 & m4 > 2)
    {
        marks[0] += m1;
        marks[1] += m2;
        marks[2] += m3;
        marks[3] += m4;
    }
    else
    {
        count_of_unnormal_student++;
    }
    
}
Console.WriteLine($"Count of unnormal students - {count_of_unnormal_student}, Group average - {marks.Sum() / (4 * (student_count - count_of_unnormal_student))}");
#endregion

#region // level 3 Task 12
Console.WriteLine($"Enter N");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter R");
    double r = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Press 1 if you want search area of square, 2 if circle, 3 if triangle");
    double x = Convert.ToDouble(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine($"Squere = {r * r}");
            break;
        case 2:
            Console.WriteLine($"Circle = {Math.PI * r * r}");
            break;
        case 3:
            Console.WriteLine($"Triangle = {Math.Sqrt(3) * r * r / 4}");
            break;
        default:
            break;
    }
}
#endregion
