using System;

namespace _2nd_lab
{
    class Program
    {
        static void Main(String[] args)
        {
            #region lvl1_task5
            // a
            Console.Write("A: ");
            double r = 70, s = 36.74;
            double square_d = Math.Sqrt(s * 2);
            double circle_d = 2 * Math.Sqrt(r / Math.PI);
            if (square_d <= circle_d)
            {
                Console.WriteLine("Fit");
            }
            else
            {
                Console.WriteLine("Don't fit");
            }
            // b
            Console.Write("A: ");
            r = 0.86;
            s = 0.74;
            square_d = Math.Sqrt(s * 2);
            circle_d = 2 * Math.Sqrt(r / Math.PI);
            if (square_d <= circle_d)
            {
                Console.WriteLine("Fit");
            }
            else
            {
                Console.WriteLine("Don't fit");
            }
            #endregion

            #region lvl1_task6
            // a
            Console.Write("A: ");
            r = 3.2;
            s = 3.5;
            square_d = Math.Sqrt(s);
            circle_d = 2 * Math.Sqrt(r / Math.PI);
            if (circle_d <= square_d)
            {
                Console.WriteLine("Fit");
            }
            else
            {
                Console.WriteLine("Don't fit");
            }
            // b
            Console.Write("B: ");
            s = 4;
            square_d = Math.Sqrt(s);
            circle_d = 2 * Math.Sqrt(r / Math.PI);
            if (circle_d <= square_d)
            {
                Console.WriteLine("Fit");
            }
            else
            {
                Console.WriteLine("Don't fit");
            }
            // c
            Console.Write("C: ");
            r = 6;
            s = 9;
            square_d = Math.Sqrt(s);
            circle_d = 2 * Math.Sqrt(r / Math.PI);
            if (circle_d <= square_d)
            {
                Console.WriteLine("Fit");
            }
            else
            {
                Console.WriteLine("Don't fit");
            }
            #endregion

            #region lvl1_task10
            Console.Write("Enter X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (x <= -1)
            {
                y = 1;
            }
            else
            {
                if (x > 1)
                {
                    y = -1;
                }
                else
                {
                    y = -1 * x;
                }
            }
            Console.WriteLine("y = " + y);
            #endregion

            #region lvl2_task1
            int i;
            char[] charsToTrimSex = { ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] charsToTrimHeight = { ' ', 'F', 'M', 'f', 'm' };
            Console.WriteLine("Input example: N: [Height] [Sex] (F - Female, M - Male)");
            Console.Write("Number of classmates: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int male_n = 0, female_n = 0;
            double male = 0, female = 0;
            try
            {
                for (i = 0; i < n; i++)
                {
                    Console.Write((i + 1) + ": ");
                    string line = Console.ReadLine();
                    string sex = line.Trim(charsToTrimSex);
                    sex = sex.ToUpper();
                    double height = Convert.ToDouble(line.Trim(charsToTrimHeight));
                    if (sex == "M" || sex == "m")
                    {
                        male_n++;
                        male += height;
                    }
                    else
                    {
                        if (sex == "F" || sex == "f")
                        {
                            female_n++;
                            female += height;
                        }
                        else
                        {
                            Console.WriteLine("You didn't follow my example! Goodbye...");
                            return;
                        }
                    }
                }
                if (female != 0)
                {
                    double female_mid = Math.Round(female / female_n, 3);
                    Console.WriteLine("Women medium height: " + female_mid);
                }
                else
                {
                    Console.WriteLine("There are no any women in your class.");
                }
                if (male != 0)
                {
                    double male_mid = Math.Round(male / male_n, 3);
                    Console.WriteLine("Men medium height: " + male_mid);
                }
                else
                {
                    Console.WriteLine("There are no any men in your class.");
                }
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }
            #endregion

            #region lvl2_task7
            Console.WriteLine("Input example: N: [x] [y]");
            Console.Write("Number of points: ");
            n = Convert.ToInt32(Console.ReadLine());
            int layout1 = 0, layout3 = 0;
            try
            {
                for (i = 0; i < n; i++)
                {
                    Console.Write((i + 1) + ": ");
                    string[] coords = Console.ReadLine().Split(' ');
                    x = double.Parse(coords[0]);
                    y = double.Parse(coords[1]);
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            Console.WriteLine("-> 1 part");
                            layout1++;
                        }
                        else
                        {
                            Console.WriteLine("-> 4 part");
                        }
                    }
                    else
                    {
                        if (y > 0)
                        {
                            Console.WriteLine("-> 2 part");
                        }
                        else
                        {
                            Console.WriteLine("-> 3 part");
                            layout3++;
                        }
                    }
                }
                Console.WriteLine("1 layout: " + layout1);
                Console.WriteLine("3 layout: " + layout3);
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }

            #endregion

            #region lvl3_task4 
            int sum = 0;
            Console.WriteLine("Input example: N: [x] [y]");
            i = 0;
            try
            {
                Console.Write("r1: ");
                double r1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("r2: ");
                double r2 = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    Console.Write((i + 1) + ": ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        break;
                    }
                    string[] coords = input.Split(' ');
                    x = double.Parse(coords[0]);
                    y = double.Parse(coords[1]);
                    double line = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    if (line > r1 && line < r2)
                    {
                        sum++;
                    }
                    i += 1;
                }
                Console.WriteLine("Sum: " + sum);
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }
            #endregion

            #region lvl3_task11 
            int mark_n1 = 0, mark_n2 = 0, mark_n3 = 0, mark_n4 = 0;
            int bad_marked1 = 0, bad_marked2 = 0, bad_marked3 = 0, bad_marked4 = 0;
            double mark_sum1 = 0, mark_sum2 = 0, mark_sum3 = 0, mark_sum4 = 0;
            i = 0;
            try
            {
                Console.WriteLine("(Input example) Goals: [1st sbj] [2nd sbj] [3rd sbj] [4th sbj]");
                Console.Write("Goals: ");
                string[] marks = Console.ReadLine().Split(' ');
                double goal1 = double.Parse(marks[0]);
                double goal2 = double.Parse(marks[1]);
                double goal3 = double.Parse(marks[2]);
                double goal4 = double.Parse(marks[3]);
                Console.WriteLine("(Input example) N: [1st mark] [2nd mark] [3rd mark] [4th mark]");
                while (true)
                {
                    Console.Write((i + 1) + ": ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        break;
                    }
                    marks = input.Split(' ');
                    double m1 = double.Parse(marks[0]);
                    double m2 = double.Parse(marks[1]);
                    double m3 = double.Parse(marks[2]);
                    double m4 = double.Parse(marks[3]);
                    i++;
                    mark_n1++;
                    mark_sum1 += m1;
                    mark_n2++;
                    mark_sum2 += m2;
                    mark_n3++;
                    mark_sum3 += m3;
                    mark_n4++;
                    mark_sum4 += m4;
                    if (m1 < goal1)
                    {
                        bad_marked1++;
                    }
                    if (m2 < goal2)
                    {
                        bad_marked2++;
                    }
                    if (m3 < goal3)
                    {
                        bad_marked3++;
                    }
                    if (m4 < goal4)
                    {
                        bad_marked4++;
                    }
                }
                double mid1 = mark_sum1 / mark_n1;
                Console.WriteLine("Mid mark 1st sbj: " + mid1);
                double mid2 = mark_sum2 / mark_n2;
                Console.WriteLine("Mid mark 2st sbj: " + mid2);
                double mid3 = mark_sum3 / mark_n3;
                Console.WriteLine("Mid mark 3st sbj: " + mid3);
                double mid4 = mark_sum4 / mark_n4;
                Console.WriteLine("Mid mark 4st sbj: " + mid4);
                Console.WriteLine("Bad marked 1st sbj: " + bad_marked1);
                Console.WriteLine("Bad marked 2st sbj: " + bad_marked2);
                Console.WriteLine("Bad marked 3st sbj: " + bad_marked3);
                Console.WriteLine("Bad marked 4st sbj: " + bad_marked4);
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }
            #endregion

            #region lvl3_task12  
            i = 0;
            try
            {
                Console.WriteLine("(Input example) N: [r] [Type]");
                Console.WriteLine("(Input example) Type 1 - Square");
                Console.WriteLine("(Input example) Type 2 - Circle");
                Console.WriteLine("(Input example) Type 3 - Equilateral triangle");
                while (true)
                {
                    Console.Write((i + 1) + ": ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        break;
                    }
                    string[] line = input.Split(' ');
                    r = double.Parse(line[0]);
                    int type = int.Parse(line[1]);
                    double area = 0;
                    if (type == 1)
                    {
                        area = Math.Pow(r, 2);
                    }
                    else
                    {
                        if (type == 2)
                        {
                            area = Math.PI * Math.Pow(r, 2);
                        }
                        else
                        {
                            if (type == 3)
                            {
                                area = (Math.Sqrt(3) * Math.Pow(r, 2)) / 4;
                            }
                            else
                            {
                                Console.WriteLine("You didn't follow my example! Goodbye...");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Area: " + Math.Round(area, 3));
                    i++;
                }
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }
            #endregion

            #region lvl3_task13 
            i = 0;
            try
            {
                Console.WriteLine("(Input example) N: [a] [b] [Type]");
                Console.WriteLine("(Input example) Type 1 - Rectangle");
                Console.WriteLine("(Input example) Type 2 - Ring");
                Console.WriteLine("(Input example) Type 3 - Isosceles");
                while (true)
                {
                    Console.Write((i + 1) + ": ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        break;
                    }
                    string[] line = input.Split(' ');
                    double a = double.Parse(line[0]);
                    double b = double.Parse(line[1]);
                    int type = int.Parse(line[2]);
                    double area = 0;
                    if (type == 1)
                    {
                        area = a * b;
                    }
                    else
                    {
                        if (type == 2)
                        {
                            area = Math.Abs((Math.PI * Math.Pow(a, 2)) - (Math.PI * Math.Pow(b, 2)));
                        }
                        else
                        {
                            if (type == 3)
                            {
                                double p = (a + b + b) / 2;
                                area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                            }
                            else
                            {
                                Console.WriteLine("You didn't follow my example! Goodbye...");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Area: " + Math.Round(area, 3));
                    i++;
                }
            }
            catch
            {
                Console.WriteLine("You didn't follow my example! Goodbye...");
            }
            #endregion
        }
    }
}
