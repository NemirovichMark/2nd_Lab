using System;
using System.Collections.Generic;
using System.Text;

namespace _2nd_Lab
{
    internal class Student
    {
        private int[] marks;
        public int this[int index]
        {
            get
            {
                return marks[index];
            }

            set
            {
                if (value >= 2 && value <= 5)
                    marks[index] = value;
                else
                    throw new Exception();
            }
        }

        public Student()
        {
            marks = new int[] { 2, 2, 2, 2 };
        }

        public Student(int[] marks)
        {
            this.marks = marks;
        }

        public Student InitializeStudent()
        {
            int[] marks = InitializeMarks();
            return new Student(marks);
        }

        private int[] InitializeMarks()
        {
            int mark;
            int[] marks = new int[4];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"subject №{i + 1}, mark: ");
                int.TryParse(Console.ReadLine(), out mark);
                marks[i] = mark;
            }
            return marks;
        }
    }
}