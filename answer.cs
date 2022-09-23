using System;

namespace _2_Lab{
    class Program {
        static void Main(string[] args) {


            // Level 1 -----------------------

            static void task_1_4() {
                if (!double.TryParse(Console.ReadLine(), out double a)) {
                    Console.WriteLine("It's not a number.");
                    return;
                }
                if (!double.TryParse(Console.ReadLine(), out double b)) {
                    Console.WriteLine("It's not a number.");
                    return;
                }
                if (!double.TryParse(Console.ReadLine(), out double c)) {
                    Console.WriteLine("It's not a number.");
                    return;
                }

                Console.WriteLine($"Task 1.4 answer:\nz = {Math.Max(Math.Min(a, b), c)}");
            }

            static void task_1_5() {

                static string algoritm(double circle, double square) {
                    if (Math.Sqrt(2 * square) <= Math.Sqrt(circle / Math.PI) * 2) {
                        return "Yes";
                    }
                    return "No";
                }

                double r1 = 70, s1 = 36.74;
                double r2 = 0.86, s2 = 0.74;

                Console.WriteLine($"Task 1.5 answer\n1) {algoritm(r1, s1)}\n2) {algoritm(r2, s2)}\n");
            }
            
            static void task_1_6() {

                static string algoritm(double circle, double square) {
                    if (Math.Sqrt(square) >= Math.Sqrt(circle / Math.PI) * 2) {
                        return "Yes";
                    }
                    return "No";
                }

                double r1 = 3.2, s1 = 3.5;
                double r2 = 3.2, s2 = 4;
                double r3 = 6, s3 = 9;

                Console.WriteLine($"Task 1.6 answer\n1) {algoritm(r1, s1)}\n2) {algoritm(r2, s2)}\n3) {algoritm(r3, s3)}\n");
            }


            // Level 2 -----------------------

            static void task_2_1() {
                if (!int.TryParse(Console.ReadLine(), out int n)){
                    Console.WriteLine("It`s not a integer");
                    return;
                }

                double suma = 0, x;
                for (int i = 0; i < n; i++) {
                    if (!double.TryParse(Console.ReadLine(), out x)) {
                        Console.WriteLine("It`s not a number. Let`s try again.");
                        i--;
                    } else {
                        suma += x;
                    }
                }
                Console.WriteLine($"Task 2.1 answer\nAverage height: {suma / n}");
            }

            static void task_2_5() {

                Console.WriteLine("enter the norm");
                if (!double.TryParse(Console.ReadLine(), out double norm)) {
                        Console.WriteLine("It`s not a integer");
                        return;
                }
                int count = 0;

                for (int i = 0; i < 30; i++) {
                    if (!double.TryParse(Console.ReadLine(), out double x)) {
                        Console.WriteLine("It`s not a number. Let`s try again.");
                        i--;
                    } else{
                        if (x <= norm) {
                            count++;
                        }
                    }
                }

                Console.WriteLine($"Task 2.5 answer\n{count}");
            }


            // Level 3 -----------------------

            static void task_3_4() {
                double r1, r2;
                int count = 0;

                Console.WriteLine("Enter r1");
                if (!double.TryParse(Console.ReadLine(), out r1)) {
                    Console.WriteLine("It`s not a number.");
                    return;
                }

                Console.WriteLine("Enter r2");
                if (!double.TryParse(Console.ReadLine(), out r2)) {
                    Console.WriteLine("It`s not a number.");
                    return;
                }

                Console.WriteLine("Еnter a coordinate with a space, example: 10 13");
                string s;
                double x, y;

                while (true) {
                    s = Console.ReadLine();

                    if (s == "") {
                        break;
                    }

                    string[] nums = s.Split();
                    
                    if (nums.Length != 2) {
                        Console.WriteLine("Wrong input. Let`s try again.");
                        continue;
                    }

                    if (!double.TryParse(nums[0], out x)) {
                        Console.WriteLine("x is not a number. Let`s try again.");
                        continue;
                    }
                    if (!double.TryParse(nums[1], out y)) {
                        Console.WriteLine("y is not a number. Let`s try again.");
                        continue;
                    }

                    if ((r1 * r1 <= x * x + y * y) && (r2 * r2 >= x * x + y * y)) {
                        count++;
                    }
                }

                Console.WriteLine($"Task 3.4 answer\n{count}");
            }

            static void task_3_11() {
                Console.WriteLine("Еnter all 4 marks with a space between, example: 4 5 3 3");

                string s;
                string[] marks;

                int failingStudents = 0;
                int sumOfMarks= 0;
                int numberOfStudents = 0;

                while (true) {
                    s = Console.ReadLine();
                    if (s == "") {
                        break;
                    }

                    marks = s.Split();
                    if (marks.Length != 4) {
                        Console.WriteLine("Wrong input. Let`s try again.");
                        continue;
                    }

                    int[] intMarks = { 0, 0, 0, 0 };
                    bool isFailng = false;
                    bool wrongInput = false;

                    for (int i = 0; i < 4; i++) {
                        if (!int.TryParse(marks[i], out intMarks[i])) {
                            wrongInput = true;
                        }
                    }

                    if (wrongInput) {
                        Console.WriteLine("One of the marks isn`t integer. Let`s try again.");
                        continue;
                    }

                    foreach (int mark in intMarks) {
                        if (mark <= 2) {
                            isFailng = true;
                        }
                        sumOfMarks += mark;
                    }

                    if (isFailng) {
                        failingStudents += 1;
                    }

                    numberOfStudents += 1;
                }

                Console.WriteLine($"Task 3.11 answer\nFailing students: {failingStudents}\nAverage mark: {sumOfMarks / 4.0 / numberOfStudents}");
            }

            static void task_3_12() {
                string s;
                double r;
                string cmd;

                while (true) {
                    Console.WriteLine("Enter r: ");

                    s = Console.ReadLine();
                    if (s == "") {
                        break;
                    }

                    if (!double.TryParse(s, out r)) {
                        Console.WriteLine("It`s not a number. Let`s try again.");
                        continue;
                    }

                    if (r < 0) {
                        Console.WriteLine("Wrong input (r < 0). Let`s try again.");
                        continue;
                    }

                    Console.WriteLine("Number commands\n1. rectangle area\n2. ring area\n3. triange area\nEnter command");
                    cmd = Console.ReadLine();

                    switch (cmd) {
                        case "1":
                            Console.WriteLine($"Area of the square: {r * r}");
                            break;
                        case "2":
                            Console.WriteLine($"Area of the cirle: {r * r * Math.PI}");
                            break;
                        case "3":
                            Console.WriteLine($"Area of the triangle: {(Math.Sqrt(3) / 4) * r * r}");
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }


            }

            static void task_3_13() {
                Console.WriteLine("Еnter a and b with a space between, example: 10 13");

                string s;
                double a, b;
                string cmd;

                while (true) {
                    Console.WriteLine("Enter a and b");
                    s = Console.ReadLine();

                    if (s == "") {
                        break;
                    }

                    string[] nums = s.Split();

                    if (nums.Length != 2) {
                        Console.WriteLine("Wrong input. Let`s try again.");
                        continue;
                    }

                    if (!double.TryParse(nums[0], out a)) {
                        Console.WriteLine("a is not a number. Let`s try again.");
                        continue;
                    }
                    if (!double.TryParse(nums[1], out b)) {
                        Console.WriteLine("b is not a number. Let`s try again.");
                        continue;
                    }

                    if (a < 0 || b < 0) {
                        Console.WriteLine("Wrong input: a < 0 or b < 0. Let`s try again.");
                        continue;
                    }

                    Console.WriteLine("Number commands\n1. square area\n2. circle area\n3. triange area\nEnter command");
                    cmd = Console.ReadLine();

                    switch (cmd) {
                        case "1":
                            Console.WriteLine($"Area of the square: {a * b}");
                            break;
                        case "2":
                            Console.WriteLine($"Area of the cirle: {Math.Abs(a * a * Math.PI - b * b * Math.PI)}");
                            break;
                        case "3":
                            if (Math.Max(a, b) > (a + b + b) - Math.Max(a, b)) {
                                Console.WriteLine("There is no triangle with such sides");
                                break;
                            }
                            Console.WriteLine($"Area of the triangle: {Math.Sqrt(b * b - Math.Pow((a / 2.0), 2)) * a / 2.0}");
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
            }


            // -------------------------------

            task_1_4();

        }
    }
}
