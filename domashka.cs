using System;
// See https://aka.ms/new-console-template for more information
#region 1.3
double a= Convert.ToDouble(Console.ReadLine());
double b= Convert.ToDouble(Console.ReadLine());
double c=0;
if(a>0){
    if(a>b){
        c=a;
    }
    else{
        c=b;
    }
}
else{
     if(a>b){
        c=b;
    }
    else{
        c=a;
    }
}
Console.WriteLine(c);
#endregion

#region 1.7
double x= Convert.ToDouble(Console.ReadLine());
double y=0;
if(x<0){
    x*=-1;
}
if(x>1){
    y=1;
}
else{
    y=x;
}
Console.WriteLine(y);
#endregion
#region 1.10
double x= Convert.ToDouble(Console.ReadLine());
double y=0;
if(x<=-1){
    y=1;
}
else if(x>-1&&x<=0){
    y=-x;
}
else{
    y=-1;
}
Console.WriteLine(y);
#endregion
#region 2.1
int n = 5;
int i = 1;
double sum = 0;
while (i <= n){
    Console.WriteLine("Введите рост в метрах: ");
    double height = Convert.ToDouble(Console.ReadLine());
    if(height>0){
        sum += height;i++;
    }
    else{
        Console.WriteLine("Рост должен быть положительным");
        return;
    }
}
Console.WriteLine("Средний рост: "+sum/n);

#endregion
#region 2.9
double n, result;
double best = double.PositiveInfinity;
while (true)
{
    Console.WriteLine("Please enter n:");
    if (!double.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Wrong n, please try again");
        continue;
    }
    break;
}
for (int i = 1; i <= n; i++)
{
    while (true)
    {
        Console.WriteLine($"Please enter the result of the {i} sportsman.");
        if (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Wrong result, please try again");
            continue;
        }
        if (result <= 0)
        {
            Console.WriteLine($"result must be > 0.");
            continue;
        }
        break;
    }
    if (result < best) best = result;
}
Console.WriteLine($"The best result is {best}");

#endregion
#region 2.5
Console.WriteLine("Введите норматив");
double norm=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 30 результатов");
double vipolnili=0;
double schet=0;
while(schet<30){
    double result=Convert.ToDouble(Console.ReadLine());
    if(result>=norm){
        vipolnili++;
    }
    schet++;
}
Console.WriteLine(vipolnili);
#endregion
#region 3.4
Console.WriteLine("Введите абсциссу центра окружности"); 
double a = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Введите ординату центра окружности"); 
double b = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Введите значение внутреннего радиуса"); 
double R1 = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Введите значение внешнего радиуса"); 
double R2 = Convert.ToDouble((Console.ReadLine()));               
double x = 1, y = 0, n=0; 
Console.WriteLine("Введите значение x"); 
x = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Введите значение y"); 
y = Convert.ToDouble((Console.ReadLine())); 
if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) >= Math.Pow(R1, 2) && Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= Math.Pow(R2, 2)){ 
    n += 1;     
}  
Console.WriteLine(n); 
#endregion
#region 3.11
Console.WriteLine("Введите число учеников");
double q=Convert.ToDouble(Console.ReadLine());
double a, b, c, d, s = 0, sum = 0; 
double qwerty=0;
for(int i=1; i<=q;i++){ 
    Console.WriteLine($"Студент №{i}"); 
    Console.WriteLine("Оценка №1:"); 
    a = Convert.ToDouble((Console.ReadLine())); 
    Console.WriteLine("Оценка №2:"); 
    b = Convert.ToDouble((Console.ReadLine())); 
    Console.WriteLine("Оценка №3:"); 
    c = Convert.ToDouble((Console.ReadLine())); 
    Console.WriteLine("Оценка №4:"); 
    d = Convert.ToDouble((Console.ReadLine())); 
    if(a <6|| b<6||c<6||d<6 ||a>1||b>1||c>1||d>1){
        
    
    if (a < 3 || b < 3 || c < 3 || d < 3){ 
        s++; 
    }
    if (a > 2 & b > 2 & c > 2 & d > 2){ 
        qwerty++;
        sum += a + b + c + d; 
    }
}
else{
    Console.WriteLine("Оценки должны быть от 2 до 5");
    return;
}
}
Console.WriteLine($"Неуспевающих студентов: {s} \nСредний балл группы: {sum * 1.0 / qwerty / 4:f2}"); 
#endregion


#region 3.12
double k=0, r=0, s1=0, s2=0, s3=0; 
Console.WriteLine("Вычислить площадь квадрата - 1,"); 
Console.WriteLine("вычислить площадь круга - 2,"); 
Console.WriteLine("вычислить площадь равностороннего треугольника - 3"); 
k = Convert.ToDouble((Console.ReadLine())); 
switch (k) 
{ 
    case 1: 
        Console.WriteLine("Введите длину стороны, для завершения введите 0:"); 
        r = Convert.ToDouble((Console.ReadLine())); 
        s1 = r * r; 
        Console.WriteLine(s1); 
        break; 
    case 2: 
        Console.WriteLine("Введите радиус, для завершения введите 0:"); 
        r = Convert.ToDouble((Console.ReadLine())); 
        s2 = Math.PI * Math.Pow(r, 2); 
        Console.WriteLine(s2); 
        break; 
    case 3: 
        Console.WriteLine("Введите длину стороны, для завершения введите 0:"); 
        r = Convert.ToDouble((Console.ReadLine())); 
        s3 = Math.Pow(r, 2) * Math.Sqrt(3) / 4; 
        Console.WriteLine(s3); 
        break; 
}

#endregion 
#region 3.13
 Console.WriteLine("Введите A"); 
double a = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Введите B."); 
double b = Convert.ToDouble((Console.ReadLine())); 
Console.WriteLine("Для вычисления введите:\n" + 
    "1 - площадь прямоугольника сторонами А, В \n" + 
    "2 - площадь кольца, заключенного между окружностями радиусами А и В\n" + 
    "3 - площадь равнобедренного треугольника со стороной A и основанием B"); 
double k = Convert.ToDouble((Console.ReadLine())); 
if(a>=0&&b>=0){
switch (k) 
{ 
    case 1: 
        Console.WriteLine(a * b); 
        break; 
    case 2: 
        Console.WriteLine(Math.Abs(Math.PI * ((a * a) - (b * b)))); 
        break; 
     case 3:
        Console.WriteLine(Math.Sqrt(Math.Abs((b - a) * (b + a))) / 2);
        break;

    default:
        Console.WriteLine("Неправильное значение");
        break;
} 

  }
#endregion
