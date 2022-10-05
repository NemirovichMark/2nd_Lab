using System;
using System.Security.Cryptography.X509Certificates;

class homework3
{
    static void Main()
    {
        
        Console.WriteLine("пожалуйста, выберите номер задания для удобного ввода (4, 11, 12, 13)");
        int numb  = Convert.ToInt32(Console.ReadLine());
        if (numb == 4)
        {
            #region Level3 Task 4
            int n;
            Console.WriteLine("введите r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите r2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double x, y;
            int count = 0;
            bool yesorno = true;
            while (yesorno == true)
            {
                Console.WriteLine("введите 1, если хотите ввести значение. любое другое число - если нет");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("пожалуйста, введите х, а потом y");
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());
                    if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(r2, 2))
                    {
                        if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2)) >= Math.Pow(r1, 2))
                            count += 1;
                    }
                }
                else yesorno = false;
            }
            Console.WriteLine($"точек -> {count} ");
            #endregion
        }
        else if (numb == 11)
        {
            #region Level3 Task11
            int n2;
            bool yesorno2 = true;
            double mark1, res2, average;
            res2 = 0.0;
            int count2 = 0;
            int countstudent = 0;
            while (yesorno2 == true)
            {
                Console.WriteLine("пожалуйста! введите 1, если хотите ввести значение. любое другое число - если нет");
                n2 = Convert.ToInt32(Console.ReadLine());
                average = 0.0;
                if (n2 == 1)
                {
                    Console.WriteLine("пожалуйста! введите через Enter четыре оценки студента");
                    for (int i1 = 1; i1 <= 4; i1++)
                    {
                        mark1 = Convert.ToDouble(Console.ReadLine());
                        if ((mark1 >= 2) && (mark1<=5)) average += mark1;
                        else Console.WriteLine("пожалуйста! введите значение в рамках [2;5]");
                    }
                    if ((average / 4) < 2.5) count2 += 1;
                    else res2 += (average / 4);
                    countstudent += 1;
                }
                else { yesorno2 = false; }
            }
            Console.WriteLine($"неуспевающих -> {count2}, общий средний балл по группе -> {res2 / (countstudent-count2)}");
            #endregion
        }

        else if (numb == 12)
        {
            #region Level3 Task12
            bool yesorno3 = true;
            int n3;
            double r;
            while (yesorno3 == true)
            {
                Console.WriteLine("введите 1, если хотите ввести значение. любое другое число - если нет");
                n3 = Convert.ToInt32(Console.ReadLine());
                if (n3 == 1)
                {
                    Console.WriteLine("введите число r");
                    r = Convert.ToDouble(Console.ReadLine());
                    if (r > 0)
                    {
                        Console.WriteLine("пожалуйста, выберите, что хотите сделать:");
                        Console.WriteLine("вычислить площадь квадрата со стороной r -> введите 1");
                        Console.WriteLine("вычислить площадь круга с радиусом r -> введите 2");
                        Console.WriteLine("вычислить площадь равностороннего треугольника со стороной r -> введите 3");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine($"площадь квадрата со стороной {r} = {Math.Pow(r, 2)}");
                                break;
                            case 2:
                                Console.WriteLine($"площадь круга с радиусом {r} = {Math.PI * Math.Pow(r, 2)}");
                                break;
                            case 3:
                                Console.WriteLine($"площадь равносороннего треугольника со стороной {r} = {Math.Pow(r, 2) * Math.Pow(3, 0.5) / 4}");
                                break;
                            default:
                                Console.WriteLine("пожалуйста, введите заново и выберите из предложенных действий");
                                break;
                        }
                    }
                    else Console.WriteLine("пожалуйста, введите значение > 0");

                }
                else  yesorno3 = false; 
            }
            #endregion
        }
        else if (numb == 13)
        {
            #region Level Task13
            int n3,way;
            double A, B;
            bool yesorno4 = true;
            while (yesorno4 == true)
            {
                Console.WriteLine("введите 1, если хотите ввести значение. любое другое число - если нет");
                n3 = Convert.ToInt32(Console.ReadLine());
                if (n3 == 1)
                {
                    Console.WriteLine("введите значения А, а потом В");
                    A = Convert.ToDouble(Console.ReadLine());
                    B = Convert.ToDouble(Console.ReadLine());
                    if ((A > 0) && (B > 0))
                    {

                        Console.WriteLine("пожалуйста, выберите, что хотите сделать:");
                        Console.WriteLine("вычислить площадь прямоугольника со сторонами A и B -> введите 1");
                        Console.WriteLine("вычислить площадь кольца заключенного между двумя окружности с радиусами А и В -> введите 2");
                        Console.WriteLine("вычислить площадь равнобедренного треугольника со сторонами А, В, В -> введите 3");
                        way = Convert.ToInt32(Console.ReadLine());
                        switch (way)
                        {
                            case 1:
                                Console.WriteLine($"площадь прямоугольника со сторонами A и B -> {A * B}");
                                break;
                            case 2:
                                Console.WriteLine($"площадь кольца заключенного между двумя окружности с радиусами А и В -> {Math.PI * (Math.Abs(Math.Pow(A, 2) - Math.Pow(B, 2)))}");
                                break;
                            case 3:
                                Console.WriteLine($"площадь равнобедренного треугольника со сторонами А, В, В -> {(A * Math.Pow((4 * A * A - B * B), 0.5) / 4)}");
                                break;
                            default:
                                Console.WriteLine("пожалуйста, введите значения заново и выберите команды из списка");
                                break;
                        }
                    }
                    else Console.WriteLine("пожалуйста, введите значения > 0");

                }
                else yesorno4 = false;
            }
            #endregion
        }
        else { Console.WriteLine("nothing"); }

    }
}
