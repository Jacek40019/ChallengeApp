using static ChallengeApp.EmployeeBase;

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
        void AddGrade(long grade);
        void AddGrade(decimal grade);
        void AddGrade(int grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistic();
    }
}

