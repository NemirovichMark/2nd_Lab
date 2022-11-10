using System;
using System.Linq;
namespace _2nd_Lab
{
    class program
    {
        static void Main(string[] args)
        {
            #region First Level Excercise 3
            int a, b, c;
            Console.Write("Introduce the value of a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce the value of b: ");
            b = Int32.Parse(Console.ReadLine());
            if (a <= 0)
            {
                c = Math.Min(a, b);
                Console.WriteLine($"The minimun value between a and b is: {c} ");
            }
            else
            {
                c = Math.Max(a, b);
                Console.WriteLine($"The maximun value between a and b is: {c}  ");
            }
            #endregion
            #region Second Level Excercise 1
            int students, numberOfStudents;
            double StudentHeights, average;
            StudentHeights = 0;
            average = 0.00;
            Console.Write("Introduce the number of students: ");
            int.TryParse(Console.ReadLine(), out numberOfStudents);
            students = numberOfStudents;
            while (students > 0)
            {
                Console.Write("Introduce the height of the student: ");
                StudentHeights = double.Parse(Console.ReadLine());
                average += StudentHeights;
                students--;
                if (students == 0)
                {
                    average = average / numberOfStudents;
                    Console.WriteLine($"The average student height is {average}");
                }
            }
            #endregion
            #region  Second Level Excercise 9
            int n = 0; // amount of athletes
            int x = 1;
            Console.Write("Introduce the amount of the atletes: ");
            int.TryParse(Console.ReadLine(), out n);
            double[] array = new double[n];
            Console.WriteLine("Introduce the time it took to the athlete to reach 200 meters");
            foreach (int elements in array)
            {
                Console.Write($"Athlete number {x}: ");
                double.TryParse(Console.ReadLine(), out array[elements]);
                x++;
            }
            double[] tabulator = array.OrderByDescending(i => i).Take(2).ToArray();
            Console.WriteLine($"The Winner is the athlete {x - 1} with the record of: {tabulator[0]} seconds");
            #endregion
            #region Third Level Exercise 4
            double r1, r2;
            double x, y;
            while (true)
            {
                Console.Write("Introduce r1: ");
                if (!double.TryParse(Console.ReadLine(), out r1))
                {
                    Console.WriteLine("The value of r1 is wrong");
                    continue;
                }
                if (r1 <= 0)
                {
                    Console.WriteLine("r1 has to be positive");
                    continue;
                }
                Console.Write("Introduce r2: ");
                if (!double.TryParse(Console.ReadLine(), out r2))
                {
                    Console.WriteLine("The value of r2 is wrong");
                    continue;
                }
                if (r2 <= 0)
                {
                    Console.WriteLine("r2 has to be positive");
                    continue;
                }
                if (r2 < r1)
                {
                    Console.WriteLine("r2 has to be bigger than r1");
                }
                break;
            }
            while (true)
            {
                Console.Write($"Enter coordinate x: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("incorrect format");
                    return;
                }
                Console.Write("Enter coordinate y: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("incorrect format");
                    return;
                }
                string result = ((x * x + y * y) >= r1 * r1 && (x * x + y * y) <= r2 * r2) ? "The points X and Y fall into the inner radius ring" : "The point X and Y dont fall into the inner radius ring";
                Console.WriteLine(result);
                break;
            }
            #endregion
            #region Third Level Excercise 11
            int nStudents;
            int score, nStudent = 0, disaprovedStudents = 0, IndividualScoreSummatory = 0;
            double averageScoreOfAllStudents, averageScore = 0;
            while (true)
            {
                Console.Write("Introduce the amount of students: ");
                if (!int.TryParse(Console.ReadLine(), out nStudents))
                {
                    Console.WriteLine("The value of nStudents is wrong");
                    continue;
                }
                if (nStudents <= 0)
                {
                    Console.WriteLine("The amount of students has to be positive");
                    continue;
                }
                break;
            }
            bool hasFs;
            while (nStudents > 0)
            {
                hasFs = false;
                nStudent++;
                int exams = 1;
                Console.WriteLine($"Student #{nStudent}");
                while (exams < 4)
                {
                    Console.Write($"Introduce the score of the exam number {exams}:  ");
                    int.TryParse(Console.ReadLine(), out score);
                    averageScore += score;
                    exams++;
                    //IndividualScoreSummatory = score;
                    if (score < 3)
                    {
                        hasFs = true;
                    }
                }
                if (hasFs) disaprovedStudents++;
                nStudents--;
            }

            averageScoreOfAllStudents = averageScore / (nStudent * 3);
            Console.WriteLine($"the amount of disaproved students are {disaprovedStudents}");
            Console.WriteLine($"the average score of all students is {averageScoreOfAllStudents}");
            #endregion
            #region Third Level Excercise 12
            int functionSelected = 0;
            double r = 0, AreaSquare = 0, AreaCircle = 0, AreaEquilateral = 0;
            Console.WriteLine("write 1 for calculating the area of a square only with side values");
            Console.WriteLine("write 2 for calculating the area of a circle only with the value of radius ");
            Console.WriteLine("write 3 for calculating the area of an equilateral triangle only with side values ");
            while (true)
            {
                Console.Write("Choose one of the functions that you want to use: ");
                if (!int.TryParse(Console.ReadLine(), out functionSelected))
                {
                    Console.WriteLine("You havent chosen correctly");
                }
                if (functionSelected <= 0 || functionSelected > 3)
                {
                    Console.WriteLine("Please choose correctly");
                    continue;
                }
                break;
            }
            switch (functionSelected)
            {
                //Area of a square
                case 1:
                    while (true)
                    {
                        Console.Write("Introduce the value of the side of the square: ");
                        if (!double.TryParse(Console.ReadLine(), out r))
                        {
                            Console.WriteLine("Please enter a correct value");
                        }
                        if (r <= 0)
                        {
                            Console.WriteLine("The value of r has to be bigger than 0");
                            continue;
                        }
                        break;
                    }
                    AreaSquare = r * r;
                    Console.WriteLine($"The area of the square is {AreaSquare}");
                    break;
                //Area of a circle
                case 2:
                    while (true)
                    {
                        Console.Write("Introduce the value of the radius of the circle: ");
                        if (!double.TryParse(Console.ReadLine(), out r))
                        {
                            Console.WriteLine("Please enter a correct value");
                        }
                        if (r <= 0)
                        {
                            Console.WriteLine("The value of r has to be bigger than 0");
                            continue;
                        }
                        break;
                    }
                    AreaCircle = Math.PI * r * r;
                    Console.WriteLine($"The area of the square is {AreaCircle}");
                    break;
                case 3:
                    while (true)
                    {
                        Console.Write("Introduce the value of the side of the square: ");
                        if (!double.TryParse(Console.ReadLine(), out r))
                        {
                            Console.WriteLine("Please enter a correct value");
                        }
                        if (r <= 0)
                        {
                            Console.WriteLine("The value of r has to be bigger than 0");
                            continue;
                        }
                        break;
                    }
                    AreaEquilateral = (Math.Pow(3, 0.5) * r * r) / 4;
                    Console.WriteLine($"The area of the square is {AreaEquilateral}");
                    break;
            }
        }
        #endregion
        #region Third Level Excercise 13
        int FSelected = 0;
        double a = 0, b = 0, AreaRectangle = 0, AreaRingEnclosed = 0, AreaIsosceles = 0;
        Console.WriteLine("write 1 to calculate the area of a rectangle with sides A, B");
    Console.WriteLine("write 2 to calculate the area of a ring enclosed between two circles with radiuses A and B");
    Console.WriteLine("write 3 to calculate the area of an isosceles triangle with sides A, B");
    while(true){
    Console.Write("Choose one of the functions that you want to use: ");
        if(!int.TryParse(Console.ReadLine(), out FSelected)){
            Console.WriteLine("You havent chosen correctly");
            }
        if (FSelected <= 0 || FSelected > 3){
            Console.WriteLine("Please choose correctly");
            continue;
            }
break;
        }
    switch (FSelected)
{
    //Area of a rectangle
    case 1:
        while (true)
        {
            Console.Write("Introduce the value of A: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (a <= 0)
            {
                Console.WriteLine("The value of A has to be bigger than 0");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("Introduce the value of B: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (b <= 0)
            {
                Console.WriteLine("The value of B has to be bigger than 0");
                continue;
            }
            break;
        }
        AreaRectangle = a * b;
        Console.WriteLine($"The area of the rectangle is {AreaRectangle}");
        break;
    //Area of a ring enclosed between two circles
    case 2:
        while (true)
        {
            Console.Write("Introduce the value of A: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (a <= 0)
            {
                Console.WriteLine("The value of A has to be bigger than 0");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("Introduce the value of B: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (b <= 0)
            {
                Console.WriteLine("The value of B has to be bigger than 0");
                continue;
            }
            break;
        }
        AreaRingEnclosed = Math.PI * (a + b);
        Console.WriteLine($"The area of a ring enclosed between two circles is {AreaRingEnclosed}");
        break;
    //Area of an isosceles triangle
    case 3:
        while (true)
        {
            Console.Write("Introduce the value of A: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (a <= 0)
            {
                Console.WriteLine("The value of A has to be bigger than 0");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("Introduce the value of B: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a correct value");
                continue;
            }
            if (b <= 0)
            {
                Console.WriteLine("The value of B has to be bigger than 0");
                continue;
            }
            break;
        }
        AreaIsosceles = a * b * 0.5;
        Console.WriteLine($"The area of an isosceles triangle is {AreaIsosceles}");
        break;
}
    }
            #endregion
    }
    }
}
