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
#region 2/3.5
Console.WriteLine("Введите заданный норматив");
double normativ=Convert.ToDouble(Console.ReadLine());
var res=new List<double>();
int baza=0;
for(int i = 1; i<31;i++){
    Console.WriteLine($"Введите результат {i}-ого ученика");
    res.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int z=0; z<30;z++){
    if(res[z]>normativ){
        baza+=1;
    }
}
Console.WriteLine(baza);
#endregion
#region 2/3.9
Console.WriteLine("Введите количество спортсменов");
double max=0;
double kolichestvo=Convert.ToDouble(Console.ReadLine());
var resultaty=new List<double>();
for(int i=1;i<kolichestvo+1;i++){
    Console.WriteLine($"Введите результат {i}-ого ученика");
    resultaty.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int z=0;z<kolichestvo;z++){
    if(resultaty[z]>max){
        max=resultaty[z];
    }
}
Console.WriteLine($"Лучший результат: {max}");

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
for(int i=1; i<=q;i++){ 
    Console.WriteLine($"Студент №{i}"); 
    Console.WriteLine("Для окончания введите 0. Оценка №1:"); 
    a = Convert.ToDouble((Console.ReadLine())); 
    if (a == 0) break; 
    Console.WriteLine("Оценка №2:"); 
    b = Convert.ToDouble((Console.ReadLine())); 
    Console.WriteLine("Оценка №3:"); 
    c = Convert.ToDouble((Console.ReadLine())); 
    Console.WriteLine("Оценка №4:"); 
    d = Convert.ToDouble((Console.ReadLine())); 
    if (a < 4 || b < 4 || c < 4 || d < 4) 
        s++; 
    sum += a + b + c + d; 
}
Console.WriteLine($"Неуспевающих студентов: {s} \nСредний балл группы: {sum * 1.0 / q / 4:f2}"); 
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
    "3 - площадь равнобедренного треугольника со стороной B и основанием A"); 
double k = Convert.ToDouble((Console.ReadLine())); 
switch (k) 
{ 
    case 1: 
        Console.WriteLine(a * b); 
        break; 
    case 2: 
        Console.WriteLine(Math.Abs(Math.PI * ((a * a) - (b * b)))); 
        break; 
    case 3: 
        Console.WriteLine(Math.Sqrt((b * b) - (a * a / 4)) * a / 2); 
        break; 
} 
while (a != 0); 
#endregion
