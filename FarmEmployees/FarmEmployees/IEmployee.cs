
using static FarmEmployees.EmployeeBase;

namespace FarmEmployees
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddSalary(float salaryForFruit);

        //event SalaryAddedDelegate SalaryAdded;
        Statistics GetStatistics();
        void ShowStatistics();

    }
}
