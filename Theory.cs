using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            // in all tasks you have to use comma if you want to enter double numbers
            static void task_1_3()
            {

                double a;
                double b;
                Console.Write("enter a: ");
                bool res_1 = double.TryParse(Console.ReadLine(), out a);
                Console.Write("enter b: ");
                bool res_2 = double.TryParse(Console.ReadLine(), out b);
                if (res_1 && res_2)
                {
                    if (a > 0)
                    {
                        Console.WriteLine("a > 0");
                        if (a > b) Console.WriteLine($"c = {a}");
                        else if (a == b) Console.WriteLine("a = b");
                        else Console.WriteLine($"c = {b}");

                    }
                    else
                    {
                        Console.WriteLine("a <= 0");
                        if (a < b) Console.WriteLine($"c = {a}");
                        else if (a == b) Console.WriteLine("a = b");
                        else Console.WriteLine($"c = {b}");

                    }
                }
                else return;

            }
            static void task_1_4()
            {
                double a;
                double b;
                double c;
                Console.Write("enter a: ");
                bool res_1 = double.TryParse(Console.ReadLine(), out a);
                Console.Write("enter b: ");
                bool res_2 = double.TryParse(Console.ReadLine(), out b);
                Console.Write("enter c: ");
                bool res_3 = double.TryParse(Console.ReadLine(), out c);
                if (res_1 && res_2 && res_2)
                {
                    if (a < b)
                    {
                        if (a > c) Console.WriteLine($"z = {a}");
                        else Console.WriteLine($"z = {c}");
                    }
                    else
                    {
                        if (b > c) Console.WriteLine($"z = {b}");
                        else Console.WriteLine($"z = {c}");
                    }
                }
                else return;

            }
            static void task_1_7()
            {
                double x;
                Console.Write("enter x: ");
                bool res = double.TryParse(Console.ReadLine(), out x);
                if (res)
                {
                    if (Math.Abs(x) > 1) Console.WriteLine("y = 1");
                    else Console.WriteLine($"y = {Math.Abs(x)}");
                }
                else return;
            }
            static void task_2_1()
            {

                uint students = 5;
                double heights = 0;
                double result = 0;
                for (int i = 1; i <= +students; i++)
                {
                    double height;
                    Console.WriteLine($"enter height of student {i:f0}: ");
                    bool res_ = double.TryParse(Console.ReadLine(), out height);
                    if (!(res_ && height > 0)) return;
                    heights = heights + height;

                }
                result = heights / students;
                Console.WriteLine($"average height:{result}");

            }
            static void task_2_9()
            {
                uint sportsmen = 5;

                double result = 0;
                for (int i = 1; i <= +sportsmen; i++)
                {
                    double time;
                    Console.WriteLine($"enter time of sportsman {i:f0}: ");
                    bool res_ = double.TryParse(Console.ReadLine(), out time);
                    if (i == 1) result = time;
                    if (res_ && time > 0)
                    {
                        if (time < result) result = time;
                    }
                    else return;
                    if (i == sportsmen) Console.WriteLine($"the best time:{result}");

                }


            }

            static void task_3_4()
            {

                double x;
                double y;
                double r_1 = 2;
                double r_2 = 4;
                double result = 0;
                uint n;
                Console.WriteLine("points quality:");
                bool points = uint.TryParse(Console.ReadLine(), out n);
                if (points && n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"enter x of point {i:f0}: ");
                        bool res_1 = double.TryParse(Console.ReadLine(), out x);
                        Console.WriteLine($"enter y of point {i:f0}: ");
                        bool res_2 = double.TryParse(Console.ReadLine(), out y);
                        if (!(res_1 && res_2)) return;
                        double s = Math.Sqrt(x * x + y * y);
                        if (r_1 <= s && s <= r_2) result += 1;

                    }
                    Console.WriteLine($"quality:{result}");
                }

            }
            static void task_3_11()
            {
                uint m1;
                uint m2;
                uint m3;
                uint m4;
                double result = 0;
                double all_marks = 0;
                uint n;
                Console.WriteLine("students quality:");
                bool res = uint.TryParse(Console.ReadLine(), out n);
                if (res && n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"1 mark of student {i:f0}: ");
                        bool res_1 = uint.TryParse(Console.ReadLine(), out m1);
                        Console.WriteLine($"2 mark of student {i:f0}: ");
                        bool res_2 = uint.TryParse(Console.ReadLine(), out m2);
                        Console.WriteLine($"2 mark of student {i:f0}: ");
                        bool res_3 = uint.TryParse(Console.ReadLine(), out m3);
                        Console.WriteLine($"2 mark of student {i:f0}: ");
                        bool res_4 = uint.TryParse(Console.ReadLine(), out m4);
                        if (!(res_1 && res_2 && res_3 && res_4)) return;
                        if (m1 < 3 || m2 < 3 || m3 < 3 || m4 < 3)
                        {
                            result += 1;
                            continue;
                        }
                         // i do not calc dvoechnicov
                         all_marks += (double)m1 + m2 + m3 + m4;
                            
                        
                    }
                    double ball = all_marks / 4 / (n-result);// i do not calc dvoechnicov
                    Console.WriteLine($"dvoechniki:{result}");
                    Console.WriteLine($"average ball: {ball}");
                }

            }
            static void task_3_12()
            {
                double r = 0;                
                double result = 0;

                uint n;
                Console.WriteLine("operations quality:");
                bool operations = uint.TryParse(Console.ReadLine(), out n);
                if (operations && n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"enter r for trial {i:f0}: ");
                        bool res_1 = double.TryParse(Console.ReadLine(), out r);                       
                        if (!(res_1 && r>0)) return;
                        Console.WriteLine("choose operation, you have to enter number:\n1)square area\n2)circle area\n3)triangle area");
                        uint operation;
                        bool res = uint.TryParse(Console.ReadLine(), out operation);
                        if (!(res && operation != 0 && operation <= 3)) return;
                        switch (operation)
                        {
                            case 1:
                                {
                                    result = r * r;
                                    Console.WriteLine($"square area:{result}");
                                    break;
                                }
                            case 2:
                                {
                                    result = Math.PI * r*r;
                                    Console.WriteLine($"circle area:{result}");
                                    break;
                                }
                            case 3:
                                {
                                    result = r*r*Math.Sqrt(3)/4;
                                    Console.WriteLine($"triangle area:{result}");
                                    break;
                                }
                        }
                    }
                   
                }
            }
            static void task_3_13()
            {
                double a = 0;
                double b = 0;
                double result = 0;

                uint n;
                Console.WriteLine("operations quality:");
                bool operations = uint.TryParse(Console.ReadLine(), out n);
                if (operations && n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"enter a for trial {i:f0}: ");
                        bool res_1 = double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine($"enter b for trial {i:f0}: ");
                        bool res_2 = double.TryParse(Console.ReadLine(), out b);
                        if (!(res_1 && res_2 && b>0 && a > 0)) return;
                        Console.WriteLine("choose operation, you have to enter number:\n1)ring area\n2)triangle area");
                        uint operation;
                        bool res = uint.TryParse(Console.ReadLine(), out operation);
                        if (!(res && operation != 0 && operation <= 2)) return;
                        switch (operation)
                        {
                            case 1:
                                {
                                    result = Math.Abs(Math.PI*a*a - Math.PI * b * b);
                                    Console.WriteLine($"ring area:{result}");
                                    break;
                                }
                            case 2:
                                {
                                    result = a*Math.Sqrt(b*b - a*a/4)/2;
                                    Console.WriteLine($"triangle area:{result}");
                                    break;
                                }
                            
                        }
                    }

                }
            }
            

        }
    }
}

