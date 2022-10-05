using System;


namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto used to test the tasks faster, not as a part of the program
            //goto task_4_lv1;
            //goto task_10_lv1;

            //goto task_1_lv2;
            //goto task_5_lv2;

            //goto task_4_lv3;
            //goto task_11_lv3;
            //goto task_12_lv3;
            //goto task_13_lv3;

            #region task 3 lv1
            Console.WriteLine("Task 3 (level 1)");
            double a, b, c;
            Console.WriteLine("Enter the value of a.");
            bool try_a = double.TryParse(Console.ReadLine(), out a);
            if (!try_a)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the value of b.");
            bool try_b = double.TryParse(Console.ReadLine(), out b);
            if (!try_b)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"a = {a}, b = {b}");

            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }

            Console.WriteLine($"c = {c}");
            Console.ReadLine();
        #endregion

        task_4_lv1:
            #region task 4 lv1
            Console.WriteLine("Task 4 (level 1)");
            double z;
            Console.WriteLine("Enter the value of a.");
            try_a = double.TryParse(Console.ReadLine(), out a);
            if (!try_a)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the value of b.");
            try_b = double.TryParse(Console.ReadLine(), out b);
            if (!try_b)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the value of c.");
            bool try_c = double.TryParse(Console.ReadLine(), out c);
            if (!try_c)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            z = Math.Max(Math.Min(a, b), c);
            Console.WriteLine($"z = {z}");

            Console.ReadLine();
        #endregion

        task_10_lv1:
            #region task 10 lv1
            Console.WriteLine("Task 10 (level 1)");
            Console.WriteLine("Enter the value of x.");
            double x;
            bool try_x = double.TryParse(Console.ReadLine(), out x);
            if (!try_x)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"x = {x}");

            if (x <= -1)
            {
                Console.WriteLine("y = 1");
            }

            else if ((x > -1) && (x <= 1))
            //I think there was a mistake in the task. It said (y = -x) for (1 < x <= 1), so i assumed it meant (-1 < x <= 1).
            {
                Console.WriteLine($"y = {-x}");
            }
            else if (x > 1)
            {
                Console.WriteLine("y = -1");
            }

            Console.ReadLine();
        #endregion

        task_1_lv2:
            #region task 1 lv2
            Console.WriteLine("Task 1 (level 2)");

            Console.WriteLine("Enter the number of students.");
            double n;
            bool try_n = double.TryParse(Console.ReadLine(), out n);

            if (!try_n)
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }
            else if ((n <= 0) || (n != (int)n))
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"There are {n} student(s) in the group.");
            Console.WriteLine();

            Console.WriteLine("Enter the gender and the height of each student in cm.");
            Console.WriteLine("(Format: B123 or G123)");

            int b_count = 0, g_count = 0;
            double b_sum = 0, g_sum = 0;
            double h;
            string info, gender;
            bool try_h;

            for (int i = 0; i < n; i++)
            {
                info = Console.ReadLine();
                if (info == "")
                {
                    Console.WriteLine("Incorrect input.");
                    Console.ReadLine();
                    return;
                }

                gender = info.Substring(0, 1);
                //Console.WriteLine(gender);
                //Console.WriteLine(info.Substring(1, info.Length - 1));

                if (gender == "B")
                {

                    b_count += 1;
                    try_h = double.TryParse(info.Substring(1, info.Length - 1), out h);
                    if ((!try_h) || (h <= 0))
                    {
                        Console.WriteLine("Incorrect input.");
                        Console.ReadLine();
                        return;
                    }
                    //Console.WriteLine($"{gender} {h} cm");
                    b_sum += h;
                }

                else if (gender == "G")
                {

                    g_count += 1;
                    try_h = double.TryParse(info.Substring(1, info.Length - 1), out h);
                    if ((!try_h) || (h <= 0))
                    {
                        Console.WriteLine("Incorrect input.");
                        Console.ReadLine();
                        return;
                    }
                    //Console.WriteLine($"{gender} {h} cm");
                    g_sum += h;
                }

                else
                {
                    Console.WriteLine("Incorrect input.");
                    Console.ReadLine();
                    return;
                }


            }

            if (b_count == 0)
            {
                b_count = 1;
            }

            if (g_count == 0)
            {
                g_count = 1;
            }

            Console.WriteLine();
            Console.WriteLine($"Average boy height: {(b_sum / b_count):f2} cm.");
            Console.WriteLine($"Average girl height: {(g_sum / g_count):f2} cm.");

            Console.ReadLine();
        #endregion

        task_5_lv2:
            #region task 5 lv2
            Console.WriteLine("Task 5 (level 2)");

            Console.WriteLine("Enter the norm value.");
            n = 30;
            double norm;
            bool try_norm = double.TryParse(Console.ReadLine(), out norm);
            if ((!try_norm) || (norm < 0))
            {
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"The norm is {norm}.");
            Console.WriteLine($"Enter the result of each of the {n} runners.");

            int c_count = 0;
            bool try_result;
            double result;

            for (int i = 1; i <= n; i += 1)
            {
                try_result = double.TryParse(Console.ReadLine(), out result);
                if ((!try_result) || (result < 0))
                {
                    Console.WriteLine("Incorrect input.");
                    Console.ReadLine();
                    return;
                }

                if (result >= norm)
                {
                    c_count += 1;
                }
            }

            Console.WriteLine($"{c_count} of the runners have achieved the norm.");
            Console.ReadLine();
        #endregion

        task_4_lv3:
            #region task 4 lv3
            //I assumed the center of both circles is at (0; 0) as it wasn't mentioned in the task.
            Console.WriteLine("Task 4 (level 3)");
            double r1, r2;
            bool try_r;

            Console.WriteLine("Enter the radius of the inner circle.");
            try_r = double.TryParse(Console.ReadLine(), out r1);
            if ((!try_r) || (r1 <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the radius of the outer circle.");
            try_r = double.TryParse(Console.ReadLine(), out r2);
            if ((!try_r) || (r2 <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            if (r1 == r2)
            {
                Console.WriteLine("The inner radius is supposed to be smaller than the outer radius.");
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }
            else if (r1 > r2)
            {
                Console.WriteLine("The inner radius is supposed to be smaller than the outer radius.");
                Console.WriteLine("The values have been swapped.");
                double r_swap = r1;
                r1 = r2;
                r2 = r_swap;
            }
            Console.WriteLine();
            Console.WriteLine($"Inner radius = {r1}.");
            Console.WriteLine($"Outer radius = {r2}.");
            Console.WriteLine();

            Console.WriteLine("Enter the coordinates of the points.");
            Console.WriteLine("(Format: X Y)");
            Console.WriteLine("(Input an empty string to finish)");

            int p_count = 0;
            double p_x, p_y;
            Array pos;
            bool try_y;

            info = Console.ReadLine();
            while (info != "")
            {
                pos = info.Split();
                if (pos.Length != 2)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                try_x = double.TryParse((string)pos.GetValue(0), out p_x);
                try_y = double.TryParse((string)pos.GetValue(1), out p_y);

                if ((!try_x) || (!try_y))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                //Console.WriteLine($"{p_x} {p_y}");

                if ((p_x * p_x + p_y * p_y >= r1 * r1) && (p_x * p_x + p_y * p_y <= r2 * r2))
                {
                    p_count += 1;
                }

                info = Console.ReadLine();
            }

            Console.WriteLine($"{p_count} points are inside of the ring.");
            Console.ReadLine();
        #endregion

        task_11_lv3:
            #region task 11 lv3
            Console.WriteLine("Task 11 (level 3)");
            //I consider a student "unsuccessful" if they have at least one bad mark ("2").

            Console.WriteLine("Enter the exam marks (from \"2\" to \"5\") of each student.");
            Console.WriteLine("(Format: 5 4 3 2)");
            Console.WriteLine("(Input an empty string to finish)");

            double cur_sum = 0, total = 0;
            int cur_mark, succ = 0, unsucc = 0;
            bool try_mark, fail = false;
            Array marks;

            info = Console.ReadLine();
            while (info != "")
            {
                marks = info.Split();
                if (marks.Length != 4)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                foreach (var item in marks)
                {
                    try_mark = int.TryParse((string)item, out cur_mark);
                    //Console.WriteLine(cur_mark);

                    if (!try_mark || (cur_mark < 2) || (cur_mark > 5))
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    if (cur_mark == 2)
                    {
                        fail = true;
                    }
                    else
                    {
                        cur_sum += cur_mark;
                    }

                }

                if (!fail)
                {
                    succ += 1;
                    total += cur_sum;
                }
                else
                {
                    unsucc += 1;
                }

                cur_sum = 0;
                fail = false;
                info = Console.ReadLine();
            }

            if (succ == 0)
            {
                succ = 1;
            }

            Console.WriteLine($"There is (are) {unsucc} unsuccessful student(s) in the group.");
            Console.WriteLine($"The average mark of the group is {total / (succ * 4.0)} (without unsuccessful results).");

            Console.ReadLine();
        #endregion

        task_12_lv3:
            #region task 12 lv3
            Console.WriteLine("Task 12 (level 3)");
            double r;

            do
            {
                Console.WriteLine("Enter the r value (input \"-1\" to stop)");
                try_r = double.TryParse(Console.ReadLine(), out r);
                if (r == -1)
                {
                    break;
                }

                if ((!try_r) || (r < 0))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Which surface area do you want to calculate?");
                Console.WriteLine("(Input \"1\" for a square, \"2\" for a circle, \"3\" for a triangle)");

                info = Console.ReadLine();
                switch (info)
                {
                    case "1":
                        Console.WriteLine($"S = {r * r:f2}.");
                        break;

                    case "2":
                        Console.WriteLine($"S = {Math.PI * r * r:f2}.");
                        break;

                    case "3":
                        Console.WriteLine($"S = {(Math.Sqrt(3) * r * r) / 4.0:f2}.");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                }
                Console.WriteLine();
            } while (r != -1);


            Console.ReadLine();
        #endregion

        task_13_lv3:
            #region task 13 lv3
            Console.WriteLine("Task 13 (level 3)");
            double ra, rb;

            do
            {
                Console.WriteLine("Enter the A value (input \"-1\" to stop)");
                try_r = double.TryParse(Console.ReadLine(), out ra);
                if (ra == -1)
                {
                    break;
                }

                if ((!try_r) || (ra < 0))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Enter the B value (must be >= A)");
                try_r = double.TryParse(Console.ReadLine(), out rb);

                if ((!try_r) || (rb < ra))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Which surface area do you want to calculate?");
                Console.WriteLine("(Input \"1\" for a rectangle, \"2\" for a ring, \"3\" for a triangle)");

                info = Console.ReadLine();
                switch (info)
                {
                    case "1":
                        Console.WriteLine($"S = {ra * rb:f2}.");
                        break;

                    case "2":
                        Console.WriteLine($"S = {Math.PI * rb * rb - Math.PI * ra * ra:f2}.");
                        break;

                    case "3":
                        Console.WriteLine($"S = {Math.Sqrt((rb * rb) - (ra * ra / 4.0)) * ra / 2.0 :f2}.");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                }
                Console.WriteLine();
            } while (ra != -1);


            Console.ReadLine();
            #endregion
        }
    }
}

