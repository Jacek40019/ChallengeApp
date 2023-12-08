
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, int age) 
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(decimal grade);
        public abstract void AddGrade(int grade);

        public abstract Statistics GetStatistic();
    }
}
    
