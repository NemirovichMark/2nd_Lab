using System;
using System.Collections.Generic;
using System.Text;

namespace _2nd_Lab
{
    public enum Gender
    {
        Male = 0,
        Female = 1,
        Undefined
    }

    internal class Person
    {
        private Gender gender;
        public Gender GenderOfPerson { get { return gender; } }

        private int heightInCm;
        public int HeightInCm { get { return heightInCm; } }

        public Person(Gender gender, int heightInCm)
        {
            this.gender = gender;
            this.heightInCm = heightInCm;
        }

        public static Person InitializePerson()
        {
            Console.WriteLine("Enter the gender of the person (0 - male, 1 - female, other numbers - undefined)");
            int.TryParse(Console.ReadLine(), out int userData);
            Gender gender = (Gender)userData;

            Console.WriteLine("Enter the person's height in centimeters");
            int.TryParse(Console.ReadLine(), out userData);
            int heightInCm = userData < 0 ? Math.Abs(userData) : userData;

            return new Person(gender, heightInCm);
        }
    }
}
