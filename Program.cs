using System;
using Geometry;
using System.Collections.Generic;
using System.Text;

namespace _2nd_Lab
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\n\t\t\tTask 1\n\n");
            Task1();
            Console.WriteLine("\n\n\t\t\tTask 2\n\n");
            Task2();
            Console.WriteLine("\n\n\t\t\tTask 3\n\n");
            Task3();
            Console.WriteLine("\n\n\t\t\tTask 4\n\n");
            Task4();

            Console.WriteLine("\n\n\t\t\tTask level 2 ex 1\n\n");
            Task2_1();
            Console.WriteLine("\n\n\t\t\tTask level 2 ex 2\n\n");
            Task2_2();

            Console.WriteLine("\n\n\t\t\tTask level 3 ex 4\n\n");
            Task3_4();
            Console.WriteLine("\n\n\t\t\tTask level 3 ex 11\n\n");
            Task3_11();
            Console.WriteLine("\n\n\t\t\tTask level 3 ex 12\n\n");
            Task3_12();
            Console.WriteLine("\n\n\t\t\tTask level 3 ex 13\n\n");
            Task3_13();
        }
        #region Level1
        #region Task1
        static void Task1()
        {
            double epsilon = Math.Pow(10, -3);

            double circleRadius = 2;
            Point centerOfCircle = new Point(0, 0);

            Point[] points = new Point[] { new Point(0, 2), new Point(1.5, 0.7),
                                           new Point(1, 1), new Point(3, 0)     };

            foreach (var point in points)
            {
                bool isBelong = Math.Abs(Point.GetDistance(centerOfCircle, point) - Math.Pow(circleRadius, 2)) <= epsilon;
                if (isBelong)
                    Console.WriteLine($"The point {point} belongs to the circle");
                else
                    Console.WriteLine($"The point {point} does not belong to a circle");
            }
        }
        #endregion

        #region Task2
        static void Task2()
        {
            Console.WriteLine("Task level 1 ex 2\n");
            Point point = new Point(0, 0);
            if (point.CoordY + Math.Abs(point.CoordX) <= 1)
            {
                Console.WriteLine($"The point {point} belongs to the triangle");
            }
            else
            {
                Console.WriteLine($"The point {point} does not belong to a triangle");
            }
        }
        #endregion

        #region Task3
        static void Task3()
        {
            double a = 15;
            double b = 13;
            double c;

            if (a > b)
                c = Math.Max(a, b);
            else
                c = Math.Min(a, b);

            Console.WriteLine($"c = {c}");
        }
        #endregion

        #region Task4
        static void Task4()
        {
            double a = 57876712;
            double b = 123454322;
            double c = 34654123;
            double z = Math.Max(Math.Min(a, b), c);
            Console.WriteLine($"z = {z}");
        }
        #endregion
        #endregion

        #region Level2
        #region Task2_1
        static void Task2_1()
        {
            Person[] people = new Person[] { new Person(Gender.Female, 178), new Person(Gender.Male, 172), new Person(Gender.Female, 168),
                                             new Person(Gender.Male, 180), new Person(Gender.Male, 170), new Person(Gender.Female, 166)};

            try
            {
                ClassStudents classStudents = new ClassStudents(people);
                Console.WriteLine($"Average height of boys = {classStudents.AverageHeigthBoys}\nAverage height of girls = {classStudents.AverageHeightGirls}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return;
            }

        }
        #endregion

        #region Task2_2
        static void Task2_2()
        {
            double epsilon = Math.Pow(10, -4);

            Console.WriteLine("Enter the coordinates of the center of the circle");
            Point centerOfCircle = Point.InitializePoint();
            Console.Write("Eneter radius: ");
            double.TryParse(Console.ReadLine(), out double radiusCircle);
            radiusCircle = radiusCircle < 0 ? Math.Abs(radiusCircle) : radiusCircle;

            Console.Write("Enter the number of points");
            int.TryParse(Console.ReadLine(), out int n);
            if (n != 0)
                n = n < 0 ? Math.Abs(n) : n;
            else
                return;

            Point[] points = new Point[n];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = Point.InitializePoint();
            }
            int numberPointsInCircle = 0;

            foreach (var point in points)
            {
                numberPointsInCircle = Math.Abs(Point.GetDistance(centerOfCircle, point) - Math.Pow(radiusCircle, 2)) < epsilon ?
                                       numberPointsInCircle++ : numberPointsInCircle += 0;
            }

            Console.WriteLine($"Number of points in the circle = {numberPointsInCircle}");
        }
        #endregion
        #endregion

        #region Level3
        #region Task3_4
        static void Task3_4()
        {
            List<Point> points = new List<Point>();

            Console.WriteLine("To stop entering data, enter any character or string");
            while (true)
            {
                try
                {
                    Console.Write("Enter coordinate x: ");
                    double coordX = double.Parse(Console.ReadLine());
                    Console.Write("Enter coordinate y: ");
                    double coordY = double.Parse(Console.ReadLine());
                    Point point = new Point(coordX, coordY);
                    points.Add(point);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The data flow has ended");
                    break;
                }
            }

            Console.Write("Enter a smaller radius");
            double.TryParse(Console.ReadLine(), out double smallRadius);
            smallRadius = smallRadius < 0 ? Math.Abs(smallRadius) : smallRadius;
            Console.Write("Enter a larger radius");
            double.TryParse(Console.ReadLine(), out double largeRadius);
            largeRadius = largeRadius < 0 ? Math.Abs(largeRadius) : largeRadius;
            Point centersCircle = new Point();

            int numberOfPoints = 0;
            foreach (var point in points)
            {
                double distance = Point.GetDistance(point, centersCircle);
                bool isBelong = distance >= smallRadius && distance <= largeRadius;
                if (isBelong)
                {
                    numberOfPoints++;
                }
            }

            Console.WriteLine($"the number of points belonging to the ring = {numberOfPoints}");
        }
        #endregion

        #region Task3_11
        static void Task3_11()
        {
            int numberExams = 4;
            Student student = new Student();
            int failedExam = 0;
            int[] passedExam = new int[] { 0, 0, 0, 0 };
            double[] averageMark = new double[] { 0, 0, 0, 0 };

            int number = 1;
            Console.WriteLine("To stop entering data, enter any character or string");
            while (true)
            {
                Console.WriteLine($"Student's number №{number}");
                try
                {
                    for (int i = 0; i < numberExams; i++)
                    {
                        student[i] = int.Parse(Console.ReadLine());
                        if (student[i] != 2)
                        {
                            averageMark[i] += student[i];
                            if (student[i] != 2)
                            {
                                passedExam[i]++;
                            }
                        }
                    }

                    for (int i = 0; i < numberExams; i++)
                    {
                        if (student[i] == 2)
                        {
                            failedExam++;
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The data flow has ended");
                    break;
                }
                number++;
            }

            for (int i = 0; i < numberExams; i++)
            {
                try
                {
                    averageMark[i] /= passedExam[i];
                    Console.WriteLine($"exam No. {i} average score: {averageMark[i]}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"No one passed exam No. {i}");
                }
            }

            Console.WriteLine($"The number of students who failed one or more exams: {failedExam}");
        }
        #endregion

        #region Task3_12
        static void Task3_12()
        {
            Console.WriteLine("To stop entering data, enter negative number");
            int userChoice;
            while (true)
            {
                double.TryParse(Console.ReadLine(), out double r);
                if (r < 0) break;
                Console.WriteLine("Choose which area to calculate:");
                Console.WriteLine("0 - Square area, 1 - Area of the circle\n" +
                                  "2 - The area of an equilateral triangle");

                int.TryParse(Console.ReadLine(), out userChoice);
                switch (userChoice)
                {
                    case 0:
                        Console.WriteLine($"Square area = {Math.Pow(r, 2)}");
                        break;
                    case 1:
                        Console.WriteLine($"Area of the circle = {Math.PI * Math.Pow(r, 2)}");
                        break;
                    case 2:
                        Console.WriteLine($"The area of an equilateral triangle = {Math.Sqrt(3) / 4 * Math.Pow(r, 2)}");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
        #endregion

        #region Task3_13
        static void Task3_13()
        {
            Console.WriteLine("To stop entering data, enter negative number");
            int userChoice;

            while (true)
            {
                double.TryParse(Console.ReadLine(), out double a);
                double.TryParse(Console.ReadLine(), out double b);
                if (a < 0 || b < 0) break;
                Console.WriteLine("Choose which area to calculate:");
                Console.WriteLine("0 - The area of a ring enclosed between two circles\n" +
                                  "1 - Rectangle area\n" +
                                  "2 - The area of an isosceles triangle");

                int.TryParse(Console.ReadLine(), out userChoice);
                switch (userChoice)
                {
                    case 0:
                        Console.WriteLine($"The area of a ring enclosed between two circles" +
                                          $"= {Math.Abs(Math.PI * (Math.Pow(a, 2) - Math.Pow(b, 2)))}");
                        break;
                    case 1:
                        Console.WriteLine($"Rectangle area = {a * b}");
                        break;
                    case 2:
                        Console.WriteLine($"The area of an isosceles triangle = {a / 4 * Math.Sqrt(4 * Math.Pow(b, 2) - Math.Pow(a, 2))}");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
        #endregion
        #endregion
    }
}