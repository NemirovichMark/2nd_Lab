using System;
using System.Security.Cryptography.X509Certificates;

class Homew3lvl2
{
    static void Main()
    {
        #region Level2 task2

        Console.WriteLine("введите число n");
        int n = Convert.ToInt32(Console.ReadLine());
        double s = 0.0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++) s += Convert.ToDouble(Console.ReadLine());
            double res1 = s / n;
            Console.WriteLine($"средний рост -> {res1}");
        }
        else Console.WriteLine("please n>0");
        #endregion
        #region Level2_task10
        Console.WriteLine("введите число n");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int mark1;
        int cm,count;
        count = 0;
        for (int i2 = 1; i2<=n2;i2++)
        {
            cm = 0;
            Console.WriteLine("введите номер студента, а потом четыре его оценки");
            int xn = Convert.ToInt32(Console.ReadLine());
            for (int i3 = 1;i3 <=4;i3++)
            {
                mark1 = Convert.ToInt32(Console.ReadLine());
                if ((mark1 != 2) && (mark1 != 3))
                    cm += 1;
            }
            
            if (cm == 4) count += 1;
            //Console.WriteLine(cm,count);

        }
        Console.WriteLine($"студентов без оценок 2 и 3 -> {count}");
        #endregion
    }
}
