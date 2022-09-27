using System;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region task 2.1.2

            double x, y;
            bool l = false;
            Console.WriteLine("enter x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("enter y");
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && y + Math.Abs(x) <= 1)
            {
                l = !l;
            }
            Console.WriteLine($"the dot lies inside the triangle - {l}");

            #endregion


            #region task 2.1.3

            double a, b, c;
            Console.WriteLine("enter a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("enter b");
            double.TryParse(Console.ReadLine(), out b);
            if (a > 0 && a > b)
            {
                c = a;
            }
            else if (a <= 0 && a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
            Console.WriteLine(c);

            #endregion


            #region task 2.2.1

            double h, sh, s = 0;
            int n, i;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("n must be positive");
                int.TryParse(Console.ReadLine(), out n);
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("enter height");
                double.TryParse(Console.ReadLine(), out h);
                s = s + h;
            }
            sh = s / n;
            Console.WriteLine($"average height is {sh}");

            #endregion


            #region task 2.2.4

            double r1, r2, x_q, y_q;
            int i_q, n_q, k = 0;
            Console.WriteLine("enter r1");
            double.TryParse(Console.ReadLine(), out r1);
            Console.WriteLine("enter r2");
            double.TryParse(Console.ReadLine(), out r2);
            while (r1 < 0 || r2 < 0)
            {
                Console.WriteLine("r1 an r2 must not be negative");
                Console.WriteLine("enter r1");
                double.TryParse(Console.ReadLine(), out r1);
                Console.WriteLine("enter r2");
                double.TryParse(Console.ReadLine(), out r2);
            }
            while (r1 > r2)
            {
                Console.WriteLine("r2 >= r1");
                Console.WriteLine("enter r2");
                double.TryParse(Console.ReadLine(), out r2);
            }
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_q);
            while (n_q <= 0)
            {
                Console.WriteLine("n must be positive");
                int.TryParse(Console.ReadLine(), out n_q);
            }
            for (i_q = 0; i_q < n_q; i_q++)
            {
                Console.WriteLine("enter x");
                double.TryParse(Console.ReadLine(), out x_q);
                Console.WriteLine("enter y");
                double.TryParse(Console.ReadLine(), out y_q);
                if (x_q * x_q + y_q * y_q <= r2 * r2 && x_q * x_q + y_q * y_q >= r1 * r1)
                {
                    k = k + 1;
                }
            }
            Console.WriteLine($"points in the ring - {k}");

            #endregion


            #region task 2.3.4

            double k1, k2, x_w, y_w;
            int k_w = 0;
            Console.WriteLine("enter r1");
            double.TryParse(Console.ReadLine(), out k1);
            Console.WriteLine("enter r2");
            double.TryParse(Console.ReadLine(), out k2);
            while (k1 < 0 || k2 < 0)
            {
                Console.WriteLine("r1 an r2 must not be negative");
                Console.WriteLine("enter r1");
                double.TryParse(Console.ReadLine(), out k1);
                Console.WriteLine("enter r2");
                double.TryParse(Console.ReadLine(), out k2);
            }
            while (k1 > k2)
            {
                Console.WriteLine("r2 >= r1");
                Console.WriteLine("enter r2");
                double.TryParse(Console.ReadLine(), out k2);
            }
            do
            {
                Console.WriteLine("enter x or enter 1000 (or more) to end");
                double.TryParse(Console.ReadLine(), out x_w);
                if (x_w >= 1000) break;
                Console.WriteLine("enter y");
                double.TryParse(Console.ReadLine(), out y_w);
                if (x_w * x_w + y_w * y_w <= k2 * k2 && x_w * x_w + y_w * y_w >= k1 * k1)
                {
                    k_w = k_w + 1;
                }
            } while (x_w < 1000);
            Console.WriteLine($"points in the ring - {k_w}");

            #endregion


            #region task 2.3.11

            double srb = 0, ssb = 0, nb = 0;
            int j, po, an = 0, sb, ann = 0;
            do
            {
                sb = 0;
                ann = 0;
                Console.WriteLine($"enter points for exam 1 or type smth not in [2:5]");
                int.TryParse(Console.ReadLine(), out po);
                if (po < 2 || po > 5)
                {
                    break;
                }
                if (po == 2)
                {
                    ann++;
                }
                sb = sb + po;
                for (j = 2; j < 5; j++)
                {
                    Console.WriteLine($"enter points for exam {j}");
                    int.TryParse(Console.ReadLine(), out po);
                    while (po < 2 || po > 5)
                    {
                        Console.WriteLine("points can be only 2-5");
                        Console.WriteLine($"enter points for exam {j}");
                        int.TryParse(Console.ReadLine(), out po);
                    }
                    if (po == 2)
                    {
                        ann++;
                    }
                    sb = sb + po;
                }
                if (ann > 0)
                {
                    an++;
                }
                ssb = ssb + sb;
                nb++;
            } while (po >= 2 && po <= 5);
            if (nb > 0)
            {
                srb = ssb / nb / 4;
            }
            Console.WriteLine($"number of loosers - {an}, average points - {srb}");

            #endregion

            #region task 2.3.12

            double r, g;
            int key;
            do
            {
                Console.WriteLine("enter positive r or enter negative to end");
                double.TryParse(Console.ReadLine(), out r);
                if (r < 0)
                {
                    break;
                }
                Console.WriteLine("attribute: 1 = square area," + "2 = circle area," + "3 = triangle area");
                Console.WriteLine("enter attribute 1, 2 or 3: ");
                int.TryParse(Console.ReadLine(), out key);
                while (key < 1 || key > 3)
                {
                    Console.WriteLine("not the right attribute - enter attribute 1, 2 or 3:");
                    int.TryParse(Console.ReadLine(), out key);
                }
                switch (key)
                {
                    case 1:
                        g = r * r;
                        Console.WriteLine($"square area - {g}");

                        break;

                    case 2:
                        g = Math.PI * r * r;
                        Console.WriteLine($"circle area - {g}");

                        break;

                    case 3:
                        g = Math.Sqrt(3) * r * r / 4;
                        Console.WriteLine($"triangle area - {g}");

                        break;
                }
            } while (r >= 0);


            #endregion

            #region task 2.3.13

            double A, B, G;
            int ke;
            do
            {
                Console.WriteLine("enter positive A or enter negative to end");
                double.TryParse(Console.ReadLine(), out A);
                if (A < 0)
                {
                    break;
                }
                Console.WriteLine("enter B");
                double.TryParse(Console.ReadLine(), out B);
                while (B < 0)
                {
                    Console.WriteLine("B cannot be negative");
                    double.TryParse(Console.ReadLine(), out B);
                }
                Console.WriteLine("attribute: 1 = rectangle area," + "2 = ring area," + "3 = triangle area");
                Console.WriteLine("enter attribute 1, 2 or 3: ");
                int.TryParse(Console.ReadLine(), out ke);
                while (ke < 1 || ke > 3)
                {
                    Console.WriteLine("not the right attribute - enter attribute 1, 2 or 3:");
                    int.TryParse(Console.ReadLine(), out ke);
                }
                switch (ke)
                {
                    case 1:
                        G = A * B;
                        Console.WriteLine($"rectangle area - {G}");

                        break;

                    case 2:
                        G = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                        Console.WriteLine($"ring area - {G}");

                        break;

                    case 3:
                        G = Math.Sqrt(B * B - A * A / 4) * A / 2;
                                    if (B + B < A)
                                    {
                                        Console.WriteLine("impossible");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"triangle area - {G}"); 
                                    }

                        break;
                }
            } while (A >= 0);

            #endregion  
        }
    }
}
