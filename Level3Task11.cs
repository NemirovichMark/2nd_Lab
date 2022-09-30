using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double proverka = 0;
        double count = 0;
        double ex1 = 0;
        double ex2 = 0;
        double ex3 = 0;
        double ex4 = 0;
        string str1;using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double proverka = 0;
        double count = 0;
        double ex1 = 0;
        double ex2 = 0;
        double ex3 = 0;
        double ex4 = 0;
        string str1;
        string str2;
        string str3;
        string str4;
        double sredball = 0;
        double t = 1;
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        double sum4 = 0;
        double p = 0;
        string kot;
        Console.WriteLine("Enter the students' grades for 4 exams. The scores should take values from 2 to 5.");

        while (proverka == 0)
        {
            Console.WriteLine("The student number: " + t);
            ex1:
            Console.WriteLine("Enter student's number " + t + " grade for exam number 1: ");
            str1 = Console.ReadLine();
            ex1 = Convert.ToDouble(str1);
            if (ex1 < 2 || ex1 >5) { Console.WriteLine("The scores should take values from 2 to 5!!"); goto ex1; }
            ex2:
            Console.WriteLine("Enter student's number " + t + " grade for exam number 2: ");
            str2 = Console.ReadLine();
            ex2 = Convert.ToDouble(str2);
            if (ex2 < 2 || ex2 > 5) { Console.WriteLine("The scores should take values from 2 to 5!!"); goto ex2; }
            ex3:
            Console.WriteLine("Enter student's number " + t + " grade for exam number 3: ");
            str3 = Console.ReadLine();
            ex3 = Convert.ToDouble(str3);
            if (ex3 < 2 || ex3 > 5) { Console.WriteLine("The scores should take values from 2 to 5!!"); goto ex3; }
            ex4:
            Console.WriteLine("Enter student's number " + t + " grade for exam number 4: ");
            str4 = Console.ReadLine();
            ex4 = Convert.ToDouble(str4);
            if (ex4 < 2 || ex4 > 5) { Console.WriteLine("The scores should take values from 2 to 5!!"); goto ex4; }
            t++;
            if (ex1 == 2 || ex2 == 2 || ex3 == 2 || ex4 == 2) count++;
            else
            {
                sum1 = sum1 + ex1;
                sum2 = sum2 + ex2;
                sum3 = sum3 + ex3;
                sum4 = sum4 + ex4;
                p++;
            }
            Console.WriteLine("Do you want to continue entering student grades ?");
            Console.WriteLine("1) Yes.");
            Console.WriteLine("2) No.");
            Console.WriteLine("Enter the number of your choice: ");
            kot = Console.ReadLine();
            if (kot == "2") break;



        }
        if (p == 0) Console.WriteLine("All students are lagging behind, their number: " + count);
        else
        {
            Console.WriteLine("Number of underachievers: " + count);
            Console.WriteLine("Average score for exam number " + 1 + ": " + sum1 / p);
            Console.WriteLine("Average score for exam number " + 2 + ": " + sum2 / p);
            Console.WriteLine("Average score for exam number " + 3 + ": " + sum3 / p);
            Console.WriteLine("Average score for exam number " + 4 + ": " + sum4 / p);
        }
        return 0;
    }
}
        string str2;
        string str3;
        string str4;
        double sredball = 0;
        double t = 1;
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        double sum4 = 0;
        double p = 0;
        string kot;
        Console.WriteLine("Enter the students' grades for 4 exams. The scores should take values from 2 to 5.");

        while (proverka == 0)
        {
            Console.WriteLine("The student number: " + t);

            Console.WriteLine("Enter student's number " + t + " grade for exam number 1: ");
            str1 = Console.ReadLine();
            ex1 = Convert.ToDouble(str1);
            Console.WriteLine("Enter student's number " + t + " grade for exam number 2: ");
            str2 = Console.ReadLine();
            ex2 = Convert.ToDouble(str2);
            Console.WriteLine("Enter student's number " + t + " grade for exam number 3: ");
            str3 = Console.ReadLine();
            ex3 = Convert.ToDouble(str3);
            Console.WriteLine("Enter student's number " + t + " grade for exam number 4: ");
            str4 = Console.ReadLine();
            ex4 = Convert.ToDouble(str4);
            t++;
            if (ex1 == 2 || ex2 == 2 || ex3 == 2 || ex4 == 2) count++;
            else
            {
                sum1 = sum1 + ex1;
                sum2 = sum2 + ex2;
                sum3 = sum3 + ex3;
                sum4 = sum4 + ex4;
                p++;
            }
            Console.WriteLine("Do you want to continue entering student grades ?");
            Console.WriteLine("1) Yes.");
            Console.WriteLine("2) No.");
            Console.WriteLine("Enter the number of your choice: ");
            kot = Console.ReadLine();
            if (kot == "2") break;



        }
        if (p == 0) Console.WriteLine("All students are lagging behind, their number: " + count);
        else
        {
            Console.WriteLine("Number of underachievers: " + count);
            Console.WriteLine("Average score for exam number " + 1 + ": " + sum1 / p);
            Console.WriteLine("Average score for exam number " + 2 + ": " + sum2 / p);
            Console.WriteLine("Average score for exam number " + 3 + ": " + sum3 / p);
            Console.WriteLine("Average score for exam number " + 4 + ": " + sum4 / p);
        }
        return 0;
    }
}
