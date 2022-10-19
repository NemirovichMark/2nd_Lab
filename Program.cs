using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace lab_2
{
    class Program
    {
        static void Main()
        {
            #region Lvl1 


            #region L1Task3
            double a;
            double b;
            double c;
            Console.WriteLine("Vvedite a, b, c");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }
            Console.WriteLine($"L1Task3 {c}");
            #endregion
            #region L1Task4
            double c1;
            c1 = double.Parse(Console.ReadLine());
            double z;
            {
                z = Math.Max(Math.Min(a, b), c1);
            }
            Console.WriteLine($"L1Task4 {z}");
            #endregion
            #region L1Task7
            double x;
            double y;
            Console.WriteLine("Vvedite x");
            x = double.Parse(Console.ReadLine());
            if (Math.Abs(x) > 1)
            {
                y = 1;
            }
            else
            {
                y = Math.Abs(x);
            }
            Console.WriteLine($"L1Task7 {y}");
            #endregion

            #endregion


            #region Lvl2


            #region Task1
            double sr;
            double r;
            double s = 0;
            for (int ii = 0; ii < 5; ii++)
            {
                Console.WriteLine("Vvedite rost uchenika");
                r = double.Parse(Console.ReadLine());
                s += r;
            }
            sr = s / 5;
            Console.WriteLine($"Sredniy rost {sr}");
            #endregion

            #region Task3
            double ves = 30; //kg
            double m = 300; //ml
            double k;
            double ss = 0;
            double nado;
            for (int iii = 0; iii < 5; iii++)
            {
                Console.WriteLine("Vvedite ves uchenika");
                k = double.Parse(Console.ReadLine());
                if (k < ves)
                {
                    ss += 1;
                }
            }
            nado = ss * m;
            Console.WriteLine($"Nuzno {nado} ml");
            #endregion
            #endregion


            #region Lvl3

            #region L3Task11
            double e1, e2, e3, e4; //exam
            int uch; //kolvo uchenikov
            Console.WriteLine("kolvo uchenikov: ");
            uch = Convert.ToInt32(Console.ReadLine());
            int oc = uch * 4; //exmam's rez
            double sumoc = 0;
            double coc = 0, prev = 0, min = 100000;  //coc - sr rez
            while (uch > 0)
            {
                for (int q = 1; q <= nado; q++)
                {
                    Console.WriteLine("ocenki uchenika cerez enter: ");
                    e1 = Convert.ToInt32(Console.ReadLine());
                    e2 = Convert.ToInt32(Console.ReadLine());
                    e3 = Convert.ToInt32(Console.ReadLine());
                    e4 = Convert.ToInt32(Console.ReadLine());
                    uch = uch - 1;
                    sumoc += e1 + e2 + e3 + e4;
                    coc = (e1 + e2 + e3 + e4) / 4;
                    min = Math.Min(min, coc);
                    prev = coc;
                }
            }
            Console.WriteLine("Sr ball: " + sumoc / uch);
            #endregion

            #region L3Task4
            int i = 0;
            Console.WriteLine("pervii r: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vtoroi r: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kolvo tochek dlya proverki: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine("x: ");
                double xx = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y: ");
                double yy = Convert.ToDouble(Console.ReadLine());
                if (Math.Pow(xx, 2) + Math.Pow(yy, 2) > Math.Pow(r1, 2) && Math.Pow(xx, 2) + Math.Pow(yy, 2) <= Math.Pow(r2, 2))
                {
                    i++;
                }
                n = n - 1;
            }
            Console.WriteLine(i);
            #endregion

            #region L3Task12
            Console.WriteLine("kolvo povtorov: ");
            int nn = Convert.ToInt32(Console.ReadLine());
            while (nn > 0)
            {
                Console.WriteLine(" 1 = S kvad," + " 2 = S crug," + " 3 = S ravn triangle");
                Console.WriteLine("vvedi davai:");
                int vibor = Convert.ToInt32(Console.ReadLine());
                switch (vibor)
                {
                    case 1:
                        Console.WriteLine("dlina storoni:");
                        double aa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Pow(aa, 2));
                        break;
                    case 2:
                        Console.WriteLine("gde radius:");
                        aa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.PI * (Math.Pow(aa, 2)));
                        break;
                    case 3:
                        Console.WriteLine("storonku pz:");
                        aa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine((Math.Pow(aa, 2)) * Math.Pow(3, 0.5) / 4);
                        break;
                    default:
                        Console.WriteLine("gad, 1 2 ili 3 tolko");
                        break;
                }
                nn = nn - 1;
            }
            #endregion

            #region L3Task13
            Console.WriteLine("kolvo povtorov:");
            int nnn = Convert.ToInt32(Console.ReadLine());
            while (nnn > 0)
            {
                Console.WriteLine("1 = S pryamoug," + " 2 = S ring," + " 3 = S rb triangle");
                Console.WriteLine("vvedi davai:");
                int vibor = Convert.ToInt32(Console.ReadLine());
                switch (vibor)
                {
                    case 1:
                        Console.WriteLine("dlini cherez enter:");
                        double odn = Convert.ToDouble(Console.ReadLine());
                        double dva = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(odn * dva);
                        break;
                    case 2:
                        Console.WriteLine("Vnut i vnesh r:");
                        odn = Convert.ToDouble(Console.ReadLine());
                        dva = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Abs(Math.PI * Math.Pow(odn, 2)) - Math.PI * Math.Pow(dva, 2));
                        break;
                    case 3:
                        Console.WriteLine("pervaya dlina osnovanie:");
                        odn = Convert.ToDouble(Console.ReadLine());
                        dva = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(odn * Math.Pow((4 * Math.Pow(dva, 2) - Math.Pow(odn, 2)), 0.5) / 4);
                        break;
                    default:
                        Console.WriteLine("gad, 1 2 ili 3 tolko");
                        break;
                }
                nnn = nnn - 1;
            }
            #endregion

            #endregion
        }
    }
}