using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Transactions;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            //Level1();
            //Level2();
            Level3();
        }

        static void Level1()
        {
            #region Level 1
            Console.WriteLine("--- Level 1 ---");
            Console.WriteLine("--- ex.1 ---");
            #region ex.1
            double radius;
            double x, y;

            for (; ; )
            {
                try
                {
                    Console.Write("Enter radius: ");
                    radius = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter x: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter y: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2))
                    {
                        Console.WriteLine("The point is inside the circle");
                        Console.WriteLine("------------------------------");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("The point is outside the circle");
                        Console.WriteLine("------------------------------");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("------------------------------");
                }

            }
            #endregion
            Console.WriteLine("--- ex.5 ---");
            #region ex.5

            double areaOfCircle;
            double areaOfSquare;

            for (; ; )
            {
                try
                {
                    Console.Write("Enter the area of the circle: ");
                    areaOfCircle = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the area of the square: ");
                    areaOfSquare = Convert.ToDouble(Console.ReadLine());

                    double radiusOfCircle = Math.Sqrt(areaOfCircle / Math.PI);
                    double diagonal = Math.Sqrt(areaOfSquare) * Math.Sqrt(2);

                    if (diagonal <= 2 * radiusOfCircle)
                    {
                        Console.WriteLine("The square can be placed into the circle");
                        Console.WriteLine("----------------------------------------");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("The square can't be placed into the circle");
                        Console.WriteLine("------------------------------------------");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("------------------------------");
                }
            }

            #endregion
            Console.WriteLine("--- ex.7 ---");
            #region ex.7

            double argument;
            double func;
            for (; ; )
            {
                try
                {
                    Console.Write("Enter argument: ");
                    argument = Convert.ToDouble(Console.ReadLine());

                    if (argument < -1 || argument > 1)
                    {
                        func = 1;
                        Console.WriteLine($"y = {func}");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                    }
                    else if (argument >= -1 || argument <= 1)
                    {
                        func = Math.Abs(argument);
                        Console.WriteLine($"y = {func}");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oopsie....Try again");
                        Console.WriteLine("------------------------------------------------------------");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Oopsie....Try again");
                    Console.WriteLine("------------------------------------------------------------");
                }
            }

            #endregion

            #endregion
        }

        static void Level2()
        {

            #region Level 2
            Console.WriteLine("--- Level 2 ---");
            Console.WriteLine("--- ex.1 ---");
            #region ex.1

            double averageHeight;
            double sumOfHeight = 0;
            int n = 0;
            for (; ; )
            {
                try
                {

                    double height;



                    Console.Write("Enter gender(B or G, if you want to exit the program type 'E'): ");
                    char gender = char.Parse(Console.ReadLine());

                    if (gender == 'E')
                    {
                        averageHeight = sumOfHeight / n;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine($"The average height in class: {Math.Round(averageHeight, 2)}");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                    }

                    if (gender == 'B')
                    {
                        Console.Write("Enter height: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------------------");
                        sumOfHeight += height;
                        n++;
                    }

                    else if (gender == 'G')
                    {
                        Console.Write("Enter height: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------------------");
                        sumOfHeight += height;
                        n++;
                    }



                    else
                    {
                        Console.WriteLine("There's only two genders");
                        Console.WriteLine("------------------------------------------------------------");
                    }






                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Input =( Try Again");
                }
            }

            #endregion
            Console.WriteLine("--- ex.2 ---");
            #region ex.2

            int numberOfDots = 0;
            double r = 10;
            double a = 4;
            double b = 3;

            for (; ; )
            {
                try
                {
                    Console.Write("Enter x coord(to exit the program type some letters or symbols): ");
                    double xCoordinate = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter y coord: ");
                    double yCoordinate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------");


                    if (Math.Pow(xCoordinate - a, 2) + Math.Pow(yCoordinate - b, 2) - Math.Pow(r, 2) < Math.Pow(10, -4))
                    {
                        numberOfDots++;
                    }



                }

                catch (Exception)
                {
                    Console.WriteLine($"Number of dots inside the ring: {numberOfDots}");
                    break;
                }

            }


            #endregion

            #endregion
        }

        static void Level3() 
        {
            #region Level 3
            Console.WriteLine("--- Level 3 ---");
            Console.WriteLine("--- ex.4 ---");
            #region ex.4
            int quantity = 0;
            double innerRadius;
            double outerRadius;

            Console.Write("Enter inner radius: ");
            double.TryParse(Console.ReadLine(), out innerRadius);
            Console.Write("Enter outer radius: ");
            double.TryParse(Console.ReadLine(), out outerRadius);
            Console.WriteLine("--------------------------------------------------------");


            if (innerRadius > 0 && outerRadius > 0)
            {

                for (; ; )
                {
                    try
                    {
                        Console.Write("Enter x coord(to exit the program type some letters or symbols): ");
                        double xCoord = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter y coord: ");
                        double yCoord = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------");


                        if (Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2) <= Math.Pow(outerRadius, 2) && Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2) >= Math.Pow(innerRadius, 2))
                        {
                            quantity++;
                        }

                    }

                    catch (Exception)
                    {
                        Console.WriteLine($"Answer: {quantity}");
                        Console.WriteLine("--------------------------------------------------------");
                        break;
                    }

                }
            }



            #endregion

            Console.WriteLine("--- ex.11 ---");
            #region ex.11

            int[] student = new int[4];
            double[] averageMark = new double[] { 0, 0, 0, 0};
            int numberOfFools = 0;
            int numberOfGeniuses = 0;
            bool badMark;
            int numberOfStudent = 1;
            try
            {
                while (true)
                {
                    Console.WriteLine($"--- {numberOfStudent} ---");
                    badMark = false;

                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("Enter mark: ");
                        student[i] = int.Parse(Console.ReadLine());
                        if (student[i] >= 2 && student[i] <=5)
                        {
                            if (student[i] == 2)
                            {
                                numberOfFools++;
                                badMark = true;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong mark");
                            throw new Exception();
                        }
                    }
                    if (!badMark)
                    {
                        numberOfGeniuses++;
                        for (int i = 0; i < 4; i++)
                        {
                            averageMark[i] += student[i];
                            
                        }
                    }
                    numberOfStudent++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You have quitted the input");
            }

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    averageMark[i] /= numberOfGeniuses;
                    Console.WriteLine($"Average score on exam №{i + 1} is {averageMark[i]}");
                }
                catch (Exception)
                {
                    Console.WriteLine($"No one passed exam №{i + 1}");
                }
            }


            #endregion
            Console.WriteLine("--- ex.12 ---");
            #region ex.12

            while (true)
            {
                Console.WriteLine("If you want to stop input type -1");
                Console.Write("Enter r: ");
                double.TryParse(Console.ReadLine(), out double r);
                if (r < 0)
                {
                    break;
                }
                Console.WriteLine("If you want to count the area of rectangle, type 1\nIf you want to count the area of ring, type 2\nIf you want to count the area of triangle, type 3");
                Console.Write("Choose: ");
                int.TryParse(Console.ReadLine(), out int chooseAreaType);
                switch (chooseAreaType)
                {
                    case 1:
                        Console.WriteLine($"Square: {Math.Pow(r, 2)}");
                        break;

                    case 2:
                        Console.WriteLine($"Circle: {Math.PI * Math.Pow(r, 2)}");
                        break;

                    case 3:
                        Console.WriteLine($"Triangle: {(Math.Sqrt(3) * Math.Pow(r, 2)) / 4}");
                        break;

                    default:
                        Console.WriteLine("Try again");
                        break;

                }

            }

            #endregion
            Console.WriteLine("--- ex.13 ---");
            #region ex.13
            while (true)
            {
                int chooseArea;
                Console.WriteLine("If you want to stop input type -1");
                Console.Write("Enter a: ");
                double.TryParse(Console.ReadLine(), out double a);
                Console.Write("Enter b: ");
                double.TryParse(Console.ReadLine(), out double b);
                if (a < 0 || b < 0)
                {
                    break;
                }
                Console.WriteLine("If you want to count the area of square, type 1\nIf you want to count the area of circle, type 2\nIf you want to count the area of triangle, type 3");
                Console.Write("Choose: ");
                int.TryParse(Console.ReadLine(), out chooseArea);
                switch (chooseArea)
                {
                    case 1:
                        Console.WriteLine($"Rectangle: {a * b}");
                        break;

                    case 2:
                        Console.WriteLine($"Ring: {Math.Abs((Math.PI * Math.Pow(a, 2)) - (Math.PI * Math.Pow(b, 2)))}");
                        break;

                    case 3:
                        Console.WriteLine($"The area of a triangle: {Math.Sqrt((b - a) * (b + a)) / 2}");
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }

            }
            #endregion

            #endregion

        }
    }
}