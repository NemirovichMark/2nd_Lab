using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region level 1 number 8
            Console.WriteLine("--------level 1 number 8--------");
            double x,y;
            Console.WriteLine("Enter x:");
            x = double.Parse(Console.ReadLine());
            if (Math.Abs(x) >= 1) y = 0;
            else y = x * x - 1;
            Console.WriteLine("y = {0}", y);
            #endregion

            #region level 1 number 2
            Console.WriteLine("--------level 1 number 2--------");
            Console.WriteLine("Enter (x;y):");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y >= 0 && y + Math.Abs(x) <= 1) Console.WriteLine("dot in triangle");
            else Console.WriteLine("dot not in triangle");
            #endregion

            #region level 2 number 1
            Console.WriteLine("--------level 2 number 1--------");
            int n;
            double height, summary=0;
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter {0} student's height:", i);
                height = double.Parse(Console.ReadLine());
                summary += height;
            }
            Console.WriteLine("average height of students: {0}", summary/n);
            #endregion

            #region level 2 number 9
            Console.WriteLine("--------level 2 number 9--------");
            Console.WriteLine("Enter n");
            n = int.Parse(Console.ReadLine());
            double maxi=0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter {0} result: ", i);
                x = double.Parse(Console.ReadLine());
                if (x > maxi) maxi = x;

            }
            Console.WriteLine("Best result: {0}", maxi);

            #endregion

            #region level 3 number 4
            Console.WriteLine("--------level 3 number 4--------");
            double r1, r2;
            int Res = 0;
            Console.WriteLine("Enter r1: ");
            r1 = double.Parse(Console.ReadLine());
            if (r1 <= 0)
            {
                Console.WriteLine("r1 must be > 0");
            }
            else //if r1>0
            {
                Console.WriteLine("Enter r2: ");
                r2 = double.Parse(Console.ReadLine());
                if (r2 <= r1)
                {
                    Console.WriteLine("r2 must be > r1");
                }
                else //if right conditions
                {
                    Console.WriteLine("Enter x and y, or x > 1000 to exit");
                    do
                    {
                        x = double.Parse(Console.ReadLine());
                        if (x >= 1000) break;
                        y = double.Parse(Console.ReadLine());
                        if (x * x + y * y <= r2 * r2 || x * x + y * y >= r1)
                        {
                            Res += 1;
                        }
                    } while (x < 1000);
                    Console.WriteLine("dots in the ring: {0}", Res);

                }
            }



            #endregion

            #region level 3 number 11
            Console.WriteLine("--------level 3 number 11--------");
            //n студентов, каждый 4 экзамена, число неуспевающих и средний балл группы - ?
            int exam1 = 0, exam2 = 0, exam3 = 0, exam4 = 0, res = 0, amount = 0, bad_st = 0;

            do
            {
                Console.WriteLine("Enter exam 1, for exit - 6");
                exam1 = int.Parse(Console.ReadLine());
                if (exam1 == 6) break;
                Console.WriteLine("Enter exam 2");
                exam2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter exam 3");
                exam3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter exam 4");
                exam4 = int.Parse(Console.ReadLine());
                if (exam1 != 2 && exam2 != 2 && exam3 != 2 && exam4 != 2)
                {
                    amount += 4;
                    res += (exam4 + exam3 + exam2 + exam1);
                }
                else bad_st++;
            } while (exam1 < 6);
            Console.WriteLine("Amount of bad students: {0}, average score: {1}", bad_st, res / (0.0 + (amount)));

            #endregion

            #region level 3 number 12
            Console.WriteLine("--------level 3 number 12--------");
            double r = 0;
            int S;
            do
            {
                Console.WriteLine("Enter r, for exit - 100");
                r = double.Parse(Console.ReadLine());
                if (r == 100) break;
                Console.WriteLine("Enter 1 for S of circle, 2 for S of square, 3 for S of triangle");
                S = int.Parse(Console.ReadLine());
                switch (S)
                {
                    case 1:
                        Console.WriteLine("S of circle with radius {0}: {1}", r, Math.PI * r * r);
                        break;
                    case 2:
                        Console.WriteLine("S of square with side {0}: {1}", r,  r * r);
                        break;
                    case 3:
                        Console.WriteLine("S of triangle with side {0}: {1}", r, r * r * Math.Sqrt(3) / 4);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            } while (r < 100 && r>0);
            #endregion

            #region level 3 number 13
            Console.WriteLine("--------level 3 number 13--------");
            double A = 0, B;
            do
            {
                Console.WriteLine("Enter A, for exit enter 100");
                A = double.Parse(Console.ReadLine());
                if (A == 100) break;
                Console.WriteLine("Enter B");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1 for S of rectangle, 2 for S of ring, 3 for S of triangle");
                S = int.Parse(Console.ReadLine());
                switch (S)
                {
                    case 1:
                        Console.WriteLine("S of rectangle with sides {0} and {1}: {2}", A, B, A * B);
                        break;
                    case 2:
                        Console.WriteLine("S of ring between circles with radiuses {0} and {1}: {2}", A, B, Math.Abs(Math.PI*A*A-Math.PI*B*B));
                        break;
                    case 3:
                        Console.WriteLine("S of triangle with sides {0} and {1}: {2}", A, B, 1/2*A*Math.Sqrt(B*B-(A*A/4)));
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (A < 100);
            #endregion
        }
    }
}
