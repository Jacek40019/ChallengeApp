
namespace FarmEmployees
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddSalary(float salaryForFruit);
        Statistics GetStatistics();
        void ShowStatistics();

    }
}
