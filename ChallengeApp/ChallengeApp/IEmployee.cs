﻿
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        public void AddGrade(long grade);
        void AddGrade(decimal grade);
        void AddGrade(int grade);
        Statistics GetStatistic();
    }
}
