using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region I|1
            Console.WriteLine("I №1");
            
            double[] xm = {0.0, 1.5, 1.0, 3};
            double[] ym = {2.0, 0.7, 1, 0};
            int r = 2;
            for (int i = 0; i < xm.Length; i++)
            {
                if (Math.Abs(xm[i]*xm[i] + ym[i]*ym[i] - r*r) <= 0.001)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

            Console.WriteLine("--------------------");
            #endregion
            
            #region I|2
            Console.WriteLine("I №2");

            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (y >= 0 && Math.Abs(x) + y <= 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("--------------------");
            #endregion

            #region I|3
            Console.WriteLine("I №3");

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (a > b)
                {
                    Console.WriteLine($"c = {a}");
                }
                else
                {
                    Console.WriteLine($"c = {b}");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"c = {b}");
                }
                else
                {
                    Console.WriteLine($"c = {a}");
                }
            }

            Console.WriteLine("--------------------");
            #endregion

            #region II|1
            Console.WriteLine("II №1");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0, o;
            for (int i = 0; i < n; i++)
            {   
                Console.Write("Enter height: ");
                o = Convert.ToDouble(Console.ReadLine());
                if (o >= 0)
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    n -= 1;
                }
            }
            Console.WriteLine($"middle height = {sum/n}");
            
            Console.WriteLine("--------------------");
            #endregion

            #region II|2
            Console.WriteLine("II №2");

            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter r: ");
            double R = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {   
                Console.WriteLine($"--{i+1}--");
                Console.Write("Enter x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter y: ");
                y = Convert.ToDouble(Console.ReadLine());
                if ((x - a)*(x - a) + (y - b)*(y - b) <= R*R)
                {
                    sum ++;
                }
            }
            Console.WriteLine($"vlaue = {sum}");
            
            Console.WriteLine("--------------------");
            #endregion

            #region III|4
            Console.WriteLine("III №4");

            double r1 = Convert.ToDouble(Console.ReadLine());
            double r2 = Convert.ToDouble(Console.ReadLine());
            sum = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter x: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    break;
                }
                if (x*x + y*y < r2 && x*x + y*y > r1)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Answer: {sum}");

            Console.WriteLine("--------------------");
            #endregion

            #region III|11
            Console.WriteLine("III №11");

            double srbal = 0;
            double e1, e2, e3, e4;

            while (true)
            {
                try
                {
                    Console.Write("Enter 1-st exam: ");
                    e1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter 2-nd exam: ");
                    e2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter 3-rd exam: ");
                    e3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter 4-th exam: ");
                    e4 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    break;
                }
                if (e1 >= 2 && e1 <= 5 && e2 >= 2 && e2 <= 5 && e3 >= 2 && e3 <= 5 && e4 >= 2 && e4 <= 5)
                {
                    if (e1 < 2.5 | e2 < 2.5 | e3 < 2.5 | e4 < 2.5)
                    {
                        sum++;
                    }
                    else
                    {
                        srbal = (e1 + e2 + e3 + e4)/4;
                    }
                }
            }
            Console.WriteLine($"Middle mark: {srbal}; Students with bad mark: {sum}");

            Console.WriteLine("--------------------");
            #endregion

            #region III|12
            Console.WriteLine("III №12");
            
            int p;

            while (true)
            {
                try
                {
                    Console.Write("Enter r: ");
                    r1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter what to do(1, 2, 3): ");
                    p = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch
                {
                    break;
                }
                if (r1 >= 0)
                {
                    switch(p)
                    {
                        case 1:
                            sum = r1*r1;
                            break;
                        case 2:
                            sum = Math.PI*r1*r1;
                            break;
                        case 3:
                            sum = (r1*r1*Math.Sqrt(3))/4;
                            break;
                    }
                }
                Console.WriteLine($"S: {sum}");
            }

            Console.WriteLine("--------------------");
            #endregion

            #region III|13
            Console.WriteLine("III №13");

            while (true)
            {
                try
                {
                    Console.Write("Enter A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter what to do(1, 2, 3): ");
                    p = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch
                {
                    break;
                }
                if (a >= 0 && b >= 0)
                {
                    switch(p)
                    {
                        case 1:
                            sum = a*b;
                            break;
                        case 2:
                            if (a>b)
                            {
                                sum = Math.PI*a*a - Math.PI*b*b;
                            }
                            else
                            {
                                sum = Math.PI*b*b - Math.PI*a*a;
                            }
                            break;
                        case 3:
                            if (a>b)
                            {
                                sum = 0.5*a*(Math.Sqrt(b*b - (0.5*a)*(0.5*a)));
                            }
                            else
                            {
                                sum = 0.5*b*(Math.Sqrt(a*a - (0.5*b)*(0.5*b)));
                            }
                            break;
                    }
                }
                Console.WriteLine($"S: {sum}");
            }

            Console.WriteLine("--------------------");
            #endregion
        }
    }
}