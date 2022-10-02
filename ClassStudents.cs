using System;
using System.Collections.Generic;
using System.Text;

namespace _2nd_Lab
{
    internal class ClassStudents
    {
        private Person[] students;
        private int NeStudent;

        private double averageHeightBoys;
        public double AverageHeigthBoys { get { return averageHeightBoys; } }

        private double averageHeightGirls;
        public double AverageHeightGirls { get { return averageHeightGirls; } }

        public ClassStudents(Person[] students)
        {
            this.students = students != null ? students : throw new NullReferenceException();
            this.averageHeightBoys = GetAverageHeightBoys();
            this.averageHeightGirls = GetAverageHeigthGirls();
        }

        private double GetAverageHeightBoys()
        {
            double averageHeigth = 0;
            int amountBoys = 0;
            foreach (var boys in students)
            {
                if (boys.GenderOfPerson == Gender.Male)
                {
                    amountBoys++;
                    averageHeigth += boys.HeightInCm;
                }
            }
            averageHeigth /= amountBoys;

            return averageHeigth;
        }

        private double GetAverageHeigthGirls()
        {
            double averageHeight = 0;
            int amountGirls = 0;
            foreach (var girls in students)
            {
                if (girls.GenderOfPerson == Gender.Female)
                {
                    amountGirls++;
                    averageHeight += girls.HeightInCm;
                }
            }
            averageHeight /= amountGirls;

            return averageHeight;
        }
    }
}
