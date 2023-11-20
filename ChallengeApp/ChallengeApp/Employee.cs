﻿//using System.Data.SqlTypes;
//using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee

    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }


        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Number: {grade} is invalid value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public void AddGrade(long grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public void AddGrade(decimal grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public void AddGrade(int grade)
        {
            {
                float gradeAsFloat = grade;
                this.AddGrade(gradeAsFloat);
            }

        }

        public Statistics GetStatisticWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            for (var counter = 0; counter < this.grades.Count; counter++)
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Average += this.grades[counter];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            var counter = 0;
            do
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Average += this.grades[counter];
                counter++;
            } while (counter < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            var counter = 0;
            while (counter < this.grades.Count)
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Average += this.grades[counter];
                counter++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

    }
}





