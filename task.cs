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
