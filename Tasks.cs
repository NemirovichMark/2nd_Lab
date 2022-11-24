using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double inputDouble() //Method for entering double numbers
        {
            double simbol = 0;
            Int16 ok = 0;

            while (ok == 0)
            {
                try
                {
                    simbol = Convert.ToDouble(Console.ReadLine());
                    ok = 1;
                }
                catch
                {
                    Console.WriteLine("Enter right simbols");
                }
            }

            return simbol;
        }


        static int inputInt32() //Method for entering int32 numbers
        {
            int simbol = 0;
            Int16 ok = 0;

            while (ok == 0)
            {
                try
                {
                    simbol = Convert.ToInt32(Console.ReadLine());
                    ok = 1;
                }
                catch
                {
                    Console.WriteLine("Enter right simbols");
                }
            }

            return simbol;
        }


        /*static string inputString() //Method for entering strings
        {
            string simbol = "abc";
            Int16 ok = 0;

            while (ok == 0)
            {
                try
                {
                    simbol = Console.ReadLine();
                    ok = 1;
                }
                catch
                {
                    Console.WriteLine("Enter right simbols");
                }
            }

            return simbol;
        }*/


        static void Main(string[] args)
        {
            //Part 1


             #region 1
             double x, y;
             try
             {
                 x = Convert.ToDouble(Console.ReadLine());
                 y = Convert.ToDouble(Console.ReadLine());
             }
             catch
             {
                 Console.Writeline("You entered the wrong simbol")
             }
             if (Math.Abs(x * x + y * y - 4) <= 0.001)
             {
                 Console.WriteLine("The point belongs to the circle");
             }
             else
             {
                 Console.WriteLine("The point don't belongs to the circle");
             }

             #endregion



             #region 4
             double a, b, c, min;
             try
             {
                 a = Convert.ToDouble(Console.ReadLine());
                 b = Convert.ToDouble(Console.ReadLine());
                 c = Convert.ToDouble(Console.ReadLine());
             }
             catch
             {
                 Console.Writeline("You entered the wrong simbol")
             }
             if (a < b) min = a;
             else min = b;
             if (min > c) Console.WriteLine(min);
             else Console.WriteLine(c);
             #endregion





            //Part 2


            #region 1
             double height, n, S;

             try
             {
                 Console.WriteLine("Enter amount of pupils");
                 n = Convert.ToDouble(Console.ReadLine());
             }
             catch
             {
                 Console.Writeline("You entered the wrong simbol")
             }
             S = 0;
             for (double i = 1; i == n; i++)
             {
                 Console.WriteLine("Enter height");
                 try
                 {
                     height = Convert.ToDouble(Console.ReadLine());
                 }
                 catch
                 {
                     Console.Writeline("You entered the wrong simbol")
                 }
                 S += height;
             }
             Console.WriteLine(S / n);
             #endregion


             #region 4
             double n, R1, R2, count, x, y;
             Console.WriteLine("Enter amount of points");
             Int32.TryParse(Console.ReadLine(), out n);
             Console.Clear();
             Console.WriteLine("Enter radius of the 1st circle");
             Int32.TryParse(Console.ReadLine(), R1);
             while (R1 <= 0)
             {
                 Console.WriteLine("1st radius must be more then 0. Please enter right 1st radius");
                 R1 = inputDouble();
             }
             Console.WriteLine("Enter radius of the 2nd circle");
             R2 = inputDouble();
             Console.Clear();
             while (R2 <= 0)
             {
                 Console.WriteLine("2nd radius must be more then 0. Please enter right 2nd radius");
                 R2 = inputDouble();
                 Console.Clear();
             }
             while (R2 < R1)
             {
                 Console.WriteLine("Radius of the 1st circle is");
                 Console.WriteLine(R1);
                 Console.WriteLine("2nd radius must be more then 1st. Please enter right 2nd radius");
                 R2 = inputDouble();
                 Console.Clear();
             }
             count = 0;
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("Enter coordinates of the point");
                 Console.Write("x: ");
                 x = inputDouble();
                 Console.Write("y: ");
                 y = inputDouble();
                 if (Math.Sqrt(x * x + y * y) >= R1 && Math.Sqrt(x * x + y * y) <= R2)
                 {
                     count += 1;
                     Console.WriteLine("The point are suitable");
                 }
                 else
                 {
                     Console.WriteLine("The point aren`t suitable");
                     continue;
                 }
                 Console.WriteLine(" ");
             }
             Console.WriteLine(" ");
             Console.WriteLine("Amount of suitable points is " + count);
             #endregion





             //Part 3


             #region 4 
             double R1, R2, count, x, y;
             Console.WriteLine("Enter radius of the 1st circle");
             R1 = inputDouble();
             while (R1 <= 0)
             {
                 Console.WriteLine("1st radius must be more then 0. Please enter right 1st radius");
                 R1 = inputDouble();
             }
             Console.WriteLine("Enter radius of the 2nd circle");
             R2 = inputDouble();
             Console.Clear();
             while (R2 <= 0)
             {
                 Console.WriteLine("2nd radius must be more then 0. Please enter right 2nd radius");
                 R2 = inputDouble();
                 Console.Clear();
             }
             while (R2 < R1)
             {
                 Console.WriteLine("Radius of the 1st circle is");
                 Console.WriteLine(R1);
                 Console.WriteLine("2nd radius must be more then 1st. Please enter right 2nd radius");
                 R2 = inputDouble();
                 Console.Clear();
             }
             count = 0;
             string x1 = "";
             while (x1 != "stop")
             {
                 Console.WriteLine("Enter coordinates of the point, if you want to finish then enter word 'stop' in coordinate 'x'");
                 Console.Write("x: ");
                 x1 = Convert.ToString(Console.ReadLine());
                 Console.Write("y: ");
                 y = Convert.inputDouble();
                 if (x1 != "stop")
                 {
                     x = inputDouble();
                     if (Math.Sqrt(x * x + y * y) >= R1 && Math.Sqrt(x * x + y * y) <= R2)
                     {
                         count += 1;
                         Console.WriteLine("The point are suitable");
                     }
                     else
                     {
                         Console.WriteLine("The point aren`t suitable");
                     }
                 }

                 Console.WriteLine(" ");
             }
             Console.WriteLine("Amount of suitable points is " + count);
             #endregion

             #region 11
             Int32 E1, E2, E3, E4, count, n, n1;
             Int32 S, genS;
             E1 = 1;
             count = 0;
             n = 1;
             genS = 0;
             S = 0;
             n1 = 1;
             while (E1 != 0)
             {
                 Console.WriteLine("Student" + n1);
                 Console.WriteLine("Enter student's marks for exams(from 1st to 4th), marks should be from 2 to 5, if you want to end enter '0' in 1st string:");
                 E1 = inputInt32();
                 E2 = inputInt32();
                 E3 = inputInt32();
                 E4 = inputInt32();
                 if (E1 == 0) continue;
                 else
                 {
                     S = E1 + E2 + E3 + E4;
                     if ( (S <= 16 || E1 == 2 || E2 == 2 || E3 == 2 || E4 == 2) == false)
                     {
                        genS += S;
                        n += 1;
                     }
                     else
                        count += 1;
                    n1 ++;
                 }
             }
             n -= 1;
             n *= 4;
             Console.WriteLine("Amount of students who have poor academic performance is:" + count);
             Console.WriteLine("Average mark in the group is:" + genS / n);
             #endregion
            
            
             #region 12
             int A, B, R, l;
             string j;
             while (true)
             {
                 Console.WriteLine("Enter number, if you want to stop enter 0");
                 R = inputInt32();
                 if (R <= 0) break;
                 Console.WriteLine("If you want to find square area enter 3, if circle area enter 1, if triangle area enter 2");
                 l = inputInt32();
                 j = Convert.ToString(l);   
                 switch (j)
                 {
                     case "1":
                         Console.WriteLine(3.14 * R * R);
                         break;
                     case "2":
                         Console.WriteLine(R * R * Math.Sqrt(3) / 4);
                         break;
                     case "3":
                         Console.WriteLine(R * R);
                         break;
                 }
             }
             #endregion
            

            #region 13
            int A, B, l;
            string j;
            while (true)
            {
                Console.WriteLine("Enter number A, if you want to stop enter 0");
                A = inputInt32();
                if (A <= 0) break;
                Console.WriteLine("Enter number B");
                B = inputInt32();
                if (B <= 0) break;
                Console.WriteLine("If you want to find rectangle area enter 1, if ring area between circles with A and B radiouses enter 2, if triangle area with A, B, B sides enter 3");
                l = inputInt32();
                j = Convert.ToString(l);    
                switch (j)
                {
                    case "1":
                        Console.WriteLine(A * B);
                        break;
                    case "2":
                        if (A > B) Console.WriteLine(3.14 * A * A - 3.14 * B * B);
                        else if (A < B) Console.WriteLine(-3.14 * A * A + 3.14 * B * B);
                        break;
                    case "3":
                        if ((A* Math.Sqrt(4 * B * B - A * A) / 4) <= 0)
                        {
                            Console.WriteLine("You entered the wrong lenght of trinagle's sides");
                            break;
                        }
                        Console.WriteLine(A * Math.Sqrt(4 * B * B - A * A) / 4);
                        break;
                }
                #endregion
                
            }
        } 
    }
}
