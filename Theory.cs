using System;
namespace Lab_2
{
    
    class Main_Prog
    {

        static void Main(string[] args)
            
        {
             
            #region First_Lvl_3

            double a = 0;
            double b = 0;
            Console.WriteLine("Please, enter correct parameters!");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if(a>0){
                double c = Math.Max(a, b);
                Console.WriteLine(c);
            } else {
                double c = Math.Min(a, b);
                Console.WriteLine(c);
            }

            #endregion




            #region First_Lvl_5
            double a = 0; 
            double b = 0; 
            while ((a <= 0) || (b <= 0))
            {
                Console.WriteLine("Please, enter correct parameters!");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
            }
            if ((Math.Sqrt(a) * Math.Sqrt(2)) <= (Math.Sqrt(b/Math.PI)*2))
            {
                Console.WriteLine("Да, поместится");
            }
            else
            {
                Console.WriteLine("Нет, не поместится");
            }

            #endregion






            #region First_Lvl_6

            double a = 0;
            double b = 0;
            while ((a <= 0) || (b <= 0))
            {
                Console.WriteLine("Please, enter correct parameters!");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
            }
            if (Math.Sqrt(a/Math.PI) <= Math.Sqrt(b) / 2)
            {
                Console.WriteLine("Да, поместится");
            }
            else
            {
                Console.WriteLine("Нет, не поместится");
            }

            #endregion






            #region Second_Lvl_1

            int n = 0;

            do{
                Console.WriteLine("Please, enter real number")
                n = Convert.ToInt32(Console.ReadLine());
            }while(n<=0);

            double sum_b = 0;
            double amount_b = 0;
            double sum_g = 0;
            double amount_g = 0;

            do
            {
                int s = 0;
                do {
                    Console.WriteLine("Please, enter 1 if HE. Enter 0 if SHE");
                    s = Convert.ToInt32(Console.ReadLine());
                }while ((s != 0) && (s != 1));

                if (s == 0)
                {
                    amount_g += 1;
                    Console.WriteLine("Please, enter correct height of person");
                    point = Convert.ToDouble(Console.ReadLine());
                    if (point<=0) continue;
                    sum_g += point;
                } else
                {
                    amount_b += 1;
                    Console.WriteLine("Please, enter correct height of person");
                    point = Convert.ToDouble(Console.ReadLine());
                    if (point<=0) continue;
                    sum_b += point;
                }

                n -= 1;

            } while (n != 0);

            Console.WriteLine($"Average height of girls in the class is {sum_g/amount_g}");
            Console.WriteLine($"Average height of boys in the class is {sum_b/amount_b}");

            #endregion








            #region Second_Lvl_9

            int n = 0;

            do
            {
                Console.WriteLine("Please, enter real number");
                n = Convert.ToDouble(Console.ReadLine());
            } while (n <= 0);

            
            double best_result = int32.maxvalue;
           
            do
            {
                double res = Convert.ToDouble(Console.ReadLine());

                if (res < 0)
                {
                    Console.WriteLine("Please, enter correct result of a person");
                    continue;
                }
                else if (res < best_result)
                    best_result = res;
                    
                n -= 1;
            } while (n != 0);

            #endregion






            #region Third_Lvl_4

            double r1 = 0;
            double r2 = 0;

            do{
                Console.WriteLine("Please, enter correct parameters");
                r1 = Convert.ToDouble(Console.ReadLine());
                r2 = Convert.ToDouble(Console.ReadLine());
            }while((r1<=0)||(r2<=0));

            int sum = 0;

            while (true)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();

                if ((x == "") || (y == ""))
                    break;

                double Point_X = Convert.ToDouble(x);
                double Point_Y = Convert.ToDouble(y);
                double r = Math.Sqrt(Point_X * Point_X + Point_Y * Point_Y);

                if ((r1 < r) && (r2 > r))
                {
                    sum += 1;
                }
            }

            Console.WriteLine($"Only {sum} points belong this zone");

            #endregion



            #region Third_Lvl_11
            double sum = 0;
            int amount = 0;
            int amount_of_bad_students = 0;
            while (true)
            {
                double pre_sum = 0;
                bool key1 = true;
                bool key2 = true;
                Console.WriteLine("Please, enter person`s marks one by one");
                try
                {
                    for (int i = 0; i <= 3; i += 1)
                    {
                        string row = Console.ReadLine();
                        if (row == "")
                        {
                            key1 = false;
                            break;
                        }
                        int grade = Convert.ToInt32(row);
                        if ((grade > 5) || (grade < 2))
                        {
                            throw new Exception();
                        }
                        if (grade == 2)
                        {
                            key2 = false;
                            break;
                        } else pre_sum += grade;
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong format!!!");
                    continue;
                }

                if (key1 == false) break;
                if (key2 == false) amount_of_bad_students += 1;
                sum += pre_sum / 4;
                amount += 1;
            }
            Console.WriteLine($"Average grade in the class is {sum / amount}. And amount of bad students is {amount_of_bad_students}");
            #endregion



            #region Third_Lvl_12
            while (true)
            {
                double R = 0;
                try
                {
                    string Re = Console.ReadLine();
                    if (Re == "")
                    {
                        break;
                    }
                    else
                    {
                        R = Convert.ToDouble(Re);
                    }
                } catch
                {
                    Console.WriteLine("Wrong format!!!!!");
                    continue;
                }
                Console.WriteLine("Please, use only 3 types of messages: triangle, circle, square");
                string message = Console.ReadLine();
                double S = 0;
                switch(message){
                case "triangle": S = R * Math.Sqrt(3)/4; break;
                case "circle": S = Math.PI * R * R; break;
                case "square": S = R * R; break;
                default: Console.WriteLine("Wrong format! Please, try again!"); continue; break;
                }
                Console.WriteLine(S);
            }
            #endregion



            #region Third_Lvl_13
            while (true)
            {
                double A = 0;
                double B = 0;
                try
                {
                    string A1 = Console.ReadLine();
                    string B1 = Console.ReadLine();
                    if (A1 == "")
                    {
                        break;
                    }
                    else
                    {
                        A = Convert.ToDouble(A1);
                        B = Convert.ToDouble(B1);
                    }
                } catch
                {
                    Console.WriteLine("Wrong format!!!!!");
                    continue;
                }
                Console.WriteLine("Please, use only 3 types of messages: triangle, circle, rectangle");
                string message = Console.ReadLine();
                double S = 0;
                switch(message){
                case "triangle": S = A * (Math.Sqrt(B * B - 0.25 * A * A)); break;
                case "circle": S = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
                case "rectangle": S = A * B; break;
                default: Console.WriteLine("Wrong format! Please, try again!"); continue; break;
                }
                Console.WriteLine(S);
            }
            #endregion

            

        }
    }
}