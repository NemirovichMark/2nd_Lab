using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Booleans Logic
            bool truth = true, failure; // can have only 2 values
            failure = false;
            truth = 5 > 2; // can take a result of inequality
            truth = (1 == 0) || ((1 > 0) && true); // logic sum & multiply going from left to right (and braces change the order as usual)
            failure = !truth; // reverting (NOT)

            // when you use if operator with several conditions
            // if you use a multiply &&, it will go till first false condition or all conditions would checked (that take part in multi)
            // if you use a sum ||, it will go till first true condition or all conditions would checked (that take part in sum)

            if (1 == 0 || 5 < 2 || "a" == "abc" || 1 * 78 > 5 / 2)
            {
                // will be done, because 4th condition provide true
            }

            if (1 == 0 && (5 < 2 || "a" == "abc" || 1 * 78 > 5 / 2))
            {
                // never will be done because 1st condition is false
            }

            if ((1 == 0 && (5 < 2 || "a" == "abc")) || (1 * 78 > 5 / 2 && false))
            {
                // will be checked 1st condition (1==0) than 4th (1 * 78 > 5 / 2) and than 5th (false) and go to else block
            }
            else
            {
                // do work
            }

            #endregion

            #region Nested conditions
            string request = "I want to divide";
            if (request.Length > 5)
            {
                if (request.StartsWith('I'))
                {
                    // positive result
                    if (request.EndsWith('!'))
                    {
                        // very positive result
                    }
                }
                else
                {
                    // negative result
                }
                // addition work
            }

            // Try to use <= 3 levels of nesting (include cycles!)
            // You can miss else block if it is not needed

            #endregion

            #region If/Else for smart students
            // if variable changes both in if and else blocks, we can make program faster by changing order.
            var a = 10;
            if (new Random().NextDouble() > 0.5)
            {
                a = 20;
            }
            else
            {
                a = 30;
            }
            // Better to transform to:
            a = 30;
            if (new Random().NextDouble() > 0.5)
            {
                a = 20;
            }

            /* This hocus-pocus can be done if: 
             * 1) if variables we change don't take part in condition 
             * 2) an error should not occur 
             */

            #endregion

            #region If/Else for smart students Part 2
            // If block else contain 1 if term, it can be merged to one line:
            if (0 != 0)
            {

            }
            else
            {
                if (1 == (int)'a')
                {

                }
            }

            // Transforming to

            if (0 != 0)
            {

            }
            else if (1 == (int)'a')
            {

            }

            // But if int this else can be more than 1 if operator, do not do so!
            #endregion

            #region Switch
            // Many people hate this block, but it is very effective & sharp weapon Clever man will do good job with it, but other people cut themselves.
            // So! Use it very carefully. When another methods too difficult.
            // But we cannot to use ranges in the cases (1 - 9 => -8) or (1:9 => 0)

            switch ((int)Console.ReadLine().Length)
            {
                case 0:
                    Console.WriteLine("Cannot be empty");
                    break;
                case 11: // select some
                    request = "Good job!";
                    break;
                case 4:   // merge
                case 5:   // merge
                case 13:    // with this one
                    request += "!!!";
                    break;
                default:
                    Console.WriteLine("No suitable condition above");
                    break;
            }
            Console.WriteLine(request);

            #endregion

            #region Switch for smart students
            // if you sure that you have to use switch and it have to return some value, you can make it shorter:
            var mark = request.Length / 2 switch
            {
                0 => 0,
                1 => 0,
                2 => 1,
                3 => 2,
                4 => 4,
                _ => 5 // any other input(!) value (default)
            };

            #endregion
                
                
                
                
            TASKS
                
                
                
           Part 1
                
                
           #region 1
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
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
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a < b) min = a;
            else min = b;
            if (min > c) Console.WriteLine(min);
            else Console.WriteLine(c);
           #endregion
                
               
               
               
                   
           Part 2
               
               
           #region 1
            double height, n, S;
            Console.WriteLine("Enter amount of pupils");
            n = Convert.ToDouble(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Enter amount of pupils");
                n = Convert.ToDouble(Console.ReadLine());
            }
            S = 0;
            for (double i = 0; i == n; i++)
            {
                height = Convert.ToDouble(Console.ReadLine());
                S += height;
            }
            Console.WriteLine(S/n);
           #endregion 
                
                
           #region 4
            double n, R1, R2, count, x, y;
            Console.WriteLine("Enter amount of points");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter radius of the 1st circle");
            R1 = Convert.ToDouble(Console.ReadLine());
            while (R1 <= 0)
            {
                Console.WriteLine("1st radius must be more then 0. Please enter right 1st radius");
                R1 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter radius of the 2nd circle");
            R2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            while (R2 <= 0)
            {
                Console.WriteLine("2nd radius must be more then 0. Please enter right 2nd radius");
                R2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            while (R2 < R1)
            {
                Console.WriteLine("Radius of the 1st circle is");
                Console.WriteLine(R1);
                Console.WriteLine("2nd radius must be more then 1st. Please enter right 2nd radius");
                R2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter coordinates of the point");
                Console.Write("x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y: ");
                y = Convert.ToDouble(Console.ReadLine());
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
                
                
                
                
                
            Part 3
                
                             
            #region 4 
            double R1, R2, count, x, y;
            Console.WriteLine("Enter radius of the 1st circle");
            R1 = Convert.ToDouble(Console.ReadLine());
            while (R1 <= 0)
            {
                Console.WriteLine("1st radius must be more then 0. Please enter right 1st radius");
                R1 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter radius of the 2nd circle");
            R2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            while (R2 <= 0)
            {
                Console.WriteLine("2nd radius must be more then 0. Please enter right 2nd radius");
                R2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            while (R2 < R1)
            {
                Console.WriteLine("Radius of the 1st circle is");
                Console.WriteLine(R1);
                Console.WriteLine("2nd radius must be more then 1st. Please enter right 2nd radius");
                R2 = Convert.ToDouble(Console.ReadLine());
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
                y = Convert.ToDouble(Console.ReadLine());
                if (x1 != "stop") x = Convert.ToDouble(x1);
                else continue;
                if (Math.Sqrt(x * x + y * y) >= R1 && Math.Sqrt(x * x + y * y) <= R2 && x1 != "stop")
                {
                    count += 1;
                    Console.WriteLine("The point are suitable");
                }
                else if (x1 != "stop")
                {
                    Console.WriteLine("The point aren`t suitable");
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Amount of suitable points is " + count);
            #endregion
                
            #region 11
            Int16 E1, E2, E3, E4, count, n;
            Int32 S, genS;
            E1 = 1;
            count = 0;
            n = 1;
            genS = 0;
            S = 0;
            while (E1 != 0)
            {
                Console.WriteLine("Student" + n);
                Console.WriteLine("Enter student's marks for exams(from 1st to 4th), if you want to end enter '0' in 1st string:");
                E1 = Convert.ToInt16(Console.ReadLine());
                E2 = Convert.ToInt16(Console.ReadLine());
                E3 = Convert.ToInt16(Console.ReadLine());
                E4 = Convert.ToInt16(Console.ReadLine());
                if (E1 == 0) continue;
                else
                {
                    S = E1 + E2 + E3 + E4;
                    if (S <= 16 || E1 == 2 || E2 == 2 || E3 == 2 || E4 == 2)
                    {
                        count += 1;
                    }
                    genS += S;
                    n += 1;
                }
            }
            n -= 1;
            n *= 4;
            Console.WriteLine("Amount of students who have poor academic performance is:" + count);
            Console.WriteLine("Average mark in the group is:" + genS/n);
            #endregion
                
                
            #region 12
            
            #endregion
        }
    }
}
