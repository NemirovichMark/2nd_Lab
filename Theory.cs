using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Task1.1
            {
                double eps = 0.001;
                double x, y;
                double r = 2;
                Console.WriteLine("Enter x");
                bool s1=double.TryParse(Console.ReadLine(), out x);
                if (s1)
                {
                    Console.WriteLine("Enter y");
                    bool s2 = double.TryParse(Console.ReadLine(), out y);
                    if (s2)
                    {
                        if ((x * x + y * y - r * r) <= eps)
                        {
                            Console.WriteLine("Is on ellipse");
                        }
                        else
                        {
                            Console.WriteLine("Not on ellipse");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eror");
                    }
                }
                else
                {
                    Console.WriteLine("eror");
                }
            }
            #endregion
            #region Task1.3
            double a, b, c=0;
            Console.WriteLine("Input a");
            bool s3=double.TryParse(Console.ReadLine(), out a);
            if (s3)
            {
                Console.WriteLine("Input b");
                bool s4=double.TryParse(Console.ReadLine(), out b);
                if (s4)
                {
                    if ((a > 0 && a > b) || (a <= 0 && a < b))
                    {
                        c = a;
                    }
                    if ((a<=0 && a>b)||(a>0 && a<b))
                    {
                        c = b;
                    }

                    Console.WriteLine($"Answer for the 1.3 is {c}");
                }
                else
                {
                    Console.WriteLine("Eror");
                }
            }
            else
            {
                Console.WriteLine("eror");
            }
            #endregion
            #region Task1.7
            {
                double x7, y7;
                Console.WriteLine("Enter x7");
                bool s7=double.TryParse(Console.ReadLine(), out x7);
                if (s7)
                {
                    if (x7 > 1 || x7 < -1)
                    {
                        y7 = 1;
                    }
                    else
                    {
                        y7 = Math.Abs(x7);
                    }
                    Console.WriteLine($"Answer for the 1.7 is {y7}");
                }
                else
                {
                    Console.WriteLine("Eror");
                }

            }
            #endregion
            #region Task2.1
            {
                double srr=0;
                int n;
                double sheight=0;
                double sn=0;
                Console.WriteLine("Enter number of students");
                bool success=int.TryParse(Console.ReadLine(), out n);
                if (success)
                {
                    if (n>0)
                    {
                        do
                        {
                            double height;
                            Console.WriteLine("Enter height");
                            double.TryParse(Console.ReadLine(), out height);
                            sheight += height;
                            sn += 1;

                        } while (sn != n);
                        srr = sheight / sn;
                    }
                    else
                    {
                        Console.WriteLine("I can't count middle height");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
                Console.WriteLine($"Middle hight is {srr}");
            }
            #endregion
            #region Task 2.4
            {
                double x02, y02, r01,r02;
                int n2,ans=0;
                int nn2=0;
                Console.WriteLine("Enter x0 of ellipse");
                bool success1=double.TryParse(Console.ReadLine(), out x02);
                if (success1)
                {
                    Console.WriteLine("Enter y0 of ellipse");
                    bool success2=double.TryParse(Console.ReadLine(), out y02);
                    if (success2)
                    {
                        Console.WriteLine("Enter radius1 of ellipse");
                        double.TryParse(Console.ReadLine(), out r01);
                        if (r01>0)
                        {
                            r01 = r01 * r01;
                            Console.WriteLine("Enter radius2 bigger than r1 of ellipse");
                            double.TryParse(Console.ReadLine(), out r02);
                            if (r02>0)
                            {
                                r02 = r02 * r02;
                                Console.WriteLine("Enter number of dots");
                                bool success5 = int.TryParse(Console.ReadLine(), out n2);
                                if (success5)
                                {
                                    if (n2 > 0)
                                    {
                                        double x2, y2;
                                        do
                                        {
                                            Console.WriteLine("Enter x");
                                            double.TryParse(Console.ReadLine(), out x2);
                                            Console.WriteLine("Enter y");
                                            double.TryParse(Console.ReadLine(), out y2);
                                            nn2 += 1;
                                            if ((((x2 - x02) * (x2 - x02) + (y2 - y02) * (y2 - y02)) > r01) && (((x2 - x02) * (x2 - x02) + (y2 - y02) * (y2 - y02)) < r02)) ;
                                            {
                                                ans++;
                                            }
                                        } while (nn2 < n2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Number of dots must be more than 0");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect value of dots");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Radius must be more than 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Radius must be more than 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
                Console.WriteLine($"Number of dots is {ans}");
            }
            #endregion
            #region Task 3.4
            {
                double x03, y03, r013, r023;
                int ans3 = 0;
                double x32,y32;
                Console.WriteLine("Enter x0 of ellipse");
                bool success1 = double.TryParse(Console.ReadLine(), out x03);
                if (success1)
                {
                    Console.WriteLine("Enter y0 of ellipse");
                    bool success2 = double.TryParse(Console.ReadLine(), out y03);
                    if (success2)
                    {
                        Console.WriteLine("Enter radius1 of ellipse");
                        double.TryParse(Console.ReadLine(), out r013);
                        if (r013 > 0)
                        {
                            r013 = r013 * r013;
                            Console.WriteLine("Enter radius2 bigger than r1 of ellipse");
                            double.TryParse(Console.ReadLine(), out r023);
                            if (r023 > 0)
                            {
                                r023 = r023 * r023;
                                do
                                {
                                    Console.WriteLine("Enter x of dot,to end press 10000");
                                    double.TryParse(Console.ReadLine(), out x32);
                                    if (x32 == 10000) break;
                                    Console.WriteLine("Enter y of dot");
                                    double.TryParse(Console.ReadLine(), out y32);
                                    if (((x32 - x03) * (x32 - x03) + (y32 - y03) * (y32 - y03) > r013) && ((x32 - x03) * (x32 - x03) + (y32 - y03) * (y32 - y03) > r023)) ;
                                    {
                                        ans3++;
                                    }
                                } while (x32 != 10000);
                            }
                            else
                            {
                                Console.WriteLine("Radius must be more than 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Radius must be more than 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
                Console.WriteLine($"Number of dots is {ans3}");
            }
            #endregion
            #region Task3.11
            {
                double oz=0;
                int neu=0;
                int m1,m2,m3,m4,bad=0,kolvo=0;
                double answer = 0;
                do
                {
                    Console.WriteLine("Enter the mark of 1st exam,to stop press 0");
                    bool succes1 = int.TryParse(Console.ReadLine(), out m1);
                    if (succes1)
                    {
                        if (m1 == 0) break;
                        if (m1 > 0)
                        {
                            if (m1 == 2 || m1 == 1 )
                            {
                                bad++;
                            }
                            else
                            {
                                oz += m1;
                                kolvo++;
                            }
                            Console.WriteLine("Enter the mark of the 2nd exam");
                            bool succes2=int.TryParse(Console.ReadLine(), out m2);
                            if (succes2)
                            {
                                if (m2 > 0)
                                {
                                    if (m2 == 2 || m2 == 1)
                                    {
                                        bad++;
                                    }
                                    else
                                    {
                                        if (bad==0)
                                        {
                                            oz += m2;
                                            kolvo++;
                                        }
                                    }
                                    Console.WriteLine("Enter the mark of the 3rd exam");
                                    bool succes3=int.TryParse(Console.ReadLine(), out m3);
                                    if (succes3)
                                    {
                                        if (m3 > 0)
                                        {
                                            if (m3 == 2 || m3 == 1)
                                            {
                                                bad++;
                                            }
                                            else
                                            {
                                                if (bad==0)
                                                {
                                                    oz += m3;
                                                    kolvo++;
                                                }
                                            }
                                            Console.WriteLine("Enter the mark of the 4th exam");
                                            bool succes4 = int.TryParse(Console.ReadLine(), out m4);
                                            if (succes4)
                                            {
                                                if (m4 > 0)
                                                {
                                                    if (m4 == 2 || m4 == 1)
                                                    {
                                                        bad++;
                                                    }
                                                    else
                                                    {
                                                        if (bad==0)
                                                        {
                                                            oz += m4;
                                                            kolvo++;
                                                        }
                                                    }
                                                    if (bad>=1)
                                                    {
                                                        neu++;
                                                        bad = 0;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Mark should be > 0");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("You entered incorrect value");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Mark should be >0");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You entered incorrect value");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Mark should be >0");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You entered incorrect value");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Mark should be >0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered incorrect value");
                    }
                } while (m1 != 0);
                if (kolvo > 0)
                {
                    answer = oz / kolvo;
                    Console.WriteLine($"Avarage rating is {answer}");
                    Console.WriteLine($"Number of unsuccessful is {neu}");
                }
                else
                {
                    Console.WriteLine("Number of ex should be >0");
                }
            }
            #endregion
            #region Task 3.12
            {
                double r12;
                double answ = 0;
                do
                {
                    Console.WriteLine("Enter r, to stop press -10");
                    bool suces1 = double.TryParse(Console.ReadLine(), out r12);
                    if (suces1)
                    {
                        if (r12 == -10) break;
                        if (r12 > 0)
                        {
                            Console.WriteLine("Triangle=1, Square=2, Circle=3");
                            Console.WriteLine("Enter type of figure");
                            int type;
                            bool suces2 = int.TryParse(Console.ReadLine(), out type);
                            if (suces2)
                            {
                                switch(type)
                                {
                                    case 1:
                                        {
                                            answ = r12 * r12 * Math.Pow(3, 0.5) / 4;
                                            Console.WriteLine($"Triangle {answ}");
                                            break;
                                        }

                                    case 2:
                                        {
                                            answ = r12 * r12;
                                            Console.WriteLine($"Square {answ}");
                                            break;
                                        }
                                    case 3:
                                        {
                                            answ = Math.PI * r12 * r12;
                                            Console.WriteLine($"Circle {answ}");
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("You entered incorrect value");
                                        break;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Incorrect value");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Radius >0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value");
                    }

                } while (r12 != -10);
            }
            #endregion
            #region Task3.13
            {
                double A,B,otvet;
                do
                {
                    Console.WriteLine("Enter A,to stop press -1");
                    bool sucs = double.TryParse(Console.ReadLine(), out A);
                    if (sucs)
                    {
                        if (A == -1) break;
                        if (A==0)
                        {
                            Console.WriteLine("Area is 0");
                        }
                        if (A>0)
                        {
                            Console.WriteLine("Enter B");
                            bool suces = double.TryParse(Console.ReadLine(), out B);
                            if (suces)
                            {
                                if (B>0)
                                {
                                    int figura;
                                    Console.WriteLine("Enter type of figure, Rectangle=1, Circle=2, Triangle=3");
                                    bool suc=int.TryParse(Console.ReadLine(), out figura);
                                    if (suc)
                                    {
                                        switch (figura)
                                        {
                                            case 1:
                                                {
                                                    otvet = A * B;
                                                    Console.WriteLine($"Area of rectangle is {otvet}");
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    otvet = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                                                    Console.WriteLine($"Area of circle is {otvet}");
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    otvet = Math.Pow(B * B - (A / 2) * (A / 2), 0.5) * (A / 2);
                                                    Console.WriteLine($"Area of triangle is {otvet}");
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("You entered incorrect type of figure");
                                                    break;
                                                }
                                        }
                                    }
                                }

                            }
                        }

                    }

                } while (A != -1);
            }
            #endregion

        }
    }
}
