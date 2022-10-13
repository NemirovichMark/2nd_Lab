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
            double.TryParse(Console.ReadLine(), out x);
            if (Math.Abs(x) >= 1) y = 0;
            else y = x * x - 1;
            Console.WriteLine("y = {0}", y);
            #endregion

            #region level 1 number 2
            Console.WriteLine("--------level 1 number 2--------");
            Console.WriteLine("Enter (x;y):");
            double.TryParse(Console.ReadLine(),out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && y + Math.Abs(x) <= 1) Console.WriteLine("dot in triangle");
            else Console.WriteLine("dot not in triangle");
            #endregion

            #region level 2 number 1
            Console.WriteLine("--------level 2 number 1--------");
            int n;
            double height, summary=0;
            Console.WriteLine("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter {0} student's height:", i);
                double.TryParse(Console.ReadLine(),out height);
                if(height>0) summary += height;
                else
                {
                    do
                    {
                        Console.WriteLine("Enter positive height");
                        double.TryParse(Console.ReadLine(), out height);
                    } while (height <= 0);
                }
            }
            Console.WriteLine("average height of students: {0}", summary/n);
            #endregion

            #region level 2 number 9
            Console.WriteLine("--------level 2 number 9--------");
            Console.WriteLine("Enter n");
            int.TryParse(Console.ReadLine(), out n);
            double maxi=0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter {0} result: ", i);
                double.TryParse(Console.ReadLine(), out x);
                if (x > maxi) maxi = x;

            }
            Console.WriteLine("Best result: {0}", maxi);

            #endregion

            #region level 3 number 4
            Console.WriteLine("--------level 3 number 4--------");
            double r1, r2;
            int Res = 0;
            Console.WriteLine("Enter r1 and r2: ");
            double.TryParse(Console.ReadLine(), out r1);
            double.TryParse(Console.ReadLine(), out r2);
            while (r1 <= 0 && r2 <= r1) 
            {

                Console.WriteLine("r1 must be > 0 and < r2, try again");
                double.TryParse(Console.ReadLine(), out r1);
                double.TryParse(Console.ReadLine(), out r2);
            } 
            
           
            Console.WriteLine("Enter x and y, or x > 1000 to exit");
            do
            {
                Console.WriteLine("x and y:");
                double.TryParse(Console.ReadLine(), out x);
                if (x >= 1000) break;
                double.TryParse(Console.ReadLine(), out y);
                if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1*r1)
                {
                    Res += 1;
                }
            } while (x < 1000);
            Console.WriteLine("dots in the ring: {0}", Res);


            #endregion

            #region level 3 number 11
            Console.WriteLine("--------level 3 number 11--------");
            //n студентов, каждый 4 экзамена, число неуспевающих и средний балл группы - ?
            int exam1 = 2, exam2 = 2, exam3 = 2, exam4 = 2, res = 0, amount = 0, bad_st = 0;

            do
            {
                Console.WriteLine("Enter exam 1, for exit - 6");
                int.TryParse(Console.ReadLine(), out exam1);
                if (exam1 == 6) break;
                Console.WriteLine("Enter exam 2");
                int.TryParse(Console.ReadLine(), out exam2);
                Console.WriteLine("Enter exam 3");
                int.TryParse(Console.ReadLine(), out exam3);
                Console.WriteLine("Enter exam 4");
                int.TryParse(Console.ReadLine(), out exam4);
                while (exam1 < 2 || exam2 < 2 || exam2 > 5 || exam3 < 2 || exam3 > 5 || exam4 < 2 || exam4 > 5)
                {
                    Console.WriteLine("Enter positive results");
                    int.TryParse(Console.ReadLine(), out exam1);
                    if (exam1 == 6) break;
                    Console.WriteLine("Enter exam 2");
                    int.TryParse(Console.ReadLine(), out exam2);
                    Console.WriteLine("Enter exam 3");
                    int.TryParse(Console.ReadLine(), out exam3);
                    Console.WriteLine("Enter exam 4");
                    int.TryParse(Console.ReadLine(), out exam4);
                }
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
                double.TryParse(Console.ReadLine(), out r);
                if (r == 100) break;
                Console.WriteLine("Enter 1 for S of circle, 2 for S of square, 3 for S of triangle");
                int.TryParse(Console.ReadLine(), out S);
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
                double.TryParse(Console.ReadLine(), out A);
                while (A <= 0)
                {
                    Console.WriteLine("Enter positive A");
                    double.TryParse(Console.ReadLine(), out A);
                }
                if (A == 100) break;
                Console.WriteLine("Enter B");
                double.TryParse(Console.ReadLine(), out B);
                while (B <= 0)
                {
                    Console.WriteLine("Enter positive B");
                    double.TryParse(Console.ReadLine(), out B);
                }
                Console.WriteLine("Enter 1 for S of rectangle, 2 for S of ring, 3 for S of triangle");
                int.TryParse(Console.ReadLine(), out S);
                switch (S)
                {
                    case 1:
                        Console.WriteLine("S of rectangle with sides {0} and {1}: {2}", A, B, A * B);
                        break;
                    case 2:
                        Console.WriteLine("S of ring between circles with radiuses {0} and {1}: {2}", A, B, Math.Abs(Math.PI*A*A-Math.PI*B*B));
                        break;
                    case 3:
                        while (B * B - (A * A / 4) < 0)
                        {
                            Console.WriteLine("Enter another B and A (triangle with this sides is imposible");
                            double.TryParse(Console.ReadLine(), out A);
                            double.TryParse(Console.ReadLine(), out B);
                        }
                            
                        Console.WriteLine("S of triangle with sides {0} and {1}: {2}", A, B, 1/2*A*Math.Sqrt(B*B-(A*A/4.0)));
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
